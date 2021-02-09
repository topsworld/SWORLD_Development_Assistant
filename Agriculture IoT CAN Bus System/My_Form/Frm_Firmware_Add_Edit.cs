using Agriculture_IoT_CAN_Bus_System.My_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agriculture_IoT_CAN_Bus_System.My_Form
{
    public partial class Frm_Firmware_Add_Edit : Form
    {
        Type_Info _ti_Main;
        Program_Version _pv_Main;
        Common_Version _cv_Main;
        Frm_Firmware_Management _ffm_Main;
        public Frm_Firmware_Add_Edit(Type_Info _ti,Program_Version _pv,Common_Version _cv,Frm_Firmware_Management _ffm)
        {
            InitializeComponent();
            _ti_Main = _ti;
            _pv_Main = _pv;
            _cv_Main = _cv;
            _ffm_Main = _ffm;
        }

        private void Frm_Firmware_Add_Edit_Load(object sender, EventArgs e)
        {
            try
            {
                Tbx_Type_Info.Text = _ti_Main.ToString();
                Tbx_Group_Info.Text = _pv_Main.ToString();
                if (_cv_Main != null)
                {
                    Text = "修改版本";
                    Btn_OK.Text = "修改(&U)";
                    Tbx_Version.ReadOnly = true;
                    Tbx_Time.Text = _cv_Main.col_Time;
                    Tbx_Size.Text = _cv_Main.col_Size;
                    Tbx_Version.Text = _cv_Main.col_Version;
                    Tbx_MD5.Text = _cv_Main.MD5;
                    Tbx_SHA1.Text = _cv_Main.SHA1;
                }
                else
                {
                    Tbx_Time.Text = DateTime.Now.ToString("yyyy.MM.dd");
                    if (_ti_Main.type_ID == "F")//引导程序
                    {
                        if (_pv_Main.Info != null)
                        {
                            List<Common_Version> _lcv = _pv_Main.Info.OrderByDescending(a => a.col_Version).ToList();//获取列表
                            if (_lcv.Count > 0)
                            {
                                string[] _strs_ls = _lcv[0].col_Version.Split('.');
                                if (_strs_ls.Length == 2 )
                                {
                                    Tbx_Version.Text = DateTime.Now.ToString(_strs_ls[0]+"." + (int.Parse(_strs_ls[1].Substring(0,1)) + 1).ToString("X1")+"N");
                                }
                                else
                                    Tbx_Version.Text = DateTime.Now.ToString("V1.0N");
                            }
                        }
                        else
                            Tbx_Version.Text = DateTime.Now.ToString("V1.0N");
                    }
                    else
                    {
                        if (_pv_Main.Info != null)
                        {
                            List<Common_Version> _lcv = _pv_Main.Info.OrderByDescending(a => a.col_Version).ToList();//获取列表
                            if (_lcv.Count > 0)
                            {
                                string[] _strs_ls = _lcv[0].col_Version.Split('.');
                                if (_strs_ls.Length == 4 && _lcv[0].col_Version.Substring(0, 10) == DateTime.Now.ToString("Vyy.MM.dd."))
                                {
                                    Tbx_Version.Text = DateTime.Now.ToString("Vyy.MM.dd." + (int.Parse(_strs_ls[3]) + 1).ToString("X2"));
                                }
                                else
                                    Tbx_Version.Text = DateTime.Now.ToString("Vyy.MM.dd.01");
                            }
                        }
                        else
                            Tbx_Version.Text = DateTime.Now.ToString("Vyy.MM.dd.01");
                    }
                }
            }
            catch
            { }
        }

        /// <summary>
        /// 选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Select_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tbx_File_Path.Text != "")
                    Ofd_File.InitialDirectory = Tbx_File_Path.Text;
                if (Ofd_File.ShowDialog() == DialogResult.OK)
                {
                    Tbx_File_Path.Text = Ofd_File.FileName;
                    Tbx_Size.Text = new FileInfo(Tbx_File_Path.Text).Length / 1024 + "KB";
                    Tbx_MD5.Text = My_Class.Cls_Check_ALG.Get_File_MD5(Tbx_File_Path.Text);
                    Tbx_SHA1.Text = My_Class.Cls_Check_ALG.Get_File_SHA1(Tbx_File_Path.Text);
                }

            }
            catch
            {

            }
        }

        /// <summary>
        /// 判断版本是否重复
        /// </summary>
        /// <param name="_version"></param>
        /// <returns></returns>
        public bool Check_Version_Exit(string _version)
        {
            if (_pv_Main.Info != null)
            {
                if (_pv_Main.Info.Where(a => a.col_Version == _version).ToList().Count > 0)
                    return true;
            }
            else
            {
                _pv_Main.Info = new List<Common_Version>();//为空则需要初始化
            }
            return false;
        }

        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (_ti_Main.type_ID != "F")
            {
                if (Tbx_Version.Text == "" || Tbx_Version.Text.Length != 12 || Tbx_Version.Text.Split('.').Length != 4)
                {
                    MessageBox.Show("操作失败，版本号格式有误！", "提示");
                    return;
                }
            }
            else
            {
                if (Tbx_Version.Text == "" || Tbx_Version.Text.Length != 5 || Tbx_Version.Text.Split('.').Length != 2)
                {
                    MessageBox.Show("操作失败，版本号格式有误！", "提示");
                    return;
                }
            }
            //复制文件
            if (Tbx_File_Path.Text.Trim() != "")
            {
                if (_ti_Main.type_ID == "F")//为引导程序
                {
                    if (Tbx_File_Path.Text != Frm_Main.Path_Local_Config + "/Firmware/BootLoader/" + Tbx_Version.Text + ".hex")
                        File.Copy(Tbx_File_Path.Text,
                            Frm_Main.Path_Local_Config + "/Firmware/BootLoader/" + Tbx_Version.Text + ".hex", true);
                    else
                        MessageBox.Show("操作失败，版本文件路径一致","提示");
                }
                else
                {
                    Directory.CreateDirectory(Frm_Main.Path_Local_Config + "/Firmware/Program/" + _pv_Main.group_Name);//创建对应目录
                    if(Tbx_File_Path.Text!=Frm_Main.Path_Local_Config + "/Firmware/Program/" + _pv_Main.group_Name + "/" + Tbx_Version.Text + ".hex")
                        File.Copy(Tbx_File_Path.Text,
                            Frm_Main.Path_Local_Config + "/Firmware/Program/" + _pv_Main.group_Name + "/" + Tbx_Version.Text + ".hex", true);
                    else
                        MessageBox.Show("操作失败，版本文件路径一致", "提示");
                }
            }
            Common_Version _cv_ls = new Common_Version();
            if (_cv_Main == null)//Add
            {
                //判断对应信息是否重复
                if (Check_Version_Exit(Tbx_Version.Text))
                {
                    MessageBox.Show("对应版本号已存在，请更换后继续！", "提示");
                    return;
                }
                _cv_ls.col_Time = Tbx_Time.Text;
                _cv_ls.col_Size = Tbx_Size.Text;
                _cv_ls.col_Version = Tbx_Version.Text;
                _cv_ls.MD5 = Tbx_MD5.Text;
                _cv_ls.SHA1 = Tbx_SHA1.Text;
                _pv_Main.Info.Add(_cv_ls);
            }
            else//Update
            {
                _cv_Main.col_Time = Tbx_Time.Text;
                _cv_Main.col_Size = Tbx_Size.Text;
                _cv_Main.col_Version = Tbx_Version.Text;
                _cv_Main.MD5 = Tbx_MD5.Text;
                _cv_Main.SHA1 = Tbx_SHA1.Text;
            }
            //保存固件配置
            if (!Frm_Main.Write_Version_Config(Frm_Main._vc_Main))
            {
                MessageBox.Show("保存配置出错！", "错误"); ;
            }
            else
            {
                if (_cv_Main == null)//Add
                {
                    _ffm_Main.Lv_Add_Update_Version(_cv_ls);
                }
                else//Update
                {
                    _ffm_Main.Lv_Add_Update_Version(_cv_Main, 1);
                }
            }
            Close();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
