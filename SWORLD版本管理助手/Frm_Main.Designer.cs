
namespace SWORLD版本管理助手
{
    partial class Frm_Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Lv_Version = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Push = new System.Windows.Forms.Button();
            this.Btn_Pull = new System.Windows.Forms.Button();
            this.Lbx_Software = new System.Windows.Forms.ListBox();
            this.Gbx_RemoteOperate = new System.Windows.Forms.GroupBox();
            this.Btn_ServiceConfig = new System.Windows.Forms.Button();
            this.Tbx_RemotePath = new System.Windows.Forms.TextBox();
            this.Lab_SoftwarePath = new System.Windows.Forms.Label();
            this.Tbx_HostIP = new System.Windows.Forms.TextBox();
            this.Tbx_UserName = new System.Windows.Forms.TextBox();
            this.Tbx_PassWord = new System.Windows.Forms.TextBox();
            this.Gbx_Connect = new System.Windows.Forms.GroupBox();
            this.Tbx_HostPort = new System.Windows.Forms.TextBox();
            this.Lab_Status = new System.Windows.Forms.Label();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.Lab_LabStatus = new System.Windows.Forms.Label();
            this.Lab_PassWord = new System.Windows.Forms.Label();
            this.Lab_UserName = new System.Windows.Forms.Label();
            this.Lab_HostInfo = new System.Windows.Forms.Label();
            this.Btn_SoftwareUpdate = new System.Windows.Forms.Button();
            this.Btn_SoftwareDelete = new System.Windows.Forms.Button();
            this.Btn_SoftwareAdd = new System.Windows.Forms.Button();
            this.Gbx_SoftwareMngt = new System.Windows.Forms.GroupBox();
            this.Gbx_VersionMngt = new System.Windows.Forms.GroupBox();
            this.Btn_VersionAdd = new System.Windows.Forms.Button();
            this.Btn_VersionUpdate = new System.Windows.Forms.Button();
            this.Btn_VersionDelete = new System.Windows.Forms.Button();
            this.Gbx_LocalOperate = new System.Windows.Forms.GroupBox();
            this.Btn_BackupRetore = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_LocalCachePath = new System.Windows.Forms.TextBox();
            this.Lab_LocalCachePath = new System.Windows.Forms.Label();
            this.Btn_SelectLocalCachePath = new System.Windows.Forms.Button();
            this.Fbd_LocalCachePath = new System.Windows.Forms.FolderBrowserDialog();
            this.Fbd_RemotePath = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gbx_DataMngt = new System.Windows.Forms.GroupBox();
            this.Btn_DataAdd = new System.Windows.Forms.Button();
            this.Btn_DataUpdate = new System.Windows.Forms.Button();
            this.Btn_DataDelete = new System.Windows.Forms.Button();
            this.Gbx_RemoteOperate.SuspendLayout();
            this.Gbx_Connect.SuspendLayout();
            this.Gbx_SoftwareMngt.SuspendLayout();
            this.Gbx_VersionMngt.SuspendLayout();
            this.Gbx_LocalOperate.SuspendLayout();
            this.Gbx_DataMngt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lv_Version
            // 
            this.Lv_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_Version.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.Lv_Version.HideSelection = false;
            this.Lv_Version.Location = new System.Drawing.Point(505, 12);
            this.Lv_Version.Name = "Lv_Version";
            this.Lv_Version.Size = new System.Drawing.Size(367, 277);
            this.Lv_Version.TabIndex = 0;
            this.Lv_Version.UseCompatibleStateImageBehavior = false;
            this.Lv_Version.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "版本号";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "更新说明";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "发布时间";
            this.columnHeader3.Width = 120;
            // 
            // Btn_Push
            // 
            this.Btn_Push.Enabled = false;
            this.Btn_Push.Location = new System.Drawing.Point(144, 26);
            this.Btn_Push.Name = "Btn_Push";
            this.Btn_Push.Size = new System.Drawing.Size(115, 32);
            this.Btn_Push.TabIndex = 1;
            this.Btn_Push.Text = "推送";
            this.Btn_Push.UseVisualStyleBackColor = true;
            this.Btn_Push.Click += new System.EventHandler(this.Btn_Push_Click);
            // 
            // Btn_Pull
            // 
            this.Btn_Pull.Location = new System.Drawing.Point(10, 26);
            this.Btn_Pull.Name = "Btn_Pull";
            this.Btn_Pull.Size = new System.Drawing.Size(115, 32);
            this.Btn_Pull.TabIndex = 1;
            this.Btn_Pull.Text = "拉取";
            this.Btn_Pull.UseVisualStyleBackColor = true;
            this.Btn_Pull.Click += new System.EventHandler(this.Btn_Pull_Click);
            // 
            // Lbx_Software
            // 
            this.Lbx_Software.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbx_Software.FormattingEnabled = true;
            this.Lbx_Software.IntegralHeight = false;
            this.Lbx_Software.ItemHeight = 35;
            this.Lbx_Software.Location = new System.Drawing.Point(283, 225);
            this.Lbx_Software.Name = "Lbx_Software";
            this.Lbx_Software.Size = new System.Drawing.Size(216, 324);
            this.Lbx_Software.TabIndex = 2;
            // 
            // Gbx_RemoteOperate
            // 
            this.Gbx_RemoteOperate.Controls.Add(this.Btn_ServiceConfig);
            this.Gbx_RemoteOperate.Controls.Add(this.Btn_Push);
            this.Gbx_RemoteOperate.Controls.Add(this.Btn_Pull);
            this.Gbx_RemoteOperate.Controls.Add(this.Tbx_RemotePath);
            this.Gbx_RemoteOperate.Controls.Add(this.Lab_SoftwarePath);
            this.Gbx_RemoteOperate.Location = new System.Drawing.Point(12, 191);
            this.Gbx_RemoteOperate.Name = "Gbx_RemoteOperate";
            this.Gbx_RemoteOperate.Size = new System.Drawing.Size(265, 156);
            this.Gbx_RemoteOperate.TabIndex = 3;
            this.Gbx_RemoteOperate.TabStop = false;
            this.Gbx_RemoteOperate.Text = "远程操作";
            // 
            // Btn_ServiceConfig
            // 
            this.Btn_ServiceConfig.Location = new System.Drawing.Point(9, 69);
            this.Btn_ServiceConfig.Name = "Btn_ServiceConfig";
            this.Btn_ServiceConfig.Size = new System.Drawing.Size(249, 32);
            this.Btn_ServiceConfig.TabIndex = 3;
            this.Btn_ServiceConfig.Text = "服务配置";
            this.Btn_ServiceConfig.UseVisualStyleBackColor = true;
            this.Btn_ServiceConfig.Click += new System.EventHandler(this.Btn_ServiceConfig_Click);
            // 
            // Tbx_RemotePath
            // 
            this.Tbx_RemotePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tbx_RemotePath.Location = new System.Drawing.Point(80, 117);
            this.Tbx_RemotePath.Name = "Tbx_RemotePath";
            this.Tbx_RemotePath.Size = new System.Drawing.Size(179, 43);
            this.Tbx_RemotePath.TabIndex = 5;
            this.Tbx_RemotePath.Text = "/etc/sworld/software";
            this.Tbx_RemotePath.TextChanged += new System.EventHandler(this.Tbx_RemotePath_TextChanged);
            // 
            // Lab_SoftwarePath
            // 
            this.Lab_SoftwarePath.AutoSize = true;
            this.Lab_SoftwarePath.Location = new System.Drawing.Point(6, 120);
            this.Lab_SoftwarePath.Name = "Lab_SoftwarePath";
            this.Lab_SoftwarePath.Size = new System.Drawing.Size(150, 35);
            this.Lab_SoftwarePath.TabIndex = 8;
            this.Lab_SoftwarePath.Text = "远程路径：";
            // 
            // Tbx_HostIP
            // 
            this.Tbx_HostIP.Location = new System.Drawing.Point(68, 22);
            this.Tbx_HostIP.Name = "Tbx_HostIP";
            this.Tbx_HostIP.Size = new System.Drawing.Size(143, 43);
            this.Tbx_HostIP.TabIndex = 4;
            this.Tbx_HostIP.Text = "frp.sworld.top";
            // 
            // Tbx_UserName
            // 
            this.Tbx_UserName.Location = new System.Drawing.Point(68, 59);
            this.Tbx_UserName.Name = "Tbx_UserName";
            this.Tbx_UserName.Size = new System.Drawing.Size(191, 43);
            this.Tbx_UserName.TabIndex = 5;
            this.Tbx_UserName.Text = "root";
            // 
            // Tbx_PassWord
            // 
            this.Tbx_PassWord.Location = new System.Drawing.Point(68, 96);
            this.Tbx_PassWord.Name = "Tbx_PassWord";
            this.Tbx_PassWord.PasswordChar = '#';
            this.Tbx_PassWord.Size = new System.Drawing.Size(191, 43);
            this.Tbx_PassWord.TabIndex = 5;
            // 
            // Gbx_Connect
            // 
            this.Gbx_Connect.Controls.Add(this.Tbx_HostPort);
            this.Gbx_Connect.Controls.Add(this.Lab_Status);
            this.Gbx_Connect.Controls.Add(this.Btn_Connect);
            this.Gbx_Connect.Controls.Add(this.Lab_LabStatus);
            this.Gbx_Connect.Controls.Add(this.Tbx_HostIP);
            this.Gbx_Connect.Controls.Add(this.Tbx_UserName);
            this.Gbx_Connect.Controls.Add(this.Tbx_PassWord);
            this.Gbx_Connect.Controls.Add(this.Lab_PassWord);
            this.Gbx_Connect.Controls.Add(this.Lab_UserName);
            this.Gbx_Connect.Controls.Add(this.Lab_HostInfo);
            this.Gbx_Connect.Location = new System.Drawing.Point(12, 12);
            this.Gbx_Connect.Name = "Gbx_Connect";
            this.Gbx_Connect.Size = new System.Drawing.Size(265, 173);
            this.Gbx_Connect.TabIndex = 7;
            this.Gbx_Connect.TabStop = false;
            this.Gbx_Connect.Text = "服务连接";
            // 
            // Tbx_HostPort
            // 
            this.Tbx_HostPort.Location = new System.Drawing.Point(217, 22);
            this.Tbx_HostPort.Name = "Tbx_HostPort";
            this.Tbx_HostPort.Size = new System.Drawing.Size(42, 43);
            this.Tbx_HostPort.TabIndex = 11;
            this.Tbx_HostPort.Text = "22";
            this.Tbx_HostPort.TextChanged += new System.EventHandler(this.Tbx_HostPort_TextChanged);
            this.Tbx_HostPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_HostPort_KeyPress);
            // 
            // Lab_Status
            // 
            this.Lab_Status.AutoSize = true;
            this.Lab_Status.ForeColor = System.Drawing.Color.Red;
            this.Lab_Status.Location = new System.Drawing.Point(81, 136);
            this.Lab_Status.Name = "Lab_Status";
            this.Lab_Status.Size = new System.Drawing.Size(96, 35);
            this.Lab_Status.TabIndex = 10;
            this.Lab_Status.Text = "未连接";
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Location = new System.Drawing.Point(194, 129);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Size = new System.Drawing.Size(65, 30);
            this.Btn_Connect.TabIndex = 1;
            this.Btn_Connect.Text = "连接";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // Lab_LabStatus
            // 
            this.Lab_LabStatus.AutoSize = true;
            this.Lab_LabStatus.Location = new System.Drawing.Point(6, 136);
            this.Lab_LabStatus.Name = "Lab_LabStatus";
            this.Lab_LabStatus.Size = new System.Drawing.Size(120, 35);
            this.Lab_LabStatus.TabIndex = 9;
            this.Lab_LabStatus.Text = "状   态：";
            // 
            // Lab_PassWord
            // 
            this.Lab_PassWord.AutoSize = true;
            this.Lab_PassWord.Location = new System.Drawing.Point(6, 99);
            this.Lab_PassWord.Name = "Lab_PassWord";
            this.Lab_PassWord.Size = new System.Drawing.Size(120, 35);
            this.Lab_PassWord.TabIndex = 8;
            this.Lab_PassWord.Text = "密   码：";
            // 
            // Lab_UserName
            // 
            this.Lab_UserName.AutoSize = true;
            this.Lab_UserName.Location = new System.Drawing.Point(6, 62);
            this.Lab_UserName.Name = "Lab_UserName";
            this.Lab_UserName.Size = new System.Drawing.Size(123, 35);
            this.Lab_UserName.TabIndex = 8;
            this.Lab_UserName.Text = "用户名：";
            // 
            // Lab_HostInfo
            // 
            this.Lab_HostInfo.AutoSize = true;
            this.Lab_HostInfo.Location = new System.Drawing.Point(6, 25);
            this.Lab_HostInfo.Name = "Lab_HostInfo";
            this.Lab_HostInfo.Size = new System.Drawing.Size(120, 35);
            this.Lab_HostInfo.TabIndex = 7;
            this.Lab_HostInfo.Text = "主   机：";
            // 
            // Btn_SoftwareUpdate
            // 
            this.Btn_SoftwareUpdate.Location = new System.Drawing.Point(76, 22);
            this.Btn_SoftwareUpdate.Name = "Btn_SoftwareUpdate";
            this.Btn_SoftwareUpdate.Size = new System.Drawing.Size(64, 32);
            this.Btn_SoftwareUpdate.TabIndex = 1;
            this.Btn_SoftwareUpdate.Text = "修改";
            this.Btn_SoftwareUpdate.UseVisualStyleBackColor = true;
            this.Btn_SoftwareUpdate.Click += new System.EventHandler(this.Btn_SoftwareUpdate_Click);
            // 
            // Btn_SoftwareDelete
            // 
            this.Btn_SoftwareDelete.Location = new System.Drawing.Point(146, 22);
            this.Btn_SoftwareDelete.Name = "Btn_SoftwareDelete";
            this.Btn_SoftwareDelete.Size = new System.Drawing.Size(64, 32);
            this.Btn_SoftwareDelete.TabIndex = 1;
            this.Btn_SoftwareDelete.Text = "删除";
            this.Btn_SoftwareDelete.UseVisualStyleBackColor = true;
            this.Btn_SoftwareDelete.Click += new System.EventHandler(this.Btn_SoftwareDelete_Click);
            // 
            // Btn_SoftwareAdd
            // 
            this.Btn_SoftwareAdd.Location = new System.Drawing.Point(6, 22);
            this.Btn_SoftwareAdd.Name = "Btn_SoftwareAdd";
            this.Btn_SoftwareAdd.Size = new System.Drawing.Size(64, 32);
            this.Btn_SoftwareAdd.TabIndex = 1;
            this.Btn_SoftwareAdd.Text = "添加";
            this.Btn_SoftwareAdd.UseVisualStyleBackColor = true;
            this.Btn_SoftwareAdd.Click += new System.EventHandler(this.Btn_SoftwareAdd_Click);
            // 
            // Gbx_SoftwareMngt
            // 
            this.Gbx_SoftwareMngt.Controls.Add(this.Btn_SoftwareAdd);
            this.Gbx_SoftwareMngt.Controls.Add(this.Btn_SoftwareUpdate);
            this.Gbx_SoftwareMngt.Controls.Add(this.Btn_SoftwareDelete);
            this.Gbx_SoftwareMngt.Location = new System.Drawing.Point(283, 12);
            this.Gbx_SoftwareMngt.Name = "Gbx_SoftwareMngt";
            this.Gbx_SoftwareMngt.Size = new System.Drawing.Size(216, 65);
            this.Gbx_SoftwareMngt.TabIndex = 11;
            this.Gbx_SoftwareMngt.TabStop = false;
            this.Gbx_SoftwareMngt.Text = "软件管理";
            // 
            // Gbx_VersionMngt
            // 
            this.Gbx_VersionMngt.Controls.Add(this.Btn_VersionAdd);
            this.Gbx_VersionMngt.Controls.Add(this.Btn_VersionUpdate);
            this.Gbx_VersionMngt.Controls.Add(this.Btn_VersionDelete);
            this.Gbx_VersionMngt.Location = new System.Drawing.Point(283, 83);
            this.Gbx_VersionMngt.Name = "Gbx_VersionMngt";
            this.Gbx_VersionMngt.Size = new System.Drawing.Size(216, 65);
            this.Gbx_VersionMngt.TabIndex = 12;
            this.Gbx_VersionMngt.TabStop = false;
            this.Gbx_VersionMngt.Text = "版本管理";
            // 
            // Btn_VersionAdd
            // 
            this.Btn_VersionAdd.Location = new System.Drawing.Point(6, 22);
            this.Btn_VersionAdd.Name = "Btn_VersionAdd";
            this.Btn_VersionAdd.Size = new System.Drawing.Size(64, 32);
            this.Btn_VersionAdd.TabIndex = 1;
            this.Btn_VersionAdd.Text = "添加";
            this.Btn_VersionAdd.UseVisualStyleBackColor = true;
            this.Btn_VersionAdd.Click += new System.EventHandler(this.Btn_VersionAdd_Click);
            // 
            // Btn_VersionUpdate
            // 
            this.Btn_VersionUpdate.Location = new System.Drawing.Point(76, 22);
            this.Btn_VersionUpdate.Name = "Btn_VersionUpdate";
            this.Btn_VersionUpdate.Size = new System.Drawing.Size(64, 32);
            this.Btn_VersionUpdate.TabIndex = 1;
            this.Btn_VersionUpdate.Text = "修改";
            this.Btn_VersionUpdate.UseVisualStyleBackColor = true;
            this.Btn_VersionUpdate.Click += new System.EventHandler(this.Btn_VersionUpdate_Click);
            // 
            // Btn_VersionDelete
            // 
            this.Btn_VersionDelete.Location = new System.Drawing.Point(146, 22);
            this.Btn_VersionDelete.Name = "Btn_VersionDelete";
            this.Btn_VersionDelete.Size = new System.Drawing.Size(64, 32);
            this.Btn_VersionDelete.TabIndex = 1;
            this.Btn_VersionDelete.Text = "删除";
            this.Btn_VersionDelete.UseVisualStyleBackColor = true;
            this.Btn_VersionDelete.Click += new System.EventHandler(this.Btn_VersionDelete_Click);
            // 
            // Gbx_LocalOperate
            // 
            this.Gbx_LocalOperate.Controls.Add(this.Btn_BackupRetore);
            this.Gbx_LocalOperate.Controls.Add(this.label2);
            this.Gbx_LocalOperate.Controls.Add(this.label1);
            this.Gbx_LocalOperate.Controls.Add(this.Tbx_LocalCachePath);
            this.Gbx_LocalOperate.Controls.Add(this.Lab_LocalCachePath);
            this.Gbx_LocalOperate.Controls.Add(this.Btn_SelectLocalCachePath);
            this.Gbx_LocalOperate.Location = new System.Drawing.Point(12, 353);
            this.Gbx_LocalOperate.Name = "Gbx_LocalOperate";
            this.Gbx_LocalOperate.Size = new System.Drawing.Size(265, 196);
            this.Gbx_LocalOperate.TabIndex = 11;
            this.Gbx_LocalOperate.TabStop = false;
            this.Gbx_LocalOperate.Text = "本地操作";
            // 
            // Btn_BackupRetore
            // 
            this.Btn_BackupRetore.Location = new System.Drawing.Point(6, 63);
            this.Btn_BackupRetore.Name = "Btn_BackupRetore";
            this.Btn_BackupRetore.Size = new System.Drawing.Size(253, 32);
            this.Btn_BackupRetore.TabIndex = 1;
            this.Btn_BackupRetore.Text = "备份还原";
            this.Btn_BackupRetore.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Design by SWORLD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(5, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "http://www.sworld.top";
            // 
            // Tbx_LocalCachePath
            // 
            this.Tbx_LocalCachePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tbx_LocalCachePath.Location = new System.Drawing.Point(6, 128);
            this.Tbx_LocalCachePath.Name = "Tbx_LocalCachePath";
            this.Tbx_LocalCachePath.ReadOnly = true;
            this.Tbx_LocalCachePath.Size = new System.Drawing.Size(253, 43);
            this.Tbx_LocalCachePath.TabIndex = 5;
            // 
            // Lab_LocalCachePath
            // 
            this.Lab_LocalCachePath.AutoSize = true;
            this.Lab_LocalCachePath.Location = new System.Drawing.Point(7, 108);
            this.Lab_LocalCachePath.Name = "Lab_LocalCachePath";
            this.Lab_LocalCachePath.Size = new System.Drawing.Size(150, 35);
            this.Lab_LocalCachePath.TabIndex = 13;
            this.Lab_LocalCachePath.Text = "本地路径：";
            // 
            // Btn_SelectLocalCachePath
            // 
            this.Btn_SelectLocalCachePath.Location = new System.Drawing.Point(6, 157);
            this.Btn_SelectLocalCachePath.Name = "Btn_SelectLocalCachePath";
            this.Btn_SelectLocalCachePath.Size = new System.Drawing.Size(253, 30);
            this.Btn_SelectLocalCachePath.TabIndex = 14;
            this.Btn_SelectLocalCachePath.Text = "选择";
            this.Btn_SelectLocalCachePath.UseVisualStyleBackColor = true;
            this.Btn_SelectLocalCachePath.Click += new System.EventHandler(this.Btn_SelectLocalCachePath_Click);
            // 
            // Fbd_LocalCachePath
            // 
            this.Fbd_LocalCachePath.Description = "选择本地缓存路径";
            // 
            // Fbd_RemotePath
            // 
            this.Fbd_RemotePath.Description = "选择远程路径";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(505, 295);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(367, 254);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "文件名";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "说明";
            this.columnHeader5.Width = 300;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "添加时间";
            this.columnHeader6.Width = 120;
            // 
            // Gbx_DataMngt
            // 
            this.Gbx_DataMngt.Controls.Add(this.Btn_DataAdd);
            this.Gbx_DataMngt.Controls.Add(this.Btn_DataUpdate);
            this.Gbx_DataMngt.Controls.Add(this.Btn_DataDelete);
            this.Gbx_DataMngt.Location = new System.Drawing.Point(283, 154);
            this.Gbx_DataMngt.Name = "Gbx_DataMngt";
            this.Gbx_DataMngt.Size = new System.Drawing.Size(216, 65);
            this.Gbx_DataMngt.TabIndex = 16;
            this.Gbx_DataMngt.TabStop = false;
            this.Gbx_DataMngt.Text = "数据管理";
            // 
            // Btn_DataAdd
            // 
            this.Btn_DataAdd.Location = new System.Drawing.Point(6, 22);
            this.Btn_DataAdd.Name = "Btn_DataAdd";
            this.Btn_DataAdd.Size = new System.Drawing.Size(64, 32);
            this.Btn_DataAdd.TabIndex = 1;
            this.Btn_DataAdd.Text = "添加";
            this.Btn_DataAdd.UseVisualStyleBackColor = true;
            this.Btn_DataAdd.Click += new System.EventHandler(this.Btn_DataAdd_Click);
            // 
            // Btn_DataUpdate
            // 
            this.Btn_DataUpdate.Location = new System.Drawing.Point(76, 22);
            this.Btn_DataUpdate.Name = "Btn_DataUpdate";
            this.Btn_DataUpdate.Size = new System.Drawing.Size(64, 32);
            this.Btn_DataUpdate.TabIndex = 1;
            this.Btn_DataUpdate.Text = "修改";
            this.Btn_DataUpdate.UseVisualStyleBackColor = true;
            this.Btn_DataUpdate.Click += new System.EventHandler(this.Btn_DataUpdate_Click);
            // 
            // Btn_DataDelete
            // 
            this.Btn_DataDelete.Location = new System.Drawing.Point(146, 22);
            this.Btn_DataDelete.Name = "Btn_DataDelete";
            this.Btn_DataDelete.Size = new System.Drawing.Size(64, 32);
            this.Btn_DataDelete.TabIndex = 1;
            this.Btn_DataDelete.Text = "删除";
            this.Btn_DataDelete.UseVisualStyleBackColor = true;
            this.Btn_DataDelete.Click += new System.EventHandler(this.Btn_DataDelete_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Gbx_DataMngt);
            this.Controls.Add(this.Gbx_VersionMngt);
            this.Controls.Add(this.Gbx_SoftwareMngt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Gbx_LocalOperate);
            this.Controls.Add(this.Gbx_Connect);
            this.Controls.Add(this.Gbx_RemoteOperate);
            this.Controls.Add(this.Lbx_Software);
            this.Controls.Add(this.Lv_Version);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWORLD版本管理助手";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Gbx_RemoteOperate.ResumeLayout(false);
            this.Gbx_RemoteOperate.PerformLayout();
            this.Gbx_Connect.ResumeLayout(false);
            this.Gbx_Connect.PerformLayout();
            this.Gbx_SoftwareMngt.ResumeLayout(false);
            this.Gbx_VersionMngt.ResumeLayout(false);
            this.Gbx_LocalOperate.ResumeLayout(false);
            this.Gbx_LocalOperate.PerformLayout();
            this.Gbx_DataMngt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Version;
        private System.Windows.Forms.Button Btn_Push;
        private System.Windows.Forms.Button Btn_Pull;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListBox Lbx_Software;
        private System.Windows.Forms.GroupBox Gbx_RemoteOperate;
        private System.Windows.Forms.TextBox Tbx_HostIP;
        private System.Windows.Forms.TextBox Tbx_UserName;
        private System.Windows.Forms.TextBox Tbx_PassWord;
        private System.Windows.Forms.TextBox Tbx_RemotePath;
        private System.Windows.Forms.GroupBox Gbx_Connect;
        private System.Windows.Forms.Label Lab_SoftwarePath;
        private System.Windows.Forms.Label Lab_PassWord;
        private System.Windows.Forms.Label Lab_UserName;
        private System.Windows.Forms.Label Lab_HostInfo;
        private System.Windows.Forms.Label Lab_LabStatus;
        private System.Windows.Forms.Label Lab_Status;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.Button Btn_SoftwareUpdate;
        private System.Windows.Forms.Button Btn_SoftwareDelete;
        private System.Windows.Forms.Button Btn_SoftwareAdd;
        private System.Windows.Forms.GroupBox Gbx_SoftwareMngt;
        private System.Windows.Forms.GroupBox Gbx_VersionMngt;
        private System.Windows.Forms.Button Btn_VersionAdd;
        private System.Windows.Forms.Button Btn_VersionUpdate;
        private System.Windows.Forms.Button Btn_VersionDelete;
        private System.Windows.Forms.Button Btn_ServiceConfig;
        private System.Windows.Forms.GroupBox Gbx_LocalOperate;
        private System.Windows.Forms.Button Btn_BackupRetore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_HostPort;
        private System.Windows.Forms.TextBox Tbx_LocalCachePath;
        private System.Windows.Forms.Label Lab_LocalCachePath;
        private System.Windows.Forms.FolderBrowserDialog Fbd_LocalCachePath;
        private System.Windows.Forms.FolderBrowserDialog Fbd_RemotePath;
        private System.Windows.Forms.Button Btn_SelectLocalCachePath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox Gbx_DataMngt;
        private System.Windows.Forms.Button Btn_DataAdd;
        private System.Windows.Forms.Button Btn_DataUpdate;
        private System.Windows.Forms.Button Btn_DataDelete;
    }
}

