
namespace SWORLD开发助手
{
    partial class Frm_MDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MDI));
            this.Tc_Tools = new System.Windows.Forms.TabControl();
            this.Cms_Tools = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭所有页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭除本页面所有页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cms_Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_Tools
            // 
            this.Tc_Tools.ContextMenuStrip = this.Cms_Tools;
            this.Tc_Tools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tc_Tools.ItemSize = new System.Drawing.Size(70, 25);
            this.Tc_Tools.Location = new System.Drawing.Point(0, 0);
            this.Tc_Tools.Name = "Tc_Tools";
            this.Tc_Tools.SelectedIndex = 0;
            this.Tc_Tools.Size = new System.Drawing.Size(484, 541);
            this.Tc_Tools.TabIndex = 0;
            // 
            // Cms_Tools
            // 
            this.Cms_Tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关闭ToolStripMenuItem,
            this.toolStripSeparator1,
            this.关闭所有页面ToolStripMenuItem,
            this.toolStripSeparator2,
            this.关闭除本页面所有页面ToolStripMenuItem});
            this.Cms_Tools.Name = "Cms_Tools";
            this.Cms_Tools.Size = new System.Drawing.Size(173, 82);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.关闭ToolStripMenuItem.Text = "关闭选中页面";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // 关闭所有页面ToolStripMenuItem
            // 
            this.关闭所有页面ToolStripMenuItem.Name = "关闭所有页面ToolStripMenuItem";
            this.关闭所有页面ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.关闭所有页面ToolStripMenuItem.Text = "关闭所有页面";
            this.关闭所有页面ToolStripMenuItem.Click += new System.EventHandler(this.关闭所有页面ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // 关闭除本页面所有页面ToolStripMenuItem
            // 
            this.关闭除本页面所有页面ToolStripMenuItem.Name = "关闭除本页面所有页面ToolStripMenuItem";
            this.关闭除本页面所有页面ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.关闭除本页面所有页面ToolStripMenuItem.Text = "除此之外全部关闭";
            this.关闭除本页面所有页面ToolStripMenuItem.Click += new System.EventHandler(this.关闭除本页面所有页面ToolStripMenuItem_Click);
            // 
            // Frm_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 541);
            this.Controls.Add(this.Tc_Tools);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 580);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 580);
            this.Name = "Frm_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "工具箱";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_MDI_FormClosing);
            this.Load += new System.EventHandler(this.Frm_MDI_Load);
            this.Cms_Tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tc_Tools;
        private System.Windows.Forms.ContextMenuStrip Cms_Tools;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭所有页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭除本页面所有页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}