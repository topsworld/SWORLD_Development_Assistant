using Agriculture_IoT_CAN_Bus_System.My_Class;
using Agriculture_IoT_CAN_Bus_System.My_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Agriculture_IoT_CAN_Bus_System
{
    public partial class Frm_Main : Form
    {
        /// <summary>
        /// 下载线程
        /// </summary>
        Thread _th_ISP = null;
        /// <summary>
        /// 固件库更新线程
        /// </summary>
        Thread _th_Firmware_Update = null;
        /// <summary>
        /// 用户配置文件路径
        /// </summary>
        public static string Path_Local_Config = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "/" + Properties.Resources.Name;
        /// <summary>
        /// 固件配置文件实体
        /// </summary>
        public static Version_Config _vc_Main;
        /// <summary>
        /// 系统配置文件实体
        /// </summary>
        public static Sys_Config _sc_Main=new Sys_Config();
        /// <summary>
        /// 程序更新线程
        /// </summary>
        Thread Th_Update = null;
        /// <summary>
        /// 用户名
        /// </summary>
        public static string Login_Name="";
        /// <summary>
        /// 用户密码
        /// </summary>
        public static string Login_PWD="";

        public Frm_Main()
        {
            InitializeComponent();
            Load_Config();      //加载软件配置信息
            UsbNotification.RegisterUsbDeviceNotification(this.Handle);//添加串口监听事件
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Soft_Init();
        }


        #region 软件初始化及配置相关
        /// <summary>
        /// 软件初始化
        /// </summary>
        private void Soft_Init()
        {
            Tbx_Time_Show.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");//显示最新时间
            this.Serial_DL_StataChange += new EventHandler(this.Sp_Main_Serial_DL_StataChange);//下载串口状态监视事件
            Fresh_Serial();
        }
        /// <summary>
        /// 加载系统配置参数
        /// </summary>
        private void Load_Config()
        {
            try
            {
                //string path = System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                Text = Properties.Resources.Name + " " + Properties.Resources.Version;//设置名称
                                                                                      //判断固件库是否存在，不存在则导出固件库
                if (!Directory.Exists(Path_Local_Config + "/Firmware"))
                    Cls_UnZip.UnZip_Firmware_File();
                Show_DownLoad_Config();//加载固件下载界面清单
                Show_Firmware_Management_Info();//加载固件管理界面清单
                //加载配置文件
                _sc_Main = Cls_Config_Helper.Read_Sys_Config();
                //获取用户信息
                Login_Name = Cls_Login.DecryptDES(_sc_Main.Login_Name);
                Login_PWD = Cls_Login.DecryptDES( _sc_Main.Login_PWD);
                //判断波特率是否正确
                if (_sc_Main.BaudRate < 0||_sc_Main.BaudRate>13)
                    Cbx_Serial_BaudRate.SelectedIndex = 8;
                else
                    Cbx_Serial_BaudRate.SelectedIndex = _sc_Main.BaudRate;
                Tbx_New_SWBL_SAdress.Text = _sc_Main.BL_DL_Address;
                Tbx_Sys_DL_Adress.Text = _sc_Main.Firmware_DL_Address;
                Tbx_Sys_Run_Adress.Text = _sc_Main.Sys_Run_Address;
                Ckbx_Show_Time.Checked = _sc_Main.Msg_Show_Time;
                Ckbx_Check_DL.Checked = _sc_Main.DL_Check;
                Ckbx_DL_After_Dir_Run.Checked = _sc_Main.DL_Dir_Run;
                TsBtn_Start_Check_Update.Checked = _sc_Main.Start_Check_Update;
                if (_sc_Main.First_Run_Flag)
                {
                    //以下为第一次运行需要执行的代码
                    My_Form.Frm_Version_Info _fvi = new My_Form.Frm_Version_Info();
                    _fvi.ShowDialog();
                }
                //存储配置文件
                Cls_Config_Helper.Write_Sys_Config(_sc_Main);
                if (TsBtn_Start_Check_Update.Checked)//开启检查更新线程
                {
                    Check_Update();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"错误");
            }
        }
        /// <summary>
        /// 存储配置参数
        /// </summary>
        private void Save_Config()
        {
            //修改用户配置
            _sc_Main.Login_Name =Cls_Login.EncryptDES(Login_Name);
            _sc_Main.Login_PWD = Cls_Login.EncryptDES(Login_PWD);
            _sc_Main.BaudRate = Cbx_Serial_BaudRate.SelectedIndex;
            _sc_Main.BL_DL_Address = Tbx_New_SWBL_SAdress.Text;
            _sc_Main.Firmware_DL_Address = Tbx_Sys_DL_Adress.Text;
            _sc_Main.Sys_Run_Address = Tbx_Sys_Run_Adress.Text;
            _sc_Main.Msg_Show_Time = Ckbx_Show_Time.Checked;
            _sc_Main.DL_Check = Ckbx_Check_DL.Checked;
            _sc_Main.DL_Dir_Run = Ckbx_DL_After_Dir_Run.Checked;
            _sc_Main.Start_Check_Update = TsBtn_Start_Check_Update.Checked;
            //存储配置文件
            Cls_Config_Helper.Write_Sys_Config(_sc_Main);
        }
        #endregion

        #region 软件更新
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
                        if (Cls_Update.ExtractResEXE() == 0)//成功抽取更新文件
                        {
                            System.Diagnostics.Process.Start("Update_Soft.exe", "SWorld开发助手（JLAU_IoT专版）/Software " + _lvi[0].Version);//运行更新程序
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
        
        #endregion

        #region 通用函数
        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_th_ISP != null && (_th_ISP.IsAlive || _th_ISP.ThreadState == ThreadState.AbortRequested))
            {
                if (MessageBox.Show("任务正在运行，是否退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                {
                    e.Cancel = true;//取消关闭
                }
            }
            else if (Sp_DL.IsOpen)
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
        #endregion

        #region Tab 固件下载按钮及事件函数
        /// <summary>
        /// 刷新连接串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Serial_Fresh_Click(object sender, EventArgs e)
        {
            Fresh_Serial();
        }
        /// <summary>
        /// 读取系统信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Read_Sys_Info_Click(object sender, EventArgs e)
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
                Lbx_Msg.Items.Clear();
                Pgb_DL_Task_Process.Value = 0;
                Btn_New_SWBL_Download.Enabled = false;
                Btn_DL_Firmware.Enabled = false;
                Btn_DL_All.Enabled = false;
                Gbx_Connect.Enabled = false;
                _th_ISP = new Thread(th_ISP_Get_Chip_Info)
                {
                    IsBackground = true
                };
                _th_ISP.Start();

            }
        }
        /// <summary>
        /// 固件更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbx_New_Firmwares_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清除版本列表
            Cbx_New_Firmware_Version.Items.Clear();
            //判断列表中是否存在固件
            if (Lbx_New_Firmwares.SelectedItems.Count > 0&& (Lbx_New_Firmwares.SelectedItem as Program_Version).Info!=null)
            {
                //判断是否为【数据传输固件】，是，需要置入网信息Enable为true，反之false。
                Gbx_Net_Info.Enabled=((Lbx_New_Firmwares.SelectedItem as Program_Version).type_ID == "0" ? true : false);
                //添加版本列表
                List<Common_Version> _lcv_ls = (Lbx_New_Firmwares.SelectedItem as Program_Version).Info.OrderByDescending(a => a.col_Version).ToList();
                foreach (Common_Version _cv in _lcv_ls)
                {
                    //校验对应版本固件是否存在
                    if (Cls_Check_ALG.Check_File(
                        Path_Local_Config + "/Firmware/Program/" + (Lbx_New_Firmwares.SelectedItem as Program_Version).group_Name + "/" + _cv.col_Version + ".hex"
                        ,_cv))
                    {
                        Cbx_New_Firmware_Version.Items.Add(_cv);
                    }
                }
                //默认选择第一项
                if (Cbx_New_Firmware_Version.Items.Count > 0)
                    Cbx_New_Firmware_Version.SelectedIndex = 0;
                //显示固件名
                Tbx_New_Firmware_Name.Text = (Lbx_New_Firmwares.SelectedItem as Program_Version).group_Sensor;
            }
            else
            {
                Tbx_New_Firmware_Name.Text = "无";
            }
        }
        /// <summary>
        /// 固件版本选择项修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cbx_New_Firmware_Version_SelectedIndexChanged(object sender, EventArgs e)
        {
            //列表是否为空
            if (Cbx_New_Firmware_Version.Items.Count > 0)
            {
                //更新时间及大小显示
                Tbx_New_Firmware_Time.Text = (Cbx_New_Firmware_Version.SelectedItem as Common_Version).col_Time;
                Tbx_New_Firmware_Size.Text = (Cbx_New_Firmware_Version.SelectedItem as Common_Version).col_Size;
            }
            else
            {
                Tbx_New_Firmware_Time.Text = "无";
                Tbx_New_Firmware_Size.Text = "无";
            }
        }
        /// <summary>
        /// 下载固件BL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_New_SWBL_Download_Click(object sender, EventArgs e)
        {
            if (Tbx_Chip_ID.Text == "" || Tbx_Chip_ID.Text == "无" || Tbx_Chip_ID.Text.Length != 24)
            {
                MessageBox.Show("请读取设备信息后继续！", "提示");
                return;
            }

            if (Cbx_New_SWBL_Version.Text == "")
            {
                MessageBox.Show("请选择引导程序版本后继续！", "提示");
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
                Lbx_Msg.Items.Clear();
                Pgb_DL_Task_Process.Value = 0;
                Gbx_Connect.Enabled = false;
                Cbx_New_SWBL_Version.Enabled = false;
                Tbx_New_SWBL_SAdress.Enabled = false;
                Btn_Read_Sys_Info.Enabled = false;
                Btn_DL_Firmware.Enabled = false;
                Btn_DL_All.Enabled = false;
                //开启下载线程
                _th_ISP = new Thread(th_ISP_Download_SWBL)
                {
                    IsBackground = true
                };
                _th_ISP.Start(Cbx_New_SWBL_Version.SelectedItem as Common_Version);
            }
        }
        /// <summary>
        /// 获取固件入网序列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Get_Firmware_NetSerial_Click(object sender, EventArgs e)
        {
            if (Tbx_Chip_ID.Text == "" || Tbx_Chip_ID.Text == "无" || Tbx_Chip_ID.Text.Length != 24)
            {
                MessageBox.Show("请读取设备信息后继续！", "提示");
                return;
            }

            //判断原固件是否存在且是否等同于现选择固件
            if (_fm_Old.Type_ID!=""
                &&_fm_Old.Group_ID != (Lbx_New_Firmwares.SelectedItem as Program_Version).group_ID
                &&MessageBox.Show("原固件类型与新固件类型不一致，是否继续？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.No)
                return;

            if ((Lbx_New_Firmwares.SelectedItem as Program_Version).type_ID == "0")//待烧写固件为无线通讯固件
            {
                //获取入网序列号
                if (_fm_Old.Type_ID == "0")//原固件也为无线通讯固件 直接复制过来
                {
                    Tbx_New_Firmware_NewSerial.Text = Tbx_Old_Firmware_NetSerial.Text;
                }
                else
                {
                    //此处需要重新获取入网序列号
                   
                }
                Show_Btm_Msg("获取入网序列号成功！");
                //_fm_New.Net_Serial = Tbx_New_Firmware_NewSerial.Text;//设置新固件入网序列号信息
            }
            else
            {
                Show_Btm_Msg("仅【无线通讯固件】需要入网序列号！");
            }
            
        }
        /// <summary>
        /// 刷新固件列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Fresh_Firmware_List_Click(object sender, EventArgs e)
        {
            Show_DownLoad_Config();
            Show_Btm_Msg("固件列表已刷新！");
        }
        /// <summary>
        /// 下载固件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DL_Firmware_Click(object sender, EventArgs e)
        {
            if (Tbx_Chip_ID.Text == "" || Tbx_Chip_ID.Text == "无" || Tbx_Chip_ID.Text.Length != 24) 
            {
                MessageBox.Show("请读取设备信息后继续！", "提示");
                return;
            }
            //判断是否选择下载固件
            if (!(Lbx_New_Firmwares.Items.Count > 0
                && Lbx_New_Firmwares.SelectedItems.Count > 0
                && Cbx_New_Firmware_Version.Items.Count > 0
                && Cbx_New_Firmware_Version.SelectedIndex > -1))
            {
                MessageBox.Show("请选择下载固件后继续！","提示");
                return;
            }
            //判断原固件是否存在且是否等同于现选择固件
            if (_fm_Old.Type_ID != null&& _fm_Old.Type_ID != ""
                && _fm_Old.Group_ID != (Lbx_New_Firmwares.SelectedItem as Program_Version).group_ID
                && MessageBox.Show("原固件类型与新固件类型不一致，是否继续？"
                , "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            
            //设置新固件相关信息
            _fm_New = new Firmware
            {
                Type_ID = (Lbx_New_Firmwares.SelectedItem as Program_Version).type_ID,//固件类型编码
                Group_ID = (Lbx_New_Firmwares.SelectedItem as Program_Version).group_ID,//固件名称编码
                Group_Name= (Lbx_New_Firmwares.SelectedItem as Program_Version).group_Name,//分组名称（英文）
                Group_Name_CN = (Lbx_New_Firmwares.SelectedItem as Program_Version).group_Name_CN,//分组名称（中文）
                Version = (Cbx_New_Firmware_Version.SelectedItem as Common_Version).col_Version,//固件版本
                Time = (Cbx_New_Firmware_Version.SelectedItem as Common_Version).col_Time,//固件更新时间
                Size= (Cbx_New_Firmware_Version.SelectedItem as Common_Version).col_Size//固件大小
            };
            //判断入网信息是否正确
            if (_fm_New.Type_ID == "0"
                && (
                //项目编号
                Tbx_Prj_ID.Text == "" ||
                Tbx_Prj_ID.Text == "无" ||
                Tbx_Prj_ID.Text.Length != 8 ||
                //节点类型
                Cbx_Node_Type.SelectedIndex < 0 ||
                //轮询间隔
                Nud_Polling_Time.Value == 0 ||
                //入网序列号
                Tbx_New_Firmware_NewSerial.Text == "" ||
                Tbx_New_Firmware_NewSerial.Text == "无" ||
                Tbx_New_Firmware_NewSerial.Text.Length != 16
                ))
            {
                MessageBox.Show("【数据传输固件】入网信息不能为空或格式有误！", "提示");
                return;
            }
            else
            {
                //配置入网信息
                _fm_New.Net_Serial = Tbx_New_Firmware_NewSerial.Text;//入网序列号
                _fm_New.Prj_ID = Tbx_Prj_ID.Text;//项目ID
                _fm_New.Node_Type = Cbx_Node_Type.Text.Split(':')[0];//节点类型
                _fm_New.Polling_Time = (UInt16)Nud_Polling_Time.Value;//轮询时间
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
                Lbx_Msg.Items.Clear();
                Pgb_DL_Task_Process.Value = 0;
                Gbx_Connect.Enabled = false;
                Btn_Read_Sys_Info.Enabled = false;
                Btn_New_SWBL_Download.Enabled = false;
                Btn_DL_All.Enabled = false;
                Lbx_New_Firmwares.Enabled = false;
                Cbx_New_Firmware_Version.Enabled = false;
                Tbx_New_Firmware_NewSerial.Enabled = false;
                Btn_Get_Firmware_NetSerial.Enabled = false;
                Btn_Fresh_Firmware_List.Enabled = false;
                Tbx_Sys_DL_Adress.Enabled = false;
                Tbx_Sys_Run_Adress.Enabled = false;
                //开启下载线程
                _th_ISP = new Thread(th_ISP_Download_Firmware)
                {
                    IsBackground = true
                };
                _th_ISP.Start(_fm_New);
            }
        }

        /// <summary>
        /// 一键下载固件（包括引导程序以及实际固件）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DL_All_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Tab 固件下载相关函数
        /// <summary>
        /// 显示下载提示字符串消息
        /// </summary>
        /// <param name="_s_msg">字符串消息</param>
        public void Show_DL_Msg(string _s_msg)
        {
            Lbx_Msg.BeginInvoke(new Action(() =>
            {
                if (_s_msg.Contains("次重试") && Lbx_Msg.Items[Lbx_Msg.Items.Count - 1].ToString().Contains("次重试"))
                {
                    Lbx_Msg.Items.RemoveAt(Lbx_Msg.Items.Count - 1);
                    string.Format(Ckbx_Show_Time.Checked ? DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss.fff] {0}\r\n") : "{0}\r\n"
                    , _s_msg);
                }
                Lbx_Msg.Items.Add(string.Format(Ckbx_Show_Time.Checked ? DateTime.Now.ToString("[yyyy-MM-dd hh:mm:ss.fff] {0}\r\n") : "{0}\r\n"
                       , _s_msg));
                Lbx_Msg.SelectedIndex = Lbx_Msg.Items.Count - 1;        //选中最后一项
            }));
        }
        /// <summary>
        /// 重新封装打开下载串口
        /// </summary>
        public void DL_Serial_Open()
        {
            Sp_DL.Open();
            Serial_DL_StataChange?.Invoke(Sp_DL, null);
        }

        /// <summary>
        /// 重新封装关闭下载串口
        /// </summary>
        public void DL_Serial_Close()
        {
            Sp_DL.Close();
            Serial_DL_StataChange?.Invoke(Sp_DL, null);
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
                Sp_DL.Write(data, offset, count);
            }
            catch (Exception err)
            {
                throw new Exception("发送失败，" + err.Message);
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
            Ts_Bottom.Invoke(new Action(() =>
            {
                if (sp.IsOpen)
                {
                    Show_Btm_Msg("连接成功，" + sp.PortName + "，" + sp.BaudRate + "，任务进行中...");
                }
                else
                {
                    Show_Btm_Msg("断开连接！");
                }
            }));
        }
        /// <summary>
        /// 刷新串口并显示
        /// </summary>
        /// <returns></returns>
        public int Fresh_Serial()
        {
            Cbx_Serial_Port.Items.Clear();
            foreach (My_Class.Serial_Info csi in My_Class.Cls_Serial.GetPorts())
            {
                Cbx_Serial_Port.Items.Add(csi.ToString());
            }
            if (Cbx_Serial_Port.Items.Count > 0)
                Cbx_Serial_Port.SelectedIndex = 0;
            return Cbx_Serial_Port.Items.Count;
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
                        //下载串口移除
                        for (int i = 0; i < Cbx_Serial_Port.Items.Count; i++)
                        {
                            if (!Serial_List_Check(_lsi, Cbx_Serial_Port.Items[i].ToString()))
                            {
                                Cbx_Serial_Port.Items.RemoveAt(i);
                            }
                        }
                        break;
                    case UsbNotification.DbtDevicearrival://USB设备添加
                        foreach (Serial_Info _si in Cls_Serial.GetPorts())
                        {
                            if (Cbx_Serial_Port.Items.Contains(_si.ToString()))
                                continue;
                            else
                            {
                                Cbx_Serial_Port.Items.Add(_si.ToString());//添加至下载串口
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

        #endregion

        #region Tab 固件管理相关函数
        /// <summary>
        /// 读取配置文件
        /// </summary>
        /// <returns>配置文件实体</returns>
        public static Version_Config Read_Version_Config()
        {
            try
            {
                if (!File.Exists(Path_Local_Config+"/Firmware/List.json")) throw new Exception();
                //反序列化
                string toDes = "";
                Version_Config model;
                using (StreamReader sr = new StreamReader(Path_Local_Config + "/Firmware/List.json", Encoding.UTF8))
                {
                    toDes = sr.ReadToEnd();
                }
                using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(toDes)))
                {
                    DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(Version_Config));
                    model = (Version_Config)deseralizer.ReadObject(ms);// //反序列化ReadObject
                }
                return model;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="_vc"></param>
        /// <returns>true：写入成功 false：写入失败</returns>
        public static bool Write_Version_Config(Version_Config _vc)
        {
            try
            {
                //序列化
                string str_json = "";
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Version_Config));
                using (MemoryStream msObj = new MemoryStream())
                {
                    //将序列化之后的Json格式数据写入流中
                    js.WriteObject(msObj, _vc);
                    msObj.Position = 0;
                    //从0这个位置开始读取流中的数据
                    using (StreamReader sr = new StreamReader(msObj, Encoding.UTF8))
                    {
                        str_json = sr.ReadToEnd();
                    }
                }
                //写入文件流
                using (StreamWriter sw = new StreamWriter(Path_Local_Config + "/Firmware/List.json"))
                {
                    sw.WriteLine(str_json);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        /// <summary>
        /// 固件下载界面显示固件版本信息
        /// </summary>
        public void Show_DownLoad_Config()
        {
            //获取配置文件
            _vc_Main = Read_Version_Config();
            //初始化控件
            Cbx_New_SWBL_Version.Items.Clear();
            Lbx_New_Firmwares.Items.Clear();
            Cbx_New_Firmware_Version.Items.Clear();
            if (_vc_Main != null)
            {
                //添加SWBL信息至Cbx列表  在添加直线 会判断文件是否存在
                List<Common_Version> _lcv_ls = _vc_Main.BootLoader.Info.OrderByDescending(a=>a.col_Version).ToList();//按照版本降序排序
                foreach (Common_Version _cv in _lcv_ls)
                {
                    if (Cls_Check_ALG.Check_File(Path_Local_Config + "/Firmware/BootLoader/" + _cv.col_Version + ".hex",_cv))
                    {
                        Cbx_New_SWBL_Version.Items.Add(_cv);
                    } 
                }
                if (Cbx_New_SWBL_Version.Items.Count > 0)
                    Cbx_New_SWBL_Version.SelectedIndex = 0;
                //添加固件信息至Lbx和Cbx
                List<Program_Version> _lpv_ls = _vc_Main.Program.OrderBy(a => a.group_ID).ToList();//按照ID升序排序
                foreach (Program_Version _pv in _lpv_ls)
                {
                    Lbx_New_Firmwares.Items.Add(_pv);
                }
                if (Lbx_New_Firmwares.Items.Count > 0)
                    Lbx_New_Firmwares.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 固件管理界面显示固件版本信息
        /// </summary>
        private void Show_Firmware_Management_Info()
        {
            try
            {
                //获取配置文件
                _vc_Main = Read_Version_Config();
                Lv_Firmware_Management.Items.Clear();
                Lv_Firmware_Management.Groups.Clear();
                if (_vc_Main != null)
                {
                    //添加SWBL相关
                    ListViewGroup _lvg_SWBL = new ListViewGroup(_vc_Main.BootLoader.group_Name_CN);
                    _lvg_SWBL.Name = _vc_Main.BootLoader.group_Name;
                    Lv_Firmware_Management.Groups.Add(_lvg_SWBL);
                    List<Common_Version> _lcv_ls = _vc_Main.BootLoader.Info.OrderByDescending(a => a.col_Version).ToList();//按照版本降序排序
                    foreach (Common_Version _cv in _lcv_ls)
                    {
                        ListViewItem _lvi_SWBL = new ListViewItem(_cv.col_Version);
                        List<Type_Info> _lti = _vc_Main.Type_List.Where(a => a.type_ID == _vc_Main.BootLoader.type_ID).ToList();
                        if (_lti.Count > 0)
                            _lvi_SWBL.SubItems.Add(_lti[0].type_Name);
                        else
                            _lvi_SWBL.SubItems.Add("无");
                        _lvi_SWBL.SubItems.Add(_vc_Main.BootLoader.group_ID);
                        _lvi_SWBL.SubItems.Add(_vc_Main.BootLoader.group_Name);
                        _lvi_SWBL.SubItems.Add(_vc_Main.BootLoader.group_Sensor);
                        _lvi_SWBL.SubItems.Add(_cv.col_Size);
                        _lvi_SWBL.SubItems.Add(_cv.col_Time);
                        if (Cls_Check_ALG.Check_File(Path_Local_Config + "/Firmware/BootLoader/" + _cv.col_Version + ".hex",_cv))
                        {
                            _lvi_SWBL.SubItems.Add("已下载");
                        }
                        else
                        {
                            _lvi_SWBL.SubItems.Add("未下载");
                        }
                        _lvi_SWBL.Group = _lvg_SWBL;
                        Lv_Firmware_Management.Items.Add(_lvi_SWBL);
                    }
                    //添加固件相关
                    List<Program_Version> _lpv_ls = _vc_Main.Program.OrderBy(a => a.group_ID).ToList();//按照ID升序排序
                    foreach (Program_Version _pv in _lpv_ls)
                    {
                        ListViewGroup _lvg_Program = new ListViewGroup(_pv.group_Name_CN);
                        _lvg_Program.Name = _pv.group_Name;
                        Lv_Firmware_Management.Groups.Add(_lvg_Program);
                        if (_pv.Info == null) continue;//如果没有版本信息  则继续下一个
                        List<Common_Version> _lcv_Program = _pv.Info.OrderByDescending(a => a.col_Version).ToList();//按照版本降序排序
                        foreach (Common_Version _cv in _lcv_Program)
                        {
                            ListViewItem _lvi_Program = new ListViewItem(_cv.col_Version);
                            List<Type_Info> _lti = _vc_Main.Type_List.Where(a => a.type_ID == _pv.type_ID).ToList();
                            if (_lti.Count > 0)
                                _lvi_Program.SubItems.Add(_lti[0].type_Name);
                            else
                                _lvi_Program.SubItems.Add("无");
                            _lvi_Program.SubItems.Add(_pv.group_ID);
                            _lvi_Program.SubItems.Add(_pv.group_Name);
                            _lvi_Program.SubItems.Add(_pv.group_Sensor);
                            _lvi_Program.SubItems.Add(_cv.col_Size);
                            _lvi_Program.SubItems.Add(_cv.col_Time);
                            if (Cls_Check_ALG.Check_File(Path_Local_Config + "/Firmware/Program/" + _pv.group_Name + "/" + _cv.col_Version + ".hex",_cv))
                            {
                                _lvi_Program.SubItems.Add("已下载");
                            }
                            else
                            {
                                _lvi_Program.SubItems.Add("未下载");
                            }
                            _lvi_Program.Group = _lvg_Program;
                            Lv_Firmware_Management.Items.Add(_lvi_Program);
                        }
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"错误");
            }
        }

        /// <summary>
        /// 固件库更新线程
        /// </summary>
        public void Th_Firmware_Update()
        {
            try
            {
                Show_Btm_Msg("开始更新固件库...");
                //下载列表文件，用于确定下载文件列表
                if (Cls_FTP.FTP_FM_Download_File("/Firmware/List.json") != 0)
                    throw new Exception();
                List<string> _lstr_List_Update = new List<string>();
                //调用委托刷线列表

                //获取配置文件
                _vc_Main = Read_Version_Config();
                this.BeginInvoke(new Action(() =>
                {
                    Lv_Firmware_Management.Items.Clear();
                    Lv_Firmware_Management.Groups.Clear();
                }));
                if (_vc_Main != null)
                {
                    //添加SWBL相关
                    ListViewGroup _lvg_SWBL = new ListViewGroup(_vc_Main.BootLoader.group_Name_CN);
                    _lvg_SWBL.Name = _vc_Main.BootLoader.group_Name;
                    this.BeginInvoke(new Action(() =>
                    {
                        Lv_Firmware_Management.Groups.Add(_lvg_SWBL);
                    }));
                    List<Common_Version> _lcv_ls = _vc_Main.BootLoader.Info.OrderByDescending(a => a.col_Version).ToList();//按照版本降序排序
                    foreach (Common_Version _cv in _lcv_ls)
                    {
                        ListViewItem _lvi_SWBL = new ListViewItem(_cv.col_Version);
                        List<Type_Info> _lti = _vc_Main.Type_List.Where(a => a.type_ID == _vc_Main.BootLoader.type_ID).ToList();
                        if (_lti.Count > 0)
                            _lvi_SWBL.SubItems.Add(_lti[0].type_Name);
                        else
                            _lvi_SWBL.SubItems.Add("无");
                        _lvi_SWBL.SubItems.Add(_vc_Main.BootLoader.group_ID);
                        _lvi_SWBL.SubItems.Add(_vc_Main.BootLoader.group_Name);
                        _lvi_SWBL.SubItems.Add(_vc_Main.BootLoader.group_Sensor);
                        _lvi_SWBL.SubItems.Add(_cv.col_Size);
                        _lvi_SWBL.SubItems.Add(_cv.col_Time);
                        if (Cls_Check_ALG.Check_File(Path_Local_Config + "/Firmware/BootLoader/" + _cv.col_Version + ".hex",_cv))
                        {
                            _lvi_SWBL.SubItems.Add("已下载");
                        }
                        else
                        {
                            _lvi_SWBL.SubItems.Add("未下载");
                            _lstr_List_Update.Add("/Firmware/BootLoader/" + _cv.col_Version + ".hex");
                        }
                        _lvi_SWBL.Group = _lvg_SWBL;
                        this.BeginInvoke(new Action(() =>
                        {
                            Lv_Firmware_Management.Items.Add(_lvi_SWBL);
                        }));
                    }
                    //添加固件相关
                    List<Program_Version> _lpv_ls = _vc_Main.Program.OrderBy(a => a.group_ID).ToList();//按照ID升序排序
                    foreach (Program_Version _pv in _lpv_ls)
                    {
                        //ListViewGroup _lvg_Program = new ListViewGroup(string.Format("{0}（类型编码：{1}）"
                        //    , _pv.group_Name_CN, _pv.type_ID));
                        ListViewGroup _lvg_Program = new ListViewGroup(_pv.group_Name_CN);
                        _lvg_Program.Name = _pv.group_Name;
                        this.BeginInvoke(new Action(() =>
                        {
                            Lv_Firmware_Management.Groups.Add(_lvg_Program);
                        }));
                        List<Common_Version> _lcv_Program = _pv.Info.OrderByDescending(a => a.col_Version).ToList();//按照版本降序排序
                        foreach (Common_Version _cv in _lcv_Program)
                        {
                            ListViewItem _lvi_Program = new ListViewItem(_cv.col_Version);
                            List<Type_Info> _lti = _vc_Main.Type_List.Where(a => a.type_ID == _pv.type_ID).ToList();
                            if (_lti.Count > 0)
                                _lvi_Program.SubItems.Add(_lti[0].type_Name);
                            else
                                _lvi_Program.SubItems.Add("无");
                            _lvi_Program.SubItems.Add(_pv.group_ID);
                            _lvi_Program.SubItems.Add(_pv.group_Name);
                            _lvi_Program.SubItems.Add(_pv.group_Sensor);
                            _lvi_Program.SubItems.Add(_cv.col_Size);
                            _lvi_Program.SubItems.Add(_cv.col_Time);
                            if (Cls_Check_ALG.Check_File(Path_Local_Config + "/Firmware/Program/" + _pv.group_Name + "/" + _cv.col_Version + ".hex",_cv))
                            {
                                _lvi_Program.SubItems.Add("已下载");
                            }
                            else
                            {
                                _lvi_Program.SubItems.Add("未下载");
                                _lstr_List_Update.Add("/Firmware/Program/" + _pv.group_Name + "/" + _cv.col_Version + ".hex");
                            }
                            _lvi_Program.Group = _lvg_Program;
                            this.BeginInvoke(new Action(() =>
                            {
                                Lv_Firmware_Management.Items.Add(_lvi_Program);
                            }));
                        }
                    }
                }
                Show_Btm_Msg(string.Format("固件库列表获取成功，准备更新固件（{0}项待下载）...", _lstr_List_Update.Count));
                Thread.Sleep(500);
                int _timeout = 0;
                for (int i = 0; i < _lstr_List_Update.Count; i++)
                {
                    _timeout = 0;
                    Show_Btm_Msg(string.Format("【{0}/{1}】正在下载：{2}", i, _lstr_List_Update.Count, _lstr_List_Update[i]));
                    while (Cls_FTP.FTP_FM_Download_File(_lstr_List_Update[i]) != 0)
                    {
                        Show_Btm_Msg(string.Format("【{0}/{1}】下载失败，第{2}次重试！", i, _lstr_List_Update.Count, _lstr_List_Update[i],_timeout++));
                        if (_timeout > 5)
                        {
                            throw new Exception();
                        }
                    }
                    //更新列表
                    this.BeginInvoke(new Action(() => {
                        Show_Firmware_Management_Info();
                    }));
                }
                Show_Btm_Msg("固件库更新完成！");
            }
            catch
            {
                Show_Btm_Msg("【错误】更新固件库失败，请重试！",1);
            }
            finally
            {
                //最后调用委托重置线程 
                this.BeginInvoke(new Action(()=> {
                    _th_Firmware_Update = null;
                }));
            }
        }

        /// <summary>
        /// 从服务器更新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Update_From_Server_Click(object sender, EventArgs e)
        {
            if (_th_Firmware_Update != null
                && (_th_Firmware_Update.IsAlive || _th_Firmware_Update.ThreadState == ThreadState.AbortRequested))
            {
                if (MessageBox.Show("更新固件库任务正在进行，是否停止？", "提示"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Show_DL_Msg("正在终止更新固件库任务！");
                    _th_Firmware_Update.Abort();
                    _th_Firmware_Update = null;
                }
            }
            else
            {
                //初始化工作
                _th_Firmware_Update = new Thread(Th_Firmware_Update);
                _th_Firmware_Update.Start();

            }
        }
        /// <summary>
        /// 从本地刷新数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Update_From_Local_Click(object sender, EventArgs e)
        {
            Show_Firmware_Management_Info();//加载固件管理界面清单
            Show_Btm_Msg("固件列表已刷新！");
        }
        /// <summary>
        /// 一致性检查
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Consistency_Check_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// 固件恢复默认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Reset_To_Version_Default_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("该操作将会删除先使用固件库，重置至版本默认，是否继续？", "提示"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (Cls_UnZip.UnZip_Firmware_File() == 0)
                {
                    Show_Btm_Msg("固件库已重置！");
                }
                else
                    Show_Btm_Msg("固件库重置失败！",1);
            }
        }
        /// <summary>
        /// 管理入口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Admin_Access_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.OwnedForms)
                {
                    if (f is My_Form.Frm_Firmware_Management)
                    {
                        f.Activate();
                        return;
                    }
                }
                My_Form.Frm_Firmware_Management _ffm = new My_Form.Frm_Firmware_Management(_vc_Main);
                _ffm.Owner = this;
                _ffm.Show();
            }
            catch (Exception err)
            {
                MessageBox.Show("错误信息：" + err.Message.ToString(), "提示");
            }
        }
        #endregion

        #region Tab 入网序列号相关函数

        #endregion

        #region 硬件程序下载函数
        My_Model.Chip _hi_Chip;//芯片信息
        My_Model.Firmware _fm_Old=new Firmware();//旧固件信息
        My_Model.Firmware _fm_New=new Firmware();//新固件信息
        My_Model.SWBL _swbl_Old=new SWBL();//旧SWorld BootLoader信息
        My_Model.SWBL _swbl_New=new SWBL();//新SWorld BootLoader信息
        const byte ISP_ACK = 0x79;          //成功
        const byte ISP_NACK = 0x1F;         //失败
        const string STR_SERIAL = "www.sworld.ltd";//特定序列
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
                        Sp_DL.PortName = Cbx_Serial_Port.Text.Split(':')[0];                 //设置串口号
                        Sp_DL.BaudRate = int.Parse(Cbx_Serial_BaudRate.Text);     //设置波特率
                        if (Sp_DL.IsOpen)             //如果串口打开，关闭串口
                            DL_Serial_Close();
                        DL_Serial_Open();                                         //打开串口
                    }
                    catch
                    {
                        ///串口打开失败
                        Show_Btm_Msg("下载串口打开失败，请检查串口是否被占用！",1);
                        throw new Exception("下载串口打开失败，请检查串口是否被占用！");
                    }
                    Show_DL_Msg(string.Format("成功打开下载串口：{0}，波特率：{1}", Cbx_Serial_Port.Text.Split(':')[0], Cbx_Serial_BaudRate.Text));
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
                    int len = Sp_DL.BytesToRead;
                    if (len == count)
                    {
                        byte[] _ls = new byte[len];
                        Sp_DL.Read(_ls, 0, len);//读取数据
                        Sp_DL.DiscardInBuffer();//打扫战场
                        return _ls;
                    }
                }
                return null;//超时
            }
            catch (Exception err)
            {
                throw new Exception("从串口读取数据出错，" + err.Message);
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
                _hi_Chip.BL_Version = _b_ls[2].ToString("X2").Insert(1, ".");//获取BL版本号
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
                _hi_Chip.BL_Version = _b_ls[1].ToString("X2").Insert(1, ".");  //获取Version
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
            BinStruct _bs = null;
            if (_s_info.Extension.ToUpper() == ".BIN")//调用bin文件解析函数
            {
                _bs = BinParse.Parse(_s_info);
                //二进制文件下载地址需要用户设置
                _bs.adress = Cls_Convert.HexString_To_Byte(Tbx_Sys_DL_Adress.Text);
            }
            else
            {
                _bs = HexParse.BinParse(_s_info);
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
            int i_stat = 0, i_stat_r = 0;

            byte[] _b_write_one;//每次写入256字节缓冲区
            byte[] _b_read_one;//每次读取256字节缓冲区
            byte[] _b_adress_now = new byte[4];//四字节的下载地址  下载一次更新一次
            //一次写入256字节
            int _i_dl_time = ((int)_bs.size) / 256 + (((int)_bs.size) % 256 == 0 ? 0 : 1);//计算下载次数

            uint _u32 = Convert.ToUInt32(_bs.adress[0] << 24 | _bs.adress[1] << 16 | _bs.adress[2] << 8 | _bs.adress[3]);//地址转换

            for (int i = 0; i < _i_dl_time; i++, _u32 += 256)
            {
                _b_adress_now = (BitConverter.GetBytes(_u32)).Reverse().ToArray();//由于使用自带转换函数后的字节数组为大端模式 所以需要翻转
                _b_write_one = _bs.data.Skip(i * 256).Take(256).ToArray();
                i_stat = ISP_Write_Memery(_b_adress_now, _b_write_one);//写入
                if (Ckbx_Check_DL.Checked)//需要校验
                {
                    _b_read_one = new byte[_b_write_one.Length];
                    i_stat_r = ISP_Read_Memery(ref _b_read_one, _b_adress_now, _b_write_one.Length);
                    if (!Byte_Compare(_b_read_one, _b_write_one))//比较写入和读出是否相等
                    {
                        return 3;
                    }
                }
                Show_Process(i * 85 / _i_dl_time + 10);
                if (i_stat != 0 || i_stat_r != 0)//写以及读失败 表示下载失败
                    break;
            }
            return i_stat;
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
            if (pct > 100) pct = 100;
            if (pct < 0) pct = 0;
            Pgb_DL_Task_Process.BeginInvoke(new Action(() =>
            {
                if (pct == 100)//进度条为100 还原各设置
                { 
                    Gbx_Connect.Enabled = true;
                    Btn_Read_Sys_Info.Enabled = true;
                    Btn_New_SWBL_Download.Enabled = true;
                    Btn_DL_Firmware.Enabled = true;
                    Cbx_New_SWBL_Version.Enabled = true;
                    Tbx_New_SWBL_SAdress.Enabled = true;
                    Lbx_New_Firmwares.Enabled = true;
                    Cbx_New_Firmware_Version.Enabled = true;
                    Tbx_New_Firmware_NewSerial.Enabled = true;
                    Btn_Get_Firmware_NetSerial.Enabled = true;
                    Btn_Fresh_Firmware_List.Enabled = true;
                    Tbx_Sys_DL_Adress.Enabled = true;
                    Tbx_Sys_Run_Adress.Enabled = true;
                    SystemSounds.Beep.Play();//播放提示音
                }
                Pgb_DL_Task_Process.Value = pct;//显示进度
            }));
        }

        /// <summary>
        /// 写入特定序列标识
        /// 大小:14字节
        /// 地址：0x08005000
        /// 序列信息：www.sworld.ltd
        /// </summary>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Special_SerialNum_Tag()
        {
            return ISP_Write_Memery(new byte[] { 0x08, 0x00, 0x50, 0x00 }, Cls_Convert.String_To_Byte(STR_SERIAL));//写入特定序列号
        }

        /// <summary>
        /// 读取特定序列标识
        /// </summary>
        /// <returns>序列字符串</returns>
        private string ISP_Read_Special_SerialNum_Tag()
        {
            byte[] _b_only_serial = new byte[14];
            if (ISP_Read_Memery(ref _b_only_serial, new byte[] { 0x08, 0x00, 0x50, 0x00 }, 14) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_only_serial);
            }
            else
                return null;
        }

        /// <summary>
        /// 写入固件名称
        /// 大小：2字节
        /// 存储地址：0x08005010
        /// 通过对应表获取详细名称
        /// </summary>
        /// <param name="_byte"></param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Firmware_Name(byte[] _byte)
        {
            return ISP_Write_Memery(Firmware.Adress_Name, _byte);
        }
        /// <summary>
        /// 读取固件名称
        /// </summary>
        /// <returns>固件中文名称</returns>
        private string ISP_Read_Firmware_Name()
        {
            byte[] _b_ls = new byte[Firmware.Len_Name];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_Name, Firmware.Len_Name) == 0)
            {
                //从配置文件检索固件名称
                _fm_Old.Group_ID = "0x" + _b_ls[0].ToString("X2") + _b_ls[1].ToString("X2");
                List<Program_Version> _lpv = _vc_Main.Program.Where(a => a.group_ID == (_fm_Old.Group_ID)).ToList();
                if (_lpv.Count == 1)
                {              
                    //选择新固件类型等于原固件类型
                    //foreach(object _o in Lbx_New_Firmwares.Items)
                    //{
                    //    if ((_o as Program_Version).group_ID == _fm_Old.Group_ID)
                    //    {
                    //        Lbx_New_Firmwares.SelectedItem = _o;
                    //    }
                    //}
                    _fm_Old.Type_ID = _lpv[0].type_ID;
                    return _lpv[0].group_Name_CN;
                }
                else
                {
                    _fm_Old.Type_ID = "";
                    return "无";
                }
            }
            else
                return "无";
        }

        /// <summary>
        /// 写入固件入网序列号
        /// 大小：16字节
        /// 存储地址：0x08005020
        /// </summary>
        /// <param name="_data">固件入网序列号</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Firmware_Net_Serial(string _data)
        {
            return ISP_Write_Memery(Firmware.Adress_Net_Serial,Cls_Convert.String_To_Byte(_data));
        }
        /// <summary>
        /// 读取固件入网序列号
        /// </summary>
        /// <returns>序列号字符串</returns>
        private string ISP_Read_Firmware_Net_Serial()
        {
            byte[] _b_ls = new byte[Firmware.Len_Net_Serial];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_Net_Serial, Firmware.Len_Net_Serial) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "无";
        }

        /// <summary>
        /// 写入固件版本号
        /// 大小：12字节
        /// 存储地址：0x08005030
        /// </summary>
        /// <param name="_data">版本字符串</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Firmware_Version(string _data)
        {
            return ISP_Write_Memery(Firmware.Adress_Version, Cls_Convert.String_To_Byte(_data));
        }
        /// <summary>
        /// 读取固件版本号
        /// </summary>
        /// <returns>版本字符串</returns>
        private string ISP_Read_Firmware_Version()
        {
            byte[] _b_ls = new byte[Firmware.Len_Version];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_Version, Firmware.Len_Version) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "无";
        }

        /// <summary>
        /// 写入固件更新时间
        /// 大小：10字节
        /// 存储地址：0x08005040
        /// </summary>
        /// <param name="_data">更新时间字符串 格式：2019.01.01</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Firmware_Time(string _data)
        {
            return ISP_Write_Memery(Firmware.Adress_Time, Cls_Convert.String_To_Byte(_data));
        }
        /// <summary>
        /// 读取固件更新时间
        /// </summary>
        /// <returns>更新时间字符串</returns>
        private string ISP_Read_Firmware_Time()
        {
            byte[] _b_ls = new byte[Firmware.Len_Time];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_Time, Firmware.Len_Time) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "无";
        }

        /// <summary>
        /// 写入项目ID信息
        /// 大小：8字节
        /// 存储地址：0x08005050
        /// </summary>
        /// <param name="_data">项目ID信息 格式：JLAU0001</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Prj_ID(string _data)
        {
            return ISP_Write_Memery(Firmware.Adress_PrjID, Cls_Convert.String_To_Byte(_data));
        }
        /// <summary>
        /// 读取项目ID信息
        /// </summary>
        /// <returns>项目ID字符串</returns>
        private string ISP_Read_Prj_ID()
        {
            byte[] _b_ls = new byte[Firmware.Len_PrjID];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_PrjID, Firmware.Len_PrjID) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "无";
        }

        /// <summary>
        /// 写入节点类型
        /// 大小：2字节
        /// 存储地址：0x0800505A
        /// </summary>
        /// <param name="_data">节点类型 格式：ND、WS</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_Node_Type(string _data)
        {
            return ISP_Write_Memery(Firmware.Adress_NodeType,Cls_Convert.String_To_Byte(_data));
        }

        /// <summary>
        /// 读取节点类型
        /// </summary>
        /// <returns>节点类型</returns>
        private string ISP_Read_Node_Type()
        {
            byte[] _b_ls = new byte[Firmware.Len_NodeType];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_NodeType, Firmware.Len_NodeType) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "";
        }

        /// <summary>
        /// 写入轮询时间
        /// 大小：2字节
        /// </summary>
        /// <param name="_data">单位：s，范围：2-65535</param>
        /// <returns></returns>
        private int ISP_Write_Polling_Time(UInt16 _data)
        {
            return ISP_Write_Memery(Firmware.Adress_PollingTime, new byte[2] {(byte)(_data>>8),(byte)(_data&0x00FF)});
        }

        /// <summary>
        /// 读取轮询时间
        /// </summary>
        /// <returns>轮询时间</returns>
        private UInt16 ISP_Read_Polling_Time()
        {
            byte[] _b_ls = new byte[Firmware.Len_PollingTime];
            if (ISP_Read_Memery(ref _b_ls, Firmware.Adress_PollingTime, Firmware.Len_PollingTime) == 0)
            {
                return (UInt16)((_b_ls[0]<<8)|_b_ls[1]);
            }
            else
                return 2;
        }

        /// <summary>
        /// 写入SWBL版本号
        /// 大小：5字节
        /// 存储地址：0x08005060
        /// </summary>
        /// <param name="_data">版本号字符串</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_SWBL_Version(string _data)
        {
            return ISP_Write_Memery(SWBL.Adress_Version, Cls_Convert.String_To_Byte(_data));
        }
        /// <summary>
        /// 读取SWBL版本号
        /// </summary>
        /// <returns>SWBL版本号字符串</returns>
        private string ISP_Read_SWBL_Version()
        {
            byte[] _b_ls = new byte[SWBL.Len_Version];
            if (ISP_Read_Memery(ref _b_ls, SWBL.Adress_Version, SWBL.Len_Version) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "无";
        }

        /// <summary>
        /// 写入SWBL更新时间
        /// 大小：12字节
        /// 存储地址：0x08005070
        /// </summary>
        /// <param name="_data">更新时间字符串 格式：2019.01.01</param>
        /// <returns>0：成功  1：失败 2：超时</returns>
        private int ISP_Write_SWBL_Time(string _data)
        {
            return ISP_Write_Memery(SWBL.Adress_Time, Cls_Convert.String_To_Byte(_data));
        }
        /// <summary>
        /// 读取SWBL更新时间
        /// </summary>
        /// <returns>更新时间字符串</returns>
        private string ISP_Read_SWBL_Time()
        {
            byte[] _b_ls = new byte[SWBL.Len_Time];
            if (ISP_Read_Memery(ref _b_ls, SWBL.Adress_Time, SWBL.Len_Time) == 0)
            {
                return Cls_Convert.Byte_To_String(_b_ls);
            }
            else
                return "无";
        }

        /// <summary>
        /// 进入BL
        /// 获取硬件基础信息
        /// 为读取芯片信息以及下载文件做铺垫
        /// </summary>
        /// <param name="filesize">下载文件字节大小 默认为0 不需要判断</param>
        /// <returns></returns>
        public void ISP_Get_Chip_Base_Info_Start(double filesize = 0,bool b_flag=true)
        {
            int i_stat = 0;                             //函数执行状态
            i_stat = Open_Serial(); //打开串口 打开失败引发异常

            if (i_stat == 1)//串口打开失败
                throw new Exception("串口打开失败，请检查串口是否被占用！");
            int i_time = 1;                             //执行次数
            Show_Process(0);//进入BL并读取信息  开始进度为0
            _hi_Chip = new Chip();       //初始化硬件信息
            _swbl_Old = new SWBL();
            _fm_Old = new Firmware();
            DateTime dt_start = DateTime.Now;           //开始时间
            TimeSpan ts_run;                            //时间差
            Show_DL_Msg("正在进入BootLoader！");
            ISP_Go_BL_Start();                        //进入BL复位方案
            while (true)
            {
                if (!Sp_DL.IsOpen)//端口关闭 引发异常
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
                            string _str_net_serial = "";//读取的特定序列 www.sworld.ltd
                                                        //芯片的序列号 FLASH大小不一定能读取出来 有的芯片具有读保护 将无法读出
                            byte[] _b_cid = new byte[12];
                            i_stat = ISP_Read_Memery(ref _b_cid, new byte[] { 0x1F, 0xFF, 0xF7, 0xE8 }, 12);
                            if (i_stat == 0)
                            {
                                for (int j = 0; j < 12; j++)
                                    _hi_Chip.ID += _b_cid[j].ToString("X2");
                            }
                            //FLASH大小
                            byte[] _b_flash_size = new byte[4];
                            i_stat = ISP_Read_Memery(ref _b_flash_size, new byte[] { 0x1F, 0xFF, 0xF7, 0xE0 }, 4);
                            if (i_stat == 0)
                            {
                                _hi_Chip.Flash_Size = (_b_flash_size[1] << 8 | _b_flash_size[0]);
                            }
                            if (b_flag)
                            {
                                //用户选项字节 根据获取的芯片信息而定
                                byte[] _b_option_byte = new byte[16];
                                i_stat = ISP_Read_Memery(ref _b_option_byte, Cls_Convert.HexString_To_Byte("1FFFF800"), 16);
                                if (i_stat == 0)
                                {
                                    for (int j = 0; j < 16; j++)
                                        _hi_Chip.Option_Byte += _b_option_byte[j].ToString("X2");
                                }
                                //测试写入信息
                                //i_stat = ISP_Write_Special_SerialNum_Tag(); //特定序列号
                                //i_stat = ISP_Write_Firmware_Name(new byte[] { 0x00, 0x08 });//固件名称
                                //i_stat = ISP_Write_Firmware_Net_Serial("0123456789ABCDEF");//固件入网序列号
                                //i_stat = ISP_Write_Firmware_Version("V19.01.01.00");//固件版本号
                                //i_stat = ISP_Write_Firmware_Time("2019.01.01");//固件更新时间
                                //i_stat = ISP_Write_SWBL_Version("V1.0L");//SWBL版本号
                                //i_stat = ISP_Write_SWBL_Time("2019.01.01");//SWBL更新时间
                                //获取BL固件信息 判断是否存在特定序列
                                _str_net_serial = ISP_Read_Special_SerialNum_Tag();
                                if (_str_net_serial == STR_SERIAL)
                                {
                                    _swbl_Old.Version = ISP_Read_SWBL_Version();//获取SWBL版本号
                                    _swbl_Old.Time = ISP_Read_SWBL_Time();//获取SWBL更新时间
                                    _fm_Old.Group_Name_CN = ISP_Read_Firmware_Name();//获取固件名称
                                    _fm_Old.Net_Serial =( _fm_Old.Type_ID == "0" ? ISP_Read_Firmware_Net_Serial() : "无");//获取固件入网序列号
                                    _fm_Old.Prj_ID = ISP_Read_Prj_ID();//获取项目ID
                                    _fm_Old.Node_Type = ISP_Read_Node_Type();//获取节点类型
                                    _fm_Old.Polling_Time = ISP_Read_Polling_Time();//获取轮询时间
                                    _fm_Old.Version = ISP_Read_Firmware_Version();//获取固件版本号
                                    _fm_Old.Time = ISP_Read_Firmware_Time();//获取固件更新时间
                                }
                            }

                            ts_run = DateTime.Now - dt_start;
                            dt_start = DateTime.Now;
                            Show_DL_Msg("成功进入BootLoader！");
                            Show_DL_Msg("耗时：" + ts_run.Milliseconds + "毫秒");
                            Show_DL_Msg("芯片BootLoader版本号：" + _hi_Chip.BL_Version);
                            Show_DL_Msg("芯片PID：" + _hi_Chip.PID);
                            //芯片相关信息显示
                            if (_hi_Chip.ID == null)
                            {
                                Show_DL_Msg("芯片序列号获取失败！");
                                Show_DL_Msg("芯片可能设置了读保护，请解锁后重试！");
                            }
                            else
                                Show_DL_Msg("芯片序列号：" + _hi_Chip.ID);
                            if (_hi_Chip.Flash_Size < 0)
                            {
                                Show_DL_Msg("芯片FLASH容量获取失败！");
                                Show_DL_Msg("芯片可能设置了读保护，请解锁后重试！");
                            }
                            else
                                Show_DL_Msg("芯片FLASH容量：" + _hi_Chip.Flash_Size + "KB");
                            if (b_flag)
                            {
                                if (_hi_Chip.Option_Byte == null || _hi_Chip.Option_Byte == "")
                                {
                                    Show_DL_Msg("用户选项字节获取失败！");
                                    Show_DL_Msg("芯片可能设置了读保护，请解锁后重试！");
                                }
                                else
                                    Show_DL_Msg("选项字节：" + _hi_Chip.Option_Byte);
                                //SWBL版本号
                                if (_swbl_Old.Version != null)
                                {
                                    Show_DL_Msg("SWBL版本号：" + _swbl_Old.Version);
                                }
                                //SWBL更新时间
                                if (_swbl_Old.Time != null)
                                {
                                    Show_DL_Msg("SWBL更新时间：" + _swbl_Old.Time);
                                }
                                //固件名称，根据固件类型编码获取
                                if (_fm_Old.Group_Name_CN != null)
                                {
                                    Show_DL_Msg("固件名称：" + _fm_Old.Group_Name_CN);
                                }
                                //固件入网序列号
                                if (_fm_Old.Net_Serial != null)
                                {
                                    Show_DL_Msg("固件入网序列号：" + _fm_Old.Net_Serial);
                                }
                                //固件版本号
                                if (_fm_Old.Version != null)
                                {
                                    Show_DL_Msg("固件版本号：" + _fm_Old.Version);
                                }
                                //固件更新时间
                                if (_fm_Old.Time != null)
                                {
                                    Show_DL_Msg("固件更新时间：" + _fm_Old.Time);
                                }

                                //显示系统信息至界面
                                Show_Sys_Info(_str_net_serial);
                            }
                            break;
                        }
                    }
                }
                Thread.Sleep(100);//延时100ms重试
                Show_DL_Msg("初始化BootLoader失败，第" + i_time + "次重试！");
                i_time++;
            }
            //需要判断下载文件大小是否在Flash大小之下
            if (_hi_Chip.Flash_Size != 0 && filesize > _hi_Chip.Flash_Size * 1024)
                throw new Exception("程序过大，Flash无法存储，请重新选择！");
            Show_Process(5);//进入BL并读取信息 占总进度10%
        }

        /// <summary>
        /// 显示系统信息
        /// </summary>
        private void Show_Sys_Info(string _str)
        {
            this.BeginInvoke(new Action(()=> {
                //显示片上ID
                Tbx_Chip_ID.Text = _hi_Chip.ID;
                if (_str == STR_SERIAL)
                {
                    if (_swbl_Old.Version != null && _swbl_Old.Version != "" && _swbl_Old.Version.Split('.').Length>1)
                        Tbx_Old_SWBL_Version.Text = _swbl_Old.Version;
                    else
                        Tbx_Old_SWBL_Version.Text = "无";
                    if (_swbl_Old.Time != null && _swbl_Old.Time != "" && _swbl_Old.Time.Split('.').Length > 1)
                        Tbx_Old_SWBL_Time.Text = _swbl_Old.Time;
                    else
                        Tbx_Old_SWBL_Time.Text = "无";
                    if (_fm_Old.Group_Name_CN != null && _fm_Old.Group_Name_CN != "")
                        Tbx_Old_Firmware_Name.Text = _fm_Old.Group_Name_CN;
                    else
                        Tbx_Old_Firmware_Name.Text = "无";
                    if (_fm_Old.Net_Serial != null && _fm_Old.Net_Serial != "")
                        Tbx_Old_Firmware_NetSerial.Text = _fm_Old.Net_Serial;
                    else
                        Tbx_Old_Firmware_NetSerial.Text = "无";
                    if (_fm_Old.Version != null && _fm_Old.Version != "" && _fm_Old.Version.Split('.').Length > 1)
                        Tbx_Old_Firmware_Version.Text = _fm_Old.Version;
                    else
                        Tbx_Old_Firmware_Version.Text = "无";
                    if (_fm_Old.Time != null && _fm_Old.Time != "" && _fm_Old.Time.Split('.').Length > 1)
                        Tbx_Old_Firmware_Time.Text = _fm_Old.Time;
                    else
                        Tbx_Old_Firmware_Time.Text = "无";
                }
                else
                {
                    Tbx_Old_SWBL_Version.Text = "无";
                    Tbx_Old_SWBL_Time.Text = "无";
                    Tbx_Old_Firmware_Name.Text = "无";
                    Tbx_Old_Firmware_NetSerial.Text = "无";
                    Tbx_Old_Firmware_Version.Text = "无";
                    Tbx_Old_Firmware_Time.Text = "无";
                }
            }));
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
        public void ISP_Get_Chip_Base_Info_End(int i_s = 0, int way = 1)
        {
            int i_stat = i_s;                             //函数执行状态
            ISP_Go_BL_End();                          //复位方案结束
            //根据条件运行程序
            if (way == 1 && i_stat == 0 && Ckbx_DL_After_Dir_Run.Checked)//下载成功且勾选下载后运行
            {
                //运行地址可设置 默认0x08000000
                i_stat = ISP_Go(Cls_Convert.HexString_To_Byte(Tbx_Sys_Run_Adress.Text));
                if (i_stat == 0)
                {
                    Show_DL_Msg("程序已从 0x" + Tbx_Sys_Run_Adress.Text + " 处开始运行...");
                }
                else
                {
                    Show_DL_Msg("程序运行失败！");
                }
            }
            //最后，关闭串口
            if (Sp_DL.IsOpen)
                DL_Serial_Close();
            Show_Process(100);                  //全部任务完成
            Show_DL_Msg("关闭串口！");
        }

        /// <summary>
        /// 根据方案进入BootLoader
        /// </summary>
        public void ISP_Go_BL_Start()
        {
            //DTR高电平复位，RTS高电平进入BL
            Sp_DL.RtsEnable = true;
            //Show_DL_Msg("RTS置高，准备进入BootLoader");
            Sp_DL.DtrEnable = true;
            //Show_DL_Msg("DTR置高，开始复位，延时10ms");
            Thread.Sleep(10);
            Sp_DL.DtrEnable = false;
            //Show_DL_Msg("DTR置低，复位完成！");

        }

        /// <summary>
        /// 根据方案结束BootLoader
        /// </summary>
        public void ISP_Go_BL_End()
        {
            //关闭DTR和RTS
            Sp_DL.DtrEnable = false;
            Sp_DL.RtsEnable = false;
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
                _hi_Chip.ID = "无";
                Show_Sys_Info(null);
                Show_DL_Msg("获取芯片信息失败：" + err.Message);
                Show_Btm_Msg("错误，获取芯片信息任务执行失败！", 1);
                if (Sp_DL.IsOpen)
                {
                    DL_Serial_Close();
                    Show_DL_Msg("关闭串口！");
                }
                Show_Process(100);
            }
        }

        /// <summary>
        /// 写入引导程序信息
        /// </summary>
        /// <param name="_swbl">引导程序信息</param>
        /// <returns>0：写入成功 其他：写入失败</returns>
        public int ISP_Write_SWBL_Info(SWBL _swbl)
        {
            return ISP_Write_Special_SerialNum_Tag()+ ISP_Write_SWBL_Version(_swbl.Version) + ISP_Write_SWBL_Time(_swbl.Time);
        }

        /// <summary>
        /// 下载引导程序线程
        /// </summary>
        /// <param name="o">待下载引导版本信息</param>
        public void th_ISP_Download_SWBL(object o)
        {
            try
            {
                int i_stat = 0;                             //函数执行状态
                Common_Version _cv_ls = o as Common_Version;
                Show_Process(0);
                Show_DL_Msg("开始下载SWorld BootLoader引导程序...");
                Show_DL_Msg("版本号：" + _cv_ls.col_Version);
                Show_DL_Msg("程序大小：" + _cv_ls.col_Size);
                Show_DL_Msg("更新时间：" + _cv_ls.col_Time);
                _swbl_New = new SWBL
                {
                    Version = _cv_ls.col_Version,
                    Time = _cv_ls.col_Time
                };
                FileInfo _fi = new FileInfo(Path_Local_Config + "/Firmware/BootLoader/" + _cv_ls.col_Version + ".hex");
                BinStruct _bs = ISP_Load_DL_File(_fi);
                if (_bs == null)//文件读取失败
                    throw new Exception("引导程序文件有误，请选择正确文件后继续！");
                _bs.adress =Cls_Convert.HexString_To_Byte(Tbx_New_SWBL_SAdress.Text);//【注】更换BL下载地址为设置地址
                DateTime dt_start = DateTime.Now;           //程序下载开始时间
                TimeSpan ts_run;                            //时间差

                ISP_Get_Chip_Base_Info_Start(_bs.size,false);//基础设置放在文件信息之后

                //注意： 以下任务执行进度从5%开始  95%结束  也就是占90%
                //全片擦除
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

                Show_Process(10);                   //进度条跳到20%

                //下载程序
                Show_DL_Msg("开始下载引导程序...");
                i_stat = ISP_DownLoade_Code_Bin(_bs);
                switch (i_stat)
                {
                    case 0:
                        if (Ckbx_Check_DL.Checked)
                        {
                            Show_DL_Msg("引导程序【下载】并【校验】成功！");
                        }
                        else
                        {
                            Show_DL_Msg("引导程序下载成功！");
                        }
                        ts_run = DateTime.Now - dt_start;
                        Show_DL_Msg("下载耗时：" + ts_run.Milliseconds + "毫秒");
                        break;
                    case 3:
                        Show_DL_Msg("校验失败，引导程序可能无法运行，请重新下载！");
                        break;
                    default:
                        Show_DL_Msg("引导程序下载失败，请重试！");
                        break;
                }
                if (ISP_Write_SWBL_Info(_swbl_New) == 0)//写入引导程序信息
                {
                    Show_DL_Msg("引导程序信息写入成功！");
                }
                else
                {
                    Show_DL_Msg("引导程序信息写入失败！");
                }
                //重设引导以及清空旧固件信息
                _swbl_Old = _swbl_New;
                _fm_Old = new Firmware();
                Show_Sys_Info(STR_SERIAL);
                ISP_Get_Chip_Base_Info_End(i_stat, 0);//收尾函数  BootLoader下载完成不需要运行
                Show_Btm_Msg("下载引导程序任务执行完成！");
            }
            catch (Exception err)
            {
                _hi_Chip.ID = "无";
                Show_Sys_Info(null);
                Show_DL_Msg("下载失败：" + err.Message);
                Show_Btm_Msg("错误，下载引导程序任务执行失败！", 1);
                if (Sp_DL.IsOpen)
                {
                    DL_Serial_Close();
                    Show_DL_Msg("关闭串口！");
                }
                Show_Process(100);
            }
        }

        /// <summary>
        /// 写入固件信息
        /// </summary>
        /// <param name="_swbl">固件信息</param>
        /// <returns>0：写入成功 其他：写入失败</returns>
        public int ISP_Write_Firmware_Info(Firmware _fm)
        {
            int i_ret = 0;
            i_ret += ISP_Write_Firmware_Name(Cls_Convert.HexString_To_Byte(_fm.Group_ID.Substring(2)));
            if (_fm.Type_ID == "0")//只有为数据传输固件才需要写入入网信息
            {
                i_ret += ISP_Write_Firmware_Net_Serial(_fm.Net_Serial);
                i_ret += ISP_Write_Prj_ID(_fm.Prj_ID);
                i_ret += ISP_Write_Node_Type(_fm.Node_Type);
                i_ret += ISP_Write_Polling_Time(_fm.Polling_Time);
            }
            i_ret += ISP_Write_Firmware_Version(_fm.Version);
            i_ret += ISP_Write_Firmware_Time(_fm.Time);
            return i_ret;
        }

        /// <summary>
        /// 下载固件信息线程
        /// </summary>
        /// <param name="o">待下载固件信息</param>
        public void th_ISP_Download_Firmware(object o)
        {
            try
            {
                int i_stat = 0;                             //函数执行状态
                Firmware _fm_ls = o as Firmware;
                Show_Process(0);
                Show_DL_Msg("开始下载系统固件...");
                Show_DL_Msg("固件名称：" +_fm_ls.Group_Name_CN);
                Show_DL_Msg("版本号：" + _fm_ls.Version);
                Show_DL_Msg("程序大小：" + _fm_ls.Size);
                Show_DL_Msg("更新时间：" + _fm_ls.Time);
                
                FileInfo _fi = new FileInfo(Path_Local_Config + "/Firmware/Program/" + _fm_ls.Group_Name+"/" + _fm_ls.Version + ".hex");
                BinStruct _bs = ISP_Load_DL_File(_fi);
                if (_bs == null)//文件读取失败
                    throw new Exception("固件文件有误，请选择正确文件后继续！");
                _bs.adress = Cls_Convert.HexString_To_Byte(Tbx_Sys_DL_Adress.Text);//【注】更换固件下载地址为设置地址
                DateTime dt_start = DateTime.Now;           //程序下载开始时间
                TimeSpan ts_run;                            //时间差

                ISP_Get_Chip_Base_Info_Start(_bs.size, false);//获取基础设置放在文件信息之后

                //注意： 以下任务执行进度从5%开始  95%结束  也就是占90%
                //全片擦除  之后需要更改只擦除指定区域
                //***********************

                Show_Process(10);                   //进度条跳到10%

                //下载程序
                Show_DL_Msg("开始下载固件...");
                i_stat = ISP_DownLoade_Code_Bin(_bs);
                switch (i_stat)
                {
                    case 0:
                        if (Ckbx_Check_DL.Checked)
                        {
                            Show_DL_Msg("固件【下载】并【校验】成功！");
                        }
                        else
                        {
                            Show_DL_Msg("固件下载成功！");
                        }
                        ts_run = DateTime.Now - dt_start;
                        Show_DL_Msg("下载耗时：" + ts_run.Milliseconds + "毫秒");
                        break;
                    case 3:
                        Show_DL_Msg("校验失败，固件可能无法运行，请重新下载！");
                        throw new Exception("校验失败，固件可能无法运行，请重新下载！");
                    default:
                        Show_DL_Msg("固件下载失败，请重试！");
                        throw new Exception("固件下载失败，请重试！");
                }
                if (i_stat == 0)
                {
                    if (ISP_Write_Firmware_Info(_fm_ls) == 0)//写入引导程序信息
                    {
                        Show_DL_Msg("固件信息写入成功！");
                    }
                    else
                    {
                        Show_DL_Msg("固件息写入失败！");
                    }
                }
                //刷新固件信息为最新
                _swbl_Old = _swbl_New;
                _fm_Old = _fm_New;
                Show_Sys_Info(STR_SERIAL);
                ISP_Get_Chip_Base_Info_End(i_stat);//收尾函数  BootLoader下载完成不需要运行
                Show_Btm_Msg("下载固件任务执行完成！");
            }
            catch (Exception err)
            {
                _hi_Chip.ID = "无";
                Show_Sys_Info(null);
                Show_DL_Msg("下载失败：" + err.Message);
                Show_Btm_Msg("错误，下载固件任务执行失败！", 1);
                if (Sp_DL.IsOpen)
                {
                    DL_Serial_Close();
                    Show_DL_Msg("关闭串口！");
                }
                Show_Process(100);
            }
        }
        #endregion

        #region 底部按钮事件函数
        /// <summary>
        /// 计算器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Bottom_Calc_Click(object sender, EventArgs e)
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
        private void TsBtn_Bottom_Note_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Notepad");
            }
            catch { }
        }
        /// <summary>
        /// 保存窗体参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Save_Window_Para_Click(object sender, EventArgs e)
        {
            Save_Config();
            Show_Btm_Msg("窗体参数保存成功！");
        }
        /// <summary>
        /// 恢复默认设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Reset_Window_Para_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否恢复软件至初始状态？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Cls_Config_Helper.Extract_Json_Sys_Config();//重新导出配置文件
                Load_Config();
                Show_Btm_Msg("软件已恢复至默认状态！");
            }
        }
        /// <summary>
        /// 检查更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Check_Update_Click(object sender, EventArgs e)
        {
            Check_Update();
        }
        /// <summary>
        /// 启动时更新
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
                TsBtn_Start_Check_Update.Checked = true;
                Show_Btm_Msg("已开启【启动时检查更新】！");
            }

            _sc_Main.Start_Check_Update = TsBtn_Start_Check_Update.Checked;//是否开启启动时检查更新

            //保存设置
            Cls_Config_Helper.Write_Sys_Config(_sc_Main) ;
        }
        /// <summary>
        /// 反馈
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_FeedBack_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_About_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsBtn_Exit_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 底部消息栏提示函数
        /// <summary>
        /// 底部消息显示  显示时间修改定时器时间即可
        /// </summary>
        /// <param name="_msg"></param>
        public void Show_Btm_Msg(string _msg, int _type = 0)
        {
            Tc_Main.BeginInvoke(new Action(() =>
            {
                Tstbx_Msg_Txt.Text = _msg;
                switch (_type)
                {
                    case 0:
                        Tstbx_Msg_Img.BackgroundImage = Properties.Resources.msg20;
                        break;
                    case 1:
                        Tstbx_Msg_Img.BackgroundImage = Properties.Resources.errmsg20;
                        break;
                }

                Tmr_Btm_Msg.Stop();
                Tmr_Btm_Msg.Start();
            }));
        }
        /// <summary>
        /// 底部消息刷新时钟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Btm_Msg_Tick(object sender, EventArgs e)
        {
            Tmr_Btm_Msg.Stop();
            Tstbx_Msg_Txt.Text = "就绪！";
            Tstbx_Msg_Img.BackgroundImage = Properties.Resources.msg20;
        }

        /// <summary>
        /// 软件时间显示定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tmr_Clock_Tick(object sender, EventArgs e)
        {
            Tbx_Time_Show.Text = DateTime.Now.ToString("yyyy年MM月dd日 hh:mm:ss");//显示最新时间
        }






        #endregion
    }
}
