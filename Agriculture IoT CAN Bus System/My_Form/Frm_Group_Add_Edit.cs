using Agriculture_IoT_CAN_Bus_System.My_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agriculture_IoT_CAN_Bus_System.My_Form
{
    public partial class Frm_Group_Add_Edit : Form
    {
        Program_Version _pv_Main;
        Frm_Firmware_Management _ffm_Main;
        Type_Info _ti_Main;
        public Frm_Group_Add_Edit(Program_Version _pv, Frm_Firmware_Management _ffm,Type_Info _ti)
        {
            InitializeComponent();
            _pv_Main = _pv;
            _ffm_Main = _ffm;
            _ti_Main = _ti;
        }

        private void Frm_Group_Add_Edit_Load(object sender, EventArgs e)
        {
            Tbx_Type_Info.Text = _ti_Main.ToString();
            if (_pv_Main != null)
            {
                Text = "修改固件";
                Btn_OK.Text = "修改(&U)";

                Tbx_Group_ID.Text = _pv_Main.group_ID;
                Tbx_Group_Name.Text = _pv_Main.group_Name;
                Tbx_Group_Name_CN.Text = _pv_Main.group_Name_CN;
                Tbx_Group_Sensor.Text = _pv_Main.group_Sensor;
                //Cbx_Type_Info.Enabled = false;
                Tbx_Group_ID.Enabled = false;
                Tbx_Group_Name.Enabled = false;
            }
        }

        /// <summary>
        /// 判断对应固件编码是否存在
        /// </summary>
        /// <param name="_group_id">固件编码</param>
        /// <returns>true：存在 false：不存在</returns>
        public bool Check_Group_ID_Exsit(string _group_id)
        {
            //检查是否为BL
            if (Frm_Main._vc_Main.BootLoader.group_ID==_group_id)
                return true;
            if (Frm_Main._vc_Main.Program.Where(a => a.group_ID == _group_id).ToList().Count > 0)
                return true;
            return false;
        }

        /// <summary>
        /// 判断对应固件名称是否存在
        /// </summary>
        /// <param name="_group_id">固件名称</param>
        /// <returns>true：存在 false：不存在</returns>
        public bool Check_Group_Name_Exsit(string _group_name)
        {
            //检查是否为BL
            if (Frm_Main._vc_Main.BootLoader.group_Name == _group_name)
                return true;
            if (Frm_Main._vc_Main.Program.Where(a => a.group_Name == _group_name).ToList().Count > 0)
                return true;
            return false;
        }


        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            //if (Cbx_Type_Info.SelectedIndex < 0)
            //{
            //    MessageBox.Show("请选择类型后继续！", "提示");
            //    return;
            //}
            if (Tbx_Group_ID.Text == ""
                || Tbx_Group_Name.Text == ""
                || Tbx_Group_Name_CN.Text == ""
                || Tbx_Group_Sensor.Text == "")
            {
                MessageBox.Show("信息不能为空！","提示");
                return;
            }
            Program_Version _pv_ls = new Program_Version();
            if (_pv_Main == null)//Add
            {
                //判断对应信息是否重复
                if (Check_Group_ID_Exsit(Tbx_Group_ID.Text))
                {
                    MessageBox.Show("固件编码已存在，请更换后继续！","提示");
                    return;
                }
                if (Check_Group_Name_Exsit(Tbx_Group_Name.Text))
                {
                    MessageBox.Show("固件名称已存在，请更换后继续！", "提示");
                    return;
                }
                _pv_ls.type_ID = _ti_Main.type_ID;
                _pv_ls.group_ID = Tbx_Group_ID.Text;
                _pv_ls.group_Name = Tbx_Group_Name.Text;
                _pv_ls.group_Name_CN = Tbx_Group_Name_CN.Text;
                _pv_ls.group_Sensor = Tbx_Group_Sensor.Text;
                Frm_Main._vc_Main.Program.Add(_pv_ls);
            }
            else//Update
            {
                _pv_Main.group_Name_CN = Tbx_Group_Name_CN.Text;
                _pv_Main.group_Sensor = Tbx_Group_Sensor.Text;
            }
            //保存固件配置
            if (!Frm_Main.Write_Version_Config(Frm_Main._vc_Main))
            {
                MessageBox.Show("保存配置出错！", "错误"); ;
            }
            else
            {
                if (_pv_Main == null)//Add
                {
                    _ffm_Main.Lv_Add_Update_Group(_pv_ls);
                }
                else//Update
                {
                    _ffm_Main.Lv_Add_Update_Group(_pv_Main, 1);
                }
            }
            Close();
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
