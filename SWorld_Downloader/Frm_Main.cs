using SWorld_Downloader.Class;
using SWorld_Downloader.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWorld_Downloader
{
    public partial class Main : Form
    {

        /// <summary>
        /// 串口工作方式
        /// default：正常收发
        /// 1：读芯片信息
        /// </summary>
        //int _i_Serial_Work_Way = 0;
        /// <summary>
        /// ISP线程
        /// </summary>
        Thread _th_ISP = null;
        /// <summary>
        /// 进入BootLoader方案
        /// </summary>
        int _i_ISP_MODE = 0;
        /// <summary>
        /// STM32 BL表格
        /// </summary>
        DataSet _ds_STM32BL = null;
        /// <summary>
        /// 下载串口调试信息提示
        /// </summary>
        string _str_DL_BTM_Msg = "下载串口已关闭！";
        /// <summary>
        /// 下载串口状态图像
        /// </summary>
        Image _img_DL_BTM = Properties.Resources.close20;
        /// <summary>
        /// 调试串口调试信息提示
        /// </summary>
        string _str_Debug_SMsg = "调试串口已关闭！";
        /// <summary>
        /// 调试串口状态图像
        /// </summary>
        Image _img_Debug_BTM = Properties.Resources.close20;
        /// <summary>
        /// 调试串口发送计数
        /// </summary>
        int _i_Debug_TX = 0;
        /// <summary>
        /// 调试串口接受计数
        /// </summary>
        int _i_Debug_RX = 0;
        /// <summary>
        /// 字节数组列表
        /// </summary>
        //List<byte> _lb_Debug = new List<byte>();
        
        ///调试串口多条发送缓存数据
        DataSet _ds_Debug_Send=null;
        /// <summary>
        /// 选中项目
        /// </summary>
        string _s_Debug_Select_Name = "";
        /// <summary>
        /// 选中项目所有页码
        /// </summary>
        int _i_Debug_Select_Page_All = 1;
        /// <summary>
        /// 选中页码
        /// </summary>
        int _i_Debug_Select_Page=1;
        /// <summary>
        /// 程序更新线程
        /// </summary>
        Thread Th_Update=null;

        public Main()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint  //全部在窗口绘制消息中绘图
                      | ControlStyles.OptimizedDoubleBuffer//使用双缓冲 
                      , true);
            InitializeComponent();
            Load_Config();      //加载软件配置信息

            //是否需要弹出版本提示
            if (Properties.Settings.Default.Show_Version_Info)
            {
                Forms.Frm_Version_Info _fvi = new Forms.Frm_Version_Info();
                _fvi.ShowDialog();
            }

            UsbNotification.RegisterUsbDeviceNotification(this.Handle);//添加串口监听事件
        }

        /// <summary>
        /// USB设备更新事件
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == UsbNotification.WmDevicechange)
            {
                switch ((int)m.WParam)
                {
                    case UsbNotification.DbtDeviceremovecomplete://USB设备移除
                        List<Serial_Info> _lsi = Cls_Serial.GetPorts();
                        //调试串口移除
                        for  (int i=0;i<Cbx_Debug_Seiral_Num.Items.Count;i++)
                        {
                            if (!Serial_List_Check(_lsi, Cbx_Debug_Seiral_Num.Items[i].ToString()))
                            {
                                //需要判断该串口是否为打开状态  是打开状态 则需要关闭串口
                                if (Pal_Serial_Option.Enabled == false
                                    &&Cbx_Debug_Seiral_Num.Text== Cbx_Debug_Seiral_Num.Items[i].ToString())
                                {
                                    Debug_Serial_Close();
                                    Pal_Serial_Option.Enabled = true;
                                    Btn_Debug_Open_Serial.Text = "打开串口";
                                    Btn_Debug_Open_Serial.Image = Properties.Resources.used20;
                                }
                                Cbx_Debug_Seiral_Num.Items.RemoveAt(i);
                            }
                        }
                        //下载串口移除
                        for (int i = 0; i < Cbx_DL_Serial_Num.Items.Count; i++)
                        {
                            if (!Serial_List_Check(_lsi, Cbx_DL_Serial_Num.Items[i].ToString()))
                            {
                                Cbx_DL_Serial_Num.Items.RemoveAt(i);
                            }
                        }
                        break;
                    case UsbNotification.DbtDevicearrival://USB设备添加
                        foreach(Serial_Info _si in Cls_Serial.GetPorts())
                        {
                            if (Cbx_Debug_Seiral_Num.Items.Contains(_si.ToString()))
                                continue;
                            else
                            {
                                Cbx_DL_Serial_Num.Items.Add(_si.ToString());//添加至下载串口
                                Cbx_Debug_Seiral_Num.Items.Add(_si.ToString());//添加至调试串口
                            }
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 判断列表是否存在某一项
        /// </summary>
        /// <param name="_s"></param>
        /// <returns>true：存在 false：不存在</returns>
        public bool Serial_List_Check(List<Serial_Info> _lsi, string _s)
        {
            foreach (Serial_Info _si in _lsi)
            {
                if (_si.ToString() == _s)
                {
                    return true;
                }
            }
            return false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Soft_Init();
        }

        /// <summary>
        /// 软件初始化
        /// </summary>
        private void Soft_Init()
        {
            _ds_STM32BL=Cls_XML.ExtractResXML("SWorld_Downloader.Data.STM32BL.xml");//获取STM32BL列表
            Tbx_Time_Show.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");//显示最新时间
            this.Serial_DL_StataChange += new EventHandler(this.Sp_Main_Serial_DL_StataChange);//下载串口状态监视事件
            this.Serial_Debug_StataChange += new EventHandler(this.Sp_Main_Serial_Debug_StataChange);//调试串口状态监视事件
            Fresh_Serial(0);//刷新串口
            Fresh_Serial(1);//刷新串口
        }
        /// <summary>
        /// 检查更新
        /// </summary>
        private void Check_Update()
        {
            if (Th_Update == null)
            {
                Th_Update = new Thread(Th_Check_Update);
                Th_Update.Start();
            }
        }

        /// <summary>
        /// 程序更新线程函数
        /// </summary>
        private void Th_Check_Update()
        {
            List<Version_Info> _lvi = Cls_Update.Get_Version_List();
            if (_lvi != null && _lvi[0].Version != Properties.Resources.Version)//判断是否为最新版本
            {
                Show_Btm_Msg("检查到新版本！");
                this.BeginInvoke(new Action(() =>
                {
                    if (MessageBox.Show(string.Format("软件当前版本为【{0}】，检测到最新版本为【{1}】，是否更新？\r\n不在提示勾掉【设置>帮助>更新>启动时检查更新】即可！"
                    , Properties.Resources.Version, _lvi[0].Version), "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        if (Cls_XML.ExtractResEXE() == 0)//成功抽取更新文件
                        {
                            System.Diagnostics.Process.Start("Update_Soft.exe", "SWorld开发助手 " + _lvi[0].Version);//运行更新程序
                            Application.Exit();//退出本软件
                        }
                    }
                    Th_Update.Abort();
                    Th_Update.Join();
                    Th_Update = null;
                }));
            }
            else
            {
                Show_Btm_Msg("软件已是最新版本！");
            }
        }


        /// <summary>
        /// 加载配置
        /// </summary>
        public void Load_Config()
        {
            //设置默认选项
            //软件名称及版本号
            this.Text = Properties.Resources.AppName +" "+ Properties.Resources.Version;

            //string path = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            //窗体配置
            this.TopMost = Properties.Settings.Default.Frm_Fix_Stat;
            if (Properties.Settings.Default.Frm_Max_Stat)//如果为窗体最大化  则最大化窗体
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.Size = Properties.Settings.Default.Frm_Size;
            }
            //this.Size = new Size();
            //设置选项卡次序(在InitializeComponent中设置)
            List<TabPage> _ltp = new List<TabPage>() { Tp_DL, Tp_Debug, Tp_Tools, Tp_Type, Tp_Code, Tp_Help };
            Tc_Main.TabPages.Clear();
            Tc_Main.TabPages.Add(_ltp.Where(a=>a.Name==Properties.Settings.Default.Tab_0).ToList()[0]);
            Tc_Main.TabPages.Add(_ltp.Where(a => a.Name == Properties.Settings.Default.Tab_1).ToList()[0]);
            Tc_Main.TabPages.Add(_ltp.Where(a => a.Name == Properties.Settings.Default.Tab_2).ToList()[0]);
            Tc_Main.TabPages.Add(_ltp.Where(a => a.Name == Properties.Settings.Default.Tab_3).ToList()[0]);
            Tc_Main.TabPages.Add(_ltp.Where(a => a.Name == Properties.Settings.Default.Tab_4).ToList()[0]);
            Tc_Main.TabPages.Add(_ltp.Where(a => a.Name == Properties.Settings.Default.Tab_5).ToList()[0]);
            if (Tc_Main.SelectedTab != null)//设置底部信息提示
            {
                switch (Tc_Main.SelectedTab.Name)
                {
                    case "Tp_DL"://下载助手
                        Tstbx_Serial_Stat_Img.BackgroundImage = _img_DL_BTM;
                        Tstbx_Serial_Stat.Text = _str_DL_BTM_Msg;
                        break;
                    case "Tp_Debug"://调试助手 
                        Tstbx_Serial_Stat_Img.BackgroundImage = _img_Debug_BTM;
                        Tstbx_Serial_Stat.Text = _str_Debug_SMsg;
                        break;
                }
            }
            //下载界面
            Cbx_DL_BaudRate.SelectedIndex = Properties.Settings.Default.DL_BaudRate;
            Tbx_DL_File_Path.Text = Properties.Settings.Default.DL_File_Path;
            Cbx_Go_BL_Way.SelectedIndex = Properties.Settings.Default.DL_BL_Go_Way;
            Ckbx_Auto_Match.Checked = Properties.Settings.Default.DL_BL_Auto_Match;
            Tbx_DL_Adress.Text = Properties.Settings.Default.DL_Start_Address;
            Tbx_Run_Adress.Text = Properties.Settings.Default.DL_Run_Address;
            Ckbx_Check.Checked = Properties.Settings.Default.DL_Check;
            Ckbx_DL_After_Dir_Run.Checked = Properties.Settings.Default.DL_After_Direct_Run;
            Ckbx_DL_Auto_Close_Debug_Port.Checked = Properties.Settings.Default.DL_Auto_Close_Debug_Port;
            Ckbx_DL_Show_Time.Checked = Properties.Settings.Default.DL_Show_Time;
            Cbx_Auto_DL.Checked = Properties.Settings.Default.DL_Auto_Download;
            if (Properties.Settings.Default.DL_Erase_Way == 0)
                Rbtn_Erase_All.Checked = true;
            else
                Rbtn_Erase_Part.Checked = true;
            Ckbx_DL_Write_Option_Byte.Checked = Properties.Settings.Default.DL_Write_Option_Byte;
            Tbx_DL_Read_Protect.Text = Properties.Settings.Default.DL_Read_Protect;
            Tbx_DL_HW_Byte.Text = Properties.Settings.Default.DL_HW_Byte;
            Tbx_DL_Write_Protect1.Text = Properties.Settings.Default.DL_Write_Protect1;
            Tbx_DL_Write_Protect2.Text = Properties.Settings.Default.DL_Write_Protect2;
            Tbx_DL_Write_Protect3.Text = Properties.Settings.Default.DL_Write_Protect3;
            Tbx_DL_Write_Protect4.Text = Properties.Settings.Default.DL_Write_Protect4;
            Tbx_DL_User_Data1.Text = Properties.Settings.Default.DL_User_Data1;
            Tbx_DL_User_Data2.Text = Properties.Settings.Default.DL_User_Data2;
            Tbx_DL_Adress.Enabled=Properties.Settings.Default.DL_Start_Address_Enable ;
            Tbx_Run_Adress.Enabled=Properties.Settings.Default.DL_Run_Address_Enable;
            //调试界面
            Cbx_Debug_BaudRate.SelectedIndex = Properties.Settings.Default.Debug_BaudRate;
            Cbx_Debug_StopBit.SelectedIndex = Properties.Settings.Default.Debug_StopBit; ;
            CBx_Debug_DataBit.SelectedIndex = Properties.Settings.Default.Debug_DataBit;
            Cbx_Debug_Parity.SelectedIndex = Properties.Settings.Default.Debug_CheckBit;
            Ckbx_Debug_Show_Hex.Checked = Properties.Settings.Default.Debug_Show_Hex;
            Ckbx_Debug_DTR.Checked = Properties.Settings.Default.Debug_DTR;
            Ckbx_Debug_RTS.Checked = Properties.Settings.Default.Debug_RTS;
            Cbx_Debug_RTS_Delay.SelectedIndex = Properties.Settings.Default.Debug_RTS_Time;
            Tbx_Debug_Send_One.Text = Properties.Settings.Default.Debug_Send_One;
            Tbx_Debug_Send_File_Name.Text = Properties.Settings.Default.Debug_Send_File_Name;
            Ckbx_Debug_Send_Hex.Checked = Properties.Settings.Default.Debug_Send_Hex;
            Ckbx_Debug_Send_NewLine.Checked = Properties.Settings.Default.Debug_Send_NewLine;
            Ckbx_Debug_Send_Ontime.Checked = Properties.Settings.Default.Debug_Send_OnTime;
            Tbx_Debug_Resend_Time.Text = Properties.Settings.Default.Debug_Resend_Time;
            Ckbx_Debug_Show_Time.Checked = Properties.Settings.Default.Debug_Show_Time;
            Tbx_Debug_Show_Time.Text = Properties.Settings.Default.Debug_Show_Time_Val;

            _ds_Debug_Send = Properties.Settings.Default.Debug_Send_Project;//获取调试串口多条发送数据集
            _s_Debug_Select_Name = Properties.Settings.Default.Debug_Select_Prj_Name;
            _i_Debug_Select_Page = Properties.Settings.Default.Debug_Select_Prj_Page;

            Lbx_Debug_Project.Items.Clear();
            if (_ds_Debug_Send != null 
                && _ds_Debug_Send.Tables.Count > 0
                && _s_Debug_Select_Name != "" 
                && _ds_Debug_Send.Tables[_s_Debug_Select_Name] != null)//存在数据  选择指定项目  且相关项目存在
            {
                //添加至列表
                foreach (DataTable _dt_ls in _ds_Debug_Send.Tables)
                {
                    Lbx_Debug_Project.Items.Add(_dt_ls.TableName);
                }
                Lbx_Debug_Project.SelectedItem = _s_Debug_Select_Name;
                Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
                Tbx_Debug_Project.TextChanged += Tbx_Debug_Project_TextChanged;//修改项目名称文本框之后再添加事件
            }
            else
            {
                //Tbx_Debug_Project.TextChanged += Tbx_Debug_Project_TextChanged;//修改项目名称文本框之后再添加事件
                //需要添加默认项目
                Btn_Debug_Prj_Add_Click(null, null);
            }
            

            Ckbx_Debug_M_Send_NewLine.Checked = Properties.Settings.Default.Debug_Send_M_NewLine;
            Ckbx_Debug_M_Send_Hex.Checked = Properties.Settings.Default.Debug_Send_M_Hex;
            Ckbx_Debug_M_Con_NumKey.Checked = Properties.Settings.Default.Debug_Send_M_ConNumKey;
            Ckbx_Debug_M_Resend.Checked = Properties.Settings.Default.Debug_Send_M_Resend;
            Tbx_Debug_M_Resend_Time.Text = Properties.Settings.Default.Debug_Send_M_Resend_Time;

            //最后相关环境配置
            if (Ckbx_Debug_Send_Hex.Checked)//勾选十六进制发送
                Tbx_Debug_Send_One.KeyPress += KeyPress_Allow_Hex_Space;
            if (Ckbx_Debug_M_Send_Hex.Checked)//勾选多条发送十六进制发送
            {
                Tbx_Debug_M0.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M1.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M2.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M3.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M4.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M5.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M6.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M7.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M8.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M9.KeyPress += KeyPress_Allow_Hex_Space;
            }
            if (Ckbx_Debug_M_Con_NumKey.Checked)
            {
                this.KeyPress += Main_KeyPress;
            }
            //置于顶层图标
            if (TopMost)
                Pbx_Fix.Image = Properties.Resources.fix;
            else
                Pbx_Fix.Image = Properties.Resources.unfix;

            //以下为系统级别设置
            //判断是否开启启动检查更新
            TsBtn_Start_Check_Update.Checked = Properties.Settings.Default.Start_Check_Update;
            if (TsBtn_Start_Check_Update.Checked)//开启检查更新线程
            {
                Check_Update();
            }
        }

        /// <summary>
        /// 根据项目名称以及页码显示
        /// </summary>
        /// <param name="_s_Name"></param>
        /// <param name="_i_Page"></param>
        public void Debug_Send_Prj_Go(string _s_Name, int _i_Page)
        {
            _s_Debug_Select_Name = _s_Name;
            _i_Debug_Select_Page = _i_Page;
            _i_Debug_Select_Page_All=_ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows.Count / 10;
            Ckbx_Debug_M0.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 0][0];
            Tbx_Debug_M0.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 0][1].ToString();
            Ckbx_Debug_M1.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 1][0];
            Tbx_Debug_M1.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 1][1].ToString();
            Ckbx_Debug_M2.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 2][0];
            Tbx_Debug_M2.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 2][1].ToString();
            Ckbx_Debug_M3.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 3][0];
            Tbx_Debug_M3.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 3][1].ToString();
            Ckbx_Debug_M4.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 4][0];
            Tbx_Debug_M4.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 4][1].ToString();
            Ckbx_Debug_M5.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 5][0];
            Tbx_Debug_M5.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 5][1].ToString();
            Ckbx_Debug_M6.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 6][0];
            Tbx_Debug_M6.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 6][1].ToString();
            Ckbx_Debug_M7.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 7][0];
            Tbx_Debug_M7.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 7][1].ToString();
            Ckbx_Debug_M8.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 8][0];
            Tbx_Debug_M8.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 8][1].ToString();
            Ckbx_Debug_M9.Checked = (bool)_ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 9][0];
            Tbx_Debug_M9.Text = _ds_Debug_Send.Tables[_s_Name].Rows[(_i_Page - 1) * 10 + 9][1].ToString();
            Btn_Debug_M0.Text = ((_i_Page - 1) * 10 + 0).ToString();
            Btn_Debug_M1.Text = ((_i_Page - 1) * 10 + 1).ToString();
            Btn_Debug_M2.Text = ((_i_Page - 1) * 10 + 2).ToString();
            Btn_Debug_M3.Text = ((_i_Page - 1) * 10 + 3).ToString();
            Btn_Debug_M4.Text = ((_i_Page - 1) * 10 + 4).ToString();
            Btn_Debug_M5.Text = ((_i_Page - 1) * 10 + 5).ToString();
            Btn_Debug_M6.Text = ((_i_Page - 1) * 10 + 6).ToString();
            Btn_Debug_M7.Text = ((_i_Page - 1) * 10 + 7).ToString();
            Btn_Debug_M8.Text = ((_i_Page - 1) * 10 + 8).ToString();
            Btn_Debug_M9.Text = ((_i_Page - 1) * 10 + 9).ToString();
            Tbx_Debug_Project.Text = _s_Debug_Select_Name;
            Lab_Debug_M_Page.Text = string.Format("{0}/{1}"
                ,_i_Debug_Select_Page, _i_Debug_Select_Page_All);
        }

        /// <summary>
        /// 存储窗体信息
        /// </summary>
        public void Save_Config()
        {
            //设置默认选项
            //窗体设置
            Properties.Settings.Default.Frm_Fix_Stat = TopMost;
            if (WindowState == FormWindowState.Maximized)
                Properties.Settings.Default.Frm_Max_Stat = true;
            else
            {
                Properties.Settings.Default.Frm_Max_Stat = false;
                Properties.Settings.Default.Frm_Size = this.Size;
            }
            //设置选项卡次序
            Properties.Settings.Default.Tab_0 = Tc_Main.TabPages[0].Name;
            Properties.Settings.Default.Tab_1 = Tc_Main.TabPages[1].Name;
            Properties.Settings.Default.Tab_2 = Tc_Main.TabPages[2].Name;
            Properties.Settings.Default.Tab_3 = Tc_Main.TabPages[3].Name;
            Properties.Settings.Default.Tab_4 = Tc_Main.TabPages[4].Name;
            //下载界面
            Properties.Settings.Default.DL_BaudRate = Cbx_DL_BaudRate.SelectedIndex;
            Properties.Settings.Default.DL_File_Path = Tbx_DL_File_Path.Text;
            Properties.Settings.Default.DL_BL_Go_Way = Cbx_Go_BL_Way.SelectedIndex;
            Properties.Settings.Default.DL_BL_Auto_Match = Ckbx_Auto_Match.Checked;
            Properties.Settings.Default.DL_Start_Address = Tbx_DL_Adress.Text;
            Properties.Settings.Default.DL_Run_Address = Tbx_Run_Adress.Text;
            Properties.Settings.Default.DL_Check = Ckbx_Check.Checked;
            Properties.Settings.Default.DL_After_Direct_Run = Ckbx_DL_After_Dir_Run.Checked;
            Properties.Settings.Default.DL_Auto_Close_Debug_Port = Ckbx_DL_Auto_Close_Debug_Port.Checked;
            Properties.Settings.Default.DL_Show_Time = Ckbx_DL_Show_Time.Checked;
            Properties.Settings.Default.DL_Auto_Download = Cbx_Auto_DL.Checked;
            if (Rbtn_Erase_All.Checked == true)
                Properties.Settings.Default.DL_Erase_Way = 0;
            else
                Properties.Settings.Default.DL_Erase_Way = 1;
            Properties.Settings.Default.DL_Write_Option_Byte = Ckbx_DL_Write_Option_Byte.Checked;
            Properties.Settings.Default.DL_Read_Protect = Tbx_DL_Read_Protect.Text;
            Properties.Settings.Default.DL_HW_Byte = Tbx_DL_HW_Byte.Text;
            Properties.Settings.Default.DL_Write_Protect1 = Tbx_DL_Write_Protect1.Text;
            Properties.Settings.Default.DL_Write_Protect2 = Tbx_DL_Write_Protect2.Text;
            Properties.Settings.Default.DL_Write_Protect3 = Tbx_DL_Write_Protect3.Text;
            Properties.Settings.Default.DL_Write_Protect4 = Tbx_DL_Write_Protect4.Text;
            Properties.Settings.Default.DL_User_Data1 = Tbx_DL_User_Data1.Text;
            Properties.Settings.Default.DL_User_Data2 = Tbx_DL_User_Data2.Text;
            Properties.Settings.Default.DL_Start_Address_Enable = Tbx_DL_Adress.Enabled;
            Properties.Settings.Default.DL_Run_Address_Enable = Tbx_Run_Adress.Enabled;
            //调试界面
            Properties.Settings.Default.Debug_BaudRate = Cbx_Debug_BaudRate.SelectedIndex;
            Properties.Settings.Default.Debug_StopBit = Cbx_Debug_StopBit.SelectedIndex; ;
            Properties.Settings.Default.Debug_DataBit = CBx_Debug_DataBit.SelectedIndex;
            Properties.Settings.Default.Debug_CheckBit = Cbx_Debug_Parity.SelectedIndex;
            Properties.Settings.Default.Debug_Show_Hex = Ckbx_Debug_Show_Hex.Checked;
            Properties.Settings.Default.Debug_DTR = Ckbx_Debug_DTR.Checked;
            Properties.Settings.Default.Debug_RTS = Ckbx_Debug_RTS.Checked;
            Properties.Settings.Default.Debug_RTS_Time = Cbx_Debug_RTS_Delay.SelectedIndex;
            Properties.Settings.Default.Debug_Send_One = Tbx_Debug_Send_One.Text;
            Properties.Settings.Default.Debug_Send_File_Name = Tbx_Debug_Send_File_Name.Text;
            Properties.Settings.Default.Debug_Send_Hex = Ckbx_Debug_Send_Hex.Checked;
            Properties.Settings.Default.Debug_Send_NewLine = Ckbx_Debug_Send_NewLine.Checked;
            Properties.Settings.Default.Debug_Send_OnTime = Ckbx_Debug_Send_Ontime.Checked;
            Properties.Settings.Default.Debug_Resend_Time = Tbx_Debug_Resend_Time.Text;
            Properties.Settings.Default.Debug_Show_Time = Ckbx_Debug_Show_Time.Checked;
            Properties.Settings.Default.Debug_Show_Time_Val = Tbx_Debug_Show_Time.Text;
            //调试界面发送多行
            Properties.Settings.Default.Debug_Send_Project = _ds_Debug_Send;
            Properties.Settings.Default.Debug_Select_Prj_Name=_s_Debug_Select_Name;
            Properties.Settings.Default.Debug_Select_Prj_Page=_i_Debug_Select_Page;
            Properties.Settings.Default.Debug_Send_M_NewLine=Ckbx_Debug_M_Send_NewLine.Checked ;
            Properties.Settings.Default.Debug_Send_M_Hex=Ckbx_Debug_M_Send_Hex.Checked;
            Properties.Settings.Default.Debug_Send_M_ConNumKey=Ckbx_Debug_M_Con_NumKey.Checked;
            Properties.Settings.Default.Debug_Send_M_Resend=Ckbx_Debug_M_Resend.Checked;
            Properties.Settings.Default.Debug_Send_M_Resend_Time=Tbx_Debug_M_Resend_Time.Text;

            //系统级别设置
            Properties.Settings.Default.Start_Check_Update = TsBtn_Start_Check_Update.Checked;//是否开启启动时检查更新

            //保存设置
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }


        #region 通用函数及事件
        /// <summary>
        /// 窗体按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Tc_Main.SelectedTab.Name=="Tp_Debug" &&Tc_Debug.SelectedTab.Name != "Tp_Debug_Send_More") return;
            switch (e.KeyChar)
            {
                case '0':
                    Btn_Debug_M0.Focus();
                    Btn_Debug_M0_Click(null,null);
                    break;
                case '1':
                    Btn_Debug_M1.Focus();
                    Btn_Debug_M1_Click(null, null);
                    break;
                case '2':
                    Btn_Debug_M2.Focus();
                    Btn_Debug_M2_Click(null, null);
                    break;
                case '3':
                    Btn_Debug_M3.Focus();
                    Btn_Debug_M3_Click(null, null);
                    break;
                case '4':
                    Btn_Debug_M4.Focus();
                    Btn_Debug_M4_Click(null, null);
                    break;
                case '5':
                    Btn_Debug_M5.Focus();
                    Btn_Debug_M5_Click(null, null);
                    break;
                case '6':
                    Btn_Debug_M6.Focus();
                    Btn_Debug_M6_Click(null, null);
                    break;
                case '7':
                    Btn_Debug_M7.Focus();
                    Btn_Debug_M7_Click(null, null);
                    break;
                case '8':
                    Btn_Debug_M8.Focus();
                    Btn_Debug_M8_Click(null, null);
                    break;
                case '9':
                    Btn_Debug_M9.Focus();
                    Btn_Debug_M9_Click(null, null);
                    break;
            }
        }

        /// <summary>
        /// 底部消息显示  显示时间修改定时器时间即可
        /// </summary>
        /// <param name="_msg"></param>
        public void Show_Btm_Msg(string _msg,int _type=0)
        {
            Tc_Main.BeginInvoke(new Action(()=>
            {
                Tstbx_Serial_Stat.Text = _msg;
                switch (_type)
                {
                    case 0:
                        Tstbx_Serial_Stat_Img.BackgroundImage = Properties.Resources.msg20;
                        break;
                    case 1:
                        Tstbx_Serial_Stat_Img.BackgroundImage = Properties.Resources.errmsg20;
                        break;
                }
                
                Tmr_Btm_Msg.Stop();
                Tmr_Btm_Msg.Start();
            }));
        }

        /// <summary>
        /// 置于顶层
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pbx_Fix_Click(object sender, EventArgs e)
        {
            if (TopMost)
            {
                Pbx_Fix.Image = Properties.Resources.unfix;
                TopMost = false;
                Show_Btm_Msg("取消置于顶层！");
            }
            else
            {
                Pbx_Fix.Image = Properties.Resources.fix;
                TopMost = true;
                Show_Btm_Msg("窗体已置于顶层！");
            }
        }

        /// <summary>
        /// 只允许十六进制字符按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPress_Allow_Hex(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F')
                || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                if (e.KeyChar >= 'a' && e.KeyChar <= 'z')//转换为大写
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 只允许数字按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPress_Allow_Num(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 显示数值范围为1-1000000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChange_1_1000000(object sender,EventArgs e)
        {
            try
            {
                int _val = int.Parse((sender as TextBox).Text);
                if (_val < 1 || _val > 1000000)
                {
                    throw new Exception("数值范围有误！");
                }
            }
            catch
            {
                (sender as TextBox).Text = "1000";
                MessageBox.Show("请输入数字（1-1000000）！", "提示");
                return;
            }
        }
        /// <summary>
        /// 显示数值范围为0-1000000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChange_0_1000000(object sender, EventArgs e)
        {
            try
            {
                int _val = int.Parse((sender as TextBox).Text);
                if (_val < 0 || _val > 1000000)
                {
                    throw new Exception("数值范围有误！");
                }
            }
            catch
            {
                (sender as TextBox).Text = "1000";
                MessageBox.Show("输入不能超过1000000！", "提示");
                return;
            }
        }


        /// <summary>
        /// 只允许十六进制字符 以及空格按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPress_Allow_Hex_Space(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b' || (e.KeyChar >= 'a' && e.KeyChar <= 'f') || (e.KeyChar >= 'A' && e.KeyChar <= 'F')
                || (e.KeyChar >= '0' && e.KeyChar <= '9')||e.KeyChar==' ')
            {
                if (e.KeyChar >= 'a' && e.KeyChar <= 'z')//转换为大写
                {
                    e.KeyChar = e.KeyChar.ToString().ToUpper()[0];
                }
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 选项卡更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tc_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tc_Main.SelectedTab == null) return;
            switch (Tc_Main.SelectedTab.Name)
            {
                case "Tp_DL"://下载助手
                    Tstbx_Serial_Stat_Img.BackgroundImage = _img_DL_BTM;
                    Tstbx_Serial_Stat.Text = _str_DL_BTM_Msg;
                    //Lbx_Msg_DL.Visible = true;
                    //Tbx_Msg_Debug.Visible = false;
                    //Lab_Debug_TX_T.Visible = false;
                    //Lab_Debug_TX.Visible = false;
                    //Lab_Debug_RX_T.Visible = false;
                    //Lab_Debug_RX.Visible = false;
                    break;
                case "Tp_Debug"://调试助手 
                    Tstbx_Serial_Stat_Img.BackgroundImage = _img_Debug_BTM;
                    Tstbx_Serial_Stat.Text = _str_Debug_SMsg;
                    //Tbx_Msg_Debug.Visible = true;
                    //Lbx_Msg_DL.Visible = false;
                    //Lab_Debug_TX_T.Visible = true;
                    //Lab_Debug_TX.Visible = true;
                    //Lab_Debug_RX_T.Visible = true;
                    //Lab_Debug_RX.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// 下载串口状态改变事件
        /// </summary>
        public event EventHandler Serial_DL_StataChange;
        
        /// <summary>
        /// 下载串口改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Sp_Main_Serial_DL_StataChange(object sender, EventArgs e)
        {
            SerialPort sp = sender as SerialPort;
            Ts_Bottom.Invoke(new Action(()=>
            {
                if (sp.IsOpen)
                {
                    _img_DL_BTM=Properties.Resources.open20;
                    _str_DL_BTM_Msg = "下载串口已打开，" + sp.PortName + "，" + sp.BaudRate + "，任务进行中...";
                }
                else
                {
                    _img_DL_BTM = Properties.Resources.close20;
                    _str_DL_BTM_Msg = "下载串口已关闭！";
                }
                if (Tc_Main.SelectedTab.Name == "Tp_DL")//只有选择下载Tab才改变
                {
                    Tstbx_Serial_Stat_Img.BackgroundImage = _img_DL_BTM;
                    Tstbx_Serial_Stat.Text = _str_DL_BTM_Msg;
                }
            })); 
        }

        /// <summary>
        /// 调试串口状态改变事件
        /// </summary>
        public event EventHandler Serial_Debug_StataChange;

        /// <summary>
        /// 调试串口改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Sp_Main_Serial_Debug_StataChange(object sender, EventArgs e)
        {
            SerialPort sp = sender as SerialPort;
            this.BeginInvoke(new Action(() =>
            {
                if (sp.IsOpen)
                {
                    _img_Debug_BTM = Properties.Resources.open20;
                    _str_Debug_SMsg = "调试串口已打开，" + sp.PortName + "，" + sp.BaudRate + "。";
                }
                else
                {
                    _img_Debug_BTM = Properties.Resources.close20;
                    _str_Debug_SMsg = "调试串口已关闭！";
                }
                if (Tc_Main.SelectedTab.Name != null && Tc_Main.SelectedTab.Name == "Tp_Debug") //只有选择调试Tab才改变
                {
                    Tstbx_Serial_Stat_Img.BackgroundImage = _img_Debug_BTM;
                    Tstbx_Serial_Stat.Text = _str_Debug_SMsg;
                }
            }));
        }

        /// <summary>
        /// 重新封装打开下载串口
        /// </summary>
        public void DL_Serial_Open()
        {
            Sp_DownLoad.Open();
            Serial_DL_StataChange?.Invoke(Sp_DownLoad,null);
        }

        /// <summary>
        /// 重新封装关闭下载串口
        /// </summary>
        public void DL_Serial_Close()
        {
            Sp_DownLoad.Close();
            Serial_DL_StataChange?.Invoke(Sp_DownLoad, null);
        }

        /// <summary>
        /// 重新封装打开调试串口
        /// </summary>
        public void Debug_Serial_Open()
        {
            Sp_Debug.Open();
            Serial_Debug_StataChange?.BeginInvoke(Sp_Debug, null,null,null);
            Pal_Serial_Option.Enabled = false;
            Btn_Debug_Open_Serial.Text = "关闭串口";
            Btn_Debug_Open_Serial.Image = Properties.Resources.open20;
        }

        /// <summary>
        /// 重新封装关闭调试串口
        /// </summary>
        public void Debug_Serial_Close()
        {
            if (Tmr_Debug_ReSend.Enabled)
            {
                Tmr_Debug_ReSend.Stop();
                Ckbx_Debug_Send_Ontime.Checked = false;
            }
            //Sp_Debug.DiscardOutBuffer();
            //Sp_Debug.DiscardInBuffer();
            Sp_Debug.Close();
            Pal_Serial_Option.Enabled = true;
            Btn_Debug_Open_Serial.Text = "打开串口";
            Btn_Debug_Open_Serial.Image = Properties.Resources.close20;
            Serial_Debug_StataChange?.BeginInvoke(Sp_Debug, null, null, null);
        }

        /// <summary>
        /// 重新封装下载串口发送函数
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        public void DL_Serial_Write(byte[] data, int offset, int count)
        {
            try
            {
                Sp_DownLoad.Write(data, offset, count);
            }
            catch (Exception err)
            {
                throw new Exception("发送失败，" + err.Message);
            }
        }

        /// <summary>
        /// 重新封装调试串口发送函数
        /// </summary>
        /// <param name="_data"></param>
        /// <param name="_offset"></param>
        public void Debug_Serial_Write(byte[] _data)
        {
            try
            {
                Sp_Debug.Write(_data,0,_data.Length);
                _i_Debug_TX += _data.Length;
                Lab_Debug_TX.Text = _i_Debug_TX.ToString();
            }
            catch(Exception err)
            {
                throw new Exception("发送失败，"+err.Message);
            }
        }

        public void Debug_Serial_Write(string _data)
        {
            Debug_Serial_Write( Encoding.Default.GetBytes(_data));
        }

        /// <summary>
        /// 显示下载提示字符串消息
        /// </summary>
        /// <param name="_s_msg">字符串消息</param>
        public void Show_DL_Msg(string _s_msg)
        {
            Lbx_Msg_DL.BeginInvoke(new Action(() =>
            {
                if (_s_msg.Contains("次重试") && Lbx_Msg_DL.Items[Lbx_Msg_DL.Items.Count - 1].ToString().Contains("次重试"))
                {
                    Lbx_Msg_DL.Items.RemoveAt(Lbx_Msg_DL.Items.Count - 1);
                    string.Format(Ckbx_DL_Show_Time.Checked ? DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss.fff] {0}\r\n") : "{0}\r\n"
                    , _s_msg);
                }
                Lbx_Msg_DL.Items.Add(string.Format(Ckbx_DL_Show_Time.Checked ? DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss.fff] {0}\r\n") : "{0}\r\n"
                       , _s_msg));
                Lbx_Msg_DL.SelectedIndex = Lbx_Msg_DL.Items.Count - 1;        //选中最后一项
            }));
        }

        /// <summary>
        /// 刷新并加载串口
        /// </summary>
        /// <param name="i">0：下载串口  1：调试串口</param>
        /// <returns></returns>
        public int Fresh_Serial(int i)
        {
            switch (i)
            {
                case 0:
                    Cbx_DL_Serial_Num.Items.Clear();
                    foreach (Class.Serial_Info csi in Class.Cls_Serial.GetPorts())
                    {
                        Cbx_DL_Serial_Num.Items.Add(csi.ToString());
                    }
                    if (Cbx_DL_Serial_Num.Items.Count > 0)
                        Cbx_DL_Serial_Num.SelectedIndex = 0;
                    return Cbx_DL_Serial_Num.Items.Count;
                case 1:
                    Cbx_Debug_Seiral_Num.Items.Clear();
                    foreach (Class.Serial_Info csi in Class.Cls_Serial.GetPorts())
                    {
                        Cbx_Debug_Seiral_Num.Items.Add(csi.ToString());
                    }
                    if (Cbx_Debug_Seiral_Num.Items.Count > 0)
                        Cbx_Debug_Seiral_Num.SelectedIndex = 0;
                    return Cbx_Debug_Seiral_Num.Items.Count;
                default:
                    return 0;
            }
            
            
        }

        /// <summary>
        /// 刷新串口按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Fresh_Serial(0);
        }

        /// <summary>
        /// 系统时间刷新显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Clock_Tick(object sender, EventArgs e)
        {
            Tbx_Time_Show.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");
        }

        /// <summary>
        /// 通用函数 关闭窗体函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_th_ISP != null && (_th_ISP.IsAlive || _th_ISP.ThreadState == ThreadState.AbortRequested))
            {
                if (MessageBox.Show("任务正在运行，是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                {
                    e.Cancel = true;//取消关闭
                }
            }
            else if (Sp_DownLoad.IsOpen||Sp_Debug.IsOpen)
            {
                if (MessageBox.Show("串口正在使用，是否关闭？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                {
                    e.Cancel = true;//取消关闭
                }
            }
            if (e.Cancel == false)//关闭则存储窗体信息
            {
                Save_Config();
            }
        }
        #endregion

        #region 下载串口控件事件
        /// <summary>
        /// SerialPort接受数据事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_Main_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //if (Sp_Main.IsOpen) //判断串口是否打开
            //{
            //    try
            //    {
            //        byte[] _b_recv = null;
            //        int N = this.Sp_Main.BytesToRead;
            //        _b_recv = new byte[N];
            //        this.Sp_Main.Read(_b_recv, 0, N);
            //        switch (_i_Serial_Work_Way)//判断使用哪一部分功能
            //        {
            //            case 1:     //下载助手 读芯片信息
            //            case 2:     //下载助手 擦除芯片
            //                _cs_Buffer.Append(_b_recv, N);
            //                Rtb_Recv_Msg.Invoke(new Action(() =>
            //                {
            //                    Tmr_Serial.Stop();          //计时器复位
            //                    Tmr_Serial.Start();
            //                }));
            //                break;
            //            default:   //正常显示接受消息 
            //                Show_DL_Msg(_b_recv, 0, N);
            //                break;

            //        }

            //    }
            //    finally
            //    {
            //    }
            //}
        }
        /// <summary>
        /// SerialPort接受错误事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_Main_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            //if (Sp_Main.IsOpen) //判断串口是否打开
            //{
            //    try
            //    {
            //        byte[] _b_recv = null;
            //        int N = this.Sp_Main.BytesToRead;
            //        _b_recv = new byte[N];
            //        this.Sp_Main.Read(_b_recv, 0, N);
            //        switch (_i_Serial_Work_Way)//判断使用哪一部分功能
            //        {
            //            case 1:     //下载助手 读芯片信息
            //            case 2:     //下载助手 擦除芯片
            //                _cs_Buffer.Append(_b_recv, N);
            //                Rtb_Recv_Msg.Invoke(new Action(() =>
            //                {
            //                    Tmr_Serial.Stop();          //计时器复位
            //                    Tmr_Serial.Start();
            //                }));
            //                break;
            //            default:   //正常显示接受消息 
            //                Show_DL_Msg(_b_recv, 0, N);
            //                break;

            //        }

            //    }
            //    finally
            //    {
            //    }
            //}
        }

        #endregion

        #region 下载助手 函数
        Class.Hardware_Info _hi_Chip;                           //芯片信息
        const byte ISP_ACK = 0x79;          //成功
        const byte ISP_NACK = 0x1F;         //失败
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <returns></returns>
        public int Open_Serial()
        {
            try
            {
                this.Invoke(new Action(() =>//需要使用委托
                {
                    try
                    {
                        Sp_DownLoad.PortName = Cbx_DL_Serial_Num.Text.Split(':')[0];                 //设置串口号
                        Sp_DownLoad.BaudRate = int.Parse(Cbx_DL_BaudRate.Text);     //设置波特率
                        if (Sp_DownLoad.IsOpen)             //如果串口打开，关闭串口
                            DL_Serial_Close();
                        if(Sp_Debug.IsOpen
                        &&Sp_Debug.PortName==Sp_DownLoad.PortName
                        &&Ckbx_DL_Auto_Close_Debug_Port.Checked)//如果调试串口打开，且等于将要打开的下载串口，且勾选自动关闭调试串口 则关闭调试串口
                        {
                            Debug_Serial_Close();
                        Show_DL_Msg(string.Format("调试助手正在使用串口：{0} ，已关闭调试串口！", Cbx_DL_Serial_Num.Text.Split(':')[0]));
                        }
                        DL_Serial_Open();                                         //打开串口
                    }
                    catch
                    {
                        ///串口打开失败
                        Tstbx_Serial_Stat.Text = "下载串口打开失败，请检查串口是否被占用！";
                        Tstbx_Serial_Stat_Img.BackgroundImage = Properties.Resources.used20;
                        throw new Exception("下载串口打开失败，请检查串口是否被占用！");
                    }
                    Show_DL_Msg(string.Format("成功打开下载串口：{0}，波特率：{1}", Cbx_DL_Serial_Num.Text.Split(':')[0], Cbx_DL_BaudRate.Text));
                }));
                return 0;
            }
            catch
            {
                return 1;
            }
        }

        /// <summary>
        /// 从串口读取指定长度数据
        /// </summary>
        /// <param name="count">数据长度</param>
        /// <param name="timeout">读取次数，默认20000</param>
        /// <returns>返回读取的数据，返回null表示超时</returns>
        public byte[] Read_More(int count, int timeout = 20000)
        {
            try
            {
                int t = timeout;
                while ((t--) > 0)// && Sp_Main.IsOpen)
                {
                    int len = Sp_DownLoad.BytesToRead;
                    if (len == count)
                    {
                        byte[] _ls = new byte[len];
                        Sp_DownLoad.Read(_ls, 0, len);//读取数据
                        Sp_DownLoad.DiscardInBuffer();//打扫战场
                        return _ls;
                    }
                }
                return null;//超时
            }
            catch(Exception err)
            {
                throw new Exception("从串口读取数据出错，"+err.Message);
            }
        }

        /// <summary>
        /// 进入BL，指令码：0x79
        /// 【注】只允许在线程模式下调用
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Enter_BootLoader(int _i_to = 20000)
        {
            DL_Serial_Write(new byte[] { 0x7F }, 0, 1);//请求进入BL
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] == ISP_ACK)  //成功
                return 0;
            else //失败
                return 1;
        }

        /// <summary>
        /// 获取支持的指令代码，指令码：0x00 0xFF（XOR校验）
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Get_Command(int _i_to = 20000)
        {
            DL_Serial_Write(new byte[] { 0x00, 0xFF }, 0, 2);
            byte[] _b_ls = Read_More(15, _i_to);      //读取15字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] == ISP_ACK     //校验指令头
                        && _b_ls.Last() == ISP_ACK)//校验指令尾
            {
                //开始解析接受数据
                _hi_Chip.Support_CMD = new byte[_b_ls[1]];//初始化支持指令列表
                _hi_Chip.Version = _b_ls[2].ToString("X2").Insert(1, ".");//获取BL版本号
                Array.Copy(_b_ls, 3, _hi_Chip.Support_CMD, 0, 11);      //获取BL支持指令列表
                return 0;
            }
            else //失败
                return 1;
        }

        /// <summary>
        /// 获取BL Version，指令码：0x01 0xFE（XOR校验）
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Get_BL_Version(int _i_to = 20000)
        {
            DL_Serial_Write(new byte[] { 0x01, 0xFE }, 0, 2);
            byte[] _b_ls = Read_More(5, _i_to);      //读取5字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] == ISP_ACK     //校验指令头
                        && _b_ls.Last() == ISP_ACK)//校验指令尾
            {
                //开始解析接受数据
                _hi_Chip.Version = _b_ls[1].ToString("X2").Insert(1, ".");  //获取Version
                return 0;
            }
            else //失败
                return 1;
        }

        /// <summary>
        /// 获取PID(Product ID)，指令码：0x02 0xFD（XOR校验）
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Get_PID(int _i_to = 20000)
        {
            DL_Serial_Write(new byte[] { 0x02, 0xFD }, 0, 2);
            byte[] _b_ls = Read_More(5, _i_to);      //读取5字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] == ISP_ACK     //校验指令头
                        && _b_ls.Last() == ISP_ACK//校验指令尾
                        && _b_ls[1] == _b_ls.Length - 4)//校验数据长度
            {
                //开始解析接受数据
                _hi_Chip.PID = _b_ls[2].ToString("X2") + _b_ls[3].ToString("X2");  //获取PID
                return 0;
            }
            else //失败
                return 1;
        }

        /// <summary>
        /// 读指定地址指定长度数据，指令码：0x11 0xEE（XOR校验）
        /// 第一步：发送 0x11 0xEE，等待回执；
        /// 第二步：发送获取地址及XOR校验，5字节，例 {0x08,0x00,0x00,0x00,checsum}，等待回执；
        /// 第三步：发送获取数据长度及XOR校验，2字节，长度一字节，大于0，小于255，等待回执
        /// 第四步：接受指定长度数据。
        /// </summary>
        /// <param name="_b_adress">待读取的内存地址，大端模式，4字节</param>
        /// <param name="_b_len">获取数据长度，1字节，0-255</param>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Read_Memery(ref byte[] _b_val, byte[] _b_adress, int _b_len, int _i_to = 20000)
        {
            //第一步
            DL_Serial_Write(new byte[] { 0x11, 0xEE }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            //第二步
            byte[] _b_step2 = new byte[5];
            Array.Copy(_b_adress, 0, _b_step2, 0, 4);
            _b_step2[4] = Convert.ToByte(_b_adress[0] ^ _b_adress[1] ^ _b_adress[2] ^ _b_adress[3]);
            DL_Serial_Write(_b_step2, 0, 5);
            _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            //第三步
            byte _b_all_cks = Convert.ToByte(0xFF ^ (_b_len - 1));
            DL_Serial_Write(new byte[] { Convert.ToByte(_b_len - 1), _b_all_cks }, 0, 2);
            _b_ls = Read_More(_b_len + 1, _i_to * 4);      //读取_b_len+1字节数据  时间翻倍
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] == ISP_ACK)//获取成功
            {
                Array.Copy(_b_ls, 1, _b_val, 0, _b_len);    //拷贝指定长度数据
                return 0;
            }
            else
                return 1;//失败
        }

        /// <summary>
        /// 写指定地址指定长度数据，指令码 0x31 0xCE
        /// 第一步：写指令，等待回执
        /// 第二步：发送起始地址加校验，5字节
        /// 第三步：发送数据长度（1字节）、数据（n字节）、XOR校验（1字节），等待回执。
        /// </summary>
        /// <param name="_b_adress">写入地址</param>
        /// <param name="_b_data">写入数据，最大256字节</param>
        /// <param name="_i_to">读取超时次数：默认10000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Write_Memery(byte[] _b_adress, byte[] _b_data, int _i_to = 100000)
        {
            //第一步
            DL_Serial_Write(new byte[] { 0x31, 0xCE }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            //第二步
            byte[] _b_step2 = new byte[5];
            Array.Copy(_b_adress, 0, _b_step2, 0, 4);
            _b_step2[4] = Convert.ToByte(_b_adress[0] ^ _b_adress[1] ^ _b_adress[2] ^ _b_adress[3]);
            DL_Serial_Write(_b_step2, 0, 5);
            _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            //第三步
            byte[] _b_send = new byte[_b_data.Length + 2];      //创建发送字节数组
            _b_send[_b_send.Length - 1] = _b_send[0] = Convert.ToByte(_b_data.Length - 1); //发送数据的长度-1
            Array.Copy(_b_data, 0, _b_send, 1, _b_data.Length);     //拷贝发送数据
            for (int i = 1; i < _b_send.Length - 1; i++)
                _b_send[_b_send.Length - 1] ^= _b_send[i];
            DL_Serial_Write(_b_send, 0, _b_send.Length);
            _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            return 0;   //写入成功
        }

        /// <summary>
        /// 从指定地址开始运行程序，指令码：0x21 0xDE
        /// 第一步：发送指令码， 0x21 0xDE，等待回执
        /// 第二步：发送运行地址及XOR校验，5字节，例 {0x08,0x00,0x00,0x00,checsum}，等待回执；
        /// 完成
        /// </summary>
        /// <param name="_b_run">程序运行地址</param>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Go(byte[] _b_run, int _i_to = 20000)
        {
            //第一步
            DL_Serial_Write(new byte[] { 0x21, 0xDE }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            //第二步
            byte[] _b_step2 = new byte[5];
            Array.Copy(_b_run, 0, _b_step2, 0, 4);
            _b_step2[4] = Convert.ToByte(_b_run[0] ^ _b_run[1] ^ _b_run[2] ^ _b_run[3]);
            DL_Serial_Write(_b_step2, 0, 5);
            _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            return 0;//成功
        }

        /// <summary>
        /// 擦除指定扇区，指令码 0x43 0xBC
        /// 第一步：发送指令码
        /// 第二步：发送待擦除扇区信息列表
        /// </summary>
        /// <param name="_i_way">擦除方式：0，全片擦除 1:，部分擦除</param>
        /// <param name="_b_cmd">需要擦除的扇区列表 0-254</param>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Erase_Page(int _i_way, byte[] _b_cmd, int _i_to = 20000)
        {
            //第一步
            DL_Serial_Write(new byte[] { 0x43, 0xBC }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            //第二步
            if (_i_way == 0)//全片擦除
            {
                DL_Serial_Write(new byte[] { 0xFF, 0x00 }, 0, 2);
                byte[] _b_ls1 = Read_More(1, _i_to);      //读取1字节数据
                if (_b_ls == null) //超时
                    return 2;
                else if (_b_ls[0] != ISP_ACK)//失败
                    return 1;

            }
            else //根据需要擦除的扇区列表进行擦除
            {
                byte[] _b_e = new byte[_b_cmd.Length + 2];
                _b_e[0] = (byte)(_b_cmd.Length - 1);//扇区数量
                _b_e[1] = _b_e[_b_e.Length - 1] = _b_cmd[0];
                for (int i = 1; i < _b_cmd.Length; i++)
                {
                    _b_e[i + 1] = _b_cmd[i];
                    _b_e[_b_e.Length - 1] ^= _b_cmd[i];
                }
                DL_Serial_Write(_b_e, 0, _b_cmd.Length + 2);
                byte[] _b_ls1 = Read_More(1, _i_to);      //读取1字节数据
                if (_b_ls == null) //超时
                    return 2;
                else if (_b_ls[0] != ISP_ACK)//失败
                    return 1;
                return 0;//成功
            }
            return 0;//成功
        }

        /// <summary>
        /// 设置写保护，指令码 0x63 0x9C
        /// 第一步：发送指令码
        /// 第二步：发送写保护扇区信息列表
        /// </summary>
        /// <param name="_b_cmd">需要保护扇区列表 0-254</param>
        /// <param name="_i_to">读取超时次数：默认20000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Write_Protect_CMD(byte[] _b_cmd, int _i_to = 20000)
        {
            //第一步
            DL_Serial_Write(new byte[] { 0x63, 0x9C }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            byte[] _b_e = new byte[_b_cmd.Length + 2];
            _b_e[0] = (byte)(_b_cmd.Length - 1);//扇区数量
            _b_e[1]=_b_e[_b_e.Length - 1] = _b_cmd[0];
            for (int i = 1; i < _b_cmd.Length; i++)
            {
                _b_e[i+1] = _b_cmd[i];
                _b_e[_b_e.Length - 1] ^= _b_cmd[i];
            }
            DL_Serial_Write(_b_e, 0, _b_cmd.Length + 2);
            byte[] _b_ls1 = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            return 0;//成功
        }


        /// <summary>
        /// 设置写不保护，指令码 0x73 0x8C
        /// 用于解除Flash写保护
        /// 两次回执
        /// 第一次为成功接收指令
        /// 第二次为解除Flash保护成功
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认200000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Write_Unprotect_CMD(int _i_to = 200000)
        {
            //写指令
            DL_Serial_Write(new byte[] { 0x73, 0x8C }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            _b_ls = Read_More(1, _i_to);      //再读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            return 0;
        }

        /// <summary>
        /// 设置读保护，指令码 0x82 0x7D
        /// 用于设置Flash读保护
        /// 防止读出Flash数据
        /// 两次回执
        /// 第一次为成功接收指令
        /// 第二次为执行成功
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认200000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Readout_Protect_CMD(int _i_to = 200000)
        {
            //写指令
            DL_Serial_Write(new byte[] { 0x82, 0x7D }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            _b_ls = Read_More(1, _i_to);      //再读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            return 0;
        }

        /// <summary>
        /// 设置读不保护，指令码 0x92 0x6D
        /// 用于解除Flash读保护
        /// 两次回执
        /// 第一次为成功接收指令
        /// 第二次为执行成功
        /// </summary>
        /// <param name="_i_to">读取超时次数：默认200000次</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        public int ISP_Readout_Unprotect_CMD(int _i_to = 200000)
        {
            //写指令
            DL_Serial_Write(new byte[] { 0x92, 0x6D }, 0, 2);
            byte[] _b_ls = Read_More(1, _i_to);      //读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            _b_ls = Read_More(1, _i_to);      //再读取1字节数据
            if (_b_ls == null) //超时
                return 2;
            else if (_b_ls[0] != ISP_ACK)//失败
                return 1;
            return 0;
        }


        /// <summary>
        /// 解析下载文件 
        /// </summary>
        /// <param name="_s_info">文件信息</param>
        /// <returns>解析文件</returns>
        public BinStruct ISP_Load_DL_File(FileInfo _s_info)
        {
            Class.BinStruct _bs = null;
            if (_s_info.Extension.ToUpper() == ".BIN")//调用bin文件解析函数
            {
                _bs = Class.BinParse.Parse(_s_info);
                //二进制文件下载地址需要用户设置
                _bs.adress = Class.Cls_Convert.HexString_To_Byte(Tbx_DL_Adress.Text);
            }
            else
            {
                _bs = Class.HexParse.BinParse(_s_info);
            }
            if (_bs != null)
                Show_DL_Msg("下载字节大小：" + _bs.size + " 字节");
            return _bs;
        }

        /// <summary>
        /// 下载程序
        /// bin文件
        /// </summary>
        /// <param name="_s_path">文件路径</param>
        /// <returns>
        /// 0：下载完成
        /// 1：下载失败
        /// 2：下载超时
        /// 3：校验失败
        /// 4：文件有误
        /// </returns>
        public int ISP_DownLoade_Code_Bin(BinStruct _bs)
        {
            int i_stat = 0,i_stat_r=0;
            
            byte[] _b_write_one;//每次写入256字节缓冲区
            byte[] _b_read_one;//每次读取256字节缓冲区
            byte[] _b_adress_now = new byte[4];//四字节的下载地址  下载一次更新一次
            //一次写入256字节
            int _i_dl_time = ((int)_bs.size) / 256 + (((int)_bs.size) % 256 == 0 ? 0 : 1);//计算下载次数

            uint _u32 =Convert.ToUInt32(_bs.adress[0] << 24 | _bs.adress[1] << 16 | _bs.adress[2] << 8 | _bs.adress[3]);//地址转换

            for (int i = 0; i < _i_dl_time; i++, _u32+=256)
            {
                _b_adress_now = (BitConverter.GetBytes(_u32)).Reverse().ToArray();//由于使用自带转换函数后的字节数组为大端模式 所以需要翻转
                _b_write_one = _bs.data.Skip(i * 256).Take(256).ToArray();
                i_stat = ISP_Write_Memery(_b_adress_now, _b_write_one);//写入
                if (Ckbx_Check.Checked)//需要校验
                {
                    _b_read_one = new byte[_b_write_one.Length];
                    i_stat_r = ISP_Read_Memery(ref _b_read_one, _b_adress_now, _b_write_one.Length);
                    if (!Byte_Compare(_b_read_one,_b_write_one))//比较写入和读出是否相等
                    {
                        return 3;
                    }
                }
                Show_Process(i * 85 / _i_dl_time + 10);
                if (i_stat != 0||i_stat_r!=0)//写以及读失败 表示下载失败
                    break;
            }
            return i_stat;
        }

        /// <summary>
        /// 根据方案进入BootLoader
        /// </summary>
        public void ISP_Go_BL_Start()
        {
            switch (_i_ISP_MODE)
            {
                case 0://不使用DTR和RTS
                    break;
                case 1://DTR低电平复位，不使用RTS
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，复位完成！");
                    break;
                case 2://DTR低电平复位，RTS低电平进入BL
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("RTS置低，准备进入BootLoader");
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，复位完成！");
                    break;
                case 3://DTR低电平复位，RTS高电平进入BL
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，准备进入BootLoader");
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，复位完成！");
                    break;
                case 4://DTR高电平复位，不使用RTS
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置低，复位完成！");
                    break;
                case 5://DTR高电平复位，RTS低电平进入BL
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("RTS置低，准备进入BootLoader");
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，复位完成！");
                    break;
                case 6://DTR高电平复位，RTS高电平进入BL
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，准备进入BootLoader");
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，复位完成！");
                    break;
                case 7://RTS低电平复位，不使用DTR
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("RTS置低，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，复位完成！");
                    break;
                case 8://RTS低电平复位，DTR低电平进入BL
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，准备进入BootLoader");
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("RTS置低，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，复位完成！");
                    break;
                case 9://RTS低电平复位，DTR高电平进入BL
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，准备进入BootLoader");
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("RTS置低，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，复位完成！");
                    break;
                case 10://RTS高电平复位，不使用DTR
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置低，复位完成！");
                    break;
                case 11://RTS高电平复位，DTR低电平进入BL
                    Sp_DownLoad.DtrEnable = false;
                    Show_DL_Msg("DTR置低，准备进入BootLoader");
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("RTS置低，复位完成！");
                    break;
                case 12://RTS高电平复位，DTR高电平进入BL
                    Sp_DownLoad.DtrEnable = true;
                    Show_DL_Msg("DTR置高，准备进入BootLoader");
                    Sp_DownLoad.RtsEnable = true;
                    Show_DL_Msg("RTS置高，开始复位，延时10ms");
                    Thread.Sleep(10);
                    Sp_DownLoad.RtsEnable = false;
                    Show_DL_Msg("DTR置低，复位完成！");
                    break;
            }
        }

        /// <summary>
        /// 根据方案结束BootLoader
        /// </summary>
        public void ISP_Go_BL_End()
        {
            //关闭DTR和RTS
            Sp_DownLoad.DtrEnable = false;
            Sp_DownLoad.RtsEnable = false;
        }

        /// <summary>
        /// 比较两个字节数组是否相等
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool Byte_Compare(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 显示进度条
        /// </summary>
        /// <param name="pct"></param>
        public void Show_Process(int pct)
        {
            //防止显示进度越界
            if(pct>100)pct = 100;
            if (pct < 0) pct = 0;
            Pgb_DL_Task_Process.Invoke(new Action(() =>
            {
                if (pct == 100)//进度条为100 还原各设置
                {
                    Btn_DL_Select_File.Enabled = true;
                    Btn_DL_DownLoad_File.Enabled = true;
                    Btn_DL_Read_Chip_Info.Enabled = true;
                    Btn_DL_Erase_Chip.Enabled = true;
                    Gbx_DL_Option.Enabled = true;
                    Gbx_Option_Byte.Enabled = true;
                    Cbx_DL_Serial_Num.Enabled = true;
                    Cbx_DL_BaudRate.Enabled = true;
                    Btn_Serial_DL_Fresh.Enabled = true;
                    SystemSounds.Beep.Play();//播放提示音
                }
                Pgb_DL_Task_Process.Value = pct;//显示进度
            }));
        }

        /// <summary>
        /// 进入BL
        /// 获取硬件基础信息
        /// 为读取芯片信息以及下载文件做铺垫
        /// </summary>
        /// <param name="filesize">下载文件字节大小 默认为0 不需要判断</param>
        /// <returns></returns>
        public void ISP_Get_Chip_Base_Info_Start(double filesize=0)
        {
            int i_stat = 0;                             //函数执行状态
            i_stat = Open_Serial(); //打开串口 打开失败引发异常

            if (i_stat==1)//串口打开失败
                throw new Exception("串口打开失败，请检查串口是否被占用！");
            int i_time = 1;                             //执行次数
            Show_Process(0);//进入BL并读取信息  开始进度为0
            _hi_Chip = new Class.Hardware_Info();       //初始化硬件信息
            DateTime dt_start = DateTime.Now;           //开始时间
            TimeSpan ts_run;                            //时间差
            Lbx_Msg_DL.Invoke(new Action(() =>
            {                       
                _i_ISP_MODE = Cbx_Go_BL_Way.SelectedIndex;
                Show_DL_Msg("尝试使用方案【" + (_i_ISP_MODE + 1) + "】进入BootLoader");
                Show_DL_Msg(Cbx_Go_BL_Way.Text);
            }));
            ISP_Go_BL_Start();                        //进入BL复位方案
            Show_DL_Msg("正在初始化BootLoader！");
            while (true)
            {
                if (!Sp_DownLoad.IsOpen)//端口关闭 引发异常
                    throw new Exception("串口关闭，请重新连接后重试！");
                i_stat = ISP_Enter_BootLoader();//进入BL
                if (i_stat == 0 || i_stat == 1)//接受到回执
                {
                    i_stat = ISP_Get_Command();//获取BL Version
                    if (i_stat == 0)
                    {
                        i_stat = ISP_Get_PID();//获取PID
                        if (i_stat == 0)
                        {
                            //芯片的序列号 FLASH大小不一定能读取出来 有的芯片具有读保护 将无法读出
                            byte[] _b_cid = new byte[12];
                            i_stat = ISP_Read_Memery(ref _b_cid, new byte[] { 0x1F, 0xFF, 0xF7, 0xE8 }, 12);
                            if (i_stat == 0)
                            {
                                for (int j = 0; j < 12; j++)
                                    _hi_Chip.Chip_ID += _b_cid[j].ToString("X2");
                            }
                            //FLASH大小
                            byte[] _b_flash_size = new byte[4];
                            i_stat = ISP_Read_Memery(ref _b_flash_size, new byte[] { 0x1F, 0xFF, 0xF7, 0xE0 }, 4);
                            if (i_stat == 0)
                            {
                                _hi_Chip.Flash_Size = (_b_flash_size[1] << 8 | _b_flash_size[0]);
                            }

                            //检索芯片信息
                            string _str_sql = string.Format("PID='0x{0}' and BLID='0x{1}'", _hi_Chip.PID, _hi_Chip.Version.Replace(".", ""));
                            DataRow[] dr = _ds_STM32BL.Tables[0].Select(_str_sql);
                            if (dr.Length == 0)//如果通过BL版本号和PID无法找到芯片  则需要退一步 仅查找PID
                            {
                                _str_sql = string.Format("PID='0x{0}'", _hi_Chip.PID);
                                dr = _ds_STM32BL.Tables[0].Select(_str_sql);

                                try//使用try语句 为防止误芯片相关信息
                                {
                                    //用户选项字节 根据获取的芯片信息而定
                                    byte[] _b_option_byte = new byte[16];
                                    i_stat = ISP_Read_Memery(ref _b_option_byte, Cls_Convert.HexString_To_Byte(dr[0][8].ToString()), int.Parse(dr[0][9].ToString()));
                                    if (i_stat == 0)
                                    {
                                        for (int j = 0; j < 16; j++)
                                            _hi_Chip.Option_Byte += _b_option_byte[j].ToString("X2");
                                    }
                                }
                                catch { }
                            }


                            ts_run = DateTime.Now - dt_start;
                            dt_start = DateTime.Now;
                            Show_DL_Msg("成功初始化BootLoader！");
                            Show_DL_Msg("耗时：" + ts_run.Milliseconds + "毫秒");
                            Show_DL_Msg("芯片BootLoader版本号：" + _hi_Chip.Version);
                            Show_DL_Msg("芯片PID：" + _hi_Chip.PID);

                            if (dr.Length != 0)//默认选择第一条记录
                            {
                                Show_DL_Msg("芯片型号：" + dr[0][1].ToString());
                            }
                            else
                            {
                                Show_DL_Msg("芯片型号：无该芯片信息！");
                            }

                            if (_hi_Chip.Chip_ID == null)
                            {
                                Show_DL_Msg("芯片序列号获取失败！");
                                Show_DL_Msg("芯片可能设置了读保护，请解锁后重试！");
                            }
                            else
                                Show_DL_Msg("芯片序列号：" + _hi_Chip.Chip_ID);
                            if (_hi_Chip.Chip_ID == null)
                            {
                                Show_DL_Msg("芯片FLASH容量获取失败！");
                                Show_DL_Msg("芯片可能设置了读保护，请解锁后重试！");
                            }
                            else
                                Show_DL_Msg("芯片FLASH容量：" + _hi_Chip.Flash_Size + "KB");
                            if (_hi_Chip.Option_Byte==null||_hi_Chip.Option_Byte == "")
                            {
                                Show_DL_Msg("用户选项字节获取失败！");
                                Show_DL_Msg("芯片可能设置了读保护，请解锁后重试！");
                            }
                            else
                                Show_DL_Msg("选项字节：" + _hi_Chip.Option_Byte);
                            break;
                        }
                    }
                }
                Thread.Sleep(100);//延时100ms重试
                Show_DL_Msg("初始化BootLoader失败，第" + i_time + "次重试！");
                i_time++;
            }
            //需要判断下载文件大小是否在Flash大小之下
            if (_hi_Chip.Flash_Size != 0&& filesize>_hi_Chip.Flash_Size * 1024 )
                throw new Exception("程序过大，Flash无法存储，请重新选择！");
            Show_Process(5);//进入BL并读取信息 占总进度10%
        }


        /// <summary>
        /// 收尾工作
        /// 判断是否开始运行
        /// 恢复进入BL方案
        /// 关闭串口
        /// </summary>
        /// <param name="i_s">是否下载成功状态</param>
        /// <param name="way">是否需要运行程序</param>
        /// <returns></returns>
        public void ISP_Get_Chip_Base_Info_End(int i_s = 0, int way=1)
        {
            int i_stat = i_s;                             //函数执行状态
            ISP_Go_BL_End();                          //复位方案结束
            //根据条件运行程序
            if (way==1&& i_stat == 0 && Ckbx_DL_After_Dir_Run.Checked)//下载成功且勾选下载后运行
            {
                //运行地址可设置 默认0x08000000
                i_stat = ISP_Go(Cls_Convert.HexString_To_Byte(Tbx_Run_Adress.Text));
                //i_stat = ISP_Go(Cls_Convert.HexString_To_Byte("08000400"));
                if (i_stat == 0)
                {
                    Show_DL_Msg("程序已从 0x" + Tbx_Run_Adress.Text + " 处开始运行...");
                }
                else
                {
                    Show_DL_Msg("程序运行失败！");
                }
            }
            //最后，关闭串口
            if (Sp_DownLoad.IsOpen)
                DL_Serial_Close();
            Show_Process(100);                  //全部任务完成
            Show_DL_Msg("关闭串口！");
        }


        /// <summary>
        /// 下载程序线程
        /// </summary>
        public void th_ISP_Download_Code(object o)
        {
            try
            {
                int i_stat = 0;                             //函数执行状态
                FileInfo _fi = o as FileInfo;               //下载文件信息
                Show_DL_Msg("开始下载文件，文件信息：");
                Show_DL_Msg("文件名称：" + _fi.Name);
                Show_DL_Msg("文件更新时间：" + _fi.LastWriteTime.ToString("yyyy年MM月dd日 hh:mm:ss"));
                Show_DL_Msg("文件字节大小：" + _fi.Length + " 字节");
                BinStruct _bs = ISP_Load_DL_File(_fi);
                if (_bs == null)//文件读取失败
                    throw new Exception("下载文件有误，请选择正确文件后继续！");

                DateTime dt_start = DateTime.Now;           //程序下载开始时间
                TimeSpan ts_run;                            //时间差

                ISP_Get_Chip_Base_Info_Start(_bs.size);//基础设置放在文件信息之后

                //注意： 以下任务执行进度从5%开始  95%结束  也就是占90%
                //全片擦除
                if (Rbtn_Erase_All.Checked)
                {
                    Show_DL_Msg("正在全片擦除！（擦除时间可能较长，请耐心等待。）");
                    i_stat = ISP_Erase_Page(0, null);
                    if (i_stat == 0)
                    {
                        Show_DL_Msg("全片擦除成功！");
                        ts_run = DateTime.Now - dt_start;
                        dt_start = DateTime.Now;
                        Show_DL_Msg("擦除耗时：" + ts_run.Milliseconds + "毫秒");
                    }
                    else
                    {
                        Show_DL_Msg("全片擦除失败，请重试！");
                    }
                }
                else
                {
                    Show_DL_Msg("正在擦除下载扇区！（擦除时间可能较长，请耐心等待。）");
                    //i_stat = ISP_Erase_Page(1, new byte[] { 1 });
                    if (i_stat == 0)
                    {
                        Show_DL_Msg("下载扇区擦除成功！");
                        ts_run = DateTime.Now - dt_start;
                        dt_start = DateTime.Now;
                        Show_DL_Msg("擦除耗时：" + ts_run.Milliseconds + "毫秒");
                    }
                    else
                    {
                        Show_DL_Msg("下载扇区擦除失败，请重试！");
                    }
                }
                Show_Process(10);                   //进度条跳到20%
                
                //下载程序
                Show_DL_Msg("开始下载程序...");
                i_stat = ISP_DownLoade_Code_Bin(_bs);
                switch (i_stat)
                {
                    case 0:
                        if (Ckbx_Check.Checked)
                        {
                            Show_DL_Msg("程序【下载】并【校验】成功！");
                        }
                        else
                        {
                            Show_DL_Msg("程序下载成功！");
                        }
                        ts_run = DateTime.Now - dt_start;
                        Show_DL_Msg("下载耗时：" + ts_run.Milliseconds + "毫秒");
                        break;
                    case 3:
                        Show_DL_Msg("校验失败，程序可能无法运行，请重新下载！");
                        throw new Exception("校验失败，程序可能无法运行，请重新下载！");
                        break;
                    default:
                        Show_DL_Msg("程序下载失败，请重试！");
                        throw new Exception("程序下载失败，请重试！");
                        break;
                }
                //设置芯片读保护
                if (Ckbx_Set_Read_Protect.Checked)
                {
                    Show_DL_Msg("正在设置芯片读保护...");
                    if (ISP_Readout_Protect_CMD() == 0)
                    {
                        Show_DL_Msg("设置读保护成功！");
                    }
                    else
                    {
                        Show_DL_Msg("设置读保护失败！");
                    }
                }
                ISP_Get_Chip_Base_Info_End(i_stat);//收尾函数
                Show_Btm_Msg("下载程序任务执行完成！");
            }
            catch(Exception err)
            {
                Show_DL_Msg("下载失败："+err.Message);
                Show_Btm_Msg("错误，下载程序任务执行失败！",1);
                if (Sp_DownLoad.IsOpen)
                {
                    DL_Serial_Close();
                    Show_DL_Msg("关闭串口！");
                }
                Show_Process(100);
            }
        }

        /// <summary>
        /// 获取芯片信息线程
        /// </summary>
        public void th_ISP_Get_Chip_Info()
        {
            try
            {
                ISP_Get_Chip_Base_Info_Start();
                ISP_Get_Chip_Base_Info_End();//收尾函数
                Show_Btm_Msg("获取芯片信息任务执行完成！");
            }
            catch (Exception err)
            {
                Show_DL_Msg("获取芯片信息失败：" + err.Message);
                Show_Btm_Msg("错误，获取芯片信息任务执行失败！", 1);
                if (Sp_DownLoad.IsOpen)
                {
                    DL_Serial_Close();
                    Show_DL_Msg("关闭串口！");
                }
                Show_Process(100);
            }
        }

        /// <summary>
        /// 擦除芯片线程
        /// </summary>
        public void th_ISP_Erase_Chip()
        {
            try
            {
                int i_stat = 0;                             //函数执行状态
                i_stat = Open_Serial(); //打开串口 打开失败引发异常

                if (i_stat == 1)//串口打开失败
                    throw new Exception("串口打开失败，请检查串口是否被占用！");
                int i_time = 1;                             //执行次数
                Show_Process(0);//进入BL并读取信息  开始进度为0
                _hi_Chip = new Class.Hardware_Info();       //初始化硬件信息
                DateTime dt_start = DateTime.Now;           //开始时间
                TimeSpan ts_run;                            //时间差
                Lbx_Msg_DL.Invoke(new Action(() =>
                {
                    _i_ISP_MODE = Cbx_Go_BL_Way.SelectedIndex;
                    Show_DL_Msg("尝试使用方案【" + (_i_ISP_MODE + 1) + "】进入BootLoader");
                    Show_DL_Msg(Cbx_Go_BL_Way.Text);
                }));
                ISP_Go_BL_Start();                        //进入BL复位方案
                Show_DL_Msg("正在初始化BootLoader！");
                while (true)
                {
                    if (!Sp_DownLoad.IsOpen)//端口关闭 引发异常
                        throw new Exception("串口关闭，请重新连接后重试！");
                    i_stat = ISP_Enter_BootLoader();//进入BL
                    if (i_stat == 0 || i_stat == 1)//接受到回执
                    {
                        i_stat = ISP_Get_Command();//获取BL Version
                        if (i_stat == 0)
                        {
                            i_stat = ISP_Get_PID();//获取PID
                            if (i_stat == 0)
                            {
                                ts_run = DateTime.Now - dt_start;
                                dt_start = DateTime.Now;
                                Show_DL_Msg("成功初始化BootLoader！");
                                Show_DL_Msg("耗时：" + ts_run.Milliseconds + "毫秒");
                                Show_DL_Msg("芯片BootLoader版本号：" + _hi_Chip.Version);
                                Show_DL_Msg("芯片PID：" + _hi_Chip.PID);
                                break;
                            }
                        }
                    }
                    Thread.Sleep(100);//延时100ms重试
                    Show_DL_Msg("初始化BootLoader失败，第" + i_time + "次重试！");
                    i_time++;
                }
                Show_Process(5);//进入BL并读取信息 占总进度10%

                Show_DL_Msg("正在解除芯片写保护...");
                i_stat = ISP_Write_Unprotect_CMD();
                if (i_stat == 0)
                {
                    Show_DL_Msg("解除芯片写保护成功！");
                }
                else
                {
                    Show_DL_Msg("解除芯片写保护失败，请重试！");
                }
                Show_Process(15);
                //芯片写保护测试
                //i_stat = ISP_Write_Protect_CMD(new byte[] { 0,1 });
                //设置写不保护测试  ok
                //i_stat = ISP_Write_Unprotect_CMD();
                //芯片读保护测试   ok
                //i_stat = ISP_Readout_Protect_CMD();
                //设置读不保护测试  ok
                //i_stat = ISP_Readout_Unprotect_CMD();

                Show_DL_Msg("正在解除芯片读保护...");
                i_stat = ISP_Readout_Unprotect_CMD();
                if (i_stat == 0)
                {
                    Show_DL_Msg("解除芯片读保护成功！");
                }
                else
                {
                    Show_DL_Msg("解除芯片读保护失败，请重试！");
                }
                Show_Process(25);
                //注意： 以下任务执行进度从5%开始  95%结束  也就是占90%
                //全片擦除
                Show_DL_Msg("正在全片擦除...（擦除时间可能较长，请耐心等待。）");
                i_stat = ISP_Erase_Page(0, null);
                if (i_stat == 0)
                {
                    Show_DL_Msg("全片擦除成功！");
                    ts_run = DateTime.Now - dt_start;
                    dt_start = DateTime.Now;
                    Show_DL_Msg("擦除耗时：" + ts_run.Milliseconds + "毫秒");
                }
                else
                {
                    Show_DL_Msg("全片擦除失败（解锁读保护会全片擦除），请重试！");
                }

                Show_Process(70);                   //进度条跳到90%


                ISP_Get_Chip_Base_Info_End(i_stat,0);//收尾函数 不需要运行
                Show_Btm_Msg("擦除芯片任务执行完成！");
            }
            catch (Exception err)
            {
                Show_DL_Msg("擦除芯片失败：" + err.Message);
                Show_Btm_Msg("错误，擦除芯片任务执行失败！", 1);
                if (Sp_DownLoad.IsOpen)
                {
                    DL_Serial_Close();
                    Show_DL_Msg("关闭串口！");
                }
                Show_Process(100);
            }
        }




        #endregion

        #region 下载助手 按钮事件
        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DL_Select_File_Click(object sender, EventArgs e)
        {
            if (Tbx_DL_File_Path.Text != "")
            {
                FileInfo _fi = new FileInfo(Tbx_DL_File_Path.Text);
                Ofd_DL_File.InitialDirectory = _fi.DirectoryName;
                Ofd_DL_File.FileName = _fi.Name;
            }
            else
                Ofd_DL_File.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Ofd_DL_File.ShowDialog() == DialogResult.OK)
            {
                Tbx_DL_File_Path.Text = Ofd_DL_File.FileName;
                FileInfo _fi = new FileInfo(Tbx_DL_File_Path.Text);
                if (_fi.Extension.ToUpper() == ".BIN")
                {
                    Tbx_DL_Adress.ReadOnly = false;
                    Tbx_Run_Adress.ReadOnly = false;
                }
                else
                {
                    Tbx_DL_Adress.ReadOnly = true;
                    Tbx_Run_Adress.ReadOnly = true;
                }
            }
        }
        /// <summary>
        /// 下载文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DL_DownLoad_File_Click(object sender, EventArgs e)
        {
            if (Tbx_DL_File_Path.Text == "")
            {
                MessageBox.Show("请选择下载文件后继续！", "提示");
                return;
            }

            if (_th_ISP != null && (_th_ISP.IsAlive || _th_ISP.ThreadState == ThreadState.AbortRequested))
            {
                Show_DL_Msg("正在终止下载，程序将无法运行！");
                _th_ISP.Abort();
                _th_ISP = null;
            }
            else
            {
                //初始化工作
                Lbx_Msg_DL.Items.Clear();
                Pgb_DL_Task_Process.Value = 0;
                Btn_DL_Select_File.Enabled = false;
                Btn_DL_Read_Chip_Info.Enabled = false;
                Btn_DL_Erase_Chip.Enabled = false;
                Gbx_DL_Option.Enabled = false;
                Gbx_Option_Byte.Enabled = false;
                Cbx_DL_Serial_Num.Enabled = false;
                Cbx_DL_BaudRate.Enabled = false;
                Btn_Serial_DL_Fresh.Enabled = false;
                //开启下载线程
                _th_ISP = new Thread(th_ISP_Download_Code)
                {
                    IsBackground = true
                };
                _th_ISP.Start(new FileInfo(Tbx_DL_File_Path.Text));
            }
        }
        /// <summary>
        /// 读芯片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DL_Read_Chip_Info_Click(object sender, EventArgs e)
        {
            if (_th_ISP != null && (_th_ISP.IsAlive || _th_ISP.ThreadState == ThreadState.AbortRequested))
            {
                Show_DL_Msg("正在终止读取芯片信息！");
                _th_ISP.Abort();
                _th_ISP = null;
            }
            else
            {
                //初始化工作
                Lbx_Msg_DL.Items.Clear();
                Pgb_DL_Task_Process.Value = 0;
                Btn_DL_Select_File.Enabled = false;
                Btn_DL_DownLoad_File.Enabled = false;
                Btn_DL_Erase_Chip.Enabled = false;
                Gbx_DL_Option.Enabled = false;
                Gbx_Option_Byte.Enabled = false;
                Cbx_DL_Serial_Num.Enabled = false;
                Cbx_DL_BaudRate.Enabled = false;
                Btn_Serial_DL_Fresh.Enabled = false;
                _th_ISP = new Thread(th_ISP_Get_Chip_Info)
                {
                    IsBackground = true
                };
                _th_ISP.Start();

            }
        }
        /// <summary>
        /// 擦除芯片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DL_Erase_Chip_Click(object sender, EventArgs e)
        {
            if (_th_ISP != null && (_th_ISP.IsAlive || _th_ISP.ThreadState == ThreadState.AbortRequested))
            {
                Show_DL_Msg("正在终止擦除芯片！");
                _th_ISP.Abort();
                _th_ISP = null;
            }
            else
            {
                //初始化工作
                Lbx_Msg_DL.Items.Clear();
                Pgb_DL_Task_Process.Value = 0;
                Btn_DL_Select_File.Enabled = false;
                Btn_DL_DownLoad_File.Enabled = false;
                Btn_DL_Read_Chip_Info.Enabled = false;
                Gbx_DL_Option.Enabled = false;
                Gbx_Option_Byte.Enabled = false;
                Cbx_DL_Serial_Num.Enabled = false;
                Cbx_DL_BaudRate.Enabled = false;
                Btn_Serial_DL_Fresh.Enabled = false;
                _th_ISP = new Thread(th_ISP_Erase_Chip)
                {
                    IsBackground = true
                };
                _th_ISP.Start();
            }
        }

        /// <summary>
        /// 选项字节设置默认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Option_Set_Default_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 调试助手 串口事件

        /// <summary>
        /// 串口接收消息
        /// </summary>
        /// <param name="_msg"></param>
        /// <param name="_offset"></param>
        /// <param name="_count"></param>
        public void Debug_Msg_Show(byte[] _msg,int _offset,int _count)
        {
            //_lb_Debug.AddRange(_msg.ToArray());
            Tbx_Msg_Debug.BeginInvoke(new Action(() =>
            {
                //显示接受计数
                _i_Debug_RX += (_count - _offset);
                Lab_Debug_RX.Text = _i_Debug_RX.ToString();
                if (Ckbx_Debug_Show_Hex.Checked)//十六进制显示
                {
                    foreach (byte _b in _msg)
                    {
                        Tbx_Msg_Debug.AppendText(_b.ToString("X2")+" ");
                    }
                }
                else//字符串显示
                {
                    //Tbx_Msg_Debug.Clear();
                    //Tbx_Msg_Debug.AppendText(Encoding.Default.GetString(_lb_Debug.ToArray()));
                    //Tbx_Msg_Debug.Text = (Encoding.Default.GetString(_lb_Debug.ToArray()));
                    //Tbx_Msg_Debug.SelectionStart = Tbx_Msg_Debug.Text.Length;
                    //Tbx_Msg_Debug.ScrollToCaret();
                    Tbx_Msg_Debug.AppendText(Encoding.Default.GetString(_msg,_offset,_count));
                }
            }));
        }

        /// <summary>
        /// 串口接受事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_Debug_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int N = this.Sp_Debug.BytesToRead;
            Thread.Sleep(1);
            if ( this.Sp_Debug.BytesToRead==N)
            {
                byte[] _b_recv = new byte[N];
                this.Sp_Debug.Read(_b_recv, 0, N);
                //调用消息显示函数显示消息
                Debug_Msg_Show(_b_recv, 0, N);
            }
        }

        private void Sp_Debug_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }
        /// <summary>
        /// 引脚改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sp_Debug_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            switch (e.EventType)
            {
                case SerialPinChange.CtsChanged:
                    Ts_Bottom.BeginInvoke(new Action(()=>
                    {
                        if (Sp_Debug.CtsHolding)
                        {
                            Tlab_CTS_Val.Text = "CTS=1";
                        }
                        else
                        {
                            Tlab_CTS_Val.Text = "CTS=0";
                        }
                    }));
                    break;
                case SerialPinChange.DsrChanged:
                    Ts_Bottom.BeginInvoke(new Action(() =>
                    {
                        if (Sp_Debug.DsrHolding)
                        {
                            Tlab_DSR_Val.Text = "DSR=1";
                        }
                        else
                        {
                            Tlab_DSR_Val.Text = "DSR=0";
                        }
                    }));
                    break;
                case SerialPinChange.CDChanged:
                    Ts_Bottom.BeginInvoke(new Action(() =>
                    {
                        if (Sp_Debug.CDHolding)
                        {
                            Tlab_DCD_Val.Text = "DCD=1";
                        }
                        else
                        {
                            Tlab_DCD_Val.Text = "DCD=0";
                        }
                    }));
                    break;
                case SerialPinChange.Break:
                    break;
                case SerialPinChange.Ring:
                    break;
            }
        }
        /// <summary>
        /// 保存窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Save_Window_Click(object sender, EventArgs e)
        {
            Tbx_Msg_Debug.AppendText(Encoding.Default.GetString(new byte[] { 0x0D,0x0A}));
        }


        #endregion

        #region 调试助手  按钮事件

        /// <summary>
        /// 调试部分打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Open_Serial_Click(object sender, EventArgs e)
        {
            if (Sp_Debug.IsOpen)//串口已经打开  需要关闭串口
            {
                Debug_Serial_Close();
            }
            else//串口未打开  需要打开串口
            {
                try
                {
                    if (Cbx_Debug_Seiral_Num.Text == "")
                    {
                        MessageBox.Show("请选择需要打开的串口后继续！", "提示");
                        return;
                    }
                    if (Cbx_Debug_BaudRate.Text == "")
                    {
                        MessageBox.Show("串口波特率不能为空！", "提示");
                        return;
                    }
                    int _val = int.Parse(Cbx_Debug_BaudRate.Text);
                    if (_val < 1200 || _val > 1843200)
                    {
                        MessageBox.Show("波特率数值范围有误（1200-1843200）！","提示");
                    }
                    //设置端口号
                    Sp_Debug.PortName = Cbx_Debug_Seiral_Num.Text.Split(':')[0];
                    //设置波特率
                    Sp_Debug.BaudRate = int.Parse(Cbx_Debug_BaudRate.Text);
                    //设置停止位
                    switch (Cbx_Debug_StopBit.SelectedIndex)
                    {
                        case 0:
                            Sp_Debug.StopBits = StopBits.None;
                            break;
                        case 1:
                            Sp_Debug.StopBits = StopBits.One;
                            break;
                        case 2:
                            Sp_Debug.StopBits = StopBits.OnePointFive;
                            break;
                        case 3:
                            Sp_Debug.StopBits = StopBits.Two;
                            break;
                    }
                    //设置数据位
                    Sp_Debug.DataBits = int.Parse(CBx_Debug_DataBit.Text);
                    //设置校验位
                    switch (Cbx_Debug_Parity.SelectedIndex)
                    {
                        case 0:
                            Sp_Debug.Parity = Parity.None;
                            break;
                        case 1:
                            Sp_Debug.Parity = Parity.Odd;
                            break;
                        case 2:
                            Sp_Debug.Parity = Parity.Even;
                            break;
                        case 3:
                            Sp_Debug.Parity = Parity.Mark;
                            break;
                        case 4:
                            Sp_Debug.Parity = Parity.Space;
                            break;
                    }
                    //打开串口
                    Debug_Serial_Open();
                }
                catch
                {
                    if (Sp_DownLoad.IsOpen && Sp_DownLoad.PortName == Cbx_Debug_Seiral_Num.Text.Split(':')[0])
                    {
                        MessageBox.Show("调试串口打开失败，串口正在被下载任务占用！", "提示");
                    }
                    else
                    {
                        MessageBox.Show("调试串口打开失败，请检查串口是否被占用！", "提示");
                    }
                    Btn_Debug_Open_Serial.Image = Properties.Resources.used20;
                }
            }
        }

        /// <summary>
        /// 调试部分刷新串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Fresh_Click(object sender, EventArgs e)
        {
            Fresh_Serial(1);
        }
        /// <summary>
        /// 调试助手清除接受
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Clear_Recv_Click(object sender, EventArgs e)
        {
            Tbx_Msg_Debug.Clear();
            _i_Debug_TX = 0;
            Lab_Debug_TX.Text = _i_Debug_TX.ToString();
            _i_Debug_RX = 0;
            Lab_Debug_RX.Text = _i_Debug_RX.ToString();
            Show_Btm_Msg("成功清除接收栏数据！");
        }
        /// <summary>
        /// 调试助手选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Select_File_Click(object sender, EventArgs e)
        {
            if (Tbx_Debug_Send_File_Name.Text != "")
            {
                FileInfo _fi = new FileInfo(Tbx_Debug_Send_File_Name.Text);
                Ofd_Debug_File.InitialDirectory = _fi.DirectoryName;
                Ofd_Debug_File.FileName = _fi.Name;
            }
            else
                Ofd_Debug_File.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Ofd_Debug_File.ShowDialog() == DialogResult.OK)
            {
                Tbx_Debug_Send_File_Name.Text = Ofd_Debug_File.FileName;
            }
        }
        /// <summary>
        /// 调试助手发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Start_Send_File_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 调试助手停止发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Stop_Send_File_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 调试助手清除发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Clear_Send_Click(object sender, EventArgs e)
        {
            //ShowBalloonTip();
            Tbx_Debug_Send_One.Text = "";
            Show_Btm_Msg("已成功清除发送栏数据！");
        }
        /// <summary>
        /// 调试助手发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Send_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_One(Tbx_Debug_Send_One.Text);
        }

        /// <summary>
        /// 调试串口通用单条发送函数
        /// </summary>
        /// <param name="_str"></param>
        public void Debug_Com_Send_One(string _str)
        {
            try
            {
                if (Sp_Debug.IsOpen)
                {
                    if (_str != "")
                    {
                        if (Ckbx_Debug_Send_Hex.Checked)//发送十六进制
                        {
                            Debug_Serial_Write(Cls_Convert.HexString_To_Byte(_str));
                        }
                        else
                        {
                            Debug_Serial_Write(_str);
                        }
                    }
                    if (Ckbx_Debug_Send_NewLine.Checked)//发送新行
                        Debug_Serial_Write("\r\n");
                }
                else
                {
                    MessageBox.Show("串口未打开，请打开串口后继续！");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"提示");
            }
        }

        /// <summary>
        /// 调试串口通用多条发送函数
        /// </summary>
        /// <param name="_str"></param>
        public void Debug_Com_Send_M(string _str)
        {
            try
            {
                if (Sp_Debug.IsOpen)
                {
                    if (_str != "")
                    {
                        if (Ckbx_Debug_M_Send_Hex.Checked)//发送十六进制
                        {
                            Debug_Serial_Write(Cls_Convert.HexString_To_Byte(_str));
                        }
                        else
                        {
                            Debug_Serial_Write(_str);
                        }
                    }
                    if (Ckbx_Debug_M_Send_NewLine.Checked)//发送新行
                        Debug_Serial_Write("\r\n");
                }
                else
                {
                    MessageBox.Show("串口未打开，请打开串口后继续！");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "提示");
            }
        }

        /// <summary>
        /// 调试助手DTR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_DTR_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_DTR.Checked)
                Sp_Debug.DtrEnable = true;
            else
                Sp_Debug.DtrEnable = false;
        }
        /// <summary>
        /// 调试助手RTS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_RTS_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_RTS.Checked)
                Sp_Debug.RtsEnable = true;
            else
                Sp_Debug.RtsEnable = false;
        }

        /// <summary>
        /// 十六进制显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_Show_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_Show_Hex.Checked)//字符串转换为十六进制字符串
            {
                Tbx_Msg_Debug.Text = Cls_Convert.String_To_Hex_String(Tbx_Msg_Debug.Text);
            }
            else//十六进制字符串转为字符串
            {
                Tbx_Msg_Debug.Text = Cls_Convert.HexString_To_String(Tbx_Msg_Debug.Text);
            }
            this.Tbx_Msg_Debug.Focus();//获取焦点
            this.Tbx_Msg_Debug.Select(this.Tbx_Msg_Debug.TextLength, 0);//光标定位到文本最后
            this.Tbx_Msg_Debug.ScrollToCaret();//滚动到光标处

        }

        /// <summary>
        /// 定时发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_Send_Ontime_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_Send_Ontime.Checked)
            {
                Tmr_Debug_ReSend.Interval = int.Parse(Tbx_Debug_Resend_Time.Text);
                Tbx_Debug_Resend_Time.Enabled = false;
                Tmr_Debug_ReSend.Start();
            }
            else
            {
                Tmr_Debug_ReSend.Stop();
                Tbx_Debug_Resend_Time.Enabled = true;
            }
        }

        /// <summary>
        /// 定时发送定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Debug_ReSend_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Tbx_Debug_Send_One.Text != "")
                {
                    if (Ckbx_Debug_Send_Hex.Checked)//发送十六进制
                    {
                        Debug_Serial_Write(Cls_Convert.HexString_To_Byte(Tbx_Debug_Send_One.Text));
                    }
                    else
                    {
                        Debug_Serial_Write(Tbx_Debug_Send_One.Text);
                    }
                }
                if (Ckbx_Debug_Send_NewLine.Checked)//发送新行
                    Debug_Serial_Write("\r\n");
            }
            catch
            { 
                Tmr_Debug_ReSend.Stop();
                Ckbx_Debug_Send_Ontime.Checked = false;
            }
        }

        /// <summary>
        /// 十六进制发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_Send_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_Send_Hex.Checked)//字符串转换为十六进制字符串
            {
                Tbx_Debug_Send_One.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_Send_One.Text);
                Tbx_Debug_Send_One.KeyPress += KeyPress_Allow_Hex_Space;
            }
            else//十六进制字符串转为字符串
            {
                Tbx_Debug_Send_One.Text = Cls_Convert.HexString_To_String(Tbx_Debug_Send_One.Text);
                Tbx_Debug_Send_One.KeyPress -= KeyPress_Allow_Hex_Space;
            }
        }

        /// <summary>
        /// 显示时间戳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_Show_Time_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_Show_Time.Checked)
            {
                Tbx_Debug_Show_Time.Enabled = true;
            }
            else
            {
                Tbx_Debug_Show_Time.Enabled = false;
            }
        }

        /// <summary>
        /// 多条十六进制发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_M_Send_Hex_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_M_Send_Hex.Checked)
            {
                Tbx_Debug_M0.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M0.Text);
                Tbx_Debug_M1.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M1.Text);
                Tbx_Debug_M2.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M2.Text);
                Tbx_Debug_M3.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M3.Text);
                Tbx_Debug_M4.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M4.Text);
                Tbx_Debug_M5.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M5.Text);
                Tbx_Debug_M6.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M6.Text);
                Tbx_Debug_M7.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M7.Text);
                Tbx_Debug_M8.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M8.Text);
                Tbx_Debug_M9.Text = Cls_Convert.String_To_Hex_String(Tbx_Debug_M9.Text);
                Tbx_Debug_M0.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M1.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M2.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M3.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M4.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M5.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M6.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M7.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M8.KeyPress += KeyPress_Allow_Hex_Space;
                Tbx_Debug_M9.KeyPress += KeyPress_Allow_Hex_Space;
            }
            else
            {
                Tbx_Debug_M0.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M0.Text);
                Tbx_Debug_M1.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M1.Text);
                Tbx_Debug_M2.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M2.Text);
                Tbx_Debug_M3.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M3.Text);
                Tbx_Debug_M4.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M4.Text);
                Tbx_Debug_M5.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M5.Text);
                Tbx_Debug_M6.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M6.Text);
                Tbx_Debug_M7.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M7.Text);
                Tbx_Debug_M8.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M8.Text);
                Tbx_Debug_M9.Text = Cls_Convert.HexString_To_String(Tbx_Debug_M9.Text);
                Tbx_Debug_M0.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M1.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M2.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M3.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M4.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M5.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M6.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M7.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M8.KeyPress -= KeyPress_Allow_Hex_Space;
                Tbx_Debug_M9.KeyPress -= KeyPress_Allow_Hex_Space;
            }
        }
        /// <summary>
        /// 关联数字键盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_M_Con_NumKey_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_M_Con_NumKey.Checked)
            {
                this.KeyPress += Main_KeyPress;
            }
            else
            {
                this.KeyPress -= Main_KeyPress;
            }
        }
        /// <summary>
        /// 重复循环发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ckbx_Debug_M_Resend_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbx_Debug_M_Resend.Checked)
            {
                if (Ckbx_Debug_Send_Ontime.Checked && MessageBox.Show("监测到单条发送正在进行定时发送任务，是否继续？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                Tmr_Debug_Resend_M.Interval = int.Parse(Tbx_Debug_M_Resend_Time.Text);
                Tbx_Debug_M_Resend_Time.Enabled = false;
                _i_Send_M_Site = 0;
                Tmr_Debug_Resend_M.Start();
            }
            else
            {
                Tmr_Debug_Resend_M.Stop();
                Tbx_Debug_M_Resend_Time.Enabled = true;
            }
        }
        /// <summary>
        /// 按键0号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M0_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M0.Text);
        }
        /// <summary>
        /// 按键1号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M1_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M1.Text);
        }
        /// <summary>
        /// 按键2号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M2_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M2.Text);
        }
        /// <summary>
        /// 按键3号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M3_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M3.Text);
        }
        /// <summary>
        /// 按键4号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M4_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M4.Text);
        }
        /// <summary>
        /// 按键5号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M5_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M5.Text);
        }
        /// <summary>
        /// 按键6号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M6_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M6.Text);
        }
        /// <summary>
        /// 按键7号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M7_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M7.Text);
        }
        /// <summary>
        /// 按键8号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M8_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M8.Text);
        }
        /// <summary>
        /// 按键9号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M9_Click(object sender, EventArgs e)
        {
            Debug_Com_Send_M(Tbx_Debug_M9.Text);
        }
        /// <summary>
        /// 添加页码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Add_Click(object sender, EventArgs e)
        {
            if (_ds_Debug_Send.Tables[_s_Debug_Select_Name] != null)//判断对应表是否存在
            {
                //添加10条记录
                for (int i = 0; i < 10; i++)
                {
                    _ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows.Add(false, "");
                }
                //添加成功需要跳转到新页码
                _i_Debug_Select_Page += 1;
                Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
            }
        }
        /// <summary>
        /// 移除页码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Rmv_Click(object sender, EventArgs e)
        {
            if (_ds_Debug_Send.Tables[_s_Debug_Select_Name] != null)//判断对应表是否存在
            {
                if (_ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows.Count < 11)
                {
                    MessageBox.Show("项目页码不能为空！","提示");
                    return;
                }
                if (MessageBox.Show("是否移除当前页码？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                //移除选中10条记录
                for (int i = 9; i >=0; i--)
                {
                    _ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows.RemoveAt((_i_Debug_Select_Page-1)*10+i);
                }
                //添移除成功需要跳转到对应的下一页
                if (_i_Debug_Select_Page > _i_Debug_Select_Page_All)
                    _i_Debug_Select_Page = _i_Debug_Select_Page_All;
                else
                    _i_Debug_Select_Page -= 1;
                Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
            }
        }
        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_First_Click(object sender, EventArgs e)
        {
            _i_Debug_Select_Page = 1;
            Debug_Send_Prj_Go(_s_Debug_Select_Name,_i_Debug_Select_Page);
        }
        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Pre_Click(object sender, EventArgs e)
        {
            _i_Debug_Select_Page -= 1;
            if (_i_Debug_Select_Page < 1)
                _i_Debug_Select_Page = 1;
            Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
        }
        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Next_Click(object sender, EventArgs e)
        {
            _i_Debug_Select_Page += 1;
            if (_i_Debug_Select_Page > _i_Debug_Select_Page_All)
                _i_Debug_Select_Page =_i_Debug_Select_Page_All;
            Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
        }
        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Last_Click(object sender, EventArgs e)
        {
            _i_Debug_Select_Page = _i_Debug_Select_Page_All;
            Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
        }
        /// <summary>
        /// 跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Go_Page_Click(object sender, EventArgs e)
        {
            if (Tbx_Debug_M_Go_Page.Text == "")
            {
                Tbx_Debug_M_Go_Page.Text = "1";
                MessageBox.Show("页码不能为空！", "提示");
            }
            else if (int.Parse(Tbx_Debug_M_Go_Page.Text) < 1 || int.Parse(Tbx_Debug_M_Go_Page.Text) > _i_Debug_Select_Page_All)
            {
                Tbx_Debug_M_Go_Page.Text = "1";
                MessageBox.Show("输入页码不正确，请重新输入！", "提示");
            }
        }
        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_M_Output_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 双击组建切换选中项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbx_Debug_Project_DoubleClick(object sender, EventArgs e)
        {
            if (Lbx_Debug_Project.SelectedItems.Count > 0)
            {
                Tbx_Debug_Project.TextChanged -= Tbx_Debug_Project_TextChanged;
                _s_Debug_Select_Name = Lbx_Debug_Project.SelectedItem.ToString();
                _i_Debug_Select_Page = 1;
                Debug_Send_Prj_Go(_s_Debug_Select_Name, _i_Debug_Select_Page);
                Tbx_Debug_Project.TextChanged += Tbx_Debug_Project_TextChanged;
            }
        }

        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Prj_Add_Click(object sender, EventArgs e)
        {
            Tbx_Debug_Project.TextChanged -=Tbx_Debug_Project_TextChanged;//先去除文本改变事件
            //如果数据集为空  则新建数据集
            if (_ds_Debug_Send == null) _ds_Debug_Send = new DataSet("Debug_Send_M");
            //添加初始项目
            string _default_name = "新建项目";
            for (int i = 1; ; i++)
            {
                if (_ds_Debug_Send.Tables[_default_name + i] == null)
                {
                    _default_name = _default_name + i;
                    break;
                }
            }
            _s_Debug_Select_Name = Tbx_Debug_Project.Text = _default_name;
            _i_Debug_Select_Page = _i_Debug_Select_Page_All = 1;
            //初始化新建项目
            DataTable _dt = new DataTable(_default_name);
            _dt.Columns.Add("col_Check", typeof(bool));
            _dt.Columns.Add("col_Val", typeof(string));
            for (int i = 0; i < 10; i++)
            {
                _dt.Rows.Add(false, "");
            }
            _ds_Debug_Send.Tables.Add(_dt);
            Lbx_Debug_Project.Items.Add(_default_name);
            Lbx_Debug_Project.SelectedItem = _default_name;
            //添加成功需要清空当前信息
            foreach (System.Windows.Forms.Control _con in Tblp_Send_M.Controls)
            {
                if (_con.Name.Contains("Ckbx_Debug_M"))
                {
                    (_con as CheckBox).Checked = false;
                }
                else if (_con.Name.Contains("Tbx_Debug_M"))
                {
                    (_con as TextBox).Text = "";
                }
            }
            Lab_Debug_M_Page.Text = "1/1";

            

            Tbx_Debug_Project.TextChanged += Tbx_Debug_Project_TextChanged;//添加完成后加回来
        }
        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Prj_Rmv_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 保存项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Debug_Prj_Save_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 调试助手多条发送勾选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Debug_Send_M_CheckedChanged(object sender, EventArgs e)
        {
            if (_ds_Debug_Send.Tables[_s_Debug_Select_Name] != null)
            {
                _ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows[(_i_Debug_Select_Page - 1) * 10 + int.Parse((sender as CheckBox).Name.Substring(12))][0]
                   = (sender as CheckBox).Checked;
            }
        }
        /// <summary>
        /// 调试助手多条发送文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Debug_Send_M_TextChange(object sender, EventArgs e)
        {
            if (_ds_Debug_Send.Tables[_s_Debug_Select_Name] != null)
            {
                _ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows[(_i_Debug_Select_Page - 1) * 10 + int.Parse((sender as TextBox).Name.Substring(11))][1]
                = (sender as TextBox).Text;
            }
        }

        /// <summary>
        /// 项目名称更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_Debug_Project_TextChanged(object sender, EventArgs e)
        {
            Tbx_Debug_Project.TextChanged -= Tbx_Debug_Project_TextChanged;
            if (_ds_Debug_Send.Tables[(sender as TextBox).Text] == null && (sender as TextBox).Text != "")//相关项目不存在 文件名不能为空
            {
                _ds_Debug_Send.Tables[_s_Debug_Select_Name].TableName = (sender as TextBox).Text;
                _s_Debug_Select_Name = (sender as TextBox).Text;

                //刷新列表
                Lbx_Debug_Project.Items.Clear();
                foreach (DataTable _dt_ls in _ds_Debug_Send.Tables)
                {
                    Lbx_Debug_Project.Items.Add(_dt_ls.TableName);
                }
            }
            else if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).Text = _s_Debug_Select_Name;
                MessageBox.Show("项目名不能为空！", "提示");
            }
            else //if(_s_Debug_Select_Name!= (sender as TextBox).Text)
            {
                (sender as TextBox).Text = _s_Debug_Select_Name;
                MessageBox.Show("已存在该项目，请重新输入项目名！", "提示");
            }
            Tbx_Debug_Project.TextChanged += Tbx_Debug_Project_TextChanged;
        }

        /// <summary>
        /// 循环发送位置
        /// </summary>
        int _i_Send_M_Site = 0;

        /// <summary>
        /// 多条循环发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Debug_Resend_M_Tick(object sender, EventArgs e)
        {
            try
            {
                string _str_send ="";
                for (int i=0;i<10;i++,_i_Send_M_Site++ )
                {
                    if (_i_Send_M_Site > 9)
                        _i_Send_M_Site = 0;
                    if ((bool)_ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows[(_i_Debug_Select_Page - 1) * 10 + _i_Send_M_Site][0] == true)
                    {
                        _str_send = _ds_Debug_Send.Tables[_s_Debug_Select_Name].Rows[(_i_Debug_Select_Page - 1) * 10 + _i_Send_M_Site][1].ToString();
                        if (_str_send != "")
                        {
                            if (Ckbx_Debug_M_Send_Hex.Checked)//发送十六进制
                            {
                                Debug_Serial_Write(Cls_Convert.HexString_To_Byte(_str_send));
                            }
                            else
                            {
                                Debug_Serial_Write(_str_send);
                            }
                        }
                        if (Ckbx_Debug_M_Send_NewLine.Checked)//发送新行
                            Debug_Serial_Write("\r\n");
                        break;
                    }
                }
                _i_Send_M_Site+=1;
                if (_i_Send_M_Site > 9)
                    _i_Send_M_Site = 0;
            }
            catch
            {
                Tmr_Debug_Resend_M.Stop();
                Ckbx_Debug_M_Resend.Checked = false;
            }
        }

        /// <summary>
        /// 切换项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsBtn_Send_Prj_Swch_Click(object sender, EventArgs e)
        {
            Lbx_Debug_Project_DoubleClick(null,null);
        }
        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsBtn_Send_Prj_Add_Click(object sender, EventArgs e)
        {
            Btn_Debug_Prj_Add_Click(null,null);
        }
        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsBtn_Send_Prj_Del_Click(object sender, EventArgs e)
        {
            if (Lbx_Debug_Project.Items.Count == 1)
            {
                MessageBox.Show("无法删除，系统中必须存在一个项目！","提示");
                return;
            }
            if (Lbx_Debug_Project.SelectedItems.Count > 0&&MessageBox.Show("是否删除选中项目信息？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                int _i_index = Lbx_Debug_Project.SelectedIndex;
                _ds_Debug_Send.Tables.Remove(Lbx_Debug_Project.SelectedItem.ToString());
                Lbx_Debug_Project.Items.Remove(Lbx_Debug_Project.SelectedItem);
                if (_i_index > Lbx_Debug_Project.Items.Count-1)
                    _i_index = Lbx_Debug_Project.Items.Count-1;
                Lbx_Debug_Project.SelectedIndex = _i_index;
                Lbx_Debug_Project_DoubleClick(null,null);
            }
        }

        #endregion

        #region 底部按钮
        /// <summary>
        /// 保存窗体参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Save_Window_Para_Click(object sender, EventArgs e)
        {
            Save_Config();
            Properties.Settings.Default.Reload();
            Show_Btm_Msg("窗体参数保存成功！");
        }
        /// <summary>
        /// 窗体参数恢复默认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Reset_Window_Para_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否恢复软件至初始状态？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Load_Config();
            }
        }
        /// <summary>
        /// 界面设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_HMI_Set_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Help_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsbtn_Bottom_Calc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Calc");
            }
            catch { }
        }
        /// <summary>
        /// 记事本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsbtn_Bottom_Note_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Notepad");
            }
            catch { }
        }
        /// <summary>
        /// 底部消息栏刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Btm_Msg_Tick(object sender, EventArgs e)
        {
            Tmr_Btm_Msg.Stop();
            Tc_Main_SelectedIndexChanged(null, null);
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// 检查更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Check_Update_Click(object sender, EventArgs e)
        {
            Show_Btm_Msg("正在后台运行【检查更新】任务！");
            Check_Update(); 
        }
        /// <summary>
        /// 启动时检查更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Start_Check_Update_Click(object sender, EventArgs e)
        {
            if (TsBtn_Start_Check_Update.Checked)
            {
                TsBtn_Start_Check_Update.Checked = false;
                Show_Btm_Msg("已关闭【启动时检查更新】！");
            }
            else
            {
                TsBtn_Start_Check_Update.Checked=true;
                Show_Btm_Msg("已开启【启动时检查更新】！");
            }

            Properties.Settings.Default.Start_Check_Update = TsBtn_Start_Check_Update.Checked;//是否开启启动时检查更新

            //保存设置
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_About_Click(object sender, EventArgs e)
        {
            Forms.Frm_Version_Info _fvi = new Forms.Frm_Version_Info();
            _fvi.ShowDialog();
        }
        /// <summary>
        /// 反馈
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_FeedBack_Click(object sender, EventArgs e)
        {
            Forms.Frm_FeedBack _fb = new Forms.Frm_FeedBack();
            _fb.ShowDialog();
        }
        #endregion

        
    }

}
