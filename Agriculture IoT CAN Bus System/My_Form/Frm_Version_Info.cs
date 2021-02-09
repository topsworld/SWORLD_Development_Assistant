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
    public partial class Frm_Version_Info : Form
    {
        public Frm_Version_Info()
        {
            InitializeComponent();
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_Version_Info_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Version_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存下次是否提示
            Frm_Main._sc_Main.First_Run_Flag = !Ckbx_Not_Show_Again.Checked;
        }
    }
}
