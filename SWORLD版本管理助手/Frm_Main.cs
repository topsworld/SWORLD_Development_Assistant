using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD版本管理助手
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }
        // SFTP实例化
        Classs.SFTPHelper _sftp ;
        // 默认本地缓存路径
        string _localCachePath =Path.Combine(Environment.CurrentDirectory, "software");

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Tbx_LocalCachePath.Text = _localCachePath;
        }
        /// <summary>
        /// 加载配置
        /// </summary>
        public void LoadConfig()
        {
            
        }


        #region 服务连接
        /// <summary>
        /// 连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                // 为实例化 或者连接状态为未连接，需要连接。
                if (_sftp == null || !_sftp.Connected)
                {
                    // 判断输入是否正确
                    if (Tbx_HostIP.Text.Trim() == "")
                    {
                        MessageBox.Show("主机地址不能为空！", "提示");
                        return;
                    }
                    if (Tbx_UserName.Text.Trim() == "")
                    {
                        MessageBox.Show("用户名不能为空！", "提示");
                        return;
                    }
                    if (Tbx_PassWord.Text.Trim() == "")
                    {
                        MessageBox.Show("用户密码不能为空！", "提示");
                        return;
                    }
                    if (Tbx_RemotePath.Text.Trim() == "")
                    {
                        MessageBox.Show("路径不能为空！", "提示");
                        return;
                    }
                    // 实例化
                    _sftp = new Classs.SFTPHelper(Tbx_HostIP.Text
                        , Tbx_UserName.Text, Tbx_PassWord.Text
                        , int.Parse(Tbx_HostPort.Text), Tbx_RemotePath.Text);
                    if (_sftp.Connect())
                    {
                        // 连接成功
                        Lab_Status.Text = "已连接";
                        Lab_Status.ForeColor = Color.DarkGreen;
                        Btn_Connect.Text = "断开";
                        Tbx_HostIP.Enabled = false;
                        Tbx_HostPort.Enabled = false;
                        Tbx_UserName.Enabled = false;
                        Tbx_PassWord.Enabled = false;
                        Tbx_RemotePath.Enabled = false;
                        Gbx_RemoteOperate.Enabled = true;
                    }
                    else
                    {
                        // 连接失败
                        MessageBox.Show("连接失败，请重新确认连接信息！", "提示");
                        Lab_Status.Text = "连接失败";
                    }
                }
                else
                {
                    _sftp.Disconnect();
                    // 需要断开连接
                    Lab_Status.Text = "未连接";
                    Lab_Status.ForeColor = Color.Red;
                    Btn_Connect.Text = "连接";
                    Tbx_HostIP.Enabled = true;
                    Tbx_HostPort.Enabled = true;
                    Tbx_UserName.Enabled = true;
                    Tbx_PassWord.Enabled = true;
                    Tbx_RemotePath.Enabled = true;
                    Gbx_RemoteOperate.Enabled = false;
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message,"提示");
            }
        }

        #endregion

        #region 验证端口号是否输入正确
        /// <summary>
        /// 字符输入校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_HostPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
                //长度限制
                if (Tbx_HostPort.TextLength > 4)
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// 文字改变校验
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_HostPort_TextChanged(object sender, EventArgs e)
        {
            if (Tbx_HostPort.Text.Trim() == "")
            {
                Tbx_HostPort.Text = "22";
                // 设置选中所有
                Tbx_HostPort.Select(0, 2);
                Tbx_HostPort.ScrollToCaret();
            }
            try
            {
                int vls= int.Parse(Tbx_HostPort.Text);
                if (vls > 65535)
                {
                    Tbx_HostPort.Text = "65535";
                    Tbx_HostPort.Select(0, 5);
                    Tbx_HostPort.ScrollToCaret();
                }
            }
            catch 
            {
                Tbx_HostPort.Text = "22";
            }
            
        }
        #endregion

        #region 远程操作
        /// <summary>
        /// 服务配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ServiceConfig_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 拉取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Pull_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 推送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Push_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 软件管理
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SoftwareAdd_Click(object sender, EventArgs e)
        {
            MyForm.SoftwareAdd _sa = new MyForm.SoftwareAdd(null);
            _sa.Show();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SoftwareUpdate_Click(object sender, EventArgs e)
        {
            if (Lbx_Software.SelectedIndex < 0)
                return;
            MyForm.SoftwareAdd _sa = new MyForm.SoftwareAdd((Lbx_Software.SelectedItem as ListViewItem).Tag as MyModel.Software) ;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SoftwareDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 版本管理
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_VersionAdd_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_VersionUpdate_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_VersionDelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 数据管理
        private void Btn_DataAdd_Click(object sender, EventArgs e)
        {

        }

        private void Btn_DataUpdate_Click(object sender, EventArgs e)
        {

        }

        private void Btn_DataDelete_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 路径选择
        /// <summary>
        /// 远程路径选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_RemotePath_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Btn_SelectLocalCachePath_Click(object sender, EventArgs e)
        {
            if (Tbx_LocalCachePath.Text.Trim() == "默认")
            {
                Fbd_LocalCachePath.SelectedPath = Tbx_LocalCachePath.Text;
            }
            else
                Fbd_LocalCachePath.SelectedPath = Tbx_LocalCachePath.Text;
            if (Fbd_LocalCachePath.ShowDialog() == DialogResult.OK)
            {
                Tbx_LocalCachePath.Text = Fbd_LocalCachePath.SelectedPath;
            }
        }

        #endregion

        #region 版本信息
        ///// <summary>
        ///// 读取配置文件
        ///// </summary>
        ///// <returns>配置文件实体</returns>
        //public  List<MyModel.Software> Read_Version_Config()
        //{
        //    try
        //    {
        //        if (!File.Exists(_localCachePath + "/Info.json")) throw new Exception();
        //        //反序列化
        //        string toDes = "";
        //        Version_Config model;
        //        using (StreamReader sr = new StreamReader(Path_Local_Config + "/Firmware/List.json", Encoding.UTF8))
        //        {
        //            toDes = sr.ReadToEnd();
        //        }
        //        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(toDes)))
        //        {
        //            DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(Version_Config));
        //            model = (Version_Config)deseralizer.ReadObject(ms);// //反序列化ReadObject
        //        }
        //        return model;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}

        ///// <summary>
        ///// 写入配置文件
        ///// </summary>
        ///// <param name="_vc"></param>
        ///// <returns>true：写入成功 false：写入失败</returns>
        //public bool Write_Version_Config(Version_Config _vc)
        //{
        //    try
        //    {
        //        //序列化
        //        string str_json = "";
        //        DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Version_Config));
        //        using (MemoryStream msObj = new MemoryStream())
        //        {
        //            //将序列化之后的Json格式数据写入流中
        //            js.WriteObject(msObj, _vc);
        //            msObj.Position = 0;
        //            //从0这个位置开始读取流中的数据
        //            using (StreamReader sr = new StreamReader(msObj, Encoding.UTF8))
        //            {
        //                str_json = sr.ReadToEnd();
        //            }
        //        }
        //        //写入文件流
        //        using (StreamWriter sw = new StreamWriter(Path_Local_Config + "/Firmware/List.json"))
        //        {
        //            sw.WriteLine(str_json);
        //        }
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        #endregion



    }
}
