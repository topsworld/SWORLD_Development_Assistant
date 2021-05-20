using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD开发助手
{
    public partial class Frm_MDI : Form
    {
        public Frm_MDI()
        {
            InitializeComponent();
        }

        private void Frm_MDI_Load(object sender, EventArgs e)
        {

        }

        public void AddToolsTab(UserControl _uc,string name,string text)
        {
            TabPage _tp = new TabPage();
            _tp.Name = name;
            _tp.Text = text;
            _tp.Controls.Add(_uc);
            Tc_Tools.TabPages.Add(_tp);
        }

        /// <summary>
        /// 判断窗体是否存在
        /// </summary>
        /// <param name="frm_name"></param>
        public bool IsExsitToolsFrm(string frm_name)
        {
            return Tc_Tools.TabPages.ContainsKey(frm_name);
        }

        /// <summary>
        /// 设置选择项
        /// </summary>
        /// <param name="name"></param>
        public void SetSelectPage(string name)
        {
            Tc_Tools.SelectedIndex = Tc_Tools.TabPages.IndexOfKey(name);
        }

        // 是否强制关闭
        private bool IsForceClose=false;
        /// <summary>
        /// 隐藏窗体，不关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                (this.Owner as Main).SetToolsPanleStatu();
                (this.Owner as Main).Activate();
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 获取已打开窗体数
        /// </summary>
        /// <returns></returns>
        public int GetPageCount() => Tc_Tools.TabPages.Count;

        /// <summary>
        /// 关闭标签，如果没有标签，则关闭页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tc_Tools.TabPages.Count == 0)
                Close();
            Tc_Tools.TabPages.Remove(Tc_Tools.SelectedTab);
            if (Tc_Tools.TabPages.Count == 0)
                Close();
        }
        /// <summary>
        /// 关闭所有页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭所有页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tc_Tools.TabPages.Clear();
            Close();
        }

        /// <summary>
        /// 关闭除此之外所有页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭除本页面所有页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage _tp in Tc_Tools.TabPages)
            {
                if (_tp.Name == Tc_Tools.SelectedTab.Name)
                    continue;
                else
                    Tc_Tools.TabPages.Remove(_tp);
            }
        }
    }
}
