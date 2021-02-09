namespace Agriculture_IoT_CAN_Bus_System
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("BootLoader引导程序", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("MS_10土壤温湿度传感器", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.Tc_Main = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Pgb_DL_Task_Process = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Tbx_New_SWBL_SAdress = new System.Windows.Forms.TextBox();
            this.Btn_New_SWBL_Download = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Cbx_New_SWBL_Version = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tbx_Old_SWBL_Time = new System.Windows.Forms.TextBox();
            this.Tbx_Old_Firmware_Time = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Btn_Read_Sys_Info = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Tbx_Old_Firmware_Version = new System.Windows.Forms.TextBox();
            this.Tbx_Old_Firmware_Name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tbx_Old_Firmware_NetSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Tbx_Chip_ID = new System.Windows.Forms.TextBox();
            this.Tbx_Old_SWBL_Version = new System.Windows.Forms.TextBox();
            this.Gbx_Connect = new System.Windows.Forms.GroupBox();
            this.Cbx_Serial_BaudRate = new System.Windows.Forms.ComboBox();
            this.Cbx_Serial_Port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Serial_Fresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Gbx_Net_Info = new System.Windows.Forms.GroupBox();
            this.Cbx_Node_Type = new System.Windows.Forms.ComboBox();
            this.Nud_Polling_Time = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Tbx_Prj_ID = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Btn_Get_Firmware_NetSerial = new System.Windows.Forms.Button();
            this.Tbx_New_Firmware_NewSerial = new System.Windows.Forms.TextBox();
            this.Btn_DL_All = new System.Windows.Forms.Button();
            this.Btn_DL_Firmware = new System.Windows.Forms.Button();
            this.Lbx_New_Firmwares = new Agriculture_IoT_CAN_Bus_System.My_Control.My_ListBox();
            this.Btn_Fresh_Firmware_List = new System.Windows.Forms.Button();
            this.Ckbx_Check_DL = new System.Windows.Forms.CheckBox();
            this.Ckbx_DL_After_Dir_Run = new System.Windows.Forms.CheckBox();
            this.Tbx_Sys_Run_Adress = new System.Windows.Forms.TextBox();
            this.Tbx_Sys_DL_Adress = new System.Windows.Forms.TextBox();
            this.Ckbx_Show_Time = new System.Windows.Forms.CheckBox();
            this.Tbx_New_Firmware_Time = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Tbx_New_Firmware_Size = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Tbx_New_Firmware_Name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Cbx_New_Firmware_Version = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbx_Msg = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Btn_Admin_Access = new System.Windows.Forms.Button();
            this.Btn_Reset_To_Version_Default = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Btn_Consistency_Check = new System.Windows.Forms.Button();
            this.Btn_Update_From_Local = new System.Windows.Forms.Button();
            this.Btn_Update_From_Server = new System.Windows.Forms.Button();
            this.Lv_Firmware_Management = new System.Windows.Forms.ListView();
            this.col_Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_Sersor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Stat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Ts_Bottom = new System.Windows.Forms.ToolStrip();
            this.Tstbx_Msg_Img = new System.Windows.Forms.ToolStripLabel();
            this.Tstbx_Msg_Txt = new System.Windows.Forms.ToolStripLabel();
            this.Tsddb_Tool_Box = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsBtn_Bottom_Calc = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Bottom_Note = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsdbtn_Set = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsBtn_Window_Para_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Save_Window_Para = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Reset_Window_Para = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Check_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_Start_Check_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_FeedBack = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tbx_Time_Show = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tmr_Clock = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Btm_Msg = new System.Windows.Forms.Timer(this.components);
            this.Tt_Msg = new System.Windows.Forms.ToolTip(this.components);
            this.Sp_DL = new System.IO.Ports.SerialPort(this.components);
            this.Tc_Main.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gbx_Connect.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Gbx_Net_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Polling_Time)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Ts_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_Main
            // 
            this.Tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tc_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tc_Main.Controls.Add(this.tabPage2);
            this.Tc_Main.Controls.Add(this.tabPage3);
            this.Tc_Main.Controls.Add(this.tabPage1);
            this.Tc_Main.ItemSize = new System.Drawing.Size(200, 25);
            this.Tc_Main.Location = new System.Drawing.Point(0, 7);
            this.Tc_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tc_Main.Name = "Tc_Main";
            this.Tc_Main.SelectedIndex = 0;
            this.Tc_Main.Size = new System.Drawing.Size(846, 514);
            this.Tc_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tc_Main.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pgb_DL_Task_Process);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.Gbx_Connect);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.Lbx_Msg);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(838, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "固件下载";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Pgb_DL_Task_Process
            // 
            this.Pgb_DL_Task_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pgb_DL_Task_Process.Location = new System.Drawing.Point(3, 466);
            this.Pgb_DL_Task_Process.Name = "Pgb_DL_Task_Process";
            this.Pgb_DL_Task_Process.Size = new System.Drawing.Size(365, 10);
            this.Pgb_DL_Task_Process.Step = 1;
            this.Pgb_DL_Task_Process.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Tbx_New_SWBL_SAdress);
            this.groupBox4.Controls.Add(this.Btn_New_SWBL_Download);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.Cbx_New_SWBL_Version);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(374, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 75);
            this.groupBox4.TabIndex = 136;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BootLoader下载";
            // 
            // Tbx_New_SWBL_SAdress
            // 
            this.Tbx_New_SWBL_SAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_New_SWBL_SAdress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_New_SWBL_SAdress.Location = new System.Drawing.Point(296, 42);
            this.Tbx_New_SWBL_SAdress.MaxLength = 8;
            this.Tbx_New_SWBL_SAdress.Name = "Tbx_New_SWBL_SAdress";
            this.Tbx_New_SWBL_SAdress.Size = new System.Drawing.Size(80, 21);
            this.Tbx_New_SWBL_SAdress.TabIndex = 130;
            this.Tbx_New_SWBL_SAdress.Text = "08000000";
            this.Tbx_New_SWBL_SAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Btn_New_SWBL_Download
            // 
            this.Btn_New_SWBL_Download.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_New_SWBL_Download.Location = new System.Drawing.Point(383, 38);
            this.Btn_New_SWBL_Download.Name = "Btn_New_SWBL_Download";
            this.Btn_New_SWBL_Download.Size = new System.Drawing.Size(72, 28);
            this.Btn_New_SWBL_Download.TabIndex = 145;
            this.Btn_New_SWBL_Download.Text = "下载BL";
            this.Tt_Msg.SetToolTip(this.Btn_New_SWBL_Download, "【注】下载BL会执行【擦除全片】操作");
            this.Btn_New_SWBL_Download.UseVisualStyleBackColor = true;
            this.Btn_New_SWBL_Download.Click += new System.EventHandler(this.Btn_New_SWBL_Download_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(276, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 14);
            this.label19.TabIndex = 137;
            this.label19.Text = "0x";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(140, 17);
            this.label18.TabIndex = 129;
            this.label18.Text = "SW BootLoader 版本：";
            // 
            // Cbx_New_SWBL_Version
            // 
            this.Cbx_New_SWBL_Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_New_SWBL_Version.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_New_SWBL_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_New_SWBL_Version.DropDownWidth = 152;
            this.Cbx_New_SWBL_Version.FormattingEnabled = true;
            this.Cbx_New_SWBL_Version.Location = new System.Drawing.Point(11, 40);
            this.Cbx_New_SWBL_Version.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Cbx_New_SWBL_Version.Name = "Cbx_New_SWBL_Version";
            this.Cbx_New_SWBL_Version.Size = new System.Drawing.Size(257, 25);
            this.Cbx_New_SWBL_Version.TabIndex = 136;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(276, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 14);
            this.label7.TabIndex = 124;
            this.label7.Text = "BL下载地址：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbx_Old_SWBL_Time);
            this.groupBox1.Controls.Add(this.Tbx_Old_Firmware_Time);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Btn_Read_Sys_Info);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Tbx_Old_Firmware_Version);
            this.groupBox1.Controls.Add(this.Tbx_Old_Firmware_Name);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Tbx_Old_Firmware_NetSerial);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tbx_Chip_ID);
            this.groupBox1.Controls.Add(this.Tbx_Old_SWBL_Version);
            this.groupBox1.Location = new System.Drawing.Point(3, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 158);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原固件信息";
            // 
            // Tbx_Old_SWBL_Time
            // 
            this.Tbx_Old_SWBL_Time.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Old_SWBL_Time.Location = new System.Drawing.Point(270, 84);
            this.Tbx_Old_SWBL_Time.MaxLength = 10000;
            this.Tbx_Old_SWBL_Time.Name = "Tbx_Old_SWBL_Time";
            this.Tbx_Old_SWBL_Time.ReadOnly = true;
            this.Tbx_Old_SWBL_Time.Size = new System.Drawing.Size(85, 21);
            this.Tbx_Old_SWBL_Time.TabIndex = 142;
            this.Tbx_Old_SWBL_Time.Text = "无";
            this.Tbx_Old_SWBL_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_Old_Firmware_Time
            // 
            this.Tbx_Old_Firmware_Time.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Old_Firmware_Time.Location = new System.Drawing.Point(270, 128);
            this.Tbx_Old_Firmware_Time.MaxLength = 10000;
            this.Tbx_Old_Firmware_Time.Name = "Tbx_Old_Firmware_Time";
            this.Tbx_Old_Firmware_Time.ReadOnly = true;
            this.Tbx_Old_Firmware_Time.Size = new System.Drawing.Size(85, 21);
            this.Tbx_Old_Firmware_Time.TabIndex = 142;
            this.Tbx_Old_Firmware_Time.Text = "无";
            this.Tbx_Old_Firmware_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 108);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 141;
            this.label12.Text = "固件更新时间：";
            // 
            // Btn_Read_Sys_Info
            // 
            this.Btn_Read_Sys_Info.Location = new System.Drawing.Point(270, 35);
            this.Btn_Read_Sys_Info.Name = "Btn_Read_Sys_Info";
            this.Btn_Read_Sys_Info.Size = new System.Drawing.Size(85, 28);
            this.Btn_Read_Sys_Info.TabIndex = 123;
            this.Btn_Read_Sys_Info.Text = "读系统信息";
            this.Btn_Read_Sys_Info.UseVisualStyleBackColor = true;
            this.Btn_Read_Sys_Info.Click += new System.EventHandler(this.Btn_Read_Sys_Info_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 141;
            this.label14.Text = "BL更新时间：";
            // 
            // Tbx_Old_Firmware_Version
            // 
            this.Tbx_Old_Firmware_Version.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Old_Firmware_Version.Location = new System.Drawing.Point(174, 128);
            this.Tbx_Old_Firmware_Version.MaxLength = 10000;
            this.Tbx_Old_Firmware_Version.Name = "Tbx_Old_Firmware_Version";
            this.Tbx_Old_Firmware_Version.ReadOnly = true;
            this.Tbx_Old_Firmware_Version.Size = new System.Drawing.Size(90, 21);
            this.Tbx_Old_Firmware_Version.TabIndex = 140;
            this.Tbx_Old_Firmware_Version.Text = "无";
            this.Tbx_Old_Firmware_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_Old_Firmware_Name
            // 
            this.Tbx_Old_Firmware_Name.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Old_Firmware_Name.Location = new System.Drawing.Point(8, 84);
            this.Tbx_Old_Firmware_Name.MaxLength = 8;
            this.Tbx_Old_Firmware_Name.Name = "Tbx_Old_Firmware_Name";
            this.Tbx_Old_Firmware_Name.ReadOnly = true;
            this.Tbx_Old_Firmware_Name.Size = new System.Drawing.Size(160, 21);
            this.Tbx_Old_Firmware_Name.TabIndex = 138;
            this.Tbx_Old_Firmware_Name.Text = "无";
            this.Tbx_Old_Firmware_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 64);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 137;
            this.label10.Text = "系统固件名称：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(171, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 139;
            this.label11.Text = "系统固件版本：";
            // 
            // Tbx_Old_Firmware_NetSerial
            // 
            this.Tbx_Old_Firmware_NetSerial.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Old_Firmware_NetSerial.Location = new System.Drawing.Point(8, 128);
            this.Tbx_Old_Firmware_NetSerial.MaxLength = 16;
            this.Tbx_Old_Firmware_NetSerial.Name = "Tbx_Old_Firmware_NetSerial";
            this.Tbx_Old_Firmware_NetSerial.ReadOnly = true;
            this.Tbx_Old_Firmware_NetSerial.Size = new System.Drawing.Size(160, 21);
            this.Tbx_Old_Firmware_NetSerial.TabIndex = 136;
            this.Tbx_Old_Firmware_NetSerial.Text = "无";
            this.Tbx_Old_Firmware_NetSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 135;
            this.label9.Text = "固件入网序列：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 131;
            this.label5.Text = "MCU 片上ID：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 132;
            this.label6.Text = "SW BL版本：";
            // 
            // Tbx_Chip_ID
            // 
            this.Tbx_Chip_ID.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Chip_ID.Location = new System.Drawing.Point(8, 40);
            this.Tbx_Chip_ID.MaxLength = 24;
            this.Tbx_Chip_ID.Name = "Tbx_Chip_ID";
            this.Tbx_Chip_ID.ReadOnly = true;
            this.Tbx_Chip_ID.Size = new System.Drawing.Size(256, 21);
            this.Tbx_Chip_ID.TabIndex = 133;
            this.Tbx_Chip_ID.Text = "无";
            this.Tbx_Chip_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_Old_SWBL_Version
            // 
            this.Tbx_Old_SWBL_Version.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Old_SWBL_Version.Location = new System.Drawing.Point(174, 84);
            this.Tbx_Old_SWBL_Version.MaxLength = 10000;
            this.Tbx_Old_SWBL_Version.Name = "Tbx_Old_SWBL_Version";
            this.Tbx_Old_SWBL_Version.ReadOnly = true;
            this.Tbx_Old_SWBL_Version.Size = new System.Drawing.Size(90, 21);
            this.Tbx_Old_SWBL_Version.TabIndex = 134;
            this.Tbx_Old_SWBL_Version.Text = "无";
            this.Tbx_Old_SWBL_Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Gbx_Connect
            // 
            this.Gbx_Connect.Controls.Add(this.Cbx_Serial_BaudRate);
            this.Gbx_Connect.Controls.Add(this.Cbx_Serial_Port);
            this.Gbx_Connect.Controls.Add(this.label1);
            this.Gbx_Connect.Controls.Add(this.label2);
            this.Gbx_Connect.Controls.Add(this.Btn_Serial_Fresh);
            this.Gbx_Connect.Location = new System.Drawing.Point(3, 7);
            this.Gbx_Connect.Name = "Gbx_Connect";
            this.Gbx_Connect.Size = new System.Drawing.Size(365, 75);
            this.Gbx_Connect.TabIndex = 135;
            this.Gbx_Connect.TabStop = false;
            this.Gbx_Connect.Text = "连接设置";
            // 
            // Cbx_Serial_BaudRate
            // 
            this.Cbx_Serial_BaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Serial_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Serial_BaudRate.FormattingEnabled = true;
            this.Cbx_Serial_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000",
            "460800",
            "921600",
            "1843200"});
            this.Cbx_Serial_BaudRate.Location = new System.Drawing.Point(209, 40);
            this.Cbx_Serial_BaudRate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Cbx_Serial_BaudRate.Name = "Cbx_Serial_BaudRate";
            this.Cbx_Serial_BaudRate.Size = new System.Drawing.Size(116, 25);
            this.Cbx_Serial_BaudRate.TabIndex = 118;
            // 
            // Cbx_Serial_Port
            // 
            this.Cbx_Serial_Port.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Serial_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Serial_Port.DropDownWidth = 152;
            this.Cbx_Serial_Port.FormattingEnabled = true;
            this.Cbx_Serial_Port.Location = new System.Drawing.Point(8, 40);
            this.Cbx_Serial_Port.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Cbx_Serial_Port.Name = "Cbx_Serial_Port";
            this.Cbx_Serial_Port.Size = new System.Drawing.Size(191, 25);
            this.Cbx_Serial_Port.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 119;
            this.label1.Text = "连接端口：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 121;
            this.label2.Text = "下载波特率：";
            // 
            // Btn_Serial_Fresh
            // 
            this.Btn_Serial_Fresh.BackgroundImage = global::Agriculture_IoT_CAN_Bus_System.Properties.Resources.refresh24;
            this.Btn_Serial_Fresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Serial_Fresh.Location = new System.Drawing.Point(333, 39);
            this.Btn_Serial_Fresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Serial_Fresh.Name = "Btn_Serial_Fresh";
            this.Btn_Serial_Fresh.Size = new System.Drawing.Size(26, 26);
            this.Btn_Serial_Fresh.TabIndex = 120;
            this.Tt_Msg.SetToolTip(this.Btn_Serial_Fresh, "刷新串口");
            this.Btn_Serial_Fresh.UseVisualStyleBackColor = true;
            this.Btn_Serial_Fresh.Click += new System.EventHandler(this.Btn_Serial_Fresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.Gbx_Net_Info);
            this.groupBox2.Controls.Add(this.Btn_DL_All);
            this.groupBox2.Controls.Add(this.Btn_DL_Firmware);
            this.groupBox2.Controls.Add(this.Lbx_New_Firmwares);
            this.groupBox2.Controls.Add(this.Btn_Fresh_Firmware_List);
            this.groupBox2.Controls.Add(this.Ckbx_Check_DL);
            this.groupBox2.Controls.Add(this.Ckbx_DL_After_Dir_Run);
            this.groupBox2.Controls.Add(this.Tbx_Sys_Run_Adress);
            this.groupBox2.Controls.Add(this.Tbx_Sys_DL_Adress);
            this.groupBox2.Controls.Add(this.Ckbx_Show_Time);
            this.groupBox2.Controls.Add(this.Tbx_New_Firmware_Time);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.Tbx_New_Firmware_Size);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.Tbx_New_Firmware_Name);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.Cbx_New_Firmware_Version);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(374, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 389);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新固件信息";
            // 
            // Gbx_Net_Info
            // 
            this.Gbx_Net_Info.Controls.Add(this.Cbx_Node_Type);
            this.Gbx_Net_Info.Controls.Add(this.Nud_Polling_Time);
            this.Gbx_Net_Info.Controls.Add(this.label3);
            this.Gbx_Net_Info.Controls.Add(this.label22);
            this.Gbx_Net_Info.Controls.Add(this.label21);
            this.Gbx_Net_Info.Controls.Add(this.Tbx_Prj_ID);
            this.Gbx_Net_Info.Controls.Add(this.label20);
            this.Gbx_Net_Info.Controls.Add(this.Btn_Get_Firmware_NetSerial);
            this.Gbx_Net_Info.Controls.Add(this.Tbx_New_Firmware_NewSerial);
            this.Gbx_Net_Info.Location = new System.Drawing.Point(11, 25);
            this.Gbx_Net_Info.Name = "Gbx_Net_Info";
            this.Gbx_Net_Info.Size = new System.Drawing.Size(277, 133);
            this.Gbx_Net_Info.TabIndex = 151;
            this.Gbx_Net_Info.TabStop = false;
            this.Gbx_Net_Info.Text = "入网信息";
            // 
            // Cbx_Node_Type
            // 
            this.Cbx_Node_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Node_Type.FormattingEnabled = true;
            this.Cbx_Node_Type.Items.AddRange(new object[] {
            "ND:采集节点"});
            this.Cbx_Node_Type.Location = new System.Drawing.Point(84, 45);
            this.Cbx_Node_Type.Name = "Cbx_Node_Type";
            this.Cbx_Node_Type.Size = new System.Drawing.Size(109, 25);
            this.Cbx_Node_Type.TabIndex = 146;
            // 
            // Nud_Polling_Time
            // 
            this.Nud_Polling_Time.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Nud_Polling_Time.Location = new System.Drawing.Point(199, 46);
            this.Nud_Polling_Time.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Nud_Polling_Time.Name = "Nud_Polling_Time";
            this.Nud_Polling_Time.Size = new System.Drawing.Size(72, 23);
            this.Nud_Polling_Time.TabIndex = 145;
            this.Nud_Polling_Time.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 135;
            this.label3.Text = "固件入网序列：";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(196, 25);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 17);
            this.label22.TabIndex = 135;
            this.label22.Text = "轮询间隔(s)：";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(81, 25);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 17);
            this.label21.TabIndex = 135;
            this.label21.Text = "节点类型：";
            // 
            // Tbx_Prj_ID
            // 
            this.Tbx_Prj_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Prj_ID.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Prj_ID.Location = new System.Drawing.Point(11, 47);
            this.Tbx_Prj_ID.MaxLength = 8;
            this.Tbx_Prj_ID.Name = "Tbx_Prj_ID";
            this.Tbx_Prj_ID.Size = new System.Drawing.Size(67, 21);
            this.Tbx_Prj_ID.TabIndex = 136;
            this.Tbx_Prj_ID.Text = "JLAU0001";
            this.Tbx_Prj_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 25);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(57, 17);
            this.label20.TabIndex = 135;
            this.label20.Text = "项目ID：";
            // 
            // Btn_Get_Firmware_NetSerial
            // 
            this.Btn_Get_Firmware_NetSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Get_Firmware_NetSerial.Location = new System.Drawing.Point(167, 77);
            this.Btn_Get_Firmware_NetSerial.Name = "Btn_Get_Firmware_NetSerial";
            this.Btn_Get_Firmware_NetSerial.Size = new System.Drawing.Size(104, 45);
            this.Btn_Get_Firmware_NetSerial.TabIndex = 144;
            this.Btn_Get_Firmware_NetSerial.Text = "获取入网信息";
            this.Btn_Get_Firmware_NetSerial.UseVisualStyleBackColor = true;
            this.Btn_Get_Firmware_NetSerial.Click += new System.EventHandler(this.Btn_Get_Firmware_NetSerial_Click);
            // 
            // Tbx_New_Firmware_NewSerial
            // 
            this.Tbx_New_Firmware_NewSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_New_Firmware_NewSerial.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_New_Firmware_NewSerial.Location = new System.Drawing.Point(11, 97);
            this.Tbx_New_Firmware_NewSerial.MaxLength = 16;
            this.Tbx_New_Firmware_NewSerial.Name = "Tbx_New_Firmware_NewSerial";
            this.Tbx_New_Firmware_NewSerial.Size = new System.Drawing.Size(150, 21);
            this.Tbx_New_Firmware_NewSerial.TabIndex = 136;
            this.Tbx_New_Firmware_NewSerial.Text = "0000000000000001";
            this.Tbx_New_Firmware_NewSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_DL_All
            // 
            this.Btn_DL_All.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_DL_All.Location = new System.Drawing.Point(297, 98);
            this.Btn_DL_All.Name = "Btn_DL_All";
            this.Btn_DL_All.Size = new System.Drawing.Size(156, 51);
            this.Btn_DL_All.TabIndex = 150;
            this.Btn_DL_All.Text = "一键下载";
            this.Tt_Msg.SetToolTip(this.Btn_DL_All, "一键下载会执行【下载BL】和【下载固件】操作");
            this.Btn_DL_All.UseVisualStyleBackColor = true;
            this.Btn_DL_All.Click += new System.EventHandler(this.Btn_DL_All_Click);
            // 
            // Btn_DL_Firmware
            // 
            this.Btn_DL_Firmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DL_Firmware.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_DL_Firmware.Location = new System.Drawing.Point(375, 345);
            this.Btn_DL_Firmware.Name = "Btn_DL_Firmware";
            this.Btn_DL_Firmware.Size = new System.Drawing.Size(78, 38);
            this.Btn_DL_Firmware.TabIndex = 11;
            this.Btn_DL_Firmware.Text = "下载固件";
            this.Btn_DL_Firmware.UseVisualStyleBackColor = true;
            this.Btn_DL_Firmware.Click += new System.EventHandler(this.Btn_DL_Firmware_Click);
            // 
            // Lbx_New_Firmwares
            // 
            this.Lbx_New_Firmwares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_New_Firmwares.FormattingEnabled = true;
            this.Lbx_New_Firmwares.IntegralHeight = false;
            this.Lbx_New_Firmwares.ItemHeight = 17;
            this.Lbx_New_Firmwares.Location = new System.Drawing.Point(11, 165);
            this.Lbx_New_Firmwares.Name = "Lbx_New_Firmwares";
            this.Lbx_New_Firmwares.ScrollAlwaysVisible = true;
            this.Lbx_New_Firmwares.Size = new System.Drawing.Size(277, 218);
            this.Lbx_New_Firmwares.TabIndex = 149;
            this.Lbx_New_Firmwares.SelectedIndexChanged += new System.EventHandler(this.Lbx_New_Firmwares_SelectedIndexChanged);
            // 
            // Btn_Fresh_Firmware_List
            // 
            this.Btn_Fresh_Firmware_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Fresh_Firmware_List.Location = new System.Drawing.Point(295, 345);
            this.Btn_Fresh_Firmware_List.Name = "Btn_Fresh_Firmware_List";
            this.Btn_Fresh_Firmware_List.Size = new System.Drawing.Size(78, 38);
            this.Btn_Fresh_Firmware_List.TabIndex = 147;
            this.Btn_Fresh_Firmware_List.Text = "刷新固件";
            this.Btn_Fresh_Firmware_List.UseVisualStyleBackColor = true;
            this.Btn_Fresh_Firmware_List.Click += new System.EventHandler(this.Btn_Fresh_Firmware_List_Click);
            // 
            // Ckbx_Check_DL
            // 
            this.Ckbx_Check_DL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Check_DL.AutoSize = true;
            this.Ckbx_Check_DL.Checked = true;
            this.Ckbx_Check_DL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbx_Check_DL.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Check_DL.Location = new System.Drawing.Point(377, 44);
            this.Ckbx_Check_DL.Name = "Ckbx_Check_DL";
            this.Ckbx_Check_DL.Size = new System.Drawing.Size(78, 18);
            this.Ckbx_Check_DL.TabIndex = 145;
            this.Ckbx_Check_DL.Text = "校验下载";
            this.Ckbx_Check_DL.UseVisualStyleBackColor = true;
            // 
            // Ckbx_DL_After_Dir_Run
            // 
            this.Ckbx_DL_After_Dir_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_DL_After_Dir_Run.AutoSize = true;
            this.Ckbx_DL_After_Dir_Run.Checked = true;
            this.Ckbx_DL_After_Dir_Run.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbx_DL_After_Dir_Run.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_DL_After_Dir_Run.Location = new System.Drawing.Point(297, 70);
            this.Ckbx_DL_After_Dir_Run.Name = "Ckbx_DL_After_Dir_Run";
            this.Ckbx_DL_After_Dir_Run.Size = new System.Drawing.Size(143, 18);
            this.Ckbx_DL_After_Dir_Run.TabIndex = 146;
            this.Ckbx_DL_After_Dir_Run.Text = "下载后直接跳转运行";
            this.Ckbx_DL_After_Dir_Run.UseVisualStyleBackColor = true;
            // 
            // Tbx_Sys_Run_Adress
            // 
            this.Tbx_Sys_Run_Adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Sys_Run_Adress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Sys_Run_Adress.Location = new System.Drawing.Point(386, 312);
            this.Tbx_Sys_Run_Adress.MaxLength = 8;
            this.Tbx_Sys_Run_Adress.Name = "Tbx_Sys_Run_Adress";
            this.Tbx_Sys_Run_Adress.Size = new System.Drawing.Size(67, 21);
            this.Tbx_Sys_Run_Adress.TabIndex = 126;
            this.Tbx_Sys_Run_Adress.Text = "08000000";
            this.Tbx_Sys_Run_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Tbx_Sys_DL_Adress
            // 
            this.Tbx_Sys_DL_Adress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Sys_DL_Adress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Sys_DL_Adress.Location = new System.Drawing.Point(386, 285);
            this.Tbx_Sys_DL_Adress.MaxLength = 8;
            this.Tbx_Sys_DL_Adress.Name = "Tbx_Sys_DL_Adress";
            this.Tbx_Sys_DL_Adress.Size = new System.Drawing.Size(67, 21);
            this.Tbx_Sys_DL_Adress.TabIndex = 127;
            this.Tbx_Sys_DL_Adress.Text = "08006000";
            this.Tbx_Sys_DL_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Ckbx_Show_Time
            // 
            this.Ckbx_Show_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Show_Time.AutoSize = true;
            this.Ckbx_Show_Time.Location = new System.Drawing.Point(297, 42);
            this.Ckbx_Show_Time.Name = "Ckbx_Show_Time";
            this.Ckbx_Show_Time.Size = new System.Drawing.Size(63, 21);
            this.Ckbx_Show_Time.TabIndex = 133;
            this.Ckbx_Show_Time.Text = "时间戳";
            this.Ckbx_Show_Time.UseVisualStyleBackColor = true;
            // 
            // Tbx_New_Firmware_Time
            // 
            this.Tbx_New_Firmware_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_New_Firmware_Time.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_New_Firmware_Time.Location = new System.Drawing.Point(295, 258);
            this.Tbx_New_Firmware_Time.MaxLength = 10000;
            this.Tbx_New_Firmware_Time.Name = "Tbx_New_Firmware_Time";
            this.Tbx_New_Firmware_Time.ReadOnly = true;
            this.Tbx_New_Firmware_Time.Size = new System.Drawing.Size(85, 21);
            this.Tbx_New_Firmware_Time.TabIndex = 142;
            this.Tbx_New_Firmware_Time.Text = "无";
            this.Tbx_New_Firmware_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(294, 238);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 143;
            this.label17.Text = "更新时间：";
            // 
            // Tbx_New_Firmware_Size
            // 
            this.Tbx_New_Firmware_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_New_Firmware_Size.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_New_Firmware_Size.Location = new System.Drawing.Point(386, 258);
            this.Tbx_New_Firmware_Size.MaxLength = 10000;
            this.Tbx_New_Firmware_Size.Name = "Tbx_New_Firmware_Size";
            this.Tbx_New_Firmware_Size.ReadOnly = true;
            this.Tbx_New_Firmware_Size.Size = new System.Drawing.Size(67, 21);
            this.Tbx_New_Firmware_Size.TabIndex = 141;
            this.Tbx_New_Firmware_Size.Text = "20Kb";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(383, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 17);
            this.label16.TabIndex = 140;
            this.label16.Text = "固件大小：";
            // 
            // Tbx_New_Firmware_Name
            // 
            this.Tbx_New_Firmware_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_New_Firmware_Name.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_New_Firmware_Name.Location = new System.Drawing.Point(295, 214);
            this.Tbx_New_Firmware_Name.MaxLength = 10000;
            this.Tbx_New_Firmware_Name.Name = "Tbx_New_Firmware_Name";
            this.Tbx_New_Firmware_Name.ReadOnly = true;
            this.Tbx_New_Firmware_Name.Size = new System.Drawing.Size(158, 21);
            this.Tbx_New_Firmware_Name.TabIndex = 139;
            this.Tbx_New_Firmware_Name.Text = "无";
            this.Tbx_New_Firmware_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(292, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 17);
            this.label15.TabIndex = 137;
            this.label15.Text = "传感器型号：";
            // 
            // Cbx_New_Firmware_Version
            // 
            this.Cbx_New_Firmware_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_New_Firmware_Version.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_New_Firmware_Version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_New_Firmware_Version.DropDownWidth = 121;
            this.Cbx_New_Firmware_Version.FormattingEnabled = true;
            this.Cbx_New_Firmware_Version.Location = new System.Drawing.Point(333, 165);
            this.Cbx_New_Firmware_Version.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Cbx_New_Firmware_Version.Name = "Cbx_New_Firmware_Version";
            this.Cbx_New_Firmware_Version.Size = new System.Drawing.Size(120, 25);
            this.Cbx_New_Firmware_Version.TabIndex = 136;
            this.Cbx_New_Firmware_Version.SelectedIndexChanged += new System.EventHandler(this.Cbx_New_Firmware_Version_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 129;
            this.label13.Text = "版本：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(292, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 129;
            this.label4.Text = "下载地址：  0x";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(292, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 14);
            this.label8.TabIndex = 125;
            this.label8.Text = "运行地址：  0x";
            // 
            // Lbx_Msg
            // 
            this.Lbx_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Lbx_Msg.FormattingEnabled = true;
            this.Lbx_Msg.IntegralHeight = false;
            this.Lbx_Msg.ItemHeight = 17;
            this.Lbx_Msg.Location = new System.Drawing.Point(3, 253);
            this.Lbx_Msg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lbx_Msg.Name = "Lbx_Msg";
            this.Lbx_Msg.ScrollAlwaysVisible = true;
            this.Lbx_Msg.Size = new System.Drawing.Size(365, 206);
            this.Lbx_Msg.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Btn_Admin_Access);
            this.tabPage3.Controls.Add(this.Btn_Reset_To_Version_Default);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.Btn_Consistency_Check);
            this.tabPage3.Controls.Add(this.Btn_Update_From_Local);
            this.tabPage3.Controls.Add(this.Btn_Update_From_Server);
            this.tabPage3.Controls.Add(this.Lv_Firmware_Management);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(838, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "固件管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Btn_Admin_Access
            // 
            this.Btn_Admin_Access.Location = new System.Drawing.Point(139, 8);
            this.Btn_Admin_Access.Name = "Btn_Admin_Access";
            this.Btn_Admin_Access.Size = new System.Drawing.Size(99, 30);
            this.Btn_Admin_Access.TabIndex = 15;
            this.Btn_Admin_Access.Text = "管理入口";
            this.Btn_Admin_Access.UseVisualStyleBackColor = true;
            this.Btn_Admin_Access.Click += new System.EventHandler(this.Btn_Admin_Access_Click);
            // 
            // Btn_Reset_To_Version_Default
            // 
            this.Btn_Reset_To_Version_Default.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset_To_Version_Default.Location = new System.Drawing.Point(497, 8);
            this.Btn_Reset_To_Version_Default.Name = "Btn_Reset_To_Version_Default";
            this.Btn_Reset_To_Version_Default.Size = new System.Drawing.Size(80, 30);
            this.Btn_Reset_To_Version_Default.TabIndex = 11;
            this.Btn_Reset_To_Version_Default.Text = "重置固件库";
            this.Btn_Reset_To_Version_Default.UseVisualStyleBackColor = true;
            this.Btn_Reset_To_Version_Default.Click += new System.EventHandler(this.Btn_Reset_To_Version_Default_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Agriculture_IoT_CAN_Bus_System.Properties.Resources.swlogo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Location = new System.Drawing.Point(48, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "未登录";
            // 
            // Btn_Consistency_Check
            // 
            this.Btn_Consistency_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Consistency_Check.Location = new System.Drawing.Point(583, 8);
            this.Btn_Consistency_Check.Name = "Btn_Consistency_Check";
            this.Btn_Consistency_Check.Size = new System.Drawing.Size(80, 30);
            this.Btn_Consistency_Check.TabIndex = 3;
            this.Btn_Consistency_Check.Text = "固件校验";
            this.Btn_Consistency_Check.UseVisualStyleBackColor = true;
            this.Btn_Consistency_Check.Click += new System.EventHandler(this.Btn_Consistency_Check_Click);
            // 
            // Btn_Update_From_Local
            // 
            this.Btn_Update_From_Local.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Update_From_Local.Location = new System.Drawing.Point(669, 8);
            this.Btn_Update_From_Local.Name = "Btn_Update_From_Local";
            this.Btn_Update_From_Local.Size = new System.Drawing.Size(80, 30);
            this.Btn_Update_From_Local.TabIndex = 2;
            this.Btn_Update_From_Local.Text = "刷新列表";
            this.Btn_Update_From_Local.UseVisualStyleBackColor = true;
            this.Btn_Update_From_Local.Click += new System.EventHandler(this.Btn_Update_From_Local_Click);
            // 
            // Btn_Update_From_Server
            // 
            this.Btn_Update_From_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Update_From_Server.Location = new System.Drawing.Point(755, 8);
            this.Btn_Update_From_Server.Name = "Btn_Update_From_Server";
            this.Btn_Update_From_Server.Size = new System.Drawing.Size(80, 30);
            this.Btn_Update_From_Server.TabIndex = 1;
            this.Btn_Update_From_Server.Text = "更新数据";
            this.Btn_Update_From_Server.UseVisualStyleBackColor = true;
            this.Btn_Update_From_Server.Click += new System.EventHandler(this.Btn_Update_From_Server_Click);
            // 
            // Lv_Firmware_Management
            // 
            this.Lv_Firmware_Management.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_Firmware_Management.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Version,
            this.type_Name,
            this.group_ID,
            this.group_Name,
            this.group_Sersor,
            this.col_Size,
            this.col_Time,
            this.col_Stat});
            this.Lv_Firmware_Management.FullRowSelect = true;
            listViewGroup1.Header = "BootLoader引导程序";
            listViewGroup1.Name = "BootLoader";
            listViewGroup2.Header = "MS_10土壤温湿度传感器";
            listViewGroup2.Name = "CAN_DAB_SLTP_SLHM_MS_10";
            this.Lv_Firmware_Management.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.Lv_Firmware_Management.HideSelection = false;
            this.Lv_Firmware_Management.Location = new System.Drawing.Point(3, 46);
            this.Lv_Firmware_Management.Name = "Lv_Firmware_Management";
            this.Lv_Firmware_Management.Size = new System.Drawing.Size(832, 429);
            this.Lv_Firmware_Management.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.Lv_Firmware_Management.TabIndex = 0;
            this.Lv_Firmware_Management.UseCompatibleStateImageBehavior = false;
            this.Lv_Firmware_Management.View = System.Windows.Forms.View.Details;
            // 
            // col_Version
            // 
            this.col_Version.Text = "版本号";
            this.col_Version.Width = 90;
            // 
            // type_Name
            // 
            this.type_Name.Text = "类型名称";
            this.type_Name.Width = 90;
            // 
            // group_ID
            // 
            this.group_ID.Text = "固件编码";
            // 
            // group_Name
            // 
            this.group_Name.Text = "固件名称";
            this.group_Name.Width = 240;
            // 
            // group_Sersor
            // 
            this.group_Sersor.Text = "传感器型号";
            this.group_Sersor.Width = 100;
            // 
            // col_Size
            // 
            this.col_Size.Text = "固件大小";
            this.col_Size.Width = 70;
            // 
            // col_Time
            // 
            this.col_Time.Text = "固件更新时间";
            this.col_Time.Width = 90;
            // 
            // col_Stat
            // 
            this.col_Stat.Text = "状态";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(838, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "入网序列管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Ts_Bottom
            // 
            this.Ts_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ts_Bottom.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ts_Bottom.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Ts_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tstbx_Msg_Img,
            this.Tstbx_Msg_Txt,
            this.Tsddb_Tool_Box,
            this.Tsdbtn_Set,
            this.toolStripSeparator1,
            this.Tbx_Time_Show,
            this.toolStripSeparator3});
            this.Ts_Bottom.Location = new System.Drawing.Point(0, 518);
            this.Ts_Bottom.Name = "Ts_Bottom";
            this.Ts_Bottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Ts_Bottom.Size = new System.Drawing.Size(846, 27);
            this.Ts_Bottom.TabIndex = 10;
            this.Ts_Bottom.Text = "toolStrip1";
            // 
            // Tstbx_Msg_Img
            // 
            this.Tstbx_Msg_Img.AutoSize = false;
            this.Tstbx_Msg_Img.BackgroundImage = global::Agriculture_IoT_CAN_Bus_System.Properties.Resources.open20;
            this.Tstbx_Msg_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tstbx_Msg_Img.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.Tstbx_Msg_Img.Name = "Tstbx_Msg_Img";
            this.Tstbx_Msg_Img.Size = new System.Drawing.Size(20, 20);
            this.Tstbx_Msg_Img.Text = "    ";
            // 
            // Tstbx_Msg_Txt
            // 
            this.Tstbx_Msg_Txt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tstbx_Msg_Txt.Name = "Tstbx_Msg_Txt";
            this.Tstbx_Msg_Txt.Size = new System.Drawing.Size(44, 24);
            this.Tstbx_Msg_Txt.Text = "就绪！";
            this.Tstbx_Msg_Txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tsddb_Tool_Box
            // 
            this.Tsddb_Tool_Box.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsddb_Tool_Box.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Bottom_Calc,
            this.TsBtn_Bottom_Note});
            this.Tsddb_Tool_Box.Image = global::Agriculture_IoT_CAN_Bus_System.Properties.Resources.tools1;
            this.Tsddb_Tool_Box.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsddb_Tool_Box.Name = "Tsddb_Tool_Box";
            this.Tsddb_Tool_Box.Size = new System.Drawing.Size(73, 24);
            this.Tsddb_Tool_Box.Text = "工具箱";
            // 
            // TsBtn_Bottom_Calc
            // 
            this.TsBtn_Bottom_Calc.Name = "TsBtn_Bottom_Calc";
            this.TsBtn_Bottom_Calc.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.TsBtn_Bottom_Calc.Size = new System.Drawing.Size(193, 22);
            this.TsBtn_Bottom_Calc.Text = "计算器";
            this.TsBtn_Bottom_Calc.Click += new System.EventHandler(this.TsBtn_Bottom_Calc_Click);
            // 
            // TsBtn_Bottom_Note
            // 
            this.TsBtn_Bottom_Note.Name = "TsBtn_Bottom_Note";
            this.TsBtn_Bottom_Note.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.TsBtn_Bottom_Note.Size = new System.Drawing.Size(193, 22);
            this.TsBtn_Bottom_Note.Text = "记事本";
            this.TsBtn_Bottom_Note.Click += new System.EventHandler(this.TsBtn_Bottom_Note_Click);
            // 
            // Tsdbtn_Set
            // 
            this.Tsdbtn_Set.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsdbtn_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Window_Para_Set,
            this.TsBtn_Help,
            this.TsBtn_Exit});
            this.Tsdbtn_Set.Image = global::Agriculture_IoT_CAN_Bus_System.Properties.Resources.settings;
            this.Tsdbtn_Set.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsdbtn_Set.Name = "Tsdbtn_Set";
            this.Tsdbtn_Set.Size = new System.Drawing.Size(61, 24);
            this.Tsdbtn_Set.Text = "设置";
            // 
            // TsBtn_Window_Para_Set
            // 
            this.TsBtn_Window_Para_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Save_Window_Para,
            this.TsBtn_Reset_Window_Para});
            this.TsBtn_Window_Para_Set.Name = "TsBtn_Window_Para_Set";
            this.TsBtn_Window_Para_Set.Size = new System.Drawing.Size(124, 22);
            this.TsBtn_Window_Para_Set.Text = "窗体参数";
            // 
            // TsBtn_Save_Window_Para
            // 
            this.TsBtn_Save_Window_Para.Name = "TsBtn_Save_Window_Para";
            this.TsBtn_Save_Window_Para.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TsBtn_Save_Window_Para.Size = new System.Drawing.Size(144, 22);
            this.TsBtn_Save_Window_Para.Text = "保存";
            this.TsBtn_Save_Window_Para.Click += new System.EventHandler(this.TsBtn_Save_Window_Para_Click);
            // 
            // TsBtn_Reset_Window_Para
            // 
            this.TsBtn_Reset_Window_Para.Name = "TsBtn_Reset_Window_Para";
            this.TsBtn_Reset_Window_Para.Size = new System.Drawing.Size(144, 22);
            this.TsBtn_Reset_Window_Para.Text = "恢复默认";
            this.TsBtn_Reset_Window_Para.Click += new System.EventHandler(this.TsBtn_Reset_Window_Para_Click);
            // 
            // TsBtn_Help
            // 
            this.TsBtn_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新ToolStripMenuItem,
            this.toolStripSeparator5,
            this.TsBtn_FeedBack,
            this.TsBtn_About});
            this.TsBtn_Help.Name = "TsBtn_Help";
            this.TsBtn_Help.Size = new System.Drawing.Size(124, 22);
            this.TsBtn_Help.Text = "帮助";
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Check_Update,
            this.toolStripSeparator4,
            this.TsBtn_Start_Check_Update});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // TsBtn_Check_Update
            // 
            this.TsBtn_Check_Update.Name = "TsBtn_Check_Update";
            this.TsBtn_Check_Update.Size = new System.Drawing.Size(160, 22);
            this.TsBtn_Check_Update.Text = "检查更新";
            this.TsBtn_Check_Update.Click += new System.EventHandler(this.TsBtn_Check_Update_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // TsBtn_Start_Check_Update
            // 
            this.TsBtn_Start_Check_Update.Checked = true;
            this.TsBtn_Start_Check_Update.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TsBtn_Start_Check_Update.Name = "TsBtn_Start_Check_Update";
            this.TsBtn_Start_Check_Update.Size = new System.Drawing.Size(160, 22);
            this.TsBtn_Start_Check_Update.Text = "启动时检查更新";
            this.TsBtn_Start_Check_Update.Click += new System.EventHandler(this.TsBtn_Start_Check_Update_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(106, 6);
            // 
            // TsBtn_FeedBack
            // 
            this.TsBtn_FeedBack.Name = "TsBtn_FeedBack";
            this.TsBtn_FeedBack.Size = new System.Drawing.Size(109, 22);
            this.TsBtn_FeedBack.Text = "反馈";
            this.TsBtn_FeedBack.Click += new System.EventHandler(this.TsBtn_FeedBack_Click);
            // 
            // TsBtn_About
            // 
            this.TsBtn_About.Name = "TsBtn_About";
            this.TsBtn_About.Size = new System.Drawing.Size(109, 22);
            this.TsBtn_About.Text = "关于...";
            this.TsBtn_About.Click += new System.EventHandler(this.TsBtn_About_Click);
            // 
            // TsBtn_Exit
            // 
            this.TsBtn_Exit.Name = "TsBtn_Exit";
            this.TsBtn_Exit.Size = new System.Drawing.Size(124, 22);
            this.TsBtn_Exit.Text = "退出";
            this.TsBtn_Exit.Click += new System.EventHandler(this.TsBtn_Exit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // Tbx_Time_Show
            // 
            this.Tbx_Time_Show.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tbx_Time_Show.AutoSize = false;
            this.Tbx_Time_Show.Name = "Tbx_Time_Show";
            this.Tbx_Time_Show.Size = new System.Drawing.Size(160, 24);
            this.Tbx_Time_Show.Text = "2018年01月01日 12:00:00";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // Tmr_Clock
            // 
            this.Tmr_Clock.Enabled = true;
            this.Tmr_Clock.Interval = 1000;
            this.Tmr_Clock.Tick += new System.EventHandler(this.Tmr_Clock_Tick);
            // 
            // Tmr_Btm_Msg
            // 
            this.Tmr_Btm_Msg.Interval = 2000;
            this.Tmr_Btm_Msg.Tick += new System.EventHandler(this.Tmr_Btm_Msg_Tick);
            // 
            // Tt_Msg
            // 
            this.Tt_Msg.AutomaticDelay = 200;
            // 
            // Sp_DL
            // 
            this.Sp_DL.BaudRate = 115200;
            this.Sp_DL.Parity = System.IO.Ports.Parity.Even;
            this.Sp_DL.WriteTimeout = 1000;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(846, 545);
            this.Controls.Add(this.Tc_Main);
            this.Controls.Add(this.Ts_Bottom);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(862, 584);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SWorld开发助手（JLAU_IoT专版）";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Tc_Main.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gbx_Connect.ResumeLayout(false);
            this.Gbx_Connect.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Gbx_Net_Info.ResumeLayout(false);
            this.Gbx_Net_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Polling_Time)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Ts_Bottom.ResumeLayout(false);
            this.Ts_Bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl Tc_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip Ts_Bottom;
        private System.Windows.Forms.ToolStripLabel Tstbx_Msg_Img;
        private System.Windows.Forms.ToolStripLabel Tstbx_Msg_Txt;
        private System.Windows.Forms.ToolStripDropDownButton Tsddb_Tool_Box;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Bottom_Calc;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Bottom_Note;
        private System.Windows.Forms.ToolStripDropDownButton Tsdbtn_Set;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Window_Para_Set;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Save_Window_Para;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Reset_Window_Para;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Help;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Check_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Start_Check_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_FeedBack;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_About;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Exit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel Tbx_Time_Show;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ListBox Lbx_Msg;
        private System.Windows.Forms.ComboBox Cbx_Serial_BaudRate;
        private System.Windows.Forms.ComboBox Cbx_Serial_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Serial_Fresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView Lv_Firmware_Management;
        private System.Windows.Forms.Button Btn_DL_Firmware;
        private System.Windows.Forms.Button Btn_Read_Sys_Info;
        private System.Windows.Forms.TextBox Tbx_Sys_Run_Adress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tbx_Sys_DL_Adress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tbx_Chip_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_New_SWBL_SAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbx_Old_Firmware_Time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Tbx_Old_Firmware_Version;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tbx_Old_Firmware_Name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Tbx_Old_Firmware_NetSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tbx_Old_SWBL_Version;
        private System.Windows.Forms.GroupBox Gbx_Connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Ckbx_Show_Time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Tbx_Old_SWBL_Time;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Cbx_New_Firmware_Version;
        private System.Windows.Forms.TextBox Tbx_New_Firmware_Size;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Tbx_New_Firmware_Name;
        private System.Windows.Forms.TextBox Tbx_New_Firmware_Time;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Tbx_New_Firmware_NewSerial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Get_Firmware_NetSerial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_New_SWBL_Download;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox Cbx_New_SWBL_Version;
        private System.Windows.Forms.CheckBox Ckbx_Check_DL;
        private System.Windows.Forms.CheckBox Ckbx_DL_After_Dir_Run;
        private System.Windows.Forms.Timer Tmr_Clock;
        private System.Windows.Forms.Timer Tmr_Btm_Msg;
        private System.Windows.Forms.ToolTip Tt_Msg;
        private System.Windows.Forms.Button Btn_Fresh_Firmware_List;
        private System.Windows.Forms.ProgressBar Pgb_DL_Task_Process;
        private System.IO.Ports.SerialPort Sp_DL;
        private System.Windows.Forms.ColumnHeader col_Version;
        private System.Windows.Forms.ColumnHeader group_ID;
        private System.Windows.Forms.ColumnHeader group_Name;
        private System.Windows.Forms.ColumnHeader col_Size;
        private System.Windows.Forms.ColumnHeader col_Time;
        private System.Windows.Forms.ColumnHeader col_Stat;
        private System.Windows.Forms.ColumnHeader group_Sersor;
        private System.Windows.Forms.Button Btn_Update_From_Server;
        private My_Control.My_ListBox Lbx_New_Firmwares;
        private System.Windows.Forms.Button Btn_Update_From_Local;
        private System.Windows.Forms.Button Btn_Consistency_Check;
        private System.Windows.Forms.ColumnHeader type_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Btn_Reset_To_Version_Default;
        private System.Windows.Forms.Button Btn_Admin_Access;
        private System.Windows.Forms.Button Btn_DL_All;
        private System.Windows.Forms.TextBox Tbx_Prj_ID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox Gbx_Net_Info;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox Cbx_Node_Type;
        private System.Windows.Forms.NumericUpDown Nud_Polling_Time;
    }
}

