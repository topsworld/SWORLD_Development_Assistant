﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWorld_Downloader.Forms
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

        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Version_Info_FormClosing(object sender, FormClosingEventArgs e)
        {
            //保存设置
            Properties.Settings.Default.Show_Version_Info = !Ckbx_Not_Tip.Checked;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }
    }
}
