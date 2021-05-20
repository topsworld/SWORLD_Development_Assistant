using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD开发助手.ToolsOwn
{
    public partial class UC_Tools_CalcTransf : UserControl
    {
        public UC_Tools_CalcTransf()
        {
            InitializeComponent();
        }

        private void UC_Tools_CalcTransf_Load(object sender, EventArgs e)
        {
            Lbx_CalcTransfItems.SelectedIndex = 0;
        }

        /// <summary>
        /// 选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lbx_CalcTransfItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 判断是否选择计算项
            if (Lbx_CalcTransfItems.SelectedIndex < 0) return;
            switch (Lbx_CalcTransfItems.SelectedItem.ToString().Split(':')[0])
            {
                case "00":
                    Btn_CalcTransf_SelectFile.Enabled = false;
                    break;
                case "50":// 文件MD5
                case "51":// 文件转C数组
                case "52":// BASE64编码
                case "53":// BASE64解码
                    Btn_CalcTransf_SelectFile.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// 清空输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LLab_CalcTransf_Input_Clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tbx_CalcTransf_Input.Text = "";
        }
        /// <summary>
        /// 清空输出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LLab_CalcTransf_Output_Clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tbx_CalcTransf_Output.Text = "";
        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CalcTransf_SelectFile_Click(object sender, EventArgs e)
        {
            // 判断是否选择计算项
            if (Lbx_CalcTransfItems.SelectedIndex < 0) return;

        }

        /// <summary>
        /// 计算转换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_CalcTransf_Start_Click(object sender, EventArgs e)
        {
            // 判断是否选择计算项
            if (Lbx_CalcTransfItems.SelectedIndex < 0) return;

        }
    }
}
