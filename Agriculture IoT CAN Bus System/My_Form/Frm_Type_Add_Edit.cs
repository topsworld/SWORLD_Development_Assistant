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
    public partial class Frm_Type_Add_Edit : Form
    {
        My_Model.Type_Info _ti_Main;
        Frm_Firmware_Management _ffm_Main;
        public Frm_Type_Add_Edit(My_Model.Type_Info _ti, Frm_Firmware_Management _ffm)
        {
            InitializeComponent();
            _ti_Main = _ti;
            _ffm_Main = _ffm;
        }

        private void Frm_Type_Add_Edit_Load(object sender, EventArgs e)
        {
            if (_ti_Main != null)
            {
                Text = "修改类型";
                Btn_OK.Text = "修改(&U)";
                Tbx_ID.Enabled = false;
                Tbx_ID.Text = _ti_Main.type_ID;
                Tbx_Name.Text = _ti_Main.type_Name;
            }
        }   
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (Tbx_ID.Text.Trim() == "" || Tbx_Name.Text.Trim() == "")
            {
                MessageBox.Show("信息不能为空！","提示");
                return;
            }
            My_Model.Type_Info _ti_ls = new My_Model.Type_Info();
            if (_ti_Main == null)//Add
            {
                //判断相关类型是否存在
                if (Frm_Main._vc_Main.Type_List.Where(a => a.type_ID == Tbx_ID.Text).ToList().Count == 0)
                {
                    _ti_ls.type_ID = Tbx_ID.Text;
                    _ti_ls.type_Name = Tbx_Name.Text;
                    Frm_Main._vc_Main.Type_List.Add(_ti_ls);
                }
                else
                {
                    MessageBox.Show("类型编码已存在，请更换后重试！","提示");
                    return;
                }
            }
            else//Update
            {
                _ti_Main.type_Name = Tbx_Name.Text;
            }
            //保存固件配置
            if (!Frm_Main.Write_Version_Config(Frm_Main._vc_Main))
            {
                MessageBox.Show("保存配置出错！", "错误"); ;
            }
            else
            {
                if (_ti_Main == null)//Add
                {
                    _ffm_Main.Lv_Add_Update_Type(_ti_ls);
                }
                else//Update
                {
                    _ffm_Main.Lv_Add_Update_Type(_ti_Main, 1);
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
