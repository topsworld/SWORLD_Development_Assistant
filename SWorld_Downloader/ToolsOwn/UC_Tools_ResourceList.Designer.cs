
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_ResourceList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("系统工具", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("调试工具", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "GeekUninstaller",
            "轻量的软件卸载工具轻量的软件卸载工具轻量的软件卸载工具轻量的软件卸载工具轻量的软件卸载工具轻量的软件卸载工具轻量的软件卸载工具轻量的软件卸载工具",
            "1024 KB",
            "1.1"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Keil");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("IAR STM8");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("FolderPainter");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("EmptyFolderNuker");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("SocketTool");
            this.Lv_Tools = new System.Windows.Forms.ListView();
            this.LvCol_ToolsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_ToolsIntroduction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_ToolsSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_ToolsVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.工具详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载选中软件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_ToolsRefresh = new System.Windows.Forms.Button();
            this.Tbx_ToolsKeyWord = new System.Windows.Forms.TextBox();
            this.Btn_ToolsSearch = new System.Windows.Forms.Button();
            this.Cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lv_Tools
            // 
            this.Lv_Tools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lv_Tools.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvCol_ToolsName,
            this.LvCol_ToolsIntroduction,
            this.LvCol_ToolsSize,
            this.LvCol_ToolsVersion});
            this.Lv_Tools.ContextMenuStrip = this.Cms;
            this.Lv_Tools.FullRowSelect = true;
            listViewGroup1.Header = "系统工具";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "调试工具";
            listViewGroup2.Name = "listViewGroup3";
            this.Lv_Tools.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.Lv_Tools.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem1.ToolTipText = "121212121212";
            listViewItem2.Group = listViewGroup2;
            listViewItem2.ToolTipText = "1212121212";
            listViewItem3.Group = listViewGroup1;
            listViewItem3.ToolTipText = "12121212";
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            this.Lv_Tools.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.Lv_Tools.Location = new System.Drawing.Point(-3, 39);
            this.Lv_Tools.MultiSelect = false;
            this.Lv_Tools.Name = "Lv_Tools";
            this.Lv_Tools.Size = new System.Drawing.Size(476, 469);
            this.Lv_Tools.TabIndex = 0;
            this.Lv_Tools.UseCompatibleStateImageBehavior = false;
            this.Lv_Tools.View = System.Windows.Forms.View.Details;
            // 
            // LvCol_ToolsName
            // 
            this.LvCol_ToolsName.Text = "名称";
            this.LvCol_ToolsName.Width = 150;
            // 
            // LvCol_ToolsIntroduction
            // 
            this.LvCol_ToolsIntroduction.Text = "简介";
            this.LvCol_ToolsIntroduction.Width = 140;
            // 
            // LvCol_ToolsSize
            // 
            this.LvCol_ToolsSize.Text = "大小";
            this.LvCol_ToolsSize.Width = 80;
            // 
            // LvCol_ToolsVersion
            // 
            this.LvCol_ToolsVersion.Text = "版本";
            this.LvCol_ToolsVersion.Width = 80;
            // 
            // Cms
            // 
            this.Cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.工具详情ToolStripMenuItem,
            this.下载选中软件ToolStripMenuItem,
            this.刷新ToolStripMenuItem});
            this.Cms.Name = "Cms";
            this.Cms.Size = new System.Drawing.Size(125, 70);
            // 
            // 工具详情ToolStripMenuItem
            // 
            this.工具详情ToolStripMenuItem.Name = "工具详情ToolStripMenuItem";
            this.工具详情ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.工具详情ToolStripMenuItem.Text = "详情";
            // 
            // 下载选中软件ToolStripMenuItem
            // 
            this.下载选中软件ToolStripMenuItem.Name = "下载选中软件ToolStripMenuItem";
            this.下载选中软件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.下载选中软件ToolStripMenuItem.Text = "下载选中";
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // Btn_ToolsRefresh
            // 
            this.Btn_ToolsRefresh.Location = new System.Drawing.Point(3, 5);
            this.Btn_ToolsRefresh.Name = "Btn_ToolsRefresh";
            this.Btn_ToolsRefresh.Size = new System.Drawing.Size(75, 27);
            this.Btn_ToolsRefresh.TabIndex = 2;
            this.Btn_ToolsRefresh.Text = "刷新";
            this.Btn_ToolsRefresh.UseVisualStyleBackColor = true;
            // 
            // Tbx_ToolsKeyWord
            // 
            this.Tbx_ToolsKeyWord.Location = new System.Drawing.Point(239, 7);
            this.Tbx_ToolsKeyWord.Name = "Tbx_ToolsKeyWord";
            this.Tbx_ToolsKeyWord.Size = new System.Drawing.Size(170, 23);
            this.Tbx_ToolsKeyWord.TabIndex = 3;
            // 
            // Btn_ToolsSearch
            // 
            this.Btn_ToolsSearch.Location = new System.Drawing.Point(415, 5);
            this.Btn_ToolsSearch.Name = "Btn_ToolsSearch";
            this.Btn_ToolsSearch.Size = new System.Drawing.Size(58, 27);
            this.Btn_ToolsSearch.TabIndex = 4;
            this.Btn_ToolsSearch.Text = "搜索";
            this.Btn_ToolsSearch.UseVisualStyleBackColor = true;
            // 
            // UC_Tools_ResourceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_ToolsSearch);
            this.Controls.Add(this.Tbx_ToolsKeyWord);
            this.Controls.Add(this.Btn_ToolsRefresh);
            this.Controls.Add(this.Lv_Tools);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_ResourceList";
            this.Size = new System.Drawing.Size(476, 508);
            this.Cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Tools;
        private System.Windows.Forms.ColumnHeader LvCol_ToolsName;
        private System.Windows.Forms.ColumnHeader LvCol_ToolsIntroduction;
        private System.Windows.Forms.ColumnHeader LvCol_ToolsSize;
        private System.Windows.Forms.ColumnHeader LvCol_ToolsVersion;
        private System.Windows.Forms.ContextMenuStrip Cms;
        private System.Windows.Forms.ToolStripMenuItem 工具详情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下载选中软件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.Button Btn_ToolsRefresh;
        private System.Windows.Forms.TextBox Tbx_ToolsKeyWord;
        private System.Windows.Forms.Button Btn_ToolsSearch;
    }
}
