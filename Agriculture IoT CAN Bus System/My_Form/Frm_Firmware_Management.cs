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
    public partial class Frm_Firmware_Management : Form
    {
        Version_Config _vc_Main;
        public Frm_Firmware_Management(Version_Config _vc)
        {
            InitializeComponent();
            _vc_Main = _vc;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Firmware_Management_Load(object sender, EventArgs e)
        {
            Show_Lv_Type();//显示类型列表
        }

        #region 按钮事件
        /// <summary>
        /// 类型添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Type_Add_Click(object sender, EventArgs e)
        {
            Frm_Type_Add_Edit _fftae = new Frm_Type_Add_Edit(null,this);
            _fftae.ShowDialog();
        }
        /// <summary>
        /// 类型修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Type_Update_Click(object sender, EventArgs e)
        {
            if (Lv_Type.SelectedItems.Count > 0)
            {
                Frm_Type_Add_Edit _fftae = new Frm_Type_Add_Edit(Lv_Type.SelectedItems[0].Tag as Type_Info,this);
                _fftae.ShowDialog();
            }
        }
        /// <summary>
        /// 类型删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Type_Del_Click(object sender, EventArgs e)
        {
            if (Lv_Type.SelectedItems.Count > 0)
            {
                if (Lv_Type.SelectedItems[0].SubItems[1].Text == "F")
                {
                    MessageBox.Show("无法删除引导程序固件！", "提示");
                    return;
                }
                if (Lv_Group.Items.Count > 0)
                {
                    MessageBox.Show("无法删除，该类型下存在固件！","提示");
                    return;
                }
                if (MessageBox.Show("是否删除名称为：【" + Lv_Type.SelectedItems[0].SubItems[2].Text + "】的类型？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _vc_Main.Type_List.Remove(Lv_Type.SelectedItems[0].Tag as Type_Info);
                    Lv_Type.Items.Remove(Lv_Type.SelectedItems[0]);
                    //保存固件配置
                    if (!Frm_Main.Write_Version_Config(Frm_Main._vc_Main))
                    {
                        MessageBox.Show("保存配置出错！", "删除失败"); ;
                    }
                }
            }
            
        }
        /// <summary>
        /// 组添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Group_Add_Click(object sender, EventArgs e)
        {
            if (Lv_Type.SelectedItems.Count ==0)
            {
                MessageBox.Show("请选择类型后继续！","提示");
                return;
            }
            Frm_Group_Add_Edit _fgae = new Frm_Group_Add_Edit(null,this,Lv_Type.SelectedItems[0].Tag as Type_Info);
            _fgae.ShowDialog();
        }
        /// <summary>
        /// 组修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Group_Update_Click(object sender, EventArgs e)
        {
            if (Lv_Type.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择类型后继续！", "提示");
                return;
            }
            if (Lv_Group.SelectedItems.Count > 0)
            {
                Frm_Group_Add_Edit _fgae = new Frm_Group_Add_Edit(Lv_Group.SelectedItems[0].Tag as Program_Version, this, Lv_Type.SelectedItems[0].Tag as Type_Info);
                _fgae.ShowDialog();
            }
        }
        /// <summary>
        /// 组删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Group_Del_Click(object sender, EventArgs e)
        {
            if (Lv_Group.SelectedItems.Count > 0)
            {
                if (Lv_Group.SelectedItems[0].SubItems[1].Text == "0xFFFF")
                {
                    MessageBox.Show("无法删除引导程序固件！","提示");
                    return;
                }
                if (Lv_Version.Items.Count > 0)
                {
                    MessageBox.Show("无法删除，该固件下存在版本！","提示");
                    return;
                }
                if (MessageBox.Show("是否删除名称为：【" + Lv_Group.SelectedItems[0].SubItems[2].Text + "】的固件？", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _vc_Main.Program.Remove(Lv_Group.SelectedItems[0].Tag as Program_Version);
                    Lv_Group.Items.Remove(Lv_Group.SelectedItems[0]);
                    //保存固件配置
                    if (!Frm_Main.Write_Version_Config(Frm_Main._vc_Main))
                    {
                        MessageBox.Show("保存配置出错！", "删除失败"); ;
                    }
                }
            }
        }
        /// <summary>
        /// 版本添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Version_Add_Click(object sender, EventArgs e)
        {
            if (Lv_Type.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择类型后继续！", "提示");
                return;
            }
            if (Lv_Group.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择固件后继续！", "提示");
                return;
            }
            Frm_Firmware_Add_Edit _ffae = new Frm_Firmware_Add_Edit(
                Lv_Type.SelectedItems[0].Tag as Type_Info,
                Lv_Group.SelectedItems[0].Tag as Program_Version,
                null,this);
            _ffae.ShowDialog();
        }
        /// <summary>
        /// 版本修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Version_Update_Click(object sender, EventArgs e)
        {
            if (Lv_Type.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择类型后继续！", "提示");
                return;
            }
            if (Lv_Group.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择固件后继续！", "提示");
                return;
            }
            if (Lv_Version.SelectedItems.Count > 0)
            {
                Frm_Firmware_Add_Edit _ffae = new Frm_Firmware_Add_Edit(
                Lv_Type.SelectedItems[0].Tag as Type_Info,
                Lv_Group.SelectedItems[0].Tag as Program_Version,
                Lv_Version.SelectedItems[0].Tag as Common_Version, this);
                _ffae.ShowDialog();
            }
        }
        /// <summary>
        /// 版本删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Version_Del_Click(object sender, EventArgs e)
        {
            if (Lv_Version.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("是否删除信息为：" +
                    "\r\n名称："+ Lv_Version.SelectedItems[0].SubItems[3].Text +
                    "\r\n版本号：" + Lv_Version.SelectedItems[0].SubItems[1].Text 
                    + "\r\n的固件？", "提示"
                    , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Lv_Type.SelectedItems[0].SubItems[1].Text == "F")
                    {
                        _vc_Main.BootLoader.Info.Remove(Lv_Version.SelectedItems[0].Tag as Common_Version);
                        Lv_Version.Items.Remove(Lv_Version.SelectedItems[0]);
                    }
                    else
                    {
                        _vc_Main.Program[_vc_Main.Program.FindIndex(a=>a.group_ID==(Lv_Group.SelectedItems[0].Tag as Program_Version).group_ID)]
                            .Info.Remove(Lv_Version.SelectedItems[0].Tag as Common_Version);
                        Lv_Version.Items.Remove(Lv_Version.SelectedItems[0]);
                    }
                    //保存固件配置
                    if (!Frm_Main.Write_Version_Config(Frm_Main._vc_Main))
                    {
                        MessageBox.Show("保存配置出错！", "删除失败"); ;
                    }
                }
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            Show_Lv_Type();
        }
        #endregion


        #region 通用函数
        /// <summary>
        /// 显示类型信息列表
        /// </summary>
        public void Show_Lv_Type()
        {
            Lv_Type.Items.Clear();//清空列表
            Lv_Group.Items.Clear();
            Lv_Version.Items.Clear();
            List<Type_Info> _lti = _vc_Main.Type_List.OrderBy(a => a.type_ID).ToList();
            foreach (Type_Info _ti in _lti)//添加每一项
            {
                ListViewItem _lvi = new ListViewItem((Lv_Type.Items.Count+1).ToString());
                _lvi.Tag = _ti;
                _lvi.SubItems.Add(_ti.type_ID);
                _lvi.SubItems.Add(_ti.type_Name);
                Lv_Type.Items.Add(_lvi);
            }
            if (Lv_Type.Items.Count > 0)//默认选择第一项
            {
                Lv_Type.Focus();
                Lv_Type.Items[0].Selected = true;
            }
        }
        /// <summary>
        /// 显示固件信息列表
        /// </summary>
        /// <param name="type_id"></param>
        public void Show_Lv_Group(string type_id)
        {
            Lv_Group.Items.Clear();
            Lv_Version.Items.Clear();
            //判断是否为引导
            if (_vc_Main.BootLoader.type_ID == type_id)
            {
                ListViewItem _lvi = new ListViewItem((Lv_Group.Items.Count + 1).ToString());
                _lvi.Tag = _vc_Main.BootLoader;
                _lvi.SubItems.Add(_vc_Main.BootLoader.group_ID);
                _lvi.SubItems.Add(_vc_Main.BootLoader.group_Name_CN);
                _lvi.SubItems.Add(_vc_Main.BootLoader.group_Sensor);
                Lv_Group.Items.Add(_lvi);
            }
            //固件
            foreach (Program_Version _pv in _vc_Main.Program)
            {
                if (_pv.type_ID == type_id)
                {
                    ListViewItem _lvi = new ListViewItem((Lv_Group.Items.Count + 1).ToString());
                    _lvi.Tag = _pv;
                    _lvi.SubItems.Add(_pv.group_ID);
                    _lvi.SubItems.Add(_pv.group_Name_CN);
                    _lvi.SubItems.Add(_pv.group_Sensor);
                    Lv_Group.Items.Add(_lvi);
                }
            }
            if (Lv_Group.Items.Count > 0)//默认选择第一项
            {
                Lv_Group.Focus();
                Lv_Group.Items[0].Selected = true;
            }
        }
        /// <summary>
        /// 显示版本信息
        /// </summary>
        /// <param name="group_id"></param>
        public void Show_Lv_Version(Program_Version _pv)
        {
            Lv_Version.Items.Clear();
            if (_pv.Info == null) return;
            foreach (Common_Version _cv in _pv.Info)
            {
                ListViewItem _lvi = new ListViewItem((Lv_Version.Items.Count+1).ToString());
                _lvi.Tag = _cv;
                _lvi.SubItems.Add(_cv.col_Version);
                _lvi.SubItems.Add(_pv.group_ID);
                _lvi.SubItems.Add(_pv.group_Name_CN);
                _lvi.SubItems.Add(_cv.col_Size);
                _lvi.SubItems.Add(_cv.col_Time);
                if(File.Exists(Frm_Main.Path_Local_Config + "/Firmware/Program/" + _pv.group_Name + "/" + _cv.col_Version + ".hex")
                    ||File.Exists(Frm_Main.Path_Local_Config + "/Firmware/BootLoader/"+_cv.col_Version + ".hex"))
                    _lvi.SubItems.Add("已下载");
                else
                    _lvi.SubItems.Add("未下载");
                Lv_Version.Items.Add(_lvi);
            }
            if (Lv_Version.Items.Count > 0)//默认选择第一项
            {
                Lv_Version.Focus();
                Lv_Version.Items[0].Selected = true;
            }
        }
        /// <summary>
        /// 在Lv_Type中添加或者修改信息
        /// </summary>
        /// <param name="_ti"></param>
        /// <param name="tag"></param>
        public void Lv_Add_Update_Type(Type_Info _ti,int tag=0)
        {
            if (tag == 0)
            {
                ListViewItem _lvi = new ListViewItem((Lv_Type.Items.Count + 1).ToString());
                _lvi.Tag = _ti;
                _lvi.SubItems.Add(_ti.type_ID);
                _lvi.SubItems.Add(_ti.type_Name);
                Lv_Type.Items.Add(_lvi);
            }
            else
            {
                Lv_Type.SelectedItems[0].Tag = _ti;
                Lv_Type.SelectedItems[0].SubItems[2].Text = _ti.type_Name;
            }
        }
        /// <summary>
        /// 在Lv_Group中添加护着修改信息
        /// </summary>
        /// <param name="_pv"></param>
        /// <param name="tag"></param>
        public void Lv_Add_Update_Group(Program_Version _pv, int tag = 0)
        {
            if (tag == 0)
            {
                ListViewItem _lvi = new ListViewItem((Lv_Group.Items.Count + 1).ToString());
                _lvi.Tag = _pv;
                _lvi.SubItems.Add(_pv.group_ID);
                _lvi.SubItems.Add(_pv.group_Name_CN);
                _lvi.SubItems.Add(_pv.group_Sensor);
                Lv_Group.Items.Add(_lvi);
            }
            else
            {
                Lv_Group.SelectedItems[0].Tag = _pv;
                Lv_Group.SelectedItems[0].SubItems[2].Text = _pv.group_Name_CN;
                Lv_Group.SelectedItems[0].SubItems[3].Text = _pv.group_Sensor;
            }
        }

        public void Lv_Add_Update_Version(Common_Version _cv, int tag = 0)
        {
            if (tag == 0)
            {
                ListViewItem _lvi = new ListViewItem((Lv_Version.Items.Count + 1).ToString());
                _lvi.Tag = _cv;
                _lvi.SubItems.Add(_cv.col_Version);
                _lvi.SubItems.Add((Lv_Group.SelectedItems[0].Tag as Program_Version).group_ID);
                _lvi.SubItems.Add((Lv_Group.SelectedItems[0].Tag as Program_Version).group_Name_CN);
                _lvi.SubItems.Add(_cv.col_Size);
                _lvi.SubItems.Add(_cv.col_Time);
                _lvi.SubItems.Add("已下载");
                Lv_Version.Items.Add(_lvi);
            }
            else
            {
                Lv_Version.SelectedItems[0].Tag = _cv;
                Lv_Version.SelectedItems[0].SubItems[4].Text = _cv.col_Size;
                Lv_Version.SelectedItems[0].SubItems[5].Text = _cv.col_Time;
            }
        }
        #endregion

        #region 选项更改事件
        /// <summary>
        /// 更改类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Lv_Type.SelectedItems.Count>0)
                Show_Lv_Group(Lv_Type.SelectedItems[0].SubItems[1].Text);
        }
        /// <summary>
        /// 更改固件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Lv_Group.SelectedItems.Count > 0)
                Show_Lv_Version(Lv_Group.SelectedItems[0].Tag as Program_Version);
        }
        private void Lv_Type_DoubleClick(object sender, EventArgs e)
        {
            Btn_Type_Update_Click(null,null);
        }

        private void Lv_Group_DoubleClick(object sender, EventArgs e)
        {
            Btn_Group_Update_Click(null,null);
        }

        private void Lv_Version_DoubleClick(object sender, EventArgs e)
        {
            Btn_Version_Update_Click(null,null);
        }

        #endregion


    }
}
