using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD版本管理助手.MyForm
{
    public partial class SoftwareAdd : Form
    {
        MyModel.Software _software;
        public SoftwareAdd(MyModel.Software software)
        {
            InitializeComponent();
            _software = software;
        }

        private void SoftwareAdd_Load(object sender, EventArgs e)
        {
            // 设置时间
            Dtp_AddDate.Value = DateTime.Now;
            if (_software == null)
            {
                // 添加
                return;
            }
            else
            {
                // 修改
                this.Text = "软件添加";
                Tbx_SoftwareCode.Text = _software.Code;
                Tbx_SoftwareCode.Enabled = false;
                Tbx_SoftwareName.Text = _software.Name;
                Dtp_AddDate.Value = _software.AddDate;
            }
            
        }
        /// <summary>
        /// 确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (_software.Name != Tbx_SoftwareName.Text)
            {
                _software.Name = Tbx_SoftwareName.Text;
                _software.AddDate = Dtp_AddDate.Value;
                // 保存修改
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
