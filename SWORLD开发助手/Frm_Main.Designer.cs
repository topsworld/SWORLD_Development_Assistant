namespace SWORLD开发助手
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Sp_DownLoad = new System.IO.Ports.SerialPort(this.components);
            this.Ofd_DL_File = new System.Windows.Forms.OpenFileDialog();
            this.Ts_Bottom = new System.Windows.Forms.ToolStrip();
            this.Tstbx_Serial_Stat_Img = new System.Windows.Forms.ToolStripLabel();
            this.Tstbx_Serial_Stat = new System.Windows.Forms.ToolStripLabel();
            this.Tsdbtn_Set = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsBtn_Window_Para_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Save_Window_Para = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Reset_Window_Para = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_HMI_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.接收界面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送界面设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Check_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_Start_Check_Update = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtn_FeedBack = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsddb_Tool_Box = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsBtn_Bottom_Calc = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Bottom_Note = new System.Windows.Forms.ToolStripMenuItem();
            this.TsBtn_Bottom_ControlPanle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tbx_Time_Show = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Tlab_CTS_Val = new System.Windows.Forms.ToolStripLabel();
            this.Tlab_DSR_Val = new System.Windows.Forms.ToolStripLabel();
            this.Tlab_DCD_Val = new System.Windows.Forms.ToolStripLabel();
            this.Tmr_Clock = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.Sp_Debug = new System.IO.Ports.SerialPort(this.components);
            this.Tt_Msg = new System.Windows.Forms.ToolTip(this.components);
            this.Pbx_Fix = new System.Windows.Forms.PictureBox();
            this.Btn_Serial_Debug_Fresh = new System.Windows.Forms.Button();
            this.Lbx_Debug_Project = new System.Windows.Forms.ListBox();
            this.Cms_Send_Prj = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsBtn_Send_Prj_Swch = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsBtn_Send_Prj_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsBtn_Send_Prj_Del = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Debug_M_Next = new System.Windows.Forms.Button();
            this.Btn_Debug_Prj_Add = new System.Windows.Forms.Button();
            this.Btn_Debug_M_Add = new System.Windows.Forms.Button();
            this.Btn_Debug_M_First = new System.Windows.Forms.Button();
            this.Btn_Debug_M_Pre = new System.Windows.Forms.Button();
            this.Btn_Debug_M_Rmv = new System.Windows.Forms.Button();
            this.Btn_Debug_M_Last = new System.Windows.Forms.Button();
            this.Btn_Debug_M_Go_Page = new System.Windows.Forms.Button();
            this.Ckbx_DL_Auto_Close_Debug_Port = new System.Windows.Forms.CheckBox();
            this.Btn_Serial_DL_Fresh = new System.Windows.Forms.Button();
            this.Btn_Tools_GeekUninstaller = new System.Windows.Forms.Button();
            this.Btn_Tools_FolderPainter = new System.Windows.Forms.Button();
            this.Btn_Tools_EmptyFolderNuker = new System.Windows.Forms.Button();
            this.Pbx_Wxpay = new System.Windows.Forms.PictureBox();
            this.Pbx_Alipay = new System.Windows.Forms.PictureBox();
            this.Tmr_Debug_Recv = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Debug_ReSend = new System.Windows.Forms.Timer(this.components);
            this.Ofd_Debug_File = new System.Windows.Forms.OpenFileDialog();
            this.Tmr_Btm_Msg = new System.Windows.Forms.Timer(this.components);
            this.Tmr_Debug_Resend_M = new System.Windows.Forms.Timer(this.components);
            this.Tc_Main = new SWORLD开发助手.Control.TabControlPlus();
            this.Tp_Debug = new System.Windows.Forms.TabPage();
            this.Tbx_Msg_Debug = new System.Windows.Forms.TextBox();
            this.Pal_Debug_Serial_Option = new System.Windows.Forms.Panel();
            this.Lab_Debug_SerialNum = new System.Windows.Forms.Label();
            this.CBx_Debug_DataBit = new System.Windows.Forms.ComboBox();
            this.Lab_Debug_DataBit = new System.Windows.Forms.Label();
            this.Cbx_Debug_Parity = new System.Windows.Forms.ComboBox();
            this.Lab_Debug_StopBit = new System.Windows.Forms.Label();
            this.Cbx_Debug_StopBit = new System.Windows.Forms.ComboBox();
            this.Lab_Debug_CheckBit = new System.Windows.Forms.Label();
            this.Cbx_Debug_Seiral_Num = new System.Windows.Forms.ComboBox();
            this.Cbx_Debug_BaudRate = new System.Windows.Forms.ComboBox();
            this.Lab_Debug_BaudRate = new System.Windows.Forms.Label();
            this.Lab_Debug_RX = new System.Windows.Forms.Label();
            this.Lab_Debug_TX = new System.Windows.Forms.Label();
            this.Lab_Debug_RX_T = new System.Windows.Forms.Label();
            this.Btn_Debug_Clear_Recv = new System.Windows.Forms.Button();
            this.Lab_Debug_TX_T = new System.Windows.Forms.Label();
            this.Btn_Debug_Save_Window = new System.Windows.Forms.Button();
            this.Cbx_Debug_RTS_Delay = new System.Windows.Forms.ComboBox();
            this.Btn_Debug_Open_Serial = new System.Windows.Forms.Button();
            this.Ckbx_Debug_Show_Hex = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_DTR = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_RTS = new System.Windows.Forms.CheckBox();
            this.Tc_Debug = new SWORLD开发助手.Control.TabCon();
            this.Tp_Debug_Send_One = new System.Windows.Forms.TabPage();
            this.Lab_Debug_Task_Process = new System.Windows.Forms.Label();
            this.Pgb_Debug_Task_Process = new System.Windows.Forms.ProgressBar();
            this.Ckbx_Debug_Show_Time = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_Resend_Time = new System.Windows.Forms.TextBox();
            this.Lab_Debug_CycleUnit = new System.Windows.Forms.Label();
            this.Lab_Debug_Cycle = new System.Windows.Forms.Label();
            this.Ckbx_Debug_Send_Ontime = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_Send_File_Name = new System.Windows.Forms.TextBox();
            this.Btn_Debug_Select_File = new System.Windows.Forms.Button();
            this.Btn_Debug_Start_Send_File = new System.Windows.Forms.Button();
            this.Ckbx_Debug_Send_NewLine = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_Send_Hex = new System.Windows.Forms.CheckBox();
            this.Btn_Debug_Stop_Send_File = new System.Windows.Forms.Button();
            this.Tbx_Debug_Show_Time = new System.Windows.Forms.TextBox();
            this.Btn_Debug_Clear_Send = new System.Windows.Forms.Button();
            this.Btn_Debug_Send = new System.Windows.Forms.Button();
            this.Tbx_Debug_Send_One = new System.Windows.Forms.TextBox();
            this.Lab_Show_Time = new System.Windows.Forms.Label();
            this.Tp_Debug_Send_More = new System.Windows.Forms.TabPage();
            this.Tblp_Send_M = new System.Windows.Forms.TableLayoutPanel();
            this.Ckbx_Debug_M_Send_NewLine = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_M_Send_Hex = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_M_Con_NumKey = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_M_Resend = new System.Windows.Forms.CheckBox();
            this.Pal_Debug_MutilCycleSet = new System.Windows.Forms.Panel();
            this.Tbx_Debug_M_Resend_Time = new System.Windows.Forms.TextBox();
            this.Lab_Debug_MutilCycle = new System.Windows.Forms.Label();
            this.Lab_Debug_MutilCycleUnit = new System.Windows.Forms.Label();
            this.Btn_Debug_M5 = new System.Windows.Forms.Button();
            this.Btn_Debug_M6 = new System.Windows.Forms.Button();
            this.Btn_Debug_M7 = new System.Windows.Forms.Button();
            this.Btn_Debug_M8 = new System.Windows.Forms.Button();
            this.Btn_Debug_M9 = new System.Windows.Forms.Button();
            this.Ckbx_Debug_M5 = new System.Windows.Forms.CheckBox();
            this.Ckbx_Debug_M6 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_Project = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M4 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_M4 = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M3 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_M3 = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M2 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_M2 = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M1 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_M9 = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M0 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_M8 = new System.Windows.Forms.TextBox();
            this.Tbx_Debug_M7 = new System.Windows.Forms.TextBox();
            this.Tbx_Debug_M1 = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M7 = new System.Windows.Forms.CheckBox();
            this.Tbx_Debug_M0 = new System.Windows.Forms.TextBox();
            this.Ckbx_Debug_M8 = new System.Windows.Forms.CheckBox();
            this.Btn_Debug_M4 = new System.Windows.Forms.Button();
            this.Ckbx_Debug_M9 = new System.Windows.Forms.CheckBox();
            this.Btn_Debug_M3 = new System.Windows.Forms.Button();
            this.Tbx_Debug_M6 = new System.Windows.Forms.TextBox();
            this.Btn_Debug_M2 = new System.Windows.Forms.Button();
            this.Tbx_Debug_M5 = new System.Windows.Forms.TextBox();
            this.Btn_Debug_M1 = new System.Windows.Forms.Button();
            this.Btn_Debug_M0 = new System.Windows.Forms.Button();
            this.Pal_Debug_SwitchProject = new System.Windows.Forms.Panel();
            this.Lab_Debug_Switch_ProjectTip = new System.Windows.Forms.Label();
            this.Lab_Debug_M_Page = new System.Windows.Forms.Label();
            this.Tbx_Debug_M_Go_Page = new System.Windows.Forms.TextBox();
            this.Lab_Debug_Sort2 = new System.Windows.Forms.Label();
            this.Lab_Debug_Sort1 = new System.Windows.Forms.Label();
            this.Pal_Debug_Operate = new System.Windows.Forms.Panel();
            this.Btn_Debug_M_Output = new System.Windows.Forms.Button();
            this.Tp_Debug_Send_Protocol = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.Lab_Debug_Delay = new System.Windows.Forms.Label();
            this.Lab_Debug_Operate = new System.Windows.Forms.Label();
            this.Tp_DL = new System.Windows.Forms.TabPage();
            this.Cbx_DL_BaudRate = new System.Windows.Forms.ComboBox();
            this.Pgb_DL_Task_Process = new System.Windows.Forms.ProgressBar();
            this.Cbx_DL_Serial_Num = new System.Windows.Forms.ComboBox();
            this.Gbx_Option_Byte = new System.Windows.Forms.GroupBox();
            this.Lab_DL_UserDataByteExplain2 = new System.Windows.Forms.Label();
            this.Lab_DL_UserDataByteExplain1 = new System.Windows.Forms.Label();
            this.Tbx_DL_User_Data2 = new System.Windows.Forms.TextBox();
            this.Tbx_DL_User_Data1 = new System.Windows.Forms.TextBox();
            this.Lab_DL_UserDataByte0x2 = new System.Windows.Forms.Label();
            this.Lab_DL_UserDataByte0x1 = new System.Windows.Forms.Label();
            this.Lab_DL_UserDataByte = new System.Windows.Forms.Label();
            this.Lab_DL_WriteProtectedByteExplain4 = new System.Windows.Forms.Label();
            this.Lab_DL_WriteProtectedByteExplain3 = new System.Windows.Forms.Label();
            this.Tbx_DL_Write_Protect4 = new System.Windows.Forms.TextBox();
            this.Tbx_DL_Write_Protect3 = new System.Windows.Forms.TextBox();
            this.Lab_DL_WriteProtectedByte0x4 = new System.Windows.Forms.Label();
            this.Lab_DL_WriteProtectedByte0x3 = new System.Windows.Forms.Label();
            this.Tbx_DL_HW_Byte = new System.Windows.Forms.TextBox();
            this.Lab_DL_WriteProtectedByteExplain2 = new System.Windows.Forms.Label();
            this.Lab_DL_WriteProtectedByteExplain1 = new System.Windows.Forms.Label();
            this.Tbx_DL_Write_Protect2 = new System.Windows.Forms.TextBox();
            this.Lab_DL_HardwareOptionByte0x = new System.Windows.Forms.Label();
            this.Tbx_DL_Read_Protect = new System.Windows.Forms.TextBox();
            this.Tbx_DL_Write_Protect1 = new System.Windows.Forms.TextBox();
            this.Lab_DL_WriteProtectedByte = new System.Windows.Forms.Label();
            this.Lab_DL_HardwareOptionByteExplain = new System.Windows.Forms.Label();
            this.Lab_DL_HardwareOptionByte = new System.Windows.Forms.Label();
            this.Btn_DetailSet = new System.Windows.Forms.Button();
            this.Lab_DL_ReadProtectByteExplain = new System.Windows.Forms.Label();
            this.Lab_DL_ReadProtectedByte = new System.Windows.Forms.Label();
            this.Btn_Option_Set_Default = new System.Windows.Forms.Button();
            this.Ckbx_DL_Write_Option_Byte = new System.Windows.Forms.CheckBox();
            this.Lab_DL_WriteProtectedByte0x2 = new System.Windows.Forms.Label();
            this.Lab_DL_WriteProtectedByte0x1 = new System.Windows.Forms.Label();
            this.Lab_DL_ReadProtectByte0x = new System.Windows.Forms.Label();
            this.Lbx_Msg_DL = new SWORLD开发助手.Control.ListBoxPlus();
            this.Gbx_DL_Option = new System.Windows.Forms.GroupBox();
            this.Ckbx_Set_Read_Protect = new System.Windows.Forms.CheckBox();
            this.Ckbx_DL_Show_Time = new System.Windows.Forms.CheckBox();
            this.Cbx_Auto_DL = new System.Windows.Forms.CheckBox();
            this.Lab_EraseWay = new System.Windows.Forms.Label();
            this.Tbx_DL_Adress = new System.Windows.Forms.TextBox();
            this.Rbtn_Erase_Part = new System.Windows.Forms.RadioButton();
            this.Ckbx_Check = new System.Windows.Forms.CheckBox();
            this.Ckbx_Auto_Match = new System.Windows.Forms.CheckBox();
            this.Rbtn_Erase_All = new System.Windows.Forms.RadioButton();
            this.Cbx_Go_BL_Way = new System.Windows.Forms.ComboBox();
            this.Lab_DownloadStartAddress = new System.Windows.Forms.Label();
            this.Tbx_Run_Adress = new System.Windows.Forms.TextBox();
            this.Lab_ProgramRunAddress = new System.Windows.Forms.Label();
            this.Ckbx_DL_After_Dir_Run = new System.Windows.Forms.CheckBox();
            this.Lab_DL_BaudRate = new System.Windows.Forms.Label();
            this.Lab_DL_SerialNum = new System.Windows.Forms.Label();
            this.Tbx_DL_File_Path = new System.Windows.Forms.TextBox();
            this.Btn_DL_Erase_Chip = new System.Windows.Forms.Button();
            this.Btn_DL_Select_File = new System.Windows.Forms.Button();
            this.Btn_DL_Read_Chip_Info = new System.Windows.Forms.Button();
            this.Btn_DL_DownLoad_File = new System.Windows.Forms.Button();
            this.Lab_DownloadFilePath = new System.Windows.Forms.Label();
            this.Tp_Tools = new System.Windows.Forms.TabPage();
            this.TlPal_Tools = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Tools_FileEncryptionDecrypt = new System.Windows.Forms.Button();
            this.Btn_Tools_TTS = new System.Windows.Forms.Button();
            this.Btn_Tools_FontCreate = new System.Windows.Forms.Button();
            this.Btn_Tools_CalcTransf = new System.Windows.Forms.Button();
            this.Btn_Tools_FileMerge = new System.Windows.Forms.Button();
            this.Btn_Tools_BinEditor = new System.Windows.Forms.Button();
            this.Btn_Tools_CodeFormat = new System.Windows.Forms.Button();
            this.Btn_Tools_QrCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Tools_FileTimeAlter = new System.Windows.Forms.Button();
            this.Btn_Tools_ResourceList = new System.Windows.Forms.Button();
            this.Btn_Tools_ToolsPanel = new System.Windows.Forms.Button();
            this.Tp_Code = new System.Windows.Forms.TabPage();
            this.Spc_Code_Lib = new System.Windows.Forms.SplitContainer();
            this.label44 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Tp_Type = new System.Windows.Forms.TabPage();
            this.Spc_DL = new System.Windows.Forms.SplitContainer();
            this.label34 = new System.Windows.Forms.Label();
            this.Tp_Help = new System.Windows.Forms.TabPage();
            this.Llab_PersonHomePage = new System.Windows.Forms.LinkLabel();
            this.Llab_PersonEmail = new System.Windows.Forms.LinkLabel();
            this.Tbx_Help = new System.Windows.Forms.TextBox();
            this.Lab_Personal_Elucidation = new System.Windows.Forms.Label();
            this.Lab_Copyright = new System.Windows.Forms.Label();
            this.Lab_Donate = new System.Windows.Forms.Label();
            this.Pbx_SWORLD = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Ts_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fix)).BeginInit();
            this.Cms_Send_Prj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Wxpay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Alipay)).BeginInit();
            this.Tc_Main.SuspendLayout();
            this.Tp_Debug.SuspendLayout();
            this.Pal_Debug_Serial_Option.SuspendLayout();
            this.Tc_Debug.SuspendLayout();
            this.Tp_Debug_Send_One.SuspendLayout();
            this.Tp_Debug_Send_More.SuspendLayout();
            this.Tblp_Send_M.SuspendLayout();
            this.Pal_Debug_MutilCycleSet.SuspendLayout();
            this.Pal_Debug_SwitchProject.SuspendLayout();
            this.Pal_Debug_Operate.SuspendLayout();
            this.Tp_Debug_Send_Protocol.SuspendLayout();
            this.Tp_DL.SuspendLayout();
            this.Gbx_Option_Byte.SuspendLayout();
            this.Gbx_DL_Option.SuspendLayout();
            this.Tp_Tools.SuspendLayout();
            this.TlPal_Tools.SuspendLayout();
            this.Tp_Code.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Code_Lib)).BeginInit();
            this.Spc_Code_Lib.Panel1.SuspendLayout();
            this.Spc_Code_Lib.Panel2.SuspendLayout();
            this.Spc_Code_Lib.SuspendLayout();
            this.Tp_Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_DL)).BeginInit();
            this.Spc_DL.Panel1.SuspendLayout();
            this.Spc_DL.SuspendLayout();
            this.Tp_Help.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_SWORLD)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_DownLoad
            // 
            this.Sp_DownLoad.BaudRate = 115200;
            this.Sp_DownLoad.Parity = System.IO.Ports.Parity.Even;
            this.Sp_DownLoad.WriteTimeout = 1000;
            // 
            // Ofd_DL_File
            // 
            this.Ofd_DL_File.Filter = "HEX文件|*.hex|BIN文件|*.bin";
            this.Ofd_DL_File.Title = "选择下载文件";
            // 
            // Ts_Bottom
            // 
            this.Ts_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ts_Bottom.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ts_Bottom.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Ts_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tstbx_Serial_Stat_Img,
            this.Tstbx_Serial_Stat,
            this.Tsdbtn_Set,
            this.Tsddb_Tool_Box,
            this.toolStripSeparator1,
            this.Tbx_Time_Show,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.Tlab_CTS_Val,
            this.Tlab_DSR_Val,
            this.Tlab_DCD_Val});
            this.Ts_Bottom.Location = new System.Drawing.Point(0, 514);
            this.Ts_Bottom.Name = "Ts_Bottom";
            this.Ts_Bottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Ts_Bottom.Size = new System.Drawing.Size(784, 27);
            this.Ts_Bottom.TabIndex = 9;
            this.Ts_Bottom.Text = "toolStrip1";
            // 
            // Tstbx_Serial_Stat_Img
            // 
            this.Tstbx_Serial_Stat_Img.AutoSize = false;
            this.Tstbx_Serial_Stat_Img.BackgroundImage = global::SWORLD开发助手.Properties.Resources.close20;
            this.Tstbx_Serial_Stat_Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tstbx_Serial_Stat_Img.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.Tstbx_Serial_Stat_Img.Name = "Tstbx_Serial_Stat_Img";
            this.Tstbx_Serial_Stat_Img.Size = new System.Drawing.Size(20, 20);
            this.Tstbx_Serial_Stat_Img.Text = "    ";
            // 
            // Tstbx_Serial_Stat
            // 
            this.Tstbx_Serial_Stat.AutoSize = false;
            this.Tstbx_Serial_Stat.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tstbx_Serial_Stat.Name = "Tstbx_Serial_Stat";
            this.Tstbx_Serial_Stat.Size = new System.Drawing.Size(320, 24);
            this.Tstbx_Serial_Stat.Text = "下载串口已关闭！";
            this.Tstbx_Serial_Stat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tsdbtn_Set
            // 
            this.Tsdbtn_Set.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsdbtn_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Window_Para_Set,
            this.TsBtn_HMI_Set,
            this.TsBtn_Help,
            this.TsBtn_Exit});
            this.Tsdbtn_Set.Image = global::SWORLD开发助手.Properties.Resources.settings;
            this.Tsdbtn_Set.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsdbtn_Set.Name = "Tsdbtn_Set";
            this.Tsdbtn_Set.Size = new System.Drawing.Size(64, 24);
            this.Tsdbtn_Set.Text = "设置";
            // 
            // TsBtn_Window_Para_Set
            // 
            this.TsBtn_Window_Para_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Save_Window_Para,
            this.TsBtn_Reset_Window_Para});
            this.TsBtn_Window_Para_Set.Name = "TsBtn_Window_Para_Set";
            this.TsBtn_Window_Para_Set.Size = new System.Drawing.Size(130, 22);
            this.TsBtn_Window_Para_Set.Text = "窗体参数";
            // 
            // TsBtn_Save_Window_Para
            // 
            this.TsBtn_Save_Window_Para.Name = "TsBtn_Save_Window_Para";
            this.TsBtn_Save_Window_Para.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TsBtn_Save_Window_Para.Size = new System.Drawing.Size(146, 22);
            this.TsBtn_Save_Window_Para.Text = "保存";
            this.TsBtn_Save_Window_Para.Click += new System.EventHandler(this.TsBtn_Save_Window_Para_Click);
            // 
            // TsBtn_Reset_Window_Para
            // 
            this.TsBtn_Reset_Window_Para.Name = "TsBtn_Reset_Window_Para";
            this.TsBtn_Reset_Window_Para.Size = new System.Drawing.Size(146, 22);
            this.TsBtn_Reset_Window_Para.Text = "恢复默认";
            this.TsBtn_Reset_Window_Para.Click += new System.EventHandler(this.TsBtn_Reset_Window_Para_Click);
            // 
            // TsBtn_HMI_Set
            // 
            this.TsBtn_HMI_Set.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接收界面设置ToolStripMenuItem,
            this.发送界面设置ToolStripMenuItem});
            this.TsBtn_HMI_Set.Name = "TsBtn_HMI_Set";
            this.TsBtn_HMI_Set.Size = new System.Drawing.Size(130, 22);
            this.TsBtn_HMI_Set.Text = "界面设置";
            this.TsBtn_HMI_Set.Click += new System.EventHandler(this.TsBtn_HMI_Set_Click);
            // 
            // 接收界面设置ToolStripMenuItem
            // 
            this.接收界面设置ToolStripMenuItem.Name = "接收界面设置ToolStripMenuItem";
            this.接收界面设置ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.接收界面设置ToolStripMenuItem.Text = "接收界面设置";
            // 
            // 发送界面设置ToolStripMenuItem
            // 
            this.发送界面设置ToolStripMenuItem.Name = "发送界面设置ToolStripMenuItem";
            this.发送界面设置ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.发送界面设置ToolStripMenuItem.Text = "发送界面设置";
            // 
            // TsBtn_Help
            // 
            this.TsBtn_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新ToolStripMenuItem,
            this.toolStripSeparator5,
            this.TsBtn_FeedBack,
            this.TsBtn_About});
            this.TsBtn_Help.Name = "TsBtn_Help";
            this.TsBtn_Help.Size = new System.Drawing.Size(130, 22);
            this.TsBtn_Help.Text = "帮助";
            this.TsBtn_Help.Click += new System.EventHandler(this.TsBtn_Help_Click);
            // 
            // 更新ToolStripMenuItem
            // 
            this.更新ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Check_Update,
            this.toolStripSeparator4,
            this.TsBtn_Start_Check_Update});
            this.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem";
            this.更新ToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.更新ToolStripMenuItem.Text = "更新";
            // 
            // TsBtn_Check_Update
            // 
            this.TsBtn_Check_Update.Name = "TsBtn_Check_Update";
            this.TsBtn_Check_Update.Size = new System.Drawing.Size(172, 22);
            this.TsBtn_Check_Update.Text = "检查更新";
            this.TsBtn_Check_Update.Click += new System.EventHandler(this.TsBtn_Check_Update_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(169, 6);
            // 
            // TsBtn_Start_Check_Update
            // 
            this.TsBtn_Start_Check_Update.Checked = true;
            this.TsBtn_Start_Check_Update.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TsBtn_Start_Check_Update.Name = "TsBtn_Start_Check_Update";
            this.TsBtn_Start_Check_Update.Size = new System.Drawing.Size(172, 22);
            this.TsBtn_Start_Check_Update.Text = "启动时检查更新";
            this.TsBtn_Start_Check_Update.Click += new System.EventHandler(this.TsBtn_Start_Check_Update_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(108, 6);
            // 
            // TsBtn_FeedBack
            // 
            this.TsBtn_FeedBack.Name = "TsBtn_FeedBack";
            this.TsBtn_FeedBack.Size = new System.Drawing.Size(111, 22);
            this.TsBtn_FeedBack.Text = "反馈";
            this.TsBtn_FeedBack.Click += new System.EventHandler(this.TsBtn_FeedBack_Click);
            // 
            // TsBtn_About
            // 
            this.TsBtn_About.Name = "TsBtn_About";
            this.TsBtn_About.Size = new System.Drawing.Size(111, 22);
            this.TsBtn_About.Text = "关于...";
            this.TsBtn_About.Click += new System.EventHandler(this.TsBtn_About_Click);
            // 
            // TsBtn_Exit
            // 
            this.TsBtn_Exit.Name = "TsBtn_Exit";
            this.TsBtn_Exit.Size = new System.Drawing.Size(130, 22);
            this.TsBtn_Exit.Text = "退出";
            this.TsBtn_Exit.Click += new System.EventHandler(this.TsBtn_Exit_Click);
            // 
            // Tsddb_Tool_Box
            // 
            this.Tsddb_Tool_Box.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Tsddb_Tool_Box.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsddb_Tool_Box.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtn_Bottom_Calc,
            this.TsBtn_Bottom_Note,
            this.TsBtn_Bottom_ControlPanle});
            this.Tsddb_Tool_Box.Image = global::SWORLD开发助手.Properties.Resources.tools;
            this.Tsddb_Tool_Box.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsddb_Tool_Box.Name = "Tsddb_Tool_Box";
            this.Tsddb_Tool_Box.Size = new System.Drawing.Size(29, 24);
            // 
            // TsBtn_Bottom_Calc
            // 
            this.TsBtn_Bottom_Calc.Name = "TsBtn_Bottom_Calc";
            this.TsBtn_Bottom_Calc.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.TsBtn_Bottom_Calc.Size = new System.Drawing.Size(210, 22);
            this.TsBtn_Bottom_Calc.Text = "计算器";
            this.TsBtn_Bottom_Calc.Click += new System.EventHandler(this.Tsbtn_Bottom_Calc_Click);
            // 
            // TsBtn_Bottom_Note
            // 
            this.TsBtn_Bottom_Note.Name = "TsBtn_Bottom_Note";
            this.TsBtn_Bottom_Note.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.TsBtn_Bottom_Note.Size = new System.Drawing.Size(210, 22);
            this.TsBtn_Bottom_Note.Text = "记事本";
            this.TsBtn_Bottom_Note.Click += new System.EventHandler(this.Tsbtn_Bottom_Note_Click);
            // 
            // TsBtn_Bottom_ControlPanle
            // 
            this.TsBtn_Bottom_ControlPanle.Name = "TsBtn_Bottom_ControlPanle";
            this.TsBtn_Bottom_ControlPanle.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.TsBtn_Bottom_ControlPanle.Size = new System.Drawing.Size(210, 22);
            this.TsBtn_Bottom_ControlPanle.Text = "控制面板";
            this.TsBtn_Bottom_ControlPanle.Click += new System.EventHandler(this.TsBtn_Bottom_ControlPanle_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // Tlab_CTS_Val
            // 
            this.Tlab_CTS_Val.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tlab_CTS_Val.Margin = new System.Windows.Forms.Padding(0);
            this.Tlab_CTS_Val.Name = "Tlab_CTS_Val";
            this.Tlab_CTS_Val.Size = new System.Drawing.Size(46, 27);
            this.Tlab_CTS_Val.Text = "CTS=0";
            this.Tlab_CTS_Val.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tlab_DSR_Val
            // 
            this.Tlab_DSR_Val.Name = "Tlab_DSR_Val";
            this.Tlab_DSR_Val.Size = new System.Drawing.Size(48, 24);
            this.Tlab_DSR_Val.Text = "DSR=0";
            // 
            // Tlab_DCD_Val
            // 
            this.Tlab_DCD_Val.Name = "Tlab_DCD_Val";
            this.Tlab_DCD_Val.Size = new System.Drawing.Size(52, 24);
            this.Tlab_DCD_Val.Text = "DCD=0";
            // 
            // Tmr_Clock
            // 
            this.Tmr_Clock.Enabled = true;
            this.Tmr_Clock.Interval = 1000;
            this.Tmr_Clock.Tick += new System.EventHandler(this.Tmr_Clock_Tick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(236, 178);
            // 
            // Sp_Debug
            // 
            this.Sp_Debug.ReadBufferSize = 40960;
            this.Sp_Debug.WriteBufferSize = 20480;
            this.Sp_Debug.WriteTimeout = 10;
            this.Sp_Debug.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.Sp_Debug_ErrorReceived);
            this.Sp_Debug.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.Sp_Debug_PinChanged);
            this.Sp_Debug.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Sp_Debug_DataReceived);
            // 
            // Tt_Msg
            // 
            this.Tt_Msg.AutomaticDelay = 200;
            // 
            // Pbx_Fix
            // 
            this.Pbx_Fix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Fix.BackColor = System.Drawing.Color.White;
            this.Pbx_Fix.Image = global::SWORLD开发助手.Properties.Resources.unfix;
            this.Pbx_Fix.Location = new System.Drawing.Point(755, 3);
            this.Pbx_Fix.Name = "Pbx_Fix";
            this.Pbx_Fix.Size = new System.Drawing.Size(20, 20);
            this.Pbx_Fix.TabIndex = 10;
            this.Pbx_Fix.TabStop = false;
            this.Tt_Msg.SetToolTip(this.Pbx_Fix, "置于顶层");
            this.Pbx_Fix.Click += new System.EventHandler(this.Pbx_Fix_Click);
            // 
            // Btn_Serial_Debug_Fresh
            // 
            this.Btn_Serial_Debug_Fresh.BackgroundImage = global::SWORLD开发助手.Properties.Resources.refresh24;
            this.Btn_Serial_Debug_Fresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Serial_Debug_Fresh.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Serial_Debug_Fresh.Location = new System.Drawing.Point(138, 18);
            this.Btn_Serial_Debug_Fresh.Name = "Btn_Serial_Debug_Fresh";
            this.Btn_Serial_Debug_Fresh.Size = new System.Drawing.Size(24, 24);
            this.Btn_Serial_Debug_Fresh.TabIndex = 26;
            this.Tt_Msg.SetToolTip(this.Btn_Serial_Debug_Fresh, "刷新串口");
            this.Btn_Serial_Debug_Fresh.UseVisualStyleBackColor = true;
            this.Btn_Serial_Debug_Fresh.Click += new System.EventHandler(this.Btn_Debug_Fresh_Click);
            // 
            // Lbx_Debug_Project
            // 
            this.Lbx_Debug_Project.ContextMenuStrip = this.Cms_Send_Prj;
            this.Lbx_Debug_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbx_Debug_Project.FormattingEnabled = true;
            this.Lbx_Debug_Project.IntegralHeight = false;
            this.Lbx_Debug_Project.ItemHeight = 14;
            this.Lbx_Debug_Project.Location = new System.Drawing.Point(3, 2);
            this.Lbx_Debug_Project.Margin = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.Lbx_Debug_Project.Name = "Lbx_Debug_Project";
            this.Tblp_Send_M.SetRowSpan(this.Lbx_Debug_Project, 5);
            this.Lbx_Debug_Project.ScrollAlwaysVisible = true;
            this.Lbx_Debug_Project.Size = new System.Drawing.Size(103, 121);
            this.Lbx_Debug_Project.TabIndex = 0;
            this.Tt_Msg.SetToolTip(this.Lbx_Debug_Project, "双击切换项目");
            this.Lbx_Debug_Project.DoubleClick += new System.EventHandler(this.Lbx_Debug_Project_DoubleClick);
            // 
            // Cms_Send_Prj
            // 
            this.Cms_Send_Prj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsBtn_Send_Prj_Swch,
            this.CmsBtn_Send_Prj_Add,
            this.CmsBtn_Send_Prj_Del});
            this.Cms_Send_Prj.Name = "Cms_Send_Prj";
            this.Cms_Send_Prj.ShowImageMargin = false;
            this.Cms_Send_Prj.Size = new System.Drawing.Size(136, 70);
            // 
            // CmsBtn_Send_Prj_Swch
            // 
            this.CmsBtn_Send_Prj_Swch.Name = "CmsBtn_Send_Prj_Swch";
            this.CmsBtn_Send_Prj_Swch.Size = new System.Drawing.Size(135, 22);
            this.CmsBtn_Send_Prj_Swch.Text = "切换至选中项目";
            this.CmsBtn_Send_Prj_Swch.Click += new System.EventHandler(this.CmsBtn_Send_Prj_Swch_Click);
            // 
            // CmsBtn_Send_Prj_Add
            // 
            this.CmsBtn_Send_Prj_Add.Name = "CmsBtn_Send_Prj_Add";
            this.CmsBtn_Send_Prj_Add.Size = new System.Drawing.Size(135, 22);
            this.CmsBtn_Send_Prj_Add.Text = "添加新项目";
            this.CmsBtn_Send_Prj_Add.Click += new System.EventHandler(this.CmsBtn_Send_Prj_Add_Click);
            // 
            // CmsBtn_Send_Prj_Del
            // 
            this.CmsBtn_Send_Prj_Del.Name = "CmsBtn_Send_Prj_Del";
            this.CmsBtn_Send_Prj_Del.Size = new System.Drawing.Size(135, 22);
            this.CmsBtn_Send_Prj_Del.Text = "删除选中项目";
            this.CmsBtn_Send_Prj_Del.Click += new System.EventHandler(this.CmsBtn_Send_Prj_Del_Click);
            // 
            // Btn_Debug_M_Next
            // 
            this.Btn_Debug_M_Next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Debug_M_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Debug_M_Next.BackgroundImage")));
            this.Btn_Debug_M_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_M_Next.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_M_Next.Location = new System.Drawing.Point(320, 2);
            this.Btn_Debug_M_Next.Name = "Btn_Debug_M_Next";
            this.Btn_Debug_M_Next.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_M_Next.TabIndex = 26;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_Next, "下一页");
            this.Btn_Debug_M_Next.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Next.Click += new System.EventHandler(this.Btn_Debug_M_Next_Click);
            // 
            // Btn_Debug_Prj_Add
            // 
            this.Btn_Debug_Prj_Add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Debug_Prj_Add.BackgroundImage = global::SWORLD开发助手.Properties.Resources.pro_add;
            this.Btn_Debug_Prj_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Debug_Prj_Add.Location = new System.Drawing.Point(3, 2);
            this.Btn_Debug_Prj_Add.Name = "Btn_Debug_Prj_Add";
            this.Btn_Debug_Prj_Add.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_Prj_Add.TabIndex = 31;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_Prj_Add, "新建项目");
            this.Btn_Debug_Prj_Add.UseVisualStyleBackColor = true;
            this.Btn_Debug_Prj_Add.Click += new System.EventHandler(this.Btn_Debug_Prj_Add_Click);
            // 
            // Btn_Debug_M_Add
            // 
            this.Btn_Debug_M_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Debug_M_Add.BackgroundImage = global::SWORLD开发助手.Properties.Resources.page_add;
            this.Btn_Debug_M_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_M_Add.Location = new System.Drawing.Point(119, 2);
            this.Btn_Debug_M_Add.Name = "Btn_Debug_M_Add";
            this.Btn_Debug_M_Add.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_M_Add.TabIndex = 22;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_Add, "添加页码");
            this.Btn_Debug_M_Add.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Add.Click += new System.EventHandler(this.Btn_Debug_M_Add_Click);
            // 
            // Btn_Debug_M_First
            // 
            this.Btn_Debug_M_First.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Debug_M_First.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Debug_M_First.BackgroundImage")));
            this.Btn_Debug_M_First.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_M_First.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_M_First.Location = new System.Drawing.Point(198, 2);
            this.Btn_Debug_M_First.Name = "Btn_Debug_M_First";
            this.Btn_Debug_M_First.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_M_First.TabIndex = 24;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_First, "首页");
            this.Btn_Debug_M_First.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_First.Click += new System.EventHandler(this.Btn_Debug_M_First_Click);
            // 
            // Btn_Debug_M_Pre
            // 
            this.Btn_Debug_M_Pre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Debug_M_Pre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Debug_M_Pre.BackgroundImage")));
            this.Btn_Debug_M_Pre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_M_Pre.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_M_Pre.Location = new System.Drawing.Point(229, 2);
            this.Btn_Debug_M_Pre.Name = "Btn_Debug_M_Pre";
            this.Btn_Debug_M_Pre.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_M_Pre.TabIndex = 25;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_Pre, "上一页");
            this.Btn_Debug_M_Pre.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Pre.Click += new System.EventHandler(this.Btn_Debug_M_Pre_Click);
            // 
            // Btn_Debug_M_Rmv
            // 
            this.Btn_Debug_M_Rmv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Debug_M_Rmv.BackgroundImage = global::SWORLD开发助手.Properties.Resources.page_rmv;
            this.Btn_Debug_M_Rmv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_M_Rmv.Location = new System.Drawing.Point(150, 2);
            this.Btn_Debug_M_Rmv.Name = "Btn_Debug_M_Rmv";
            this.Btn_Debug_M_Rmv.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_M_Rmv.TabIndex = 23;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_Rmv, "移除本页");
            this.Btn_Debug_M_Rmv.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Rmv.Click += new System.EventHandler(this.Btn_Debug_M_Rmv_Click);
            // 
            // Btn_Debug_M_Last
            // 
            this.Btn_Debug_M_Last.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Debug_M_Last.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Debug_M_Last.BackgroundImage")));
            this.Btn_Debug_M_Last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_M_Last.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_M_Last.Location = new System.Drawing.Point(350, 2);
            this.Btn_Debug_M_Last.Name = "Btn_Debug_M_Last";
            this.Btn_Debug_M_Last.Size = new System.Drawing.Size(24, 24);
            this.Btn_Debug_M_Last.TabIndex = 27;
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_Last, "尾页");
            this.Btn_Debug_M_Last.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Last.Click += new System.EventHandler(this.Btn_Debug_M_Last_Click);
            // 
            // Btn_Debug_M_Go_Page
            // 
            this.Btn_Debug_M_Go_Page.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Debug_M_Go_Page.Location = new System.Drawing.Point(44, 2);
            this.Btn_Debug_M_Go_Page.Name = "Btn_Debug_M_Go_Page";
            this.Btn_Debug_M_Go_Page.Size = new System.Drawing.Size(52, 24);
            this.Btn_Debug_M_Go_Page.TabIndex = 29;
            this.Btn_Debug_M_Go_Page.Text = "跳转";
            this.Tt_Msg.SetToolTip(this.Btn_Debug_M_Go_Page, "跳转到指定页");
            this.Btn_Debug_M_Go_Page.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Go_Page.Click += new System.EventHandler(this.Btn_Debug_M_Go_Page_Click);
            // 
            // Ckbx_DL_Auto_Close_Debug_Port
            // 
            this.Ckbx_DL_Auto_Close_Debug_Port.AutoSize = true;
            this.Ckbx_DL_Auto_Close_Debug_Port.Checked = true;
            this.Ckbx_DL_Auto_Close_Debug_Port.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbx_DL_Auto_Close_Debug_Port.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_DL_Auto_Close_Debug_Port.Location = new System.Drawing.Point(266, 80);
            this.Ckbx_DL_Auto_Close_Debug_Port.Name = "Ckbx_DL_Auto_Close_Debug_Port";
            this.Ckbx_DL_Auto_Close_Debug_Port.Size = new System.Drawing.Size(130, 18);
            this.Ckbx_DL_Auto_Close_Debug_Port.TabIndex = 12;
            this.Ckbx_DL_Auto_Close_Debug_Port.Text = "自动关闭调试串口";
            this.Tt_Msg.SetToolTip(this.Ckbx_DL_Auto_Close_Debug_Port, "当本软件调试串口和下载串口冲突时，自动关闭调试串口，用于程序下载！");
            this.Ckbx_DL_Auto_Close_Debug_Port.UseVisualStyleBackColor = true;
            // 
            // Btn_Serial_DL_Fresh
            // 
            this.Btn_Serial_DL_Fresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Serial_DL_Fresh.BackgroundImage = global::SWORLD开发助手.Properties.Resources.refresh24;
            this.Btn_Serial_DL_Fresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Serial_DL_Fresh.Location = new System.Drawing.Point(750, 8);
            this.Btn_Serial_DL_Fresh.Name = "Btn_Serial_DL_Fresh";
            this.Btn_Serial_DL_Fresh.Size = new System.Drawing.Size(26, 26);
            this.Btn_Serial_DL_Fresh.TabIndex = 114;
            this.Tt_Msg.SetToolTip(this.Btn_Serial_DL_Fresh, "刷新串口");
            this.Btn_Serial_DL_Fresh.UseVisualStyleBackColor = true;
            this.Btn_Serial_DL_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Btn_Tools_GeekUninstaller
            // 
            this.Btn_Tools_GeekUninstaller.Location = new System.Drawing.Point(3, 238);
            this.Btn_Tools_GeekUninstaller.Name = "Btn_Tools_GeekUninstaller";
            this.Btn_Tools_GeekUninstaller.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_GeekUninstaller.TabIndex = 14;
            this.Btn_Tools_GeekUninstaller.Text = "GeekUninstaller";
            this.Tt_Msg.SetToolTip(this.Btn_Tools_GeekUninstaller, "卸载软件");
            this.Btn_Tools_GeekUninstaller.UseVisualStyleBackColor = true;
            this.Btn_Tools_GeekUninstaller.Click += new System.EventHandler(this.Btn_Tools_GeekUninstaller_Click);
            // 
            // Btn_Tools_FolderPainter
            // 
            this.Btn_Tools_FolderPainter.Location = new System.Drawing.Point(152, 238);
            this.Btn_Tools_FolderPainter.Name = "Btn_Tools_FolderPainter";
            this.Btn_Tools_FolderPainter.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_FolderPainter.TabIndex = 14;
            this.Btn_Tools_FolderPainter.Text = "FolderPainter";
            this.Tt_Msg.SetToolTip(this.Btn_Tools_FolderPainter, "文件夹图标修改软件");
            this.Btn_Tools_FolderPainter.UseVisualStyleBackColor = true;
            this.Btn_Tools_FolderPainter.Click += new System.EventHandler(this.Btn_Tools_FolderPainter_Click);
            // 
            // Btn_Tools_EmptyFolderNuker
            // 
            this.Btn_Tools_EmptyFolderNuker.Location = new System.Drawing.Point(301, 238);
            this.Btn_Tools_EmptyFolderNuker.Name = "Btn_Tools_EmptyFolderNuker";
            this.Btn_Tools_EmptyFolderNuker.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_EmptyFolderNuker.TabIndex = 14;
            this.Btn_Tools_EmptyFolderNuker.Text = "EmptyFolderNuker";
            this.Tt_Msg.SetToolTip(this.Btn_Tools_EmptyFolderNuker, "清除空文件夹软件");
            this.Btn_Tools_EmptyFolderNuker.UseVisualStyleBackColor = true;
            this.Btn_Tools_EmptyFolderNuker.Click += new System.EventHandler(this.Btn_Tools_EmptyFolderNuker_Click);
            // 
            // Pbx_Wxpay
            // 
            this.Pbx_Wxpay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Wxpay.Image = global::SWORLD开发助手.Properties.Resources.微信;
            this.Pbx_Wxpay.Location = new System.Drawing.Point(656, 356);
            this.Pbx_Wxpay.Name = "Pbx_Wxpay";
            this.Pbx_Wxpay.Size = new System.Drawing.Size(120, 120);
            this.Pbx_Wxpay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Wxpay.TabIndex = 15;
            this.Pbx_Wxpay.TabStop = false;
            this.Tt_Msg.SetToolTip(this.Pbx_Wxpay, "使用微信支付捐赠");
            // 
            // Pbx_Alipay
            // 
            this.Pbx_Alipay.Image = global::SWORLD开发助手.Properties.Resources.支付宝;
            this.Pbx_Alipay.Location = new System.Drawing.Point(656, 230);
            this.Pbx_Alipay.Name = "Pbx_Alipay";
            this.Pbx_Alipay.Size = new System.Drawing.Size(120, 120);
            this.Pbx_Alipay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Alipay.TabIndex = 15;
            this.Pbx_Alipay.TabStop = false;
            this.Tt_Msg.SetToolTip(this.Pbx_Alipay, "使用支付宝支付捐赠");
            // 
            // Tmr_Debug_Recv
            // 
            this.Tmr_Debug_Recv.Interval = 1000;
            // 
            // Tmr_Debug_ReSend
            // 
            this.Tmr_Debug_ReSend.Interval = 1000;
            this.Tmr_Debug_ReSend.Tick += new System.EventHandler(this.Tmr_Debug_ReSend_Tick);
            // 
            // Ofd_Debug_File
            // 
            this.Ofd_Debug_File.Filter = "所有文件|*";
            this.Ofd_Debug_File.Title = "选择发送文件";
            // 
            // Tmr_Btm_Msg
            // 
            this.Tmr_Btm_Msg.Interval = 2000;
            this.Tmr_Btm_Msg.Tick += new System.EventHandler(this.Tmr_Btm_Msg_Tick);
            // 
            // Tmr_Debug_Resend_M
            // 
            this.Tmr_Debug_Resend_M.Interval = 1000;
            this.Tmr_Debug_Resend_M.Tick += new System.EventHandler(this.Tmr_Debug_Resend_M_Tick);
            // 
            // Tc_Main
            // 
            this.Tc_Main.AllowDrop = true;
            this.Tc_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tc_Main.BackTabPageColor = System.Drawing.SystemColors.Window;
            this.Tc_Main.BackTabPageImage = null;
            this.Tc_Main.Controls.Add(this.Tp_Debug);
            this.Tc_Main.Controls.Add(this.Tp_DL);
            this.Tc_Main.Controls.Add(this.Tp_Tools);
            this.Tc_Main.Controls.Add(this.Tp_Code);
            this.Tc_Main.Controls.Add(this.Tp_Type);
            this.Tc_Main.Controls.Add(this.Tp_Help);
            this.Tc_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tc_Main.ItemSize = new System.Drawing.Size(125, 25);
            this.Tc_Main.Location = new System.Drawing.Point(0, 0);
            this.Tc_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Tc_Main.Multiline = true;
            this.Tc_Main.Name = "Tc_Main";
            this.Tc_Main.SelectedIndex = 0;
            this.Tc_Main.Size = new System.Drawing.Size(784, 514);
            this.Tc_Main.TabIndex = 3;
            this.Tc_Main.TabMoveColorEnd = System.Drawing.Color.Gainsboro;
            this.Tc_Main.TabMoveColorState = System.Drawing.Color.Gainsboro;
            this.Tc_Main.TabOnColorEnd = System.Drawing.Color.LightGray;
            this.Tc_Main.TabOnColorState = System.Drawing.Color.LightGray;
            this.Tc_Main.SelectedIndexChanged += new System.EventHandler(this.Tc_Main_SelectedIndexChanged);
            // 
            // Tp_Debug
            // 
            this.Tp_Debug.Controls.Add(this.Tbx_Msg_Debug);
            this.Tp_Debug.Controls.Add(this.Pal_Debug_Serial_Option);
            this.Tp_Debug.Controls.Add(this.Lab_Debug_RX);
            this.Tp_Debug.Controls.Add(this.Lab_Debug_TX);
            this.Tp_Debug.Controls.Add(this.Lab_Debug_RX_T);
            this.Tp_Debug.Controls.Add(this.Btn_Debug_Clear_Recv);
            this.Tp_Debug.Controls.Add(this.Lab_Debug_TX_T);
            this.Tp_Debug.Controls.Add(this.Btn_Debug_Save_Window);
            this.Tp_Debug.Controls.Add(this.Cbx_Debug_RTS_Delay);
            this.Tp_Debug.Controls.Add(this.Btn_Debug_Open_Serial);
            this.Tp_Debug.Controls.Add(this.Ckbx_Debug_Show_Hex);
            this.Tp_Debug.Controls.Add(this.Ckbx_Debug_DTR);
            this.Tp_Debug.Controls.Add(this.Ckbx_Debug_RTS);
            this.Tp_Debug.Controls.Add(this.Tc_Debug);
            this.Tp_Debug.Controls.Add(this.Lab_Debug_Delay);
            this.Tp_Debug.Controls.Add(this.Lab_Debug_Operate);
            this.Tp_Debug.Location = new System.Drawing.Point(1, 30);
            this.Tp_Debug.Name = "Tp_Debug";
            this.Tp_Debug.Size = new System.Drawing.Size(782, 482);
            this.Tp_Debug.TabIndex = 0;
            this.Tp_Debug.Text = "调试助手";
            this.Tp_Debug.UseVisualStyleBackColor = true;
            // 
            // Tbx_Msg_Debug
            // 
            this.Tbx_Msg_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Msg_Debug.BackColor = System.Drawing.SystemColors.Window;
            this.Tbx_Msg_Debug.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Msg_Debug.Location = new System.Drawing.Point(3, 3);
            this.Tbx_Msg_Debug.Multiline = true;
            this.Tbx_Msg_Debug.Name = "Tbx_Msg_Debug";
            this.Tbx_Msg_Debug.ReadOnly = true;
            this.Tbx_Msg_Debug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Msg_Debug.Size = new System.Drawing.Size(608, 284);
            this.Tbx_Msg_Debug.TabIndex = 42;
            // 
            // Pal_Debug_Serial_Option
            // 
            this.Pal_Debug_Serial_Option.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pal_Debug_Serial_Option.Controls.Add(this.Lab_Debug_SerialNum);
            this.Pal_Debug_Serial_Option.Controls.Add(this.CBx_Debug_DataBit);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Lab_Debug_DataBit);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Cbx_Debug_Parity);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Lab_Debug_StopBit);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Cbx_Debug_StopBit);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Lab_Debug_CheckBit);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Cbx_Debug_Seiral_Num);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Cbx_Debug_BaudRate);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Lab_Debug_BaudRate);
            this.Pal_Debug_Serial_Option.Controls.Add(this.Btn_Serial_Debug_Fresh);
            this.Pal_Debug_Serial_Option.Location = new System.Drawing.Point(614, 3);
            this.Pal_Debug_Serial_Option.Name = "Pal_Debug_Serial_Option";
            this.Pal_Debug_Serial_Option.Size = new System.Drawing.Size(166, 151);
            this.Pal_Debug_Serial_Option.TabIndex = 38;
            // 
            // Lab_Debug_SerialNum
            // 
            this.Lab_Debug_SerialNum.AutoSize = true;
            this.Lab_Debug_SerialNum.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_SerialNum.Location = new System.Drawing.Point(2, 3);
            this.Lab_Debug_SerialNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Debug_SerialNum.Name = "Lab_Debug_SerialNum";
            this.Lab_Debug_SerialNum.Size = new System.Drawing.Size(63, 14);
            this.Lab_Debug_SerialNum.TabIndex = 18;
            this.Lab_Debug_SerialNum.Text = "串口号：";
            // 
            // CBx_Debug_DataBit
            // 
            this.CBx_Debug_DataBit.Cursor = System.Windows.Forms.Cursors.Default;
            this.CBx_Debug_DataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBx_Debug_DataBit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CBx_Debug_DataBit.FormattingEnabled = true;
            this.CBx_Debug_DataBit.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.CBx_Debug_DataBit.Location = new System.Drawing.Point(72, 101);
            this.CBx_Debug_DataBit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBx_Debug_DataBit.Name = "CBx_Debug_DataBit";
            this.CBx_Debug_DataBit.Size = new System.Drawing.Size(90, 20);
            this.CBx_Debug_DataBit.TabIndex = 3;
            // 
            // Lab_Debug_DataBit
            // 
            this.Lab_Debug_DataBit.AutoSize = true;
            this.Lab_Debug_DataBit.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_DataBit.Location = new System.Drawing.Point(1, 103);
            this.Lab_Debug_DataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Debug_DataBit.Name = "Lab_Debug_DataBit";
            this.Lab_Debug_DataBit.Size = new System.Drawing.Size(63, 14);
            this.Lab_Debug_DataBit.TabIndex = 22;
            this.Lab_Debug_DataBit.Text = "数据位：";
            // 
            // Cbx_Debug_Parity
            // 
            this.Cbx_Debug_Parity.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Debug_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Debug_Parity.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbx_Debug_Parity.FormattingEnabled = true;
            this.Cbx_Debug_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.Cbx_Debug_Parity.Location = new System.Drawing.Point(72, 128);
            this.Cbx_Debug_Parity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_Debug_Parity.Name = "Cbx_Debug_Parity";
            this.Cbx_Debug_Parity.Size = new System.Drawing.Size(90, 20);
            this.Cbx_Debug_Parity.TabIndex = 4;
            // 
            // Lab_Debug_StopBit
            // 
            this.Lab_Debug_StopBit.AutoSize = true;
            this.Lab_Debug_StopBit.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_StopBit.Location = new System.Drawing.Point(1, 76);
            this.Lab_Debug_StopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Debug_StopBit.Name = "Lab_Debug_StopBit";
            this.Lab_Debug_StopBit.Size = new System.Drawing.Size(63, 14);
            this.Lab_Debug_StopBit.TabIndex = 2;
            this.Lab_Debug_StopBit.Text = "停止位：";
            // 
            // Cbx_Debug_StopBit
            // 
            this.Cbx_Debug_StopBit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Debug_StopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Debug_StopBit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbx_Debug_StopBit.FormattingEnabled = true;
            this.Cbx_Debug_StopBit.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.Cbx_Debug_StopBit.Location = new System.Drawing.Point(72, 74);
            this.Cbx_Debug_StopBit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_Debug_StopBit.Name = "Cbx_Debug_StopBit";
            this.Cbx_Debug_StopBit.Size = new System.Drawing.Size(90, 20);
            this.Cbx_Debug_StopBit.TabIndex = 2;
            // 
            // Lab_Debug_CheckBit
            // 
            this.Lab_Debug_CheckBit.AutoSize = true;
            this.Lab_Debug_CheckBit.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_CheckBit.Location = new System.Drawing.Point(1, 130);
            this.Lab_Debug_CheckBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Debug_CheckBit.Name = "Lab_Debug_CheckBit";
            this.Lab_Debug_CheckBit.Size = new System.Drawing.Size(63, 14);
            this.Lab_Debug_CheckBit.TabIndex = 23;
            this.Lab_Debug_CheckBit.Text = "校验位：";
            // 
            // Cbx_Debug_Seiral_Num
            // 
            this.Cbx_Debug_Seiral_Num.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Debug_Seiral_Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Debug_Seiral_Num.DropDownWidth = 132;
            this.Cbx_Debug_Seiral_Num.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbx_Debug_Seiral_Num.FormattingEnabled = true;
            this.Cbx_Debug_Seiral_Num.Location = new System.Drawing.Point(4, 20);
            this.Cbx_Debug_Seiral_Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_Debug_Seiral_Num.Name = "Cbx_Debug_Seiral_Num";
            this.Cbx_Debug_Seiral_Num.Size = new System.Drawing.Size(132, 20);
            this.Cbx_Debug_Seiral_Num.TabIndex = 0;
            // 
            // Cbx_Debug_BaudRate
            // 
            this.Cbx_Debug_BaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Debug_BaudRate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbx_Debug_BaudRate.FormattingEnabled = true;
            this.Cbx_Debug_BaudRate.Items.AddRange(new object[] {
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
            this.Cbx_Debug_BaudRate.Location = new System.Drawing.Point(72, 47);
            this.Cbx_Debug_BaudRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_Debug_BaudRate.Name = "Cbx_Debug_BaudRate";
            this.Cbx_Debug_BaudRate.Size = new System.Drawing.Size(90, 20);
            this.Cbx_Debug_BaudRate.TabIndex = 1;
            this.Cbx_Debug_BaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Num);
            // 
            // Lab_Debug_BaudRate
            // 
            this.Lab_Debug_BaudRate.AutoSize = true;
            this.Lab_Debug_BaudRate.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_BaudRate.Location = new System.Drawing.Point(1, 49);
            this.Lab_Debug_BaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Debug_BaudRate.Name = "Lab_Debug_BaudRate";
            this.Lab_Debug_BaudRate.Size = new System.Drawing.Size(63, 14);
            this.Lab_Debug_BaudRate.TabIndex = 16;
            this.Lab_Debug_BaudRate.Text = "波特率：";
            // 
            // Lab_Debug_RX
            // 
            this.Lab_Debug_RX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_RX.BackColor = System.Drawing.SystemColors.Control;
            this.Lab_Debug_RX.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_RX.ForeColor = System.Drawing.Color.Blue;
            this.Lab_Debug_RX.Location = new System.Drawing.Point(713, 299);
            this.Lab_Debug_RX.Name = "Lab_Debug_RX";
            this.Lab_Debug_RX.Size = new System.Drawing.Size(60, 16);
            this.Lab_Debug_RX.TabIndex = 37;
            this.Lab_Debug_RX.Text = "0";
            this.Lab_Debug_RX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lab_Debug_TX
            // 
            this.Lab_Debug_TX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_TX.BackColor = System.Drawing.SystemColors.Control;
            this.Lab_Debug_TX.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_TX.ForeColor = System.Drawing.Color.Green;
            this.Lab_Debug_TX.Location = new System.Drawing.Point(622, 299);
            this.Lab_Debug_TX.Name = "Lab_Debug_TX";
            this.Lab_Debug_TX.Size = new System.Drawing.Size(60, 16);
            this.Lab_Debug_TX.TabIndex = 36;
            this.Lab_Debug_TX.Text = "0";
            this.Lab_Debug_TX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lab_Debug_RX_T
            // 
            this.Lab_Debug_RX_T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_RX_T.AutoSize = true;
            this.Lab_Debug_RX_T.BackColor = System.Drawing.SystemColors.Control;
            this.Lab_Debug_RX_T.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_RX_T.Location = new System.Drawing.Point(686, 300);
            this.Lab_Debug_RX_T.Name = "Lab_Debug_RX_T";
            this.Lab_Debug_RX_T.Size = new System.Drawing.Size(26, 14);
            this.Lab_Debug_RX_T.TabIndex = 35;
            this.Lab_Debug_RX_T.Text = "RX:";
            // 
            // Btn_Debug_Clear_Recv
            // 
            this.Btn_Debug_Clear_Recv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Clear_Recv.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Clear_Recv.Location = new System.Drawing.Point(699, 205);
            this.Btn_Debug_Clear_Recv.Name = "Btn_Debug_Clear_Recv";
            this.Btn_Debug_Clear_Recv.Size = new System.Drawing.Size(76, 28);
            this.Btn_Debug_Clear_Recv.TabIndex = 9;
            this.Btn_Debug_Clear_Recv.Text = "清空接受";
            this.Btn_Debug_Clear_Recv.UseVisualStyleBackColor = true;
            this.Btn_Debug_Clear_Recv.Click += new System.EventHandler(this.Btn_Debug_Clear_Recv_Click);
            // 
            // Lab_Debug_TX_T
            // 
            this.Lab_Debug_TX_T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_TX_T.AutoSize = true;
            this.Lab_Debug_TX_T.BackColor = System.Drawing.SystemColors.Control;
            this.Lab_Debug_TX_T.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_TX_T.Location = new System.Drawing.Point(596, 300);
            this.Lab_Debug_TX_T.Name = "Lab_Debug_TX_T";
            this.Lab_Debug_TX_T.Size = new System.Drawing.Size(25, 14);
            this.Lab_Debug_TX_T.TabIndex = 34;
            this.Lab_Debug_TX_T.Text = "TX:";
            // 
            // Btn_Debug_Save_Window
            // 
            this.Btn_Debug_Save_Window.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Save_Window.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Save_Window.Location = new System.Drawing.Point(617, 205);
            this.Btn_Debug_Save_Window.Name = "Btn_Debug_Save_Window";
            this.Btn_Debug_Save_Window.Size = new System.Drawing.Size(76, 28);
            this.Btn_Debug_Save_Window.TabIndex = 8;
            this.Btn_Debug_Save_Window.Text = "保存窗口";
            this.Btn_Debug_Save_Window.UseVisualStyleBackColor = true;
            this.Btn_Debug_Save_Window.Click += new System.EventHandler(this.Btn_Debug_Save_Window_Click);
            // 
            // Cbx_Debug_RTS_Delay
            // 
            this.Cbx_Debug_RTS_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_Debug_RTS_Delay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Debug_RTS_Delay.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbx_Debug_RTS_Delay.FormattingEnabled = true;
            this.Cbx_Debug_RTS_Delay.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.Cbx_Debug_RTS_Delay.Location = new System.Drawing.Point(719, 265);
            this.Cbx_Debug_RTS_Delay.Name = "Cbx_Debug_RTS_Delay";
            this.Cbx_Debug_RTS_Delay.Size = new System.Drawing.Size(56, 22);
            this.Cbx_Debug_RTS_Delay.TabIndex = 13;
            // 
            // Btn_Debug_Open_Serial
            // 
            this.Btn_Debug_Open_Serial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Open_Serial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Debug_Open_Serial.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Open_Serial.Image = global::SWORLD开发助手.Properties.Resources.close20;
            this.Btn_Debug_Open_Serial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Debug_Open_Serial.Location = new System.Drawing.Point(685, 160);
            this.Btn_Debug_Open_Serial.Name = "Btn_Debug_Open_Serial";
            this.Btn_Debug_Open_Serial.Size = new System.Drawing.Size(90, 28);
            this.Btn_Debug_Open_Serial.TabIndex = 5;
            this.Btn_Debug_Open_Serial.Text = "打开串口";
            this.Btn_Debug_Open_Serial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Debug_Open_Serial.UseVisualStyleBackColor = true;
            this.Btn_Debug_Open_Serial.Click += new System.EventHandler(this.Btn_Open_Serial_Click);
            // 
            // Ckbx_Debug_Show_Hex
            // 
            this.Ckbx_Debug_Show_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_Show_Hex.AutoSize = true;
            this.Ckbx_Debug_Show_Hex.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_Show_Hex.Location = new System.Drawing.Point(618, 240);
            this.Ckbx_Debug_Show_Hex.Name = "Ckbx_Debug_Show_Hex";
            this.Ckbx_Debug_Show_Hex.Size = new System.Drawing.Size(92, 18);
            this.Ckbx_Debug_Show_Hex.TabIndex = 10;
            this.Ckbx_Debug_Show_Hex.Text = "16进制显示";
            this.Ckbx_Debug_Show_Hex.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_Show_Hex.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_Show_Hex_CheckedChanged);
            // 
            // Ckbx_Debug_DTR
            // 
            this.Ckbx_Debug_DTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_DTR.AutoSize = true;
            this.Ckbx_Debug_DTR.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_DTR.Location = new System.Drawing.Point(725, 240);
            this.Ckbx_Debug_DTR.Name = "Ckbx_Debug_DTR";
            this.Ckbx_Debug_DTR.Size = new System.Drawing.Size(50, 18);
            this.Ckbx_Debug_DTR.TabIndex = 11;
            this.Ckbx_Debug_DTR.Text = "DTR";
            this.Ckbx_Debug_DTR.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_DTR.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_DTR_CheckedChanged);
            // 
            // Ckbx_Debug_RTS
            // 
            this.Ckbx_Debug_RTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_RTS.AutoSize = true;
            this.Ckbx_Debug_RTS.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_RTS.Location = new System.Drawing.Point(617, 268);
            this.Ckbx_Debug_RTS.Name = "Ckbx_Debug_RTS";
            this.Ckbx_Debug_RTS.Size = new System.Drawing.Size(48, 18);
            this.Ckbx_Debug_RTS.TabIndex = 12;
            this.Ckbx_Debug_RTS.Text = "RTS";
            this.Ckbx_Debug_RTS.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_RTS.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_RTS_CheckedChanged);
            // 
            // Tc_Debug
            // 
            this.Tc_Debug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tc_Debug.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tc_Debug.Controls.Add(this.Tp_Debug_Send_One);
            this.Tc_Debug.Controls.Add(this.Tp_Debug_Send_More);
            this.Tc_Debug.Controls.Add(this.Tp_Debug_Send_Protocol);
            this.Tc_Debug.Location = new System.Drawing.Point(3, 293);
            this.Tc_Debug.Name = "Tc_Debug";
            this.Tc_Debug.SelectedIndex = 0;
            this.Tc_Debug.Size = new System.Drawing.Size(776, 188);
            this.Tc_Debug.TabIndex = 30;
            // 
            // Tp_Debug_Send_One
            // 
            this.Tp_Debug_Send_One.BackColor = System.Drawing.SystemColors.Window;
            this.Tp_Debug_Send_One.Controls.Add(this.Lab_Debug_Task_Process);
            this.Tp_Debug_Send_One.Controls.Add(this.Pgb_Debug_Task_Process);
            this.Tp_Debug_Send_One.Controls.Add(this.Ckbx_Debug_Show_Time);
            this.Tp_Debug_Send_One.Controls.Add(this.Tbx_Debug_Resend_Time);
            this.Tp_Debug_Send_One.Controls.Add(this.Lab_Debug_CycleUnit);
            this.Tp_Debug_Send_One.Controls.Add(this.Lab_Debug_Cycle);
            this.Tp_Debug_Send_One.Controls.Add(this.Ckbx_Debug_Send_Ontime);
            this.Tp_Debug_Send_One.Controls.Add(this.Tbx_Debug_Send_File_Name);
            this.Tp_Debug_Send_One.Controls.Add(this.Btn_Debug_Select_File);
            this.Tp_Debug_Send_One.Controls.Add(this.Btn_Debug_Start_Send_File);
            this.Tp_Debug_Send_One.Controls.Add(this.Ckbx_Debug_Send_NewLine);
            this.Tp_Debug_Send_One.Controls.Add(this.Ckbx_Debug_Send_Hex);
            this.Tp_Debug_Send_One.Controls.Add(this.Btn_Debug_Stop_Send_File);
            this.Tp_Debug_Send_One.Controls.Add(this.Tbx_Debug_Show_Time);
            this.Tp_Debug_Send_One.Controls.Add(this.Btn_Debug_Clear_Send);
            this.Tp_Debug_Send_One.Controls.Add(this.Btn_Debug_Send);
            this.Tp_Debug_Send_One.Controls.Add(this.Tbx_Debug_Send_One);
            this.Tp_Debug_Send_One.Controls.Add(this.Lab_Show_Time);
            this.Tp_Debug_Send_One.Location = new System.Drawing.Point(4, 28);
            this.Tp_Debug_Send_One.Name = "Tp_Debug_Send_One";
            this.Tp_Debug_Send_One.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Debug_Send_One.Size = new System.Drawing.Size(768, 156);
            this.Tp_Debug_Send_One.TabIndex = 0;
            this.Tp_Debug_Send_One.Text = "单条发送";
            // 
            // Lab_Debug_Task_Process
            // 
            this.Lab_Debug_Task_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_Task_Process.AutoSize = true;
            this.Lab_Debug_Task_Process.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_Task_Process.Location = new System.Drawing.Point(335, 131);
            this.Lab_Debug_Task_Process.Name = "Lab_Debug_Task_Process";
            this.Lab_Debug_Task_Process.Size = new System.Drawing.Size(21, 14);
            this.Lab_Debug_Task_Process.TabIndex = 118;
            this.Lab_Debug_Task_Process.Text = "0%";
            // 
            // Pgb_Debug_Task_Process
            // 
            this.Pgb_Debug_Task_Process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pgb_Debug_Task_Process.Location = new System.Drawing.Point(3, 131);
            this.Pgb_Debug_Task_Process.Name = "Pgb_Debug_Task_Process";
            this.Pgb_Debug_Task_Process.Size = new System.Drawing.Size(326, 14);
            this.Pgb_Debug_Task_Process.TabIndex = 117;
            // 
            // Ckbx_Debug_Show_Time
            // 
            this.Ckbx_Debug_Show_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_Show_Time.AutoSize = true;
            this.Ckbx_Debug_Show_Time.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_Show_Time.Location = new System.Drawing.Point(621, 130);
            this.Ckbx_Debug_Show_Time.Name = "Ckbx_Debug_Show_Time";
            this.Ckbx_Debug_Show_Time.Size = new System.Drawing.Size(65, 18);
            this.Ckbx_Debug_Show_Time.TabIndex = 23;
            this.Ckbx_Debug_Show_Time.Text = "时间戳";
            this.Ckbx_Debug_Show_Time.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_Show_Time.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_Show_Time_CheckedChanged);
            // 
            // Tbx_Debug_Resend_Time
            // 
            this.Tbx_Debug_Resend_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_Resend_Time.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_Resend_Time.Location = new System.Drawing.Point(535, 128);
            this.Tbx_Debug_Resend_Time.Name = "Tbx_Debug_Resend_Time";
            this.Tbx_Debug_Resend_Time.Size = new System.Drawing.Size(49, 21);
            this.Tbx_Debug_Resend_Time.TabIndex = 22;
            this.Tbx_Debug_Resend_Time.Text = "1000";
            this.Tbx_Debug_Resend_Time.TextChanged += new System.EventHandler(this.TextChange_1_1000000);
            this.Tbx_Debug_Resend_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Num);
            // 
            // Lab_Debug_CycleUnit
            // 
            this.Lab_Debug_CycleUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_CycleUnit.AutoSize = true;
            this.Lab_Debug_CycleUnit.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_CycleUnit.Location = new System.Drawing.Point(584, 131);
            this.Lab_Debug_CycleUnit.Name = "Lab_Debug_CycleUnit";
            this.Lab_Debug_CycleUnit.Size = new System.Drawing.Size(23, 14);
            this.Lab_Debug_CycleUnit.TabIndex = 115;
            this.Lab_Debug_CycleUnit.Text = "ms";
            // 
            // Lab_Debug_Cycle
            // 
            this.Lab_Debug_Cycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_Cycle.AutoSize = true;
            this.Lab_Debug_Cycle.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_Cycle.Location = new System.Drawing.Point(495, 131);
            this.Lab_Debug_Cycle.Name = "Lab_Debug_Cycle";
            this.Lab_Debug_Cycle.Size = new System.Drawing.Size(46, 14);
            this.Lab_Debug_Cycle.TabIndex = 113;
            this.Lab_Debug_Cycle.Text = "周期：";
            // 
            // Ckbx_Debug_Send_Ontime
            // 
            this.Ckbx_Debug_Send_Ontime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_Send_Ontime.AutoSize = true;
            this.Ckbx_Debug_Send_Ontime.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_Send_Ontime.Location = new System.Drawing.Point(414, 130);
            this.Ckbx_Debug_Send_Ontime.Name = "Ckbx_Debug_Send_Ontime";
            this.Ckbx_Debug_Send_Ontime.Size = new System.Drawing.Size(78, 18);
            this.Ckbx_Debug_Send_Ontime.TabIndex = 21;
            this.Ckbx_Debug_Send_Ontime.Text = "定时发送";
            this.Ckbx_Debug_Send_Ontime.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_Send_Ontime.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_Send_Ontime_CheckedChanged);
            // 
            // Tbx_Debug_Send_File_Name
            // 
            this.Tbx_Debug_Send_File_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_Send_File_Name.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_Send_File_Name.Location = new System.Drawing.Point(3, 100);
            this.Tbx_Debug_Send_File_Name.Name = "Tbx_Debug_Send_File_Name";
            this.Tbx_Debug_Send_File_Name.ReadOnly = true;
            this.Tbx_Debug_Send_File_Name.Size = new System.Drawing.Size(326, 21);
            this.Tbx_Debug_Send_File_Name.TabIndex = 15;
            // 
            // Btn_Debug_Select_File
            // 
            this.Btn_Debug_Select_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Select_File.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Select_File.Location = new System.Drawing.Point(335, 97);
            this.Btn_Debug_Select_File.Name = "Btn_Debug_Select_File";
            this.Btn_Debug_Select_File.Size = new System.Drawing.Size(70, 26);
            this.Btn_Debug_Select_File.TabIndex = 16;
            this.Btn_Debug_Select_File.Text = "选择文件";
            this.Btn_Debug_Select_File.UseVisualStyleBackColor = true;
            this.Btn_Debug_Select_File.Click += new System.EventHandler(this.Btn_Debug_Select_File_Click);
            // 
            // Btn_Debug_Start_Send_File
            // 
            this.Btn_Debug_Start_Send_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Start_Send_File.Enabled = false;
            this.Btn_Debug_Start_Send_File.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Start_Send_File.Location = new System.Drawing.Point(411, 97);
            this.Btn_Debug_Start_Send_File.Name = "Btn_Debug_Start_Send_File";
            this.Btn_Debug_Start_Send_File.Size = new System.Drawing.Size(70, 26);
            this.Btn_Debug_Start_Send_File.TabIndex = 17;
            this.Btn_Debug_Start_Send_File.Text = "发送文件";
            this.Btn_Debug_Start_Send_File.UseVisualStyleBackColor = true;
            this.Btn_Debug_Start_Send_File.Click += new System.EventHandler(this.Btn_Debug_Start_Send_File_Click);
            // 
            // Ckbx_Debug_Send_NewLine
            // 
            this.Ckbx_Debug_Send_NewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_Send_NewLine.AutoSize = true;
            this.Ckbx_Debug_Send_NewLine.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_Send_NewLine.Location = new System.Drawing.Point(687, 102);
            this.Ckbx_Debug_Send_NewLine.Name = "Ckbx_Debug_Send_NewLine";
            this.Ckbx_Debug_Send_NewLine.Size = new System.Drawing.Size(78, 18);
            this.Ckbx_Debug_Send_NewLine.TabIndex = 20;
            this.Ckbx_Debug_Send_NewLine.Text = "发送新行";
            this.Ckbx_Debug_Send_NewLine.UseVisualStyleBackColor = true;
            // 
            // Ckbx_Debug_Send_Hex
            // 
            this.Ckbx_Debug_Send_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Debug_Send_Hex.AutoSize = true;
            this.Ckbx_Debug_Send_Hex.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Debug_Send_Hex.Location = new System.Drawing.Point(582, 102);
            this.Ckbx_Debug_Send_Hex.Name = "Ckbx_Debug_Send_Hex";
            this.Ckbx_Debug_Send_Hex.Size = new System.Drawing.Size(92, 18);
            this.Ckbx_Debug_Send_Hex.TabIndex = 19;
            this.Ckbx_Debug_Send_Hex.Text = "16进制发送";
            this.Ckbx_Debug_Send_Hex.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_Send_Hex.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_Send_Hex_CheckedChanged);
            // 
            // Btn_Debug_Stop_Send_File
            // 
            this.Btn_Debug_Stop_Send_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Stop_Send_File.Enabled = false;
            this.Btn_Debug_Stop_Send_File.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Stop_Send_File.Location = new System.Drawing.Point(487, 97);
            this.Btn_Debug_Stop_Send_File.Name = "Btn_Debug_Stop_Send_File";
            this.Btn_Debug_Stop_Send_File.Size = new System.Drawing.Size(70, 26);
            this.Btn_Debug_Stop_Send_File.TabIndex = 18;
            this.Btn_Debug_Stop_Send_File.Text = "停止发送";
            this.Btn_Debug_Stop_Send_File.UseVisualStyleBackColor = true;
            this.Btn_Debug_Stop_Send_File.Click += new System.EventHandler(this.Btn_Debug_Stop_Send_File_Click);
            // 
            // Tbx_Debug_Show_Time
            // 
            this.Tbx_Debug_Show_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_Show_Time.Enabled = false;
            this.Tbx_Debug_Show_Time.Font = new System.Drawing.Font("等线", 9.75F);
            this.Tbx_Debug_Show_Time.Location = new System.Drawing.Point(692, 128);
            this.Tbx_Debug_Show_Time.Name = "Tbx_Debug_Show_Time";
            this.Tbx_Debug_Show_Time.Size = new System.Drawing.Size(49, 21);
            this.Tbx_Debug_Show_Time.TabIndex = 24;
            this.Tbx_Debug_Show_Time.Text = "1000";
            this.Tbx_Debug_Show_Time.TextChanged += new System.EventHandler(this.TextChange_0_1000000);
            this.Tbx_Debug_Show_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Num);
            // 
            // Btn_Debug_Clear_Send
            // 
            this.Btn_Debug_Clear_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Clear_Send.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Clear_Send.Location = new System.Drawing.Point(695, 63);
            this.Btn_Debug_Clear_Send.Name = "Btn_Debug_Clear_Send";
            this.Btn_Debug_Clear_Send.Size = new System.Drawing.Size(70, 28);
            this.Btn_Debug_Clear_Send.TabIndex = 14;
            this.Btn_Debug_Clear_Send.Text = "清空发送";
            this.Btn_Debug_Clear_Send.UseVisualStyleBackColor = true;
            this.Btn_Debug_Clear_Send.Click += new System.EventHandler(this.Btn_Debug_Clear_Send_Click);
            // 
            // Btn_Debug_Send
            // 
            this.Btn_Debug_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_Send.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Debug_Send.Location = new System.Drawing.Point(695, 3);
            this.Btn_Debug_Send.Name = "Btn_Debug_Send";
            this.Btn_Debug_Send.Size = new System.Drawing.Size(70, 28);
            this.Btn_Debug_Send.TabIndex = 7;
            this.Btn_Debug_Send.Text = "发送";
            this.Btn_Debug_Send.UseVisualStyleBackColor = true;
            this.Btn_Debug_Send.Click += new System.EventHandler(this.Btn_Debug_Send_Click);
            // 
            // Tbx_Debug_Send_One
            // 
            this.Tbx_Debug_Send_One.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_Send_One.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_Send_One.Location = new System.Drawing.Point(3, 3);
            this.Tbx_Debug_Send_One.Multiline = true;
            this.Tbx_Debug_Send_One.Name = "Tbx_Debug_Send_One";
            this.Tbx_Debug_Send_One.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Debug_Send_One.Size = new System.Drawing.Size(683, 88);
            this.Tbx_Debug_Send_One.TabIndex = 6;
            // 
            // Lab_Show_Time
            // 
            this.Lab_Show_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Show_Time.AutoSize = true;
            this.Lab_Show_Time.Font = new System.Drawing.Font("等线", 9.75F);
            this.Lab_Show_Time.Location = new System.Drawing.Point(742, 131);
            this.Lab_Show_Time.Name = "Lab_Show_Time";
            this.Lab_Show_Time.Size = new System.Drawing.Size(23, 14);
            this.Lab_Show_Time.TabIndex = 33;
            this.Lab_Show_Time.Text = "ms";
            // 
            // Tp_Debug_Send_More
            // 
            this.Tp_Debug_Send_More.BackColor = System.Drawing.SystemColors.Window;
            this.Tp_Debug_Send_More.Controls.Add(this.Tblp_Send_M);
            this.Tp_Debug_Send_More.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tp_Debug_Send_More.Location = new System.Drawing.Point(4, 28);
            this.Tp_Debug_Send_More.Name = "Tp_Debug_Send_More";
            this.Tp_Debug_Send_More.Padding = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.Tp_Debug_Send_More.Size = new System.Drawing.Size(768, 156);
            this.Tp_Debug_Send_More.TabIndex = 1;
            this.Tp_Debug_Send_More.Text = "多条发送";
            // 
            // Tblp_Send_M
            // 
            this.Tblp_Send_M.ColumnCount = 8;
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.Tblp_Send_M.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.Tblp_Send_M.Controls.Add(this.Lbx_Debug_Project, 0, 0);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M_Send_NewLine, 7, 0);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M_Send_Hex, 7, 1);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M_Con_NumKey, 7, 2);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M_Resend, 7, 3);
            this.Tblp_Send_M.Controls.Add(this.Pal_Debug_MutilCycleSet, 7, 4);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M5, 6, 0);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M6, 6, 1);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M7, 6, 2);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M8, 6, 3);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M9, 6, 4);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M5, 4, 0);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M6, 4, 1);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_Project, 0, 5);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M4, 1, 4);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M4, 2, 4);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M3, 1, 3);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M3, 2, 3);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M2, 1, 2);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M2, 2, 2);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M1, 1, 1);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M9, 5, 4);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M0, 1, 0);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M8, 5, 3);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M7, 5, 2);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M1, 2, 1);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M7, 4, 2);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M0, 2, 0);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M8, 4, 3);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M4, 3, 4);
            this.Tblp_Send_M.Controls.Add(this.Ckbx_Debug_M9, 4, 4);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M3, 3, 3);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M6, 5, 1);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M2, 3, 2);
            this.Tblp_Send_M.Controls.Add(this.Tbx_Debug_M5, 5, 0);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M1, 3, 1);
            this.Tblp_Send_M.Controls.Add(this.Btn_Debug_M0, 3, 0);
            this.Tblp_Send_M.Controls.Add(this.Pal_Debug_SwitchProject, 1, 5);
            this.Tblp_Send_M.Controls.Add(this.Pal_Debug_Operate, 7, 5);
            this.Tblp_Send_M.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tblp_Send_M.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tblp_Send_M.Location = new System.Drawing.Point(3, 2);
            this.Tblp_Send_M.Margin = new System.Windows.Forms.Padding(1);
            this.Tblp_Send_M.Name = "Tblp_Send_M";
            this.Tblp_Send_M.RowCount = 6;
            this.Tblp_Send_M.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tblp_Send_M.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tblp_Send_M.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tblp_Send_M.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tblp_Send_M.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Tblp_Send_M.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.Tblp_Send_M.Size = new System.Drawing.Size(762, 153);
            this.Tblp_Send_M.TabIndex = 43;
            // 
            // Ckbx_Debug_M_Send_NewLine
            // 
            this.Ckbx_Debug_M_Send_NewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ckbx_Debug_M_Send_NewLine.AutoSize = true;
            this.Ckbx_Debug_M_Send_NewLine.Location = new System.Drawing.Point(594, 4);
            this.Ckbx_Debug_M_Send_NewLine.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.Ckbx_Debug_M_Send_NewLine.Name = "Ckbx_Debug_M_Send_NewLine";
            this.Ckbx_Debug_M_Send_NewLine.Size = new System.Drawing.Size(78, 18);
            this.Ckbx_Debug_M_Send_NewLine.TabIndex = 31;
            this.Ckbx_Debug_M_Send_NewLine.Text = "发送新行";
            this.Ckbx_Debug_M_Send_NewLine.UseVisualStyleBackColor = true;
            // 
            // Ckbx_Debug_M_Send_Hex
            // 
            this.Ckbx_Debug_M_Send_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ckbx_Debug_M_Send_Hex.AutoSize = true;
            this.Ckbx_Debug_M_Send_Hex.Location = new System.Drawing.Point(594, 29);
            this.Ckbx_Debug_M_Send_Hex.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.Ckbx_Debug_M_Send_Hex.Name = "Ckbx_Debug_M_Send_Hex";
            this.Ckbx_Debug_M_Send_Hex.Size = new System.Drawing.Size(92, 18);
            this.Ckbx_Debug_M_Send_Hex.TabIndex = 32;
            this.Ckbx_Debug_M_Send_Hex.Text = "16进制发送";
            this.Ckbx_Debug_M_Send_Hex.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M_Send_Hex.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_M_Send_Hex_CheckedChanged);
            // 
            // Ckbx_Debug_M_Con_NumKey
            // 
            this.Ckbx_Debug_M_Con_NumKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ckbx_Debug_M_Con_NumKey.AutoSize = true;
            this.Ckbx_Debug_M_Con_NumKey.Location = new System.Drawing.Point(594, 54);
            this.Ckbx_Debug_M_Con_NumKey.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.Ckbx_Debug_M_Con_NumKey.Name = "Ckbx_Debug_M_Con_NumKey";
            this.Ckbx_Debug_M_Con_NumKey.Size = new System.Drawing.Size(104, 18);
            this.Ckbx_Debug_M_Con_NumKey.TabIndex = 33;
            this.Ckbx_Debug_M_Con_NumKey.Text = "关联数字键盘";
            this.Ckbx_Debug_M_Con_NumKey.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M_Con_NumKey.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_M_Con_NumKey_CheckedChanged);
            // 
            // Ckbx_Debug_M_Resend
            // 
            this.Ckbx_Debug_M_Resend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ckbx_Debug_M_Resend.AutoSize = true;
            this.Ckbx_Debug_M_Resend.Location = new System.Drawing.Point(594, 79);
            this.Ckbx_Debug_M_Resend.Margin = new System.Windows.Forms.Padding(14, 3, 3, 3);
            this.Ckbx_Debug_M_Resend.Name = "Ckbx_Debug_M_Resend";
            this.Ckbx_Debug_M_Resend.Size = new System.Drawing.Size(104, 18);
            this.Ckbx_Debug_M_Resend.TabIndex = 34;
            this.Ckbx_Debug_M_Resend.Text = "自动循环发送";
            this.Ckbx_Debug_M_Resend.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M_Resend.CheckedChanged += new System.EventHandler(this.Ckbx_Debug_M_Resend_CheckedChanged);
            // 
            // Pal_Debug_MutilCycleSet
            // 
            this.Pal_Debug_MutilCycleSet.Controls.Add(this.Tbx_Debug_M_Resend_Time);
            this.Pal_Debug_MutilCycleSet.Controls.Add(this.Lab_Debug_MutilCycle);
            this.Pal_Debug_MutilCycleSet.Controls.Add(this.Lab_Debug_MutilCycleUnit);
            this.Pal_Debug_MutilCycleSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pal_Debug_MutilCycleSet.Location = new System.Drawing.Point(580, 100);
            this.Pal_Debug_MutilCycleSet.Margin = new System.Windows.Forms.Padding(0);
            this.Pal_Debug_MutilCycleSet.Name = "Pal_Debug_MutilCycleSet";
            this.Pal_Debug_MutilCycleSet.Size = new System.Drawing.Size(182, 25);
            this.Pal_Debug_MutilCycleSet.TabIndex = 64;
            // 
            // Tbx_Debug_M_Resend_Time
            // 
            this.Tbx_Debug_M_Resend_Time.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M_Resend_Time.Location = new System.Drawing.Point(52, 2);
            this.Tbx_Debug_M_Resend_Time.Name = "Tbx_Debug_M_Resend_Time";
            this.Tbx_Debug_M_Resend_Time.Size = new System.Drawing.Size(40, 21);
            this.Tbx_Debug_M_Resend_Time.TabIndex = 35;
            this.Tbx_Debug_M_Resend_Time.Text = "1000";
            this.Tbx_Debug_M_Resend_Time.TextChanged += new System.EventHandler(this.TextChange_1_1000000);
            this.Tbx_Debug_M_Resend_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Num);
            // 
            // Lab_Debug_MutilCycle
            // 
            this.Lab_Debug_MutilCycle.AutoSize = true;
            this.Lab_Debug_MutilCycle.Location = new System.Drawing.Point(11, 5);
            this.Lab_Debug_MutilCycle.Name = "Lab_Debug_MutilCycle";
            this.Lab_Debug_MutilCycle.Size = new System.Drawing.Size(46, 14);
            this.Lab_Debug_MutilCycle.TabIndex = 37;
            this.Lab_Debug_MutilCycle.Text = "周期：";
            // 
            // Lab_Debug_MutilCycleUnit
            // 
            this.Lab_Debug_MutilCycleUnit.AutoSize = true;
            this.Lab_Debug_MutilCycleUnit.Location = new System.Drawing.Point(92, 5);
            this.Lab_Debug_MutilCycleUnit.Name = "Lab_Debug_MutilCycleUnit";
            this.Lab_Debug_MutilCycleUnit.Size = new System.Drawing.Size(23, 14);
            this.Lab_Debug_MutilCycleUnit.TabIndex = 39;
            this.Lab_Debug_MutilCycleUnit.Text = "ms";
            // 
            // Btn_Debug_M5
            // 
            this.Btn_Debug_M5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M5.Location = new System.Drawing.Point(541, 1);
            this.Btn_Debug_M5.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M5.Name = "Btn_Debug_M5";
            this.Btn_Debug_M5.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M5.TabIndex = 17;
            this.Btn_Debug_M5.Text = "5";
            this.Btn_Debug_M5.UseVisualStyleBackColor = true;
            this.Btn_Debug_M5.Click += new System.EventHandler(this.Btn_Debug_M5_Click);
            // 
            // Btn_Debug_M6
            // 
            this.Btn_Debug_M6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M6.Location = new System.Drawing.Point(541, 26);
            this.Btn_Debug_M6.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M6.Name = "Btn_Debug_M6";
            this.Btn_Debug_M6.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M6.TabIndex = 18;
            this.Btn_Debug_M6.Text = "6";
            this.Btn_Debug_M6.UseVisualStyleBackColor = true;
            this.Btn_Debug_M6.Click += new System.EventHandler(this.Btn_Debug_M6_Click);
            // 
            // Btn_Debug_M7
            // 
            this.Btn_Debug_M7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M7.Location = new System.Drawing.Point(541, 51);
            this.Btn_Debug_M7.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M7.Name = "Btn_Debug_M7";
            this.Btn_Debug_M7.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M7.TabIndex = 19;
            this.Btn_Debug_M7.Text = "7";
            this.Btn_Debug_M7.UseVisualStyleBackColor = true;
            this.Btn_Debug_M7.Click += new System.EventHandler(this.Btn_Debug_M7_Click);
            // 
            // Btn_Debug_M8
            // 
            this.Btn_Debug_M8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M8.Location = new System.Drawing.Point(541, 76);
            this.Btn_Debug_M8.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M8.Name = "Btn_Debug_M8";
            this.Btn_Debug_M8.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M8.TabIndex = 20;
            this.Btn_Debug_M8.Text = "8";
            this.Btn_Debug_M8.UseVisualStyleBackColor = true;
            this.Btn_Debug_M8.Click += new System.EventHandler(this.Btn_Debug_M8_Click);
            // 
            // Btn_Debug_M9
            // 
            this.Btn_Debug_M9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M9.Location = new System.Drawing.Point(541, 101);
            this.Btn_Debug_M9.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M9.Name = "Btn_Debug_M9";
            this.Btn_Debug_M9.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M9.TabIndex = 21;
            this.Btn_Debug_M9.Text = "9";
            this.Btn_Debug_M9.UseVisualStyleBackColor = true;
            this.Btn_Debug_M9.Click += new System.EventHandler(this.Btn_Debug_M9_Click);
            // 
            // Ckbx_Debug_M5
            // 
            this.Ckbx_Debug_M5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M5.AutoSize = true;
            this.Ckbx_Debug_M5.Location = new System.Drawing.Point(354, 6);
            this.Ckbx_Debug_M5.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M5.Name = "Ckbx_Debug_M5";
            this.Ckbx_Debug_M5.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M5.TabIndex = 17;
            this.Ckbx_Debug_M5.TabStop = false;
            this.Ckbx_Debug_M5.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M5.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Ckbx_Debug_M6
            // 
            this.Ckbx_Debug_M6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M6.AutoSize = true;
            this.Ckbx_Debug_M6.Location = new System.Drawing.Point(354, 31);
            this.Ckbx_Debug_M6.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M6.Name = "Ckbx_Debug_M6";
            this.Ckbx_Debug_M6.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M6.TabIndex = 18;
            this.Ckbx_Debug_M6.TabStop = false;
            this.Ckbx_Debug_M6.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M6.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_Project
            // 
            this.Tbx_Debug_Project.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_Project.Location = new System.Drawing.Point(3, 128);
            this.Tbx_Debug_Project.Margin = new System.Windows.Forms.Padding(3, 2, 2, 2);
            this.Tbx_Debug_Project.Name = "Tbx_Debug_Project";
            this.Tbx_Debug_Project.Size = new System.Drawing.Size(103, 21);
            this.Tbx_Debug_Project.TabIndex = 1;
            this.Tbx_Debug_Project.Text = "默认项目";
            // 
            // Ckbx_Debug_M4
            // 
            this.Ckbx_Debug_M4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M4.AutoSize = true;
            this.Ckbx_Debug_M4.Location = new System.Drawing.Point(118, 106);
            this.Ckbx_Debug_M4.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M4.Name = "Ckbx_Debug_M4";
            this.Ckbx_Debug_M4.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M4.TabIndex = 4;
            this.Ckbx_Debug_M4.TabStop = false;
            this.Ckbx_Debug_M4.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M4.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_M4
            // 
            this.Tbx_Debug_M4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M4.Location = new System.Drawing.Point(136, 102);
            this.Tbx_Debug_M4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M4.Name = "Tbx_Debug_M4";
            this.Tbx_Debug_M4.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M4.TabIndex = 6;
            this.Tbx_Debug_M4.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Ckbx_Debug_M3
            // 
            this.Ckbx_Debug_M3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M3.AutoSize = true;
            this.Ckbx_Debug_M3.Location = new System.Drawing.Point(118, 81);
            this.Ckbx_Debug_M3.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M3.Name = "Ckbx_Debug_M3";
            this.Ckbx_Debug_M3.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M3.TabIndex = 3;
            this.Ckbx_Debug_M3.TabStop = false;
            this.Ckbx_Debug_M3.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M3.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_M3
            // 
            this.Tbx_Debug_M3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M3.Location = new System.Drawing.Point(136, 77);
            this.Tbx_Debug_M3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M3.Name = "Tbx_Debug_M3";
            this.Tbx_Debug_M3.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M3.TabIndex = 5;
            this.Tbx_Debug_M3.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Ckbx_Debug_M2
            // 
            this.Ckbx_Debug_M2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M2.AutoSize = true;
            this.Ckbx_Debug_M2.Location = new System.Drawing.Point(118, 56);
            this.Ckbx_Debug_M2.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M2.Name = "Ckbx_Debug_M2";
            this.Ckbx_Debug_M2.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M2.TabIndex = 2;
            this.Ckbx_Debug_M2.TabStop = false;
            this.Ckbx_Debug_M2.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M2.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_M2
            // 
            this.Tbx_Debug_M2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M2.Location = new System.Drawing.Point(136, 52);
            this.Tbx_Debug_M2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M2.Name = "Tbx_Debug_M2";
            this.Tbx_Debug_M2.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M2.TabIndex = 4;
            this.Tbx_Debug_M2.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Ckbx_Debug_M1
            // 
            this.Ckbx_Debug_M1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M1.AutoSize = true;
            this.Ckbx_Debug_M1.Location = new System.Drawing.Point(118, 31);
            this.Ckbx_Debug_M1.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M1.Name = "Ckbx_Debug_M1";
            this.Ckbx_Debug_M1.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M1.TabIndex = 1;
            this.Ckbx_Debug_M1.TabStop = false;
            this.Ckbx_Debug_M1.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M1.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_M9
            // 
            this.Tbx_Debug_M9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M9.Location = new System.Drawing.Point(372, 102);
            this.Tbx_Debug_M9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M9.Name = "Tbx_Debug_M9";
            this.Tbx_Debug_M9.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M9.TabIndex = 11;
            this.Tbx_Debug_M9.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Ckbx_Debug_M0
            // 
            this.Ckbx_Debug_M0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M0.AutoSize = true;
            this.Ckbx_Debug_M0.Location = new System.Drawing.Point(118, 6);
            this.Ckbx_Debug_M0.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M0.Name = "Ckbx_Debug_M0";
            this.Ckbx_Debug_M0.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M0.TabIndex = 0;
            this.Ckbx_Debug_M0.TabStop = false;
            this.Ckbx_Debug_M0.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M0.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_M8
            // 
            this.Tbx_Debug_M8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M8.Location = new System.Drawing.Point(372, 77);
            this.Tbx_Debug_M8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M8.Name = "Tbx_Debug_M8";
            this.Tbx_Debug_M8.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M8.TabIndex = 10;
            this.Tbx_Debug_M8.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Tbx_Debug_M7
            // 
            this.Tbx_Debug_M7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M7.Location = new System.Drawing.Point(372, 52);
            this.Tbx_Debug_M7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M7.Name = "Tbx_Debug_M7";
            this.Tbx_Debug_M7.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M7.TabIndex = 9;
            this.Tbx_Debug_M7.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Tbx_Debug_M1
            // 
            this.Tbx_Debug_M1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M1.Location = new System.Drawing.Point(136, 27);
            this.Tbx_Debug_M1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M1.Name = "Tbx_Debug_M1";
            this.Tbx_Debug_M1.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M1.TabIndex = 3;
            this.Tbx_Debug_M1.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Ckbx_Debug_M7
            // 
            this.Ckbx_Debug_M7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M7.AutoSize = true;
            this.Ckbx_Debug_M7.Location = new System.Drawing.Point(354, 56);
            this.Ckbx_Debug_M7.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M7.Name = "Ckbx_Debug_M7";
            this.Ckbx_Debug_M7.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M7.TabIndex = 19;
            this.Ckbx_Debug_M7.TabStop = false;
            this.Ckbx_Debug_M7.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M7.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Tbx_Debug_M0
            // 
            this.Tbx_Debug_M0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M0.Location = new System.Drawing.Point(136, 2);
            this.Tbx_Debug_M0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M0.Name = "Tbx_Debug_M0";
            this.Tbx_Debug_M0.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M0.TabIndex = 2;
            this.Tbx_Debug_M0.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Ckbx_Debug_M8
            // 
            this.Ckbx_Debug_M8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M8.AutoSize = true;
            this.Ckbx_Debug_M8.Location = new System.Drawing.Point(354, 81);
            this.Ckbx_Debug_M8.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M8.Name = "Ckbx_Debug_M8";
            this.Ckbx_Debug_M8.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M8.TabIndex = 20;
            this.Ckbx_Debug_M8.TabStop = false;
            this.Ckbx_Debug_M8.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M8.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Btn_Debug_M4
            // 
            this.Btn_Debug_M4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M4.Location = new System.Drawing.Point(305, 101);
            this.Btn_Debug_M4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M4.Name = "Btn_Debug_M4";
            this.Btn_Debug_M4.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M4.TabIndex = 16;
            this.Btn_Debug_M4.Text = "4";
            this.Btn_Debug_M4.UseVisualStyleBackColor = true;
            this.Btn_Debug_M4.Click += new System.EventHandler(this.Btn_Debug_M4_Click);
            // 
            // Ckbx_Debug_M9
            // 
            this.Ckbx_Debug_M9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Ckbx_Debug_M9.AutoSize = true;
            this.Ckbx_Debug_M9.Location = new System.Drawing.Point(354, 106);
            this.Ckbx_Debug_M9.Margin = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.Ckbx_Debug_M9.Name = "Ckbx_Debug_M9";
            this.Ckbx_Debug_M9.Size = new System.Drawing.Size(15, 14);
            this.Ckbx_Debug_M9.TabIndex = 21;
            this.Ckbx_Debug_M9.TabStop = false;
            this.Ckbx_Debug_M9.UseVisualStyleBackColor = true;
            this.Ckbx_Debug_M9.CheckedChanged += new System.EventHandler(this.Debug_Send_M_CheckedChanged);
            // 
            // Btn_Debug_M3
            // 
            this.Btn_Debug_M3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M3.Location = new System.Drawing.Point(305, 76);
            this.Btn_Debug_M3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M3.Name = "Btn_Debug_M3";
            this.Btn_Debug_M3.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M3.TabIndex = 15;
            this.Btn_Debug_M3.Text = "3";
            this.Btn_Debug_M3.UseVisualStyleBackColor = true;
            this.Btn_Debug_M3.Click += new System.EventHandler(this.Btn_Debug_M3_Click);
            // 
            // Tbx_Debug_M6
            // 
            this.Tbx_Debug_M6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M6.Location = new System.Drawing.Point(372, 27);
            this.Tbx_Debug_M6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M6.Name = "Tbx_Debug_M6";
            this.Tbx_Debug_M6.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M6.TabIndex = 8;
            this.Tbx_Debug_M6.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Btn_Debug_M2
            // 
            this.Btn_Debug_M2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M2.Location = new System.Drawing.Point(305, 51);
            this.Btn_Debug_M2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M2.Name = "Btn_Debug_M2";
            this.Btn_Debug_M2.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M2.TabIndex = 14;
            this.Btn_Debug_M2.Text = "2";
            this.Btn_Debug_M2.UseVisualStyleBackColor = true;
            this.Btn_Debug_M2.Click += new System.EventHandler(this.Btn_Debug_M2_Click);
            // 
            // Tbx_Debug_M5
            // 
            this.Tbx_Debug_M5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Debug_M5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Debug_M5.Location = new System.Drawing.Point(372, 2);
            this.Tbx_Debug_M5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.Tbx_Debug_M5.Name = "Tbx_Debug_M5";
            this.Tbx_Debug_M5.Size = new System.Drawing.Size(165, 21);
            this.Tbx_Debug_M5.TabIndex = 7;
            this.Tbx_Debug_M5.TextChanged += new System.EventHandler(this.Debug_Send_M_TextChange);
            // 
            // Btn_Debug_M1
            // 
            this.Btn_Debug_M1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M1.Location = new System.Drawing.Point(305, 26);
            this.Btn_Debug_M1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M1.Name = "Btn_Debug_M1";
            this.Btn_Debug_M1.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M1.TabIndex = 13;
            this.Btn_Debug_M1.Text = "1";
            this.Btn_Debug_M1.UseVisualStyleBackColor = true;
            this.Btn_Debug_M1.Click += new System.EventHandler(this.Btn_Debug_M1_Click);
            // 
            // Btn_Debug_M0
            // 
            this.Btn_Debug_M0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Debug_M0.Location = new System.Drawing.Point(305, 1);
            this.Btn_Debug_M0.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.Btn_Debug_M0.Name = "Btn_Debug_M0";
            this.Btn_Debug_M0.Size = new System.Drawing.Size(38, 24);
            this.Btn_Debug_M0.TabIndex = 12;
            this.Btn_Debug_M0.Text = "0";
            this.Btn_Debug_M0.UseVisualStyleBackColor = true;
            this.Btn_Debug_M0.Click += new System.EventHandler(this.Btn_Debug_M0_Click);
            // 
            // Pal_Debug_SwitchProject
            // 
            this.Tblp_Send_M.SetColumnSpan(this.Pal_Debug_SwitchProject, 6);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Lab_Debug_Switch_ProjectTip);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_M_Next);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Lab_Debug_M_Page);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_Prj_Add);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Tbx_Debug_M_Go_Page);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_M_Add);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Lab_Debug_Sort2);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_M_First);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Lab_Debug_Sort1);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_M_Pre);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_M_Rmv);
            this.Pal_Debug_SwitchProject.Controls.Add(this.Btn_Debug_M_Last);
            this.Pal_Debug_SwitchProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pal_Debug_SwitchProject.Location = new System.Drawing.Point(108, 125);
            this.Pal_Debug_SwitchProject.Margin = new System.Windows.Forms.Padding(0);
            this.Pal_Debug_SwitchProject.Name = "Pal_Debug_SwitchProject";
            this.Pal_Debug_SwitchProject.Size = new System.Drawing.Size(472, 28);
            this.Pal_Debug_SwitchProject.TabIndex = 65;
            // 
            // Lab_Debug_Switch_ProjectTip
            // 
            this.Lab_Debug_Switch_ProjectTip.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lab_Debug_Switch_ProjectTip.AutoSize = true;
            this.Lab_Debug_Switch_ProjectTip.Location = new System.Drawing.Point(33, 7);
            this.Lab_Debug_Switch_ProjectTip.Name = "Lab_Debug_Switch_ProjectTip";
            this.Lab_Debug_Switch_ProjectTip.Size = new System.Drawing.Size(85, 14);
            this.Lab_Debug_Switch_ProjectTip.TabIndex = 64;
            this.Lab_Debug_Switch_ProjectTip.Text = "双击切换项目";
            // 
            // Lab_Debug_M_Page
            // 
            this.Lab_Debug_M_Page.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lab_Debug_M_Page.Location = new System.Drawing.Point(253, 5);
            this.Lab_Debug_M_Page.Name = "Lab_Debug_M_Page";
            this.Lab_Debug_M_Page.Size = new System.Drawing.Size(68, 18);
            this.Lab_Debug_M_Page.TabIndex = 53;
            this.Lab_Debug_M_Page.Text = "1/1";
            this.Lab_Debug_M_Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tbx_Debug_M_Go_Page
            // 
            this.Tbx_Debug_M_Go_Page.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Tbx_Debug_M_Go_Page.Location = new System.Drawing.Point(416, 3);
            this.Tbx_Debug_M_Go_Page.Name = "Tbx_Debug_M_Go_Page";
            this.Tbx_Debug_M_Go_Page.Size = new System.Drawing.Size(29, 21);
            this.Tbx_Debug_M_Go_Page.TabIndex = 28;
            this.Tbx_Debug_M_Go_Page.Text = "1";
            this.Tbx_Debug_M_Go_Page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Num);
            // 
            // Lab_Debug_Sort2
            // 
            this.Lab_Debug_Sort2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lab_Debug_Sort2.AutoSize = true;
            this.Lab_Debug_Sort2.Location = new System.Drawing.Point(448, 7);
            this.Lab_Debug_Sort2.Name = "Lab_Debug_Sort2";
            this.Lab_Debug_Sort2.Size = new System.Drawing.Size(20, 14);
            this.Lab_Debug_Sort2.TabIndex = 63;
            this.Lab_Debug_Sort2.Text = "页";
            // 
            // Lab_Debug_Sort1
            // 
            this.Lab_Debug_Sort1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Lab_Debug_Sort1.AutoSize = true;
            this.Lab_Debug_Sort1.Location = new System.Drawing.Point(393, 7);
            this.Lab_Debug_Sort1.Name = "Lab_Debug_Sort1";
            this.Lab_Debug_Sort1.Size = new System.Drawing.Size(20, 14);
            this.Lab_Debug_Sort1.TabIndex = 62;
            this.Lab_Debug_Sort1.Text = "第";
            // 
            // Pal_Debug_Operate
            // 
            this.Pal_Debug_Operate.Controls.Add(this.Btn_Debug_M_Output);
            this.Pal_Debug_Operate.Controls.Add(this.Btn_Debug_M_Go_Page);
            this.Pal_Debug_Operate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pal_Debug_Operate.Location = new System.Drawing.Point(580, 125);
            this.Pal_Debug_Operate.Margin = new System.Windows.Forms.Padding(0);
            this.Pal_Debug_Operate.Name = "Pal_Debug_Operate";
            this.Pal_Debug_Operate.Size = new System.Drawing.Size(182, 28);
            this.Pal_Debug_Operate.TabIndex = 66;
            // 
            // Btn_Debug_M_Output
            // 
            this.Btn_Debug_M_Output.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Debug_M_Output.Location = new System.Drawing.Point(102, 2);
            this.Btn_Debug_M_Output.Name = "Btn_Debug_M_Output";
            this.Btn_Debug_M_Output.Size = new System.Drawing.Size(76, 24);
            this.Btn_Debug_M_Output.TabIndex = 30;
            this.Btn_Debug_M_Output.Text = "导出";
            this.Btn_Debug_M_Output.UseVisualStyleBackColor = true;
            this.Btn_Debug_M_Output.Click += new System.EventHandler(this.Btn_Debug_M_Output_Click);
            // 
            // Tp_Debug_Send_Protocol
            // 
            this.Tp_Debug_Send_Protocol.BackColor = System.Drawing.SystemColors.Window;
            this.Tp_Debug_Send_Protocol.Controls.Add(this.label43);
            this.Tp_Debug_Send_Protocol.Location = new System.Drawing.Point(4, 28);
            this.Tp_Debug_Send_Protocol.Name = "Tp_Debug_Send_Protocol";
            this.Tp_Debug_Send_Protocol.Size = new System.Drawing.Size(768, 156);
            this.Tp_Debug_Send_Protocol.TabIndex = 2;
            this.Tp_Debug_Send_Protocol.Text = "协议发送";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(13, 10);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(172, 15);
            this.label43.TabIndex = 1;
            this.label43.Text = "开发中，敬请期待。。。";
            // 
            // Lab_Debug_Delay
            // 
            this.Lab_Debug_Delay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_Delay.AutoSize = true;
            this.Lab_Debug_Delay.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_Delay.Location = new System.Drawing.Point(677, 269);
            this.Lab_Debug_Delay.Name = "Lab_Debug_Delay";
            this.Lab_Debug_Delay.Size = new System.Drawing.Size(46, 14);
            this.Lab_Debug_Delay.TabIndex = 16;
            this.Lab_Debug_Delay.Text = "延时：";
            // 
            // Lab_Debug_Operate
            // 
            this.Lab_Debug_Operate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Debug_Operate.AutoSize = true;
            this.Lab_Debug_Operate.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Debug_Operate.Location = new System.Drawing.Point(619, 167);
            this.Lab_Debug_Operate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_Debug_Operate.Name = "Lab_Debug_Operate";
            this.Lab_Debug_Operate.Size = new System.Drawing.Size(49, 14);
            this.Lab_Debug_Operate.TabIndex = 2;
            this.Lab_Debug_Operate.Text = "操作：";
            // 
            // Tp_DL
            // 
            this.Tp_DL.Controls.Add(this.Cbx_DL_BaudRate);
            this.Tp_DL.Controls.Add(this.Pgb_DL_Task_Process);
            this.Tp_DL.Controls.Add(this.Cbx_DL_Serial_Num);
            this.Tp_DL.Controls.Add(this.Gbx_Option_Byte);
            this.Tp_DL.Controls.Add(this.Lbx_Msg_DL);
            this.Tp_DL.Controls.Add(this.Gbx_DL_Option);
            this.Tp_DL.Controls.Add(this.Lab_DL_BaudRate);
            this.Tp_DL.Controls.Add(this.Lab_DL_SerialNum);
            this.Tp_DL.Controls.Add(this.Tbx_DL_File_Path);
            this.Tp_DL.Controls.Add(this.Btn_DL_Erase_Chip);
            this.Tp_DL.Controls.Add(this.Btn_DL_Select_File);
            this.Tp_DL.Controls.Add(this.Btn_Serial_DL_Fresh);
            this.Tp_DL.Controls.Add(this.Btn_DL_Read_Chip_Info);
            this.Tp_DL.Controls.Add(this.Btn_DL_DownLoad_File);
            this.Tp_DL.Controls.Add(this.Lab_DownloadFilePath);
            this.Tp_DL.Location = new System.Drawing.Point(1, 30);
            this.Tp_DL.Name = "Tp_DL";
            this.Tp_DL.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_DL.Size = new System.Drawing.Size(782, 482);
            this.Tp_DL.TabIndex = 1;
            this.Tp_DL.Text = "下载助手";
            this.Tp_DL.UseVisualStyleBackColor = true;
            // 
            // Cbx_DL_BaudRate
            // 
            this.Cbx_DL_BaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_DL_BaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_DL_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_DL_BaudRate.FormattingEnabled = true;
            this.Cbx_DL_BaudRate.Items.AddRange(new object[] {
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
            this.Cbx_DL_BaudRate.Location = new System.Drawing.Point(663, 10);
            this.Cbx_DL_BaudRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_DL_BaudRate.Name = "Cbx_DL_BaudRate";
            this.Cbx_DL_BaudRate.Size = new System.Drawing.Size(83, 23);
            this.Cbx_DL_BaudRate.TabIndex = 1;
            // 
            // Pgb_DL_Task_Process
            // 
            this.Pgb_DL_Task_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pgb_DL_Task_Process.Location = new System.Drawing.Point(375, 458);
            this.Pgb_DL_Task_Process.Name = "Pgb_DL_Task_Process";
            this.Pgb_DL_Task_Process.Size = new System.Drawing.Size(401, 18);
            this.Pgb_DL_Task_Process.Step = 1;
            this.Pgb_DL_Task_Process.TabIndex = 4;
            // 
            // Cbx_DL_Serial_Num
            // 
            this.Cbx_DL_Serial_Num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_DL_Serial_Num.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_DL_Serial_Num.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_DL_Serial_Num.DropDownWidth = 180;
            this.Cbx_DL_Serial_Num.FormattingEnabled = true;
            this.Cbx_DL_Serial_Num.Location = new System.Drawing.Point(432, 10);
            this.Cbx_DL_Serial_Num.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_DL_Serial_Num.Name = "Cbx_DL_Serial_Num";
            this.Cbx_DL_Serial_Num.Size = new System.Drawing.Size(140, 23);
            this.Cbx_DL_Serial_Num.TabIndex = 0;
            // 
            // Gbx_Option_Byte
            // 
            this.Gbx_Option_Byte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_UserDataByteExplain2);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_UserDataByteExplain1);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_User_Data2);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_User_Data1);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_UserDataByte0x2);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_UserDataByte0x1);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_UserDataByte);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByteExplain4);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByteExplain3);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_Write_Protect4);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_Write_Protect3);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByte0x4);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByte0x3);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_HW_Byte);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByteExplain2);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByteExplain1);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_Write_Protect2);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_HardwareOptionByte0x);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_Read_Protect);
            this.Gbx_Option_Byte.Controls.Add(this.Tbx_DL_Write_Protect1);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByte);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_HardwareOptionByteExplain);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_HardwareOptionByte);
            this.Gbx_Option_Byte.Controls.Add(this.Btn_DetailSet);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_ReadProtectByteExplain);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_ReadProtectedByte);
            this.Gbx_Option_Byte.Controls.Add(this.Btn_Option_Set_Default);
            this.Gbx_Option_Byte.Controls.Add(this.Ckbx_DL_Write_Option_Byte);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByte0x2);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_WriteProtectedByte0x1);
            this.Gbx_Option_Byte.Controls.Add(this.Lab_DL_ReadProtectByte0x);
            this.Gbx_Option_Byte.Enabled = false;
            this.Gbx_Option_Byte.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gbx_Option_Byte.Location = new System.Drawing.Point(375, 287);
            this.Gbx_Option_Byte.Name = "Gbx_Option_Byte";
            this.Gbx_Option_Byte.Size = new System.Drawing.Size(401, 166);
            this.Gbx_Option_Byte.TabIndex = 120;
            this.Gbx_Option_Byte.TabStop = false;
            this.Gbx_Option_Byte.Text = "选项字节";
            // 
            // Lab_DL_UserDataByteExplain2
            // 
            this.Lab_DL_UserDataByteExplain2.AutoSize = true;
            this.Lab_DL_UserDataByteExplain2.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_UserDataByteExplain2.Location = new System.Drawing.Point(260, 142);
            this.Lab_DL_UserDataByteExplain2.Name = "Lab_DL_UserDataByteExplain2";
            this.Lab_DL_UserDataByteExplain2.Size = new System.Drawing.Size(111, 14);
            this.Lab_DL_UserDataByteExplain2.TabIndex = 33;
            this.Lab_DL_UserDataByteExplain2.Text = "地址：0x1FFFF806";
            // 
            // Lab_DL_UserDataByteExplain1
            // 
            this.Lab_DL_UserDataByteExplain1.AutoSize = true;
            this.Lab_DL_UserDataByteExplain1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_UserDataByteExplain1.Location = new System.Drawing.Point(260, 117);
            this.Lab_DL_UserDataByteExplain1.Name = "Lab_DL_UserDataByteExplain1";
            this.Lab_DL_UserDataByteExplain1.Size = new System.Drawing.Size(111, 14);
            this.Lab_DL_UserDataByteExplain1.TabIndex = 29;
            this.Lab_DL_UserDataByteExplain1.Text = "地址：0x1FFFF804";
            // 
            // Tbx_DL_User_Data2
            // 
            this.Tbx_DL_User_Data2.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_User_Data2.Location = new System.Drawing.Point(229, 139);
            this.Tbx_DL_User_Data2.MaxLength = 2;
            this.Tbx_DL_User_Data2.Name = "Tbx_DL_User_Data2";
            this.Tbx_DL_User_Data2.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_User_Data2.TabIndex = 27;
            this.Tbx_DL_User_Data2.Text = "FF";
            this.Tbx_DL_User_Data2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_User_Data2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Tbx_DL_User_Data1
            // 
            this.Tbx_DL_User_Data1.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_User_Data1.Location = new System.Drawing.Point(229, 114);
            this.Tbx_DL_User_Data1.MaxLength = 2;
            this.Tbx_DL_User_Data1.Name = "Tbx_DL_User_Data1";
            this.Tbx_DL_User_Data1.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_User_Data1.TabIndex = 26;
            this.Tbx_DL_User_Data1.Text = "FF";
            this.Tbx_DL_User_Data1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_User_Data1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Lab_DL_UserDataByte0x2
            // 
            this.Lab_DL_UserDataByte0x2.AutoSize = true;
            this.Lab_DL_UserDataByte0x2.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_UserDataByte0x2.Location = new System.Drawing.Point(210, 142);
            this.Lab_DL_UserDataByte0x2.Name = "Lab_DL_UserDataByte0x2";
            this.Lab_DL_UserDataByte0x2.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_UserDataByte0x2.TabIndex = 32;
            this.Lab_DL_UserDataByte0x2.Text = "0x";
            // 
            // Lab_DL_UserDataByte0x1
            // 
            this.Lab_DL_UserDataByte0x1.AutoSize = true;
            this.Lab_DL_UserDataByte0x1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_UserDataByte0x1.Location = new System.Drawing.Point(210, 117);
            this.Lab_DL_UserDataByte0x1.Name = "Lab_DL_UserDataByte0x1";
            this.Lab_DL_UserDataByte0x1.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_UserDataByte0x1.TabIndex = 31;
            this.Lab_DL_UserDataByte0x1.Text = "0x";
            // 
            // Lab_DL_UserDataByte
            // 
            this.Lab_DL_UserDataByte.AutoSize = true;
            this.Lab_DL_UserDataByte.Location = new System.Drawing.Point(210, 95);
            this.Lab_DL_UserDataByte.Name = "Lab_DL_UserDataByte";
            this.Lab_DL_UserDataByte.Size = new System.Drawing.Size(98, 14);
            this.Lab_DL_UserDataByte.TabIndex = 26;
            this.Lab_DL_UserDataByte.Text = "用户数据字节：";
            // 
            // Lab_DL_WriteProtectedByteExplain4
            // 
            this.Lab_DL_WriteProtectedByteExplain4.AutoSize = true;
            this.Lab_DL_WriteProtectedByteExplain4.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByteExplain4.Location = new System.Drawing.Point(147, 142);
            this.Lab_DL_WriteProtectedByteExplain4.Name = "Lab_DL_WriteProtectedByteExplain4";
            this.Lab_DL_WriteProtectedByteExplain4.Size = new System.Drawing.Size(56, 14);
            this.Lab_DL_WriteProtectedByteExplain4.TabIndex = 23;
            this.Lab_DL_WriteProtectedByteExplain4.Text = "97-512K";
            // 
            // Lab_DL_WriteProtectedByteExplain3
            // 
            this.Lab_DL_WriteProtectedByteExplain3.AutoSize = true;
            this.Lab_DL_WriteProtectedByteExplain3.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByteExplain3.Location = new System.Drawing.Point(147, 117);
            this.Lab_DL_WriteProtectedByteExplain3.Name = "Lab_DL_WriteProtectedByteExplain3";
            this.Lab_DL_WriteProtectedByteExplain3.Size = new System.Drawing.Size(49, 14);
            this.Lab_DL_WriteProtectedByteExplain3.TabIndex = 22;
            this.Lab_DL_WriteProtectedByteExplain3.Text = "65-96K";
            // 
            // Tbx_DL_Write_Protect4
            // 
            this.Tbx_DL_Write_Protect4.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_Write_Protect4.Location = new System.Drawing.Point(120, 139);
            this.Tbx_DL_Write_Protect4.MaxLength = 2;
            this.Tbx_DL_Write_Protect4.Name = "Tbx_DL_Write_Protect4";
            this.Tbx_DL_Write_Protect4.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_Write_Protect4.TabIndex = 25;
            this.Tbx_DL_Write_Protect4.Text = "FF";
            this.Tbx_DL_Write_Protect4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_Write_Protect4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Tbx_DL_Write_Protect3
            // 
            this.Tbx_DL_Write_Protect3.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_Write_Protect3.Location = new System.Drawing.Point(120, 114);
            this.Tbx_DL_Write_Protect3.MaxLength = 2;
            this.Tbx_DL_Write_Protect3.Name = "Tbx_DL_Write_Protect3";
            this.Tbx_DL_Write_Protect3.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_Write_Protect3.TabIndex = 24;
            this.Tbx_DL_Write_Protect3.Text = "FF";
            this.Tbx_DL_Write_Protect3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_Write_Protect3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Lab_DL_WriteProtectedByte0x4
            // 
            this.Lab_DL_WriteProtectedByte0x4.AutoSize = true;
            this.Lab_DL_WriteProtectedByte0x4.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByte0x4.Location = new System.Drawing.Point(101, 142);
            this.Lab_DL_WriteProtectedByte0x4.Name = "Lab_DL_WriteProtectedByte0x4";
            this.Lab_DL_WriteProtectedByte0x4.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_WriteProtectedByte0x4.TabIndex = 25;
            this.Lab_DL_WriteProtectedByte0x4.Text = "0x";
            // 
            // Lab_DL_WriteProtectedByte0x3
            // 
            this.Lab_DL_WriteProtectedByte0x3.AutoSize = true;
            this.Lab_DL_WriteProtectedByte0x3.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByte0x3.Location = new System.Drawing.Point(101, 117);
            this.Lab_DL_WriteProtectedByte0x3.Name = "Lab_DL_WriteProtectedByte0x3";
            this.Lab_DL_WriteProtectedByte0x3.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_WriteProtectedByte0x3.TabIndex = 24;
            this.Lab_DL_WriteProtectedByte0x3.Text = "0x";
            // 
            // Tbx_DL_HW_Byte
            // 
            this.Tbx_DL_HW_Byte.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_HW_Byte.Location = new System.Drawing.Point(229, 68);
            this.Tbx_DL_HW_Byte.MaxLength = 2;
            this.Tbx_DL_HW_Byte.Name = "Tbx_DL_HW_Byte";
            this.Tbx_DL_HW_Byte.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_HW_Byte.TabIndex = 21;
            this.Tbx_DL_HW_Byte.Text = "FF";
            this.Tbx_DL_HW_Byte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_HW_Byte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Lab_DL_WriteProtectedByteExplain2
            // 
            this.Lab_DL_WriteProtectedByteExplain2.AutoSize = true;
            this.Lab_DL_WriteProtectedByteExplain2.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByteExplain2.Location = new System.Drawing.Point(52, 142);
            this.Lab_DL_WriteProtectedByteExplain2.Name = "Lab_DL_WriteProtectedByteExplain2";
            this.Lab_DL_WriteProtectedByteExplain2.Size = new System.Drawing.Size(49, 14);
            this.Lab_DL_WriteProtectedByteExplain2.TabIndex = 16;
            this.Lab_DL_WriteProtectedByteExplain2.Text = "33-64K";
            // 
            // Lab_DL_WriteProtectedByteExplain1
            // 
            this.Lab_DL_WriteProtectedByteExplain1.AutoSize = true;
            this.Lab_DL_WriteProtectedByteExplain1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByteExplain1.Location = new System.Drawing.Point(52, 117);
            this.Lab_DL_WriteProtectedByteExplain1.Name = "Lab_DL_WriteProtectedByteExplain1";
            this.Lab_DL_WriteProtectedByteExplain1.Size = new System.Drawing.Size(42, 14);
            this.Lab_DL_WriteProtectedByteExplain1.TabIndex = 15;
            this.Lab_DL_WriteProtectedByteExplain1.Text = "0-32K";
            // 
            // Tbx_DL_Write_Protect2
            // 
            this.Tbx_DL_Write_Protect2.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_Write_Protect2.Location = new System.Drawing.Point(25, 139);
            this.Tbx_DL_Write_Protect2.MaxLength = 2;
            this.Tbx_DL_Write_Protect2.Name = "Tbx_DL_Write_Protect2";
            this.Tbx_DL_Write_Protect2.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_Write_Protect2.TabIndex = 23;
            this.Tbx_DL_Write_Protect2.Text = "FF";
            this.Tbx_DL_Write_Protect2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_Write_Protect2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Lab_DL_HardwareOptionByte0x
            // 
            this.Lab_DL_HardwareOptionByte0x.AutoSize = true;
            this.Lab_DL_HardwareOptionByte0x.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_HardwareOptionByte0x.Location = new System.Drawing.Point(210, 71);
            this.Lab_DL_HardwareOptionByte0x.Name = "Lab_DL_HardwareOptionByte0x";
            this.Lab_DL_HardwareOptionByte0x.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_HardwareOptionByte0x.TabIndex = 13;
            this.Lab_DL_HardwareOptionByte0x.Text = "0x";
            // 
            // Tbx_DL_Read_Protect
            // 
            this.Tbx_DL_Read_Protect.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_Read_Protect.Location = new System.Drawing.Point(25, 68);
            this.Tbx_DL_Read_Protect.MaxLength = 2;
            this.Tbx_DL_Read_Protect.Name = "Tbx_DL_Read_Protect";
            this.Tbx_DL_Read_Protect.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_Read_Protect.TabIndex = 20;
            this.Tbx_DL_Read_Protect.Text = "5A";
            this.Tbx_DL_Read_Protect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_Read_Protect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Tbx_DL_Write_Protect1
            // 
            this.Tbx_DL_Write_Protect1.ForeColor = System.Drawing.Color.Black;
            this.Tbx_DL_Write_Protect1.Location = new System.Drawing.Point(25, 114);
            this.Tbx_DL_Write_Protect1.MaxLength = 2;
            this.Tbx_DL_Write_Protect1.Name = "Tbx_DL_Write_Protect1";
            this.Tbx_DL_Write_Protect1.Size = new System.Drawing.Size(26, 21);
            this.Tbx_DL_Write_Protect1.TabIndex = 22;
            this.Tbx_DL_Write_Protect1.Text = "FF";
            this.Tbx_DL_Write_Protect1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tbx_DL_Write_Protect1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Lab_DL_WriteProtectedByte
            // 
            this.Lab_DL_WriteProtectedByte.AutoSize = true;
            this.Lab_DL_WriteProtectedByte.Location = new System.Drawing.Point(6, 95);
            this.Lab_DL_WriteProtectedByte.Name = "Lab_DL_WriteProtectedByte";
            this.Lab_DL_WriteProtectedByte.Size = new System.Drawing.Size(85, 14);
            this.Lab_DL_WriteProtectedByte.TabIndex = 10;
            this.Lab_DL_WriteProtectedByte.Text = "写保护字节：";
            // 
            // Lab_DL_HardwareOptionByteExplain
            // 
            this.Lab_DL_HardwareOptionByteExplain.AutoSize = true;
            this.Lab_DL_HardwareOptionByteExplain.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_HardwareOptionByteExplain.Location = new System.Drawing.Point(260, 71);
            this.Lab_DL_HardwareOptionByteExplain.Name = "Lab_DL_HardwareOptionByteExplain";
            this.Lab_DL_HardwareOptionByteExplain.Size = new System.Drawing.Size(135, 14);
            this.Lab_DL_HardwareOptionByteExplain.TabIndex = 8;
            this.Lab_DL_HardwareOptionByteExplain.Text = "bit0=0使能硬件看门狗";
            // 
            // Lab_DL_HardwareOptionByte
            // 
            this.Lab_DL_HardwareOptionByte.AutoSize = true;
            this.Lab_DL_HardwareOptionByte.Location = new System.Drawing.Point(210, 47);
            this.Lab_DL_HardwareOptionByte.Name = "Lab_DL_HardwareOptionByte";
            this.Lab_DL_HardwareOptionByte.Size = new System.Drawing.Size(98, 14);
            this.Lab_DL_HardwareOptionByte.TabIndex = 7;
            this.Lab_DL_HardwareOptionByte.Text = "硬件选项字节：";
            // 
            // Btn_DetailSet
            // 
            this.Btn_DetailSet.Location = new System.Drawing.Point(305, 17);
            this.Btn_DetailSet.Name = "Btn_DetailSet";
            this.Btn_DetailSet.Size = new System.Drawing.Size(90, 23);
            this.Btn_DetailSet.TabIndex = 19;
            this.Btn_DetailSet.Text = "详细设置";
            this.Btn_DetailSet.UseVisualStyleBackColor = true;
            // 
            // Lab_DL_ReadProtectByteExplain
            // 
            this.Lab_DL_ReadProtectByteExplain.AutoSize = true;
            this.Lab_DL_ReadProtectByteExplain.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_ReadProtectByteExplain.Location = new System.Drawing.Point(57, 71);
            this.Lab_DL_ReadProtectByteExplain.Name = "Lab_DL_ReadProtectByteExplain";
            this.Lab_DL_ReadProtectByteExplain.Size = new System.Drawing.Size(122, 14);
            this.Lab_DL_ReadProtectByteExplain.TabIndex = 4;
            this.Lab_DL_ReadProtectByteExplain.Text = "0x5A:可读 0xFF;禁读";
            // 
            // Lab_DL_ReadProtectedByte
            // 
            this.Lab_DL_ReadProtectedByte.AutoSize = true;
            this.Lab_DL_ReadProtectedByte.Location = new System.Drawing.Point(6, 47);
            this.Lab_DL_ReadProtectedByte.Name = "Lab_DL_ReadProtectedByte";
            this.Lab_DL_ReadProtectedByte.Size = new System.Drawing.Size(85, 14);
            this.Lab_DL_ReadProtectedByte.TabIndex = 3;
            this.Lab_DL_ReadProtectedByte.Text = "读保护字节：";
            // 
            // Btn_Option_Set_Default
            // 
            this.Btn_Option_Set_Default.Location = new System.Drawing.Point(208, 17);
            this.Btn_Option_Set_Default.Name = "Btn_Option_Set_Default";
            this.Btn_Option_Set_Default.Size = new System.Drawing.Size(90, 23);
            this.Btn_Option_Set_Default.TabIndex = 18;
            this.Btn_Option_Set_Default.Text = "恢复默认";
            this.Btn_Option_Set_Default.UseVisualStyleBackColor = true;
            this.Btn_Option_Set_Default.Click += new System.EventHandler(this.Btn_Option_Set_Default_Click);
            // 
            // Ckbx_DL_Write_Option_Byte
            // 
            this.Ckbx_DL_Write_Option_Byte.AutoSize = true;
            this.Ckbx_DL_Write_Option_Byte.Location = new System.Drawing.Point(9, 20);
            this.Ckbx_DL_Write_Option_Byte.Name = "Ckbx_DL_Write_Option_Byte";
            this.Ckbx_DL_Write_Option_Byte.Size = new System.Drawing.Size(130, 18);
            this.Ckbx_DL_Write_Option_Byte.TabIndex = 17;
            this.Ckbx_DL_Write_Option_Byte.Text = "下载时写选项字节";
            this.Ckbx_DL_Write_Option_Byte.UseVisualStyleBackColor = true;
            // 
            // Lab_DL_WriteProtectedByte0x2
            // 
            this.Lab_DL_WriteProtectedByte0x2.AutoSize = true;
            this.Lab_DL_WriteProtectedByte0x2.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByte0x2.Location = new System.Drawing.Point(6, 142);
            this.Lab_DL_WriteProtectedByte0x2.Name = "Lab_DL_WriteProtectedByte0x2";
            this.Lab_DL_WriteProtectedByte0x2.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_WriteProtectedByte0x2.TabIndex = 18;
            this.Lab_DL_WriteProtectedByte0x2.Text = "0x";
            // 
            // Lab_DL_WriteProtectedByte0x1
            // 
            this.Lab_DL_WriteProtectedByte0x1.AutoSize = true;
            this.Lab_DL_WriteProtectedByte0x1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_WriteProtectedByte0x1.Location = new System.Drawing.Point(6, 117);
            this.Lab_DL_WriteProtectedByte0x1.Name = "Lab_DL_WriteProtectedByte0x1";
            this.Lab_DL_WriteProtectedByte0x1.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_WriteProtectedByte0x1.TabIndex = 17;
            this.Lab_DL_WriteProtectedByte0x1.Text = "0x";
            // 
            // Lab_DL_ReadProtectByte0x
            // 
            this.Lab_DL_ReadProtectByte0x.AutoSize = true;
            this.Lab_DL_ReadProtectByte0x.ForeColor = System.Drawing.Color.DarkBlue;
            this.Lab_DL_ReadProtectByte0x.Location = new System.Drawing.Point(6, 71);
            this.Lab_DL_ReadProtectByte0x.Name = "Lab_DL_ReadProtectByte0x";
            this.Lab_DL_ReadProtectByte0x.Size = new System.Drawing.Size(20, 14);
            this.Lab_DL_ReadProtectByte0x.TabIndex = 12;
            this.Lab_DL_ReadProtectByte0x.Text = "0x";
            // 
            // Lbx_Msg_DL
            // 
            this.Lbx_Msg_DL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbx_Msg_DL.BackColor = System.Drawing.Color.White;
            this.Lbx_Msg_DL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbx_Msg_DL.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbx_Msg_DL.ForeColor = System.Drawing.Color.Black;
            this.Lbx_Msg_DL.FormattingEnabled = true;
            this.Lbx_Msg_DL.HorizontalScrollbar = true;
            this.Lbx_Msg_DL.IntegralHeight = false;
            this.Lbx_Msg_DL.ItemHeight = 14;
            this.Lbx_Msg_DL.Location = new System.Drawing.Point(3, 3);
            this.Lbx_Msg_DL.Name = "Lbx_Msg_DL";
            this.Lbx_Msg_DL.Size = new System.Drawing.Size(365, 476);
            this.Lbx_Msg_DL.TabIndex = 13;
            this.Lbx_Msg_DL.TabStop = false;
            // 
            // Gbx_DL_Option
            // 
            this.Gbx_DL_Option.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_DL_Option.Controls.Add(this.Ckbx_Set_Read_Protect);
            this.Gbx_DL_Option.Controls.Add(this.Ckbx_DL_Show_Time);
            this.Gbx_DL_Option.Controls.Add(this.Ckbx_DL_Auto_Close_Debug_Port);
            this.Gbx_DL_Option.Controls.Add(this.Cbx_Auto_DL);
            this.Gbx_DL_Option.Controls.Add(this.Lab_EraseWay);
            this.Gbx_DL_Option.Controls.Add(this.Tbx_DL_Adress);
            this.Gbx_DL_Option.Controls.Add(this.Rbtn_Erase_Part);
            this.Gbx_DL_Option.Controls.Add(this.Ckbx_Check);
            this.Gbx_DL_Option.Controls.Add(this.Ckbx_Auto_Match);
            this.Gbx_DL_Option.Controls.Add(this.Rbtn_Erase_All);
            this.Gbx_DL_Option.Controls.Add(this.Cbx_Go_BL_Way);
            this.Gbx_DL_Option.Controls.Add(this.Lab_DownloadStartAddress);
            this.Gbx_DL_Option.Controls.Add(this.Tbx_Run_Adress);
            this.Gbx_DL_Option.Controls.Add(this.Lab_ProgramRunAddress);
            this.Gbx_DL_Option.Controls.Add(this.Ckbx_DL_After_Dir_Run);
            this.Gbx_DL_Option.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gbx_DL_Option.Location = new System.Drawing.Point(374, 118);
            this.Gbx_DL_Option.Name = "Gbx_DL_Option";
            this.Gbx_DL_Option.Size = new System.Drawing.Size(402, 163);
            this.Gbx_DL_Option.TabIndex = 119;
            this.Gbx_DL_Option.TabStop = false;
            this.Gbx_DL_Option.Text = "操作选项";
            // 
            // Ckbx_Set_Read_Protect
            // 
            this.Ckbx_Set_Read_Protect.AutoSize = true;
            this.Ckbx_Set_Read_Protect.Location = new System.Drawing.Point(88, 107);
            this.Ckbx_Set_Read_Protect.Name = "Ckbx_Set_Read_Protect";
            this.Ckbx_Set_Read_Protect.Size = new System.Drawing.Size(117, 18);
            this.Ckbx_Set_Read_Protect.TabIndex = 110;
            this.Ckbx_Set_Read_Protect.Text = "设置芯片读保护";
            this.Ckbx_Set_Read_Protect.UseVisualStyleBackColor = true;
            // 
            // Ckbx_DL_Show_Time
            // 
            this.Ckbx_DL_Show_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ckbx_DL_Show_Time.AutoSize = true;
            this.Ckbx_DL_Show_Time.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_DL_Show_Time.Location = new System.Drawing.Point(10, 108);
            this.Ckbx_DL_Show_Time.Name = "Ckbx_DL_Show_Time";
            this.Ckbx_DL_Show_Time.Size = new System.Drawing.Size(62, 17);
            this.Ckbx_DL_Show_Time.TabIndex = 13;
            this.Ckbx_DL_Show_Time.Text = "时间戳";
            this.Ckbx_DL_Show_Time.UseVisualStyleBackColor = true;
            // 
            // Cbx_Auto_DL
            // 
            this.Cbx_Auto_DL.AutoSize = true;
            this.Cbx_Auto_DL.Location = new System.Drawing.Point(306, 108);
            this.Cbx_Auto_DL.Name = "Cbx_Auto_DL";
            this.Cbx_Auto_DL.Size = new System.Drawing.Size(78, 18);
            this.Cbx_Auto_DL.TabIndex = 14;
            this.Cbx_Auto_DL.Text = "自动下载";
            this.Cbx_Auto_DL.UseVisualStyleBackColor = true;
            // 
            // Lab_EraseWay
            // 
            this.Lab_EraseWay.AutoSize = true;
            this.Lab_EraseWay.Location = new System.Drawing.Point(7, 136);
            this.Lab_EraseWay.Name = "Lab_EraseWay";
            this.Lab_EraseWay.Size = new System.Drawing.Size(72, 14);
            this.Lab_EraseWay.TabIndex = 109;
            this.Lab_EraseWay.Text = "擦除方式：";
            // 
            // Tbx_DL_Adress
            // 
            this.Tbx_DL_Adress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_DL_Adress.Location = new System.Drawing.Point(114, 50);
            this.Tbx_DL_Adress.MaxLength = 8;
            this.Tbx_DL_Adress.Name = "Tbx_DL_Adress";
            this.Tbx_DL_Adress.ReadOnly = true;
            this.Tbx_DL_Adress.Size = new System.Drawing.Size(80, 21);
            this.Tbx_DL_Adress.TabIndex = 8;
            this.Tbx_DL_Adress.Text = "08000000";
            this.Tbx_DL_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Rbtn_Erase_Part
            // 
            this.Rbtn_Erase_Part.AutoSize = true;
            this.Rbtn_Erase_Part.Location = new System.Drawing.Point(280, 134);
            this.Rbtn_Erase_Part.Name = "Rbtn_Erase_Part";
            this.Rbtn_Erase_Part.Size = new System.Drawing.Size(116, 18);
            this.Rbtn_Erase_Part.TabIndex = 16;
            this.Rbtn_Erase_Part.Text = "仅擦除下载扇区";
            this.Rbtn_Erase_Part.UseVisualStyleBackColor = true;
            // 
            // Ckbx_Check
            // 
            this.Ckbx_Check.AutoSize = true;
            this.Ckbx_Check.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Check.Location = new System.Drawing.Point(10, 79);
            this.Ckbx_Check.Name = "Ckbx_Check";
            this.Ckbx_Check.Size = new System.Drawing.Size(52, 18);
            this.Ckbx_Check.TabIndex = 10;
            this.Ckbx_Check.Text = "检验";
            this.Ckbx_Check.UseVisualStyleBackColor = true;
            // 
            // Ckbx_Auto_Match
            // 
            this.Ckbx_Auto_Match.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ckbx_Auto_Match.AutoSize = true;
            this.Ckbx_Auto_Match.Enabled = false;
            this.Ckbx_Auto_Match.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_Auto_Match.Location = new System.Drawing.Point(317, 22);
            this.Ckbx_Auto_Match.Name = "Ckbx_Auto_Match";
            this.Ckbx_Auto_Match.Size = new System.Drawing.Size(78, 18);
            this.Ckbx_Auto_Match.TabIndex = 7;
            this.Ckbx_Auto_Match.Text = "自动匹配";
            this.Ckbx_Auto_Match.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Erase_All
            // 
            this.Rbtn_Erase_All.AutoSize = true;
            this.Rbtn_Erase_All.Checked = true;
            this.Rbtn_Erase_All.Location = new System.Drawing.Point(88, 134);
            this.Rbtn_Erase_All.Name = "Rbtn_Erase_All";
            this.Rbtn_Erase_All.Size = new System.Drawing.Size(77, 18);
            this.Rbtn_Erase_All.TabIndex = 15;
            this.Rbtn_Erase_All.TabStop = true;
            this.Rbtn_Erase_All.Text = "全片擦除";
            this.Rbtn_Erase_All.UseVisualStyleBackColor = true;
            // 
            // Cbx_Go_BL_Way
            // 
            this.Cbx_Go_BL_Way.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbx_Go_BL_Way.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cbx_Go_BL_Way.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Go_BL_Way.DropDownWidth = 285;
            this.Cbx_Go_BL_Way.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cbx_Go_BL_Way.FormattingEnabled = true;
            this.Cbx_Go_BL_Way.Items.AddRange(new object[] {
            "不使用DTR和RTS",
            "DTR低电平复位，不使用RTS",
            "DTR低电平复位，RTS低电平进入BootLoader",
            "DTR低电平复位，RTS高电平进入Bootloader",
            "DTR高电平复位，不使用RTS",
            "DTR高电平复位，RTS低电平进入BootLoader",
            "DTR高电平复位，RTS高电平进入Bootloader",
            "RTS低电平复位，不使用DTR",
            "RTS低电平复位，DTR低电平进入BootLoader",
            "RTS低电平复位，DTR高电平进入Bootloader",
            "RTS高电平复位，不使用DTR",
            "RTS高电平复位，DTR低电平进入BootLoader",
            "RTS高电平复位，DTR高电平进入Bootloader"});
            this.Cbx_Go_BL_Way.Location = new System.Drawing.Point(5, 20);
            this.Cbx_Go_BL_Way.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Cbx_Go_BL_Way.Name = "Cbx_Go_BL_Way";
            this.Cbx_Go_BL_Way.Size = new System.Drawing.Size(305, 22);
            this.Cbx_Go_BL_Way.TabIndex = 6;
            // 
            // Lab_DownloadStartAddress
            // 
            this.Lab_DownloadStartAddress.AutoSize = true;
            this.Lab_DownloadStartAddress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_DownloadStartAddress.Location = new System.Drawing.Point(5, 54);
            this.Lab_DownloadStartAddress.Name = "Lab_DownloadStartAddress";
            this.Lab_DownloadStartAddress.Size = new System.Drawing.Size(111, 14);
            this.Lab_DownloadStartAddress.TabIndex = 7;
            this.Lab_DownloadStartAddress.Text = "下载起始地址：0x";
            // 
            // Tbx_Run_Adress
            // 
            this.Tbx_Run_Adress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Run_Adress.Location = new System.Drawing.Point(316, 50);
            this.Tbx_Run_Adress.MaxLength = 8;
            this.Tbx_Run_Adress.Name = "Tbx_Run_Adress";
            this.Tbx_Run_Adress.ReadOnly = true;
            this.Tbx_Run_Adress.Size = new System.Drawing.Size(80, 21);
            this.Tbx_Run_Adress.TabIndex = 9;
            this.Tbx_Run_Adress.Text = "08000000";
            this.Tbx_Run_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Allow_Hex);
            // 
            // Lab_ProgramRunAddress
            // 
            this.Lab_ProgramRunAddress.AutoSize = true;
            this.Lab_ProgramRunAddress.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_ProgramRunAddress.Location = new System.Drawing.Point(206, 53);
            this.Lab_ProgramRunAddress.Name = "Lab_ProgramRunAddress";
            this.Lab_ProgramRunAddress.Size = new System.Drawing.Size(111, 14);
            this.Lab_ProgramRunAddress.TabIndex = 7;
            this.Lab_ProgramRunAddress.Text = "程序运行地址：0x";
            // 
            // Ckbx_DL_After_Dir_Run
            // 
            this.Ckbx_DL_After_Dir_Run.AutoSize = true;
            this.Ckbx_DL_After_Dir_Run.Checked = true;
            this.Ckbx_DL_After_Dir_Run.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbx_DL_After_Dir_Run.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ckbx_DL_After_Dir_Run.Location = new System.Drawing.Point(88, 80);
            this.Ckbx_DL_After_Dir_Run.Name = "Ckbx_DL_After_Dir_Run";
            this.Ckbx_DL_After_Dir_Run.Size = new System.Drawing.Size(143, 18);
            this.Ckbx_DL_After_Dir_Run.TabIndex = 11;
            this.Ckbx_DL_After_Dir_Run.Text = "下载后直接跳转运行";
            this.Ckbx_DL_After_Dir_Run.UseVisualStyleBackColor = true;
            // 
            // Lab_DL_BaudRate
            // 
            this.Lab_DL_BaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_DL_BaudRate.AutoSize = true;
            this.Lab_DL_BaudRate.Location = new System.Drawing.Point(575, 14);
            this.Lab_DL_BaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_DL_BaudRate.Name = "Lab_DL_BaudRate";
            this.Lab_DL_BaudRate.Size = new System.Drawing.Size(97, 15);
            this.Lab_DL_BaudRate.TabIndex = 116;
            this.Lab_DL_BaudRate.Text = "下载波特率：";
            // 
            // Lab_DL_SerialNum
            // 
            this.Lab_DL_SerialNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_DL_SerialNum.AutoSize = true;
            this.Lab_DL_SerialNum.Location = new System.Drawing.Point(373, 14);
            this.Lab_DL_SerialNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_DL_SerialNum.Name = "Lab_DL_SerialNum";
            this.Lab_DL_SerialNum.Size = new System.Drawing.Size(67, 15);
            this.Lab_DL_SerialNum.TabIndex = 111;
            this.Lab_DL_SerialNum.Text = "串口号：";
            // 
            // Tbx_DL_File_Path
            // 
            this.Tbx_DL_File_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_DL_File_Path.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_DL_File_Path.Location = new System.Drawing.Point(375, 58);
            this.Tbx_DL_File_Path.Name = "Tbx_DL_File_Path";
            this.Tbx_DL_File_Path.ReadOnly = true;
            this.Tbx_DL_File_Path.Size = new System.Drawing.Size(401, 21);
            this.Tbx_DL_File_Path.TabIndex = 110;
            // 
            // Btn_DL_Erase_Chip
            // 
            this.Btn_DL_Erase_Chip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DL_Erase_Chip.Location = new System.Drawing.Point(686, 84);
            this.Btn_DL_Erase_Chip.Name = "Btn_DL_Erase_Chip";
            this.Btn_DL_Erase_Chip.Size = new System.Drawing.Size(90, 28);
            this.Btn_DL_Erase_Chip.TabIndex = 5;
            this.Btn_DL_Erase_Chip.Text = "擦除芯片";
            this.Btn_DL_Erase_Chip.UseVisualStyleBackColor = true;
            this.Btn_DL_Erase_Chip.Click += new System.EventHandler(this.Btn_DL_Erase_Chip_Click);
            // 
            // Btn_DL_Select_File
            // 
            this.Btn_DL_Select_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DL_Select_File.Location = new System.Drawing.Point(374, 84);
            this.Btn_DL_Select_File.Name = "Btn_DL_Select_File";
            this.Btn_DL_Select_File.Size = new System.Drawing.Size(90, 28);
            this.Btn_DL_Select_File.TabIndex = 2;
            this.Btn_DL_Select_File.Text = "选择文件";
            this.Btn_DL_Select_File.UseVisualStyleBackColor = true;
            this.Btn_DL_Select_File.Click += new System.EventHandler(this.Btn_DL_Select_File_Click);
            // 
            // Btn_DL_Read_Chip_Info
            // 
            this.Btn_DL_Read_Chip_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DL_Read_Chip_Info.Location = new System.Drawing.Point(582, 84);
            this.Btn_DL_Read_Chip_Info.Name = "Btn_DL_Read_Chip_Info";
            this.Btn_DL_Read_Chip_Info.Size = new System.Drawing.Size(90, 28);
            this.Btn_DL_Read_Chip_Info.TabIndex = 4;
            this.Btn_DL_Read_Chip_Info.Text = "读芯片信息";
            this.Btn_DL_Read_Chip_Info.UseVisualStyleBackColor = true;
            this.Btn_DL_Read_Chip_Info.Click += new System.EventHandler(this.Btn_DL_Read_Chip_Info_Click);
            // 
            // Btn_DL_DownLoad_File
            // 
            this.Btn_DL_DownLoad_File.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_DL_DownLoad_File.Location = new System.Drawing.Point(478, 84);
            this.Btn_DL_DownLoad_File.Name = "Btn_DL_DownLoad_File";
            this.Btn_DL_DownLoad_File.Size = new System.Drawing.Size(90, 28);
            this.Btn_DL_DownLoad_File.TabIndex = 3;
            this.Btn_DL_DownLoad_File.Text = "下载文件";
            this.Btn_DL_DownLoad_File.UseVisualStyleBackColor = true;
            this.Btn_DL_DownLoad_File.Click += new System.EventHandler(this.Btn_DL_DownLoad_File_Click);
            // 
            // Lab_DownloadFilePath
            // 
            this.Lab_DownloadFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_DownloadFilePath.AutoSize = true;
            this.Lab_DownloadFilePath.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_DownloadFilePath.Location = new System.Drawing.Point(376, 39);
            this.Lab_DownloadFilePath.Name = "Lab_DownloadFilePath";
            this.Lab_DownloadFilePath.Size = new System.Drawing.Size(98, 14);
            this.Lab_DownloadFilePath.TabIndex = 108;
            this.Lab_DownloadFilePath.Text = "下载文件路径：";
            // 
            // Tp_Tools
            // 
            this.Tp_Tools.Controls.Add(this.TlPal_Tools);
            this.Tp_Tools.Location = new System.Drawing.Point(1, 30);
            this.Tp_Tools.Name = "Tp_Tools";
            this.Tp_Tools.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Tools.Size = new System.Drawing.Size(782, 482);
            this.Tp_Tools.TabIndex = 5;
            this.Tp_Tools.Text = "工具箱";
            this.Tp_Tools.UseVisualStyleBackColor = true;
            // 
            // TlPal_Tools
            // 
            this.TlPal_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TlPal_Tools.ColumnCount = 6;
            this.TlPal_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlPal_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlPal_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlPal_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlPal_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TlPal_Tools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_FileEncryptionDecrypt, 2, 2);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_TTS, 1, 2);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_FontCreate, 0, 2);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_CalcTransf, 0, 1);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_FileMerge, 1, 1);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_BinEditor, 2, 1);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_CodeFormat, 3, 1);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_QrCode, 4, 1);
            this.TlPal_Tools.Controls.Add(this.label1, 0, 0);
            this.TlPal_Tools.Controls.Add(this.label2, 0, 4);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_FileTimeAlter, 3, 2);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_GeekUninstaller, 0, 5);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_FolderPainter, 1, 5);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_EmptyFolderNuker, 2, 5);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_ToolsPanel, 5, 0);
            this.TlPal_Tools.Controls.Add(this.button1, 4, 2);
            this.TlPal_Tools.Controls.Add(this.Btn_Tools_ResourceList, 0, 3);
            this.TlPal_Tools.Location = new System.Drawing.Point(3, 3);
            this.TlPal_Tools.Name = "TlPal_Tools";
            this.TlPal_Tools.RowCount = 10;
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TlPal_Tools.Size = new System.Drawing.Size(776, 476);
            this.TlPal_Tools.TabIndex = 13;
            // 
            // Btn_Tools_FileEncryptionDecrypt
            // 
            this.Btn_Tools_FileEncryptionDecrypt.Location = new System.Drawing.Point(301, 97);
            this.Btn_Tools_FileEncryptionDecrypt.Name = "Btn_Tools_FileEncryptionDecrypt";
            this.Btn_Tools_FileEncryptionDecrypt.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_FileEncryptionDecrypt.TabIndex = 23;
            this.Btn_Tools_FileEncryptionDecrypt.Text = "文件加密/解密";
            this.Btn_Tools_FileEncryptionDecrypt.UseVisualStyleBackColor = true;
            this.Btn_Tools_FileEncryptionDecrypt.Click += new System.EventHandler(this.Btn_Tools_FileEncryptionDecrypt_Click);
            // 
            // Btn_Tools_TTS
            // 
            this.Btn_Tools_TTS.Location = new System.Drawing.Point(152, 97);
            this.Btn_Tools_TTS.Name = "Btn_Tools_TTS";
            this.Btn_Tools_TTS.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_TTS.TabIndex = 22;
            this.Btn_Tools_TTS.Text = "语音合成（TTS）";
            this.Btn_Tools_TTS.UseVisualStyleBackColor = true;
            this.Btn_Tools_TTS.Click += new System.EventHandler(this.Btn_Tools_TTS_Click);
            // 
            // Btn_Tools_FontCreate
            // 
            this.Btn_Tools_FontCreate.Location = new System.Drawing.Point(3, 97);
            this.Btn_Tools_FontCreate.Name = "Btn_Tools_FontCreate";
            this.Btn_Tools_FontCreate.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_FontCreate.TabIndex = 21;
            this.Btn_Tools_FontCreate.Text = "汉字库";
            this.Btn_Tools_FontCreate.UseVisualStyleBackColor = true;
            this.Btn_Tools_FontCreate.Click += new System.EventHandler(this.Btn_Tools_FontCreate_Click);
            // 
            // Btn_Tools_CalcTransf
            // 
            this.Btn_Tools_CalcTransf.Location = new System.Drawing.Point(3, 50);
            this.Btn_Tools_CalcTransf.Name = "Btn_Tools_CalcTransf";
            this.Btn_Tools_CalcTransf.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_CalcTransf.TabIndex = 0;
            this.Btn_Tools_CalcTransf.Text = "计算/转换";
            this.Btn_Tools_CalcTransf.UseVisualStyleBackColor = true;
            this.Btn_Tools_CalcTransf.Click += new System.EventHandler(this.Btn_Tools_CalcTransf_Click);
            // 
            // Btn_Tools_FileMerge
            // 
            this.Btn_Tools_FileMerge.Location = new System.Drawing.Point(152, 50);
            this.Btn_Tools_FileMerge.Name = "Btn_Tools_FileMerge";
            this.Btn_Tools_FileMerge.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_FileMerge.TabIndex = 1;
            this.Btn_Tools_FileMerge.Text = "文件合并";
            this.Btn_Tools_FileMerge.UseVisualStyleBackColor = true;
            this.Btn_Tools_FileMerge.Click += new System.EventHandler(this.Btn_Tools_FileMerge_Click);
            // 
            // Btn_Tools_BinEditor
            // 
            this.Btn_Tools_BinEditor.Location = new System.Drawing.Point(301, 50);
            this.Btn_Tools_BinEditor.Name = "Btn_Tools_BinEditor";
            this.Btn_Tools_BinEditor.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_BinEditor.TabIndex = 1;
            this.Btn_Tools_BinEditor.Text = "二进制编辑器";
            this.Btn_Tools_BinEditor.UseVisualStyleBackColor = true;
            this.Btn_Tools_BinEditor.Click += new System.EventHandler(this.Btn_Tools_BinEditor_Click);
            // 
            // Btn_Tools_CodeFormat
            // 
            this.Btn_Tools_CodeFormat.Location = new System.Drawing.Point(450, 50);
            this.Btn_Tools_CodeFormat.Name = "Btn_Tools_CodeFormat";
            this.Btn_Tools_CodeFormat.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_CodeFormat.TabIndex = 2;
            this.Btn_Tools_CodeFormat.Text = "代码格式化";
            this.Btn_Tools_CodeFormat.UseVisualStyleBackColor = true;
            this.Btn_Tools_CodeFormat.Click += new System.EventHandler(this.Btn_Tools_CodeFormat_Click);
            // 
            // Btn_Tools_QrCode
            // 
            this.Btn_Tools_QrCode.Location = new System.Drawing.Point(599, 50);
            this.Btn_Tools_QrCode.Name = "Btn_Tools_QrCode";
            this.Btn_Tools_QrCode.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_QrCode.TabIndex = 3;
            this.Btn_Tools_QrCode.Text = "二维码/条形码";
            this.Btn_Tools_QrCode.UseVisualStyleBackColor = true;
            this.Btn_Tools_QrCode.Click += new System.EventHandler(this.Btn_Tools_QrCode_Click);
            // 
            // label1
            // 
            this.TlPal_Tools.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 47);
            this.label1.TabIndex = 19;
            this.label1.Text = "工具集合";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.TlPal_Tools.SetColumnSpan(this.label2, 5);
            this.label2.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(739, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = "内置软件";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Tools_FileTimeAlter
            // 
            this.Btn_Tools_FileTimeAlter.Location = new System.Drawing.Point(450, 97);
            this.Btn_Tools_FileTimeAlter.Name = "Btn_Tools_FileTimeAlter";
            this.Btn_Tools_FileTimeAlter.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_FileTimeAlter.TabIndex = 25;
            this.Btn_Tools_FileTimeAlter.Text = "文件时间修改器";
            this.Btn_Tools_FileTimeAlter.UseVisualStyleBackColor = true;
            this.Btn_Tools_FileTimeAlter.Click += new System.EventHandler(this.Btn_Tools_FileTimeAlter_Click);
            // 
            // Btn_Tools_ResourceList
            // 
            this.Btn_Tools_ResourceList.Location = new System.Drawing.Point(3, 144);
            this.Btn_Tools_ResourceList.Name = "Btn_Tools_ResourceList";
            this.Btn_Tools_ResourceList.Size = new System.Drawing.Size(143, 41);
            this.Btn_Tools_ResourceList.TabIndex = 24;
            this.Btn_Tools_ResourceList.Text = "资源列表";
            this.Btn_Tools_ResourceList.UseVisualStyleBackColor = true;
            this.Btn_Tools_ResourceList.Click += new System.EventHandler(this.Btn_Tools_ResourceList_Click);
            // 
            // Btn_Tools_ToolsPanel
            // 
            this.Btn_Tools_ToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Tools_ToolsPanel.Location = new System.Drawing.Point(748, 3);
            this.Btn_Tools_ToolsPanel.Name = "Btn_Tools_ToolsPanel";
            this.TlPal_Tools.SetRowSpan(this.Btn_Tools_ToolsPanel, 10);
            this.Btn_Tools_ToolsPanel.Size = new System.Drawing.Size(25, 470);
            this.Btn_Tools_ToolsPanel.TabIndex = 27;
            this.Btn_Tools_ToolsPanel.Text = ">-打开工具面板->";
            this.Btn_Tools_ToolsPanel.UseVisualStyleBackColor = true;
            this.Btn_Tools_ToolsPanel.Click += new System.EventHandler(this.Btn_Tools_ToolsPanel_Click);
            // 
            // Tp_Code
            // 
            this.Tp_Code.Controls.Add(this.Spc_Code_Lib);
            this.Tp_Code.Location = new System.Drawing.Point(1, 30);
            this.Tp_Code.Name = "Tp_Code";
            this.Tp_Code.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Code.Size = new System.Drawing.Size(782, 482);
            this.Tp_Code.TabIndex = 4;
            this.Tp_Code.Text = "代码助手";
            this.Tp_Code.UseVisualStyleBackColor = true;
            // 
            // Spc_Code_Lib
            // 
            this.Spc_Code_Lib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spc_Code_Lib.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Spc_Code_Lib.Location = new System.Drawing.Point(3, 3);
            this.Spc_Code_Lib.Name = "Spc_Code_Lib";
            // 
            // Spc_Code_Lib.Panel1
            // 
            this.Spc_Code_Lib.Panel1.Controls.Add(this.label44);
            this.Spc_Code_Lib.Panel1MinSize = 300;
            // 
            // Spc_Code_Lib.Panel2
            // 
            this.Spc_Code_Lib.Panel2.Controls.Add(this.richTextBox1);
            this.Spc_Code_Lib.Panel2MinSize = 400;
            this.Spc_Code_Lib.Size = new System.Drawing.Size(776, 476);
            this.Spc_Code_Lib.SplitterDistance = 300;
            this.Spc_Code_Lib.TabIndex = 0;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(8, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(202, 15);
            this.label44.TabIndex = 1;
            this.label44.Text = "整理开发中，敬请期待。。。";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 476);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Tp_Type
            // 
            this.Tp_Type.Controls.Add(this.Spc_DL);
            this.Tp_Type.Location = new System.Drawing.Point(1, 30);
            this.Tp_Type.Name = "Tp_Type";
            this.Tp_Type.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Type.Size = new System.Drawing.Size(782, 482);
            this.Tp_Type.TabIndex = 2;
            this.Tp_Type.Text = "选型助手";
            this.Tp_Type.UseVisualStyleBackColor = true;
            // 
            // Spc_DL
            // 
            this.Spc_DL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spc_DL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spc_DL.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Spc_DL.Location = new System.Drawing.Point(3, 3);
            this.Spc_DL.Margin = new System.Windows.Forms.Padding(0);
            this.Spc_DL.Name = "Spc_DL";
            // 
            // Spc_DL.Panel1
            // 
            this.Spc_DL.Panel1.Controls.Add(this.label34);
            this.Spc_DL.Panel1MinSize = 300;
            this.Spc_DL.Panel2MinSize = 400;
            this.Spc_DL.Size = new System.Drawing.Size(776, 476);
            this.Spc_DL.SplitterDistance = 300;
            this.Spc_DL.TabIndex = 9;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(7, 6);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(172, 15);
            this.label34.TabIndex = 0;
            this.label34.Text = "开发中，敬请期待。。。";
            // 
            // Tp_Help
            // 
            this.Tp_Help.Controls.Add(this.Llab_PersonHomePage);
            this.Tp_Help.Controls.Add(this.Llab_PersonEmail);
            this.Tp_Help.Controls.Add(this.Tbx_Help);
            this.Tp_Help.Controls.Add(this.Lab_Personal_Elucidation);
            this.Tp_Help.Controls.Add(this.Lab_Copyright);
            this.Tp_Help.Controls.Add(this.Lab_Donate);
            this.Tp_Help.Controls.Add(this.Pbx_Wxpay);
            this.Tp_Help.Controls.Add(this.Pbx_Alipay);
            this.Tp_Help.Controls.Add(this.Pbx_SWORLD);
            this.Tp_Help.Location = new System.Drawing.Point(1, 30);
            this.Tp_Help.Name = "Tp_Help";
            this.Tp_Help.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Help.Size = new System.Drawing.Size(782, 482);
            this.Tp_Help.TabIndex = 3;
            this.Tp_Help.Text = "帮助";
            this.Tp_Help.UseVisualStyleBackColor = true;
            // 
            // Llab_PersonHomePage
            // 
            this.Llab_PersonHomePage.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.Llab_PersonHomePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Llab_PersonHomePage.AutoSize = true;
            this.Llab_PersonHomePage.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Llab_PersonHomePage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Llab_PersonHomePage.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Llab_PersonHomePage.Location = new System.Drawing.Point(660, 144);
            this.Llab_PersonHomePage.Name = "Llab_PersonHomePage";
            this.Llab_PersonHomePage.Size = new System.Drawing.Size(112, 15);
            this.Llab_PersonHomePage.TabIndex = 14;
            this.Llab_PersonHomePage.TabStop = true;
            this.Llab_PersonHomePage.Text = "www.sworld.top";
            // 
            // Llab_PersonEmail
            // 
            this.Llab_PersonEmail.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.Llab_PersonEmail.AutoSize = true;
            this.Llab_PersonEmail.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Llab_PersonEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Llab_PersonEmail.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Llab_PersonEmail.Location = new System.Drawing.Point(653, 162);
            this.Llab_PersonEmail.Name = "Llab_PersonEmail";
            this.Llab_PersonEmail.Size = new System.Drawing.Size(123, 14);
            this.Llab_PersonEmail.TabIndex = 19;
            this.Llab_PersonEmail.TabStop = true;
            this.Llab_PersonEmail.Text = "970076933@qq.com";
            // 
            // Tbx_Help
            // 
            this.Tbx_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbx_Help.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tbx_Help.Location = new System.Drawing.Point(3, 3);
            this.Tbx_Help.Multiline = true;
            this.Tbx_Help.Name = "Tbx_Help";
            this.Tbx_Help.ReadOnly = true;
            this.Tbx_Help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Help.Size = new System.Drawing.Size(647, 476);
            this.Tbx_Help.TabIndex = 11;
            this.Tbx_Help.Text = resources.GetString("Tbx_Help.Text");
            // 
            // Lab_Personal_Elucidation
            // 
            this.Lab_Personal_Elucidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Personal_Elucidation.AutoSize = true;
            this.Lab_Personal_Elucidation.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Personal_Elucidation.Location = new System.Drawing.Point(647, 180);
            this.Lab_Personal_Elucidation.Name = "Lab_Personal_Elucidation";
            this.Lab_Personal_Elucidation.Size = new System.Drawing.Size(137, 14);
            this.Lab_Personal_Elucidation.TabIndex = 18;
            this.Lab_Personal_Elucidation.Text = "永远保持一颗学徒的心";
            // 
            // Lab_Copyright
            // 
            this.Lab_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Copyright.AutoSize = true;
            this.Lab_Copyright.Font = new System.Drawing.Font("等线", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Copyright.Location = new System.Drawing.Point(678, 129);
            this.Lab_Copyright.Name = "Lab_Copyright";
            this.Lab_Copyright.Size = new System.Drawing.Size(76, 14);
            this.Lab_Copyright.TabIndex = 12;
            this.Lab_Copyright.Text = "Same World";
            // 
            // Lab_Donate
            // 
            this.Lab_Donate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lab_Donate.AutoSize = true;
            this.Lab_Donate.Location = new System.Drawing.Point(697, 212);
            this.Lab_Donate.Name = "Lab_Donate";
            this.Lab_Donate.Size = new System.Drawing.Size(37, 15);
            this.Lab_Donate.TabIndex = 16;
            this.Lab_Donate.Text = "捐赠";
            // 
            // Pbx_SWORLD
            // 
            this.Pbx_SWORLD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_SWORLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pbx_SWORLD.Image = global::SWORLD开发助手.Properties.Resources.SWORLD;
            this.Pbx_SWORLD.Location = new System.Drawing.Point(656, 6);
            this.Pbx_SWORLD.Name = "Pbx_SWORLD";
            this.Pbx_SWORLD.Size = new System.Drawing.Size(120, 120);
            this.Pbx_SWORLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_SWORLD.TabIndex = 13;
            this.Pbx_SWORLD.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "图标显示修复";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Controls.Add(this.Pbx_Fix);
            this.Controls.Add(this.Ts_Bottom);
            this.Controls.Add(this.Tc_Main);
            this.Font = new System.Drawing.Font("等线", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(800, 580);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Ts_Bottom.ResumeLayout(false);
            this.Ts_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Fix)).EndInit();
            this.Cms_Send_Prj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Wxpay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Alipay)).EndInit();
            this.Tc_Main.ResumeLayout(false);
            this.Tp_Debug.ResumeLayout(false);
            this.Tp_Debug.PerformLayout();
            this.Pal_Debug_Serial_Option.ResumeLayout(false);
            this.Pal_Debug_Serial_Option.PerformLayout();
            this.Tc_Debug.ResumeLayout(false);
            this.Tp_Debug_Send_One.ResumeLayout(false);
            this.Tp_Debug_Send_One.PerformLayout();
            this.Tp_Debug_Send_More.ResumeLayout(false);
            this.Tblp_Send_M.ResumeLayout(false);
            this.Tblp_Send_M.PerformLayout();
            this.Pal_Debug_MutilCycleSet.ResumeLayout(false);
            this.Pal_Debug_MutilCycleSet.PerformLayout();
            this.Pal_Debug_SwitchProject.ResumeLayout(false);
            this.Pal_Debug_SwitchProject.PerformLayout();
            this.Pal_Debug_Operate.ResumeLayout(false);
            this.Tp_Debug_Send_Protocol.ResumeLayout(false);
            this.Tp_Debug_Send_Protocol.PerformLayout();
            this.Tp_DL.ResumeLayout(false);
            this.Tp_DL.PerformLayout();
            this.Gbx_Option_Byte.ResumeLayout(false);
            this.Gbx_Option_Byte.PerformLayout();
            this.Gbx_DL_Option.ResumeLayout(false);
            this.Gbx_DL_Option.PerformLayout();
            this.Tp_Tools.ResumeLayout(false);
            this.TlPal_Tools.ResumeLayout(false);
            this.Tp_Code.ResumeLayout(false);
            this.Spc_Code_Lib.Panel1.ResumeLayout(false);
            this.Spc_Code_Lib.Panel1.PerformLayout();
            this.Spc_Code_Lib.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spc_Code_Lib)).EndInit();
            this.Spc_Code_Lib.ResumeLayout(false);
            this.Tp_Type.ResumeLayout(false);
            this.Spc_DL.Panel1.ResumeLayout(false);
            this.Spc_DL.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_DL)).EndInit();
            this.Spc_DL.ResumeLayout(false);
            this.Tp_Help.ResumeLayout(false);
            this.Tp_Help.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_SWORLD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Sp_DownLoad;
        private System.Windows.Forms.TabPage Tp_Debug;
        private System.Windows.Forms.TabPage Tp_DL;
        private System.Windows.Forms.Label Lab_Debug_StopBit;
        private System.Windows.Forms.Label Lab_Debug_Operate;
        private System.Windows.Forms.Button Btn_Debug_Open_Serial;
        private System.Windows.Forms.CheckBox Ckbx_Debug_Show_Hex;
        private System.Windows.Forms.CheckBox Ckbx_Debug_DTR;
        private System.Windows.Forms.CheckBox Ckbx_Debug_RTS;
        private Control.ListBoxPlus Lbx_Msg_DL;
        private System.Windows.Forms.OpenFileDialog Ofd_DL_File;
        private System.Windows.Forms.ProgressBar Pgb_DL_Task_Process;
        private System.Windows.Forms.TabPage Tp_Type;
        private System.Windows.Forms.ToolStrip Ts_Bottom;
        private System.Windows.Forms.ComboBox Cbx_Debug_BaudRate;
        private System.Windows.Forms.Label Lab_Debug_BaudRate;
        private System.Windows.Forms.ToolStripLabel Tstbx_Serial_Stat;
        private System.Windows.Forms.ToolStripLabel Tstbx_Serial_Stat_Img;
        private System.Windows.Forms.ToolStripLabel Tbx_Time_Show;
        private System.Windows.Forms.ToolStripDropDownButton Tsddb_Tool_Box;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer Tmr_Clock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox Cbx_Debug_Parity;
        private System.Windows.Forms.ComboBox CBx_Debug_DataBit;
        private System.Windows.Forms.ComboBox Cbx_Debug_StopBit;
        private System.Windows.Forms.ComboBox Cbx_Debug_Seiral_Num;
        private System.Windows.Forms.Label Lab_Debug_SerialNum;
        private System.Windows.Forms.Label Lab_Debug_CheckBit;
        private System.Windows.Forms.Label Lab_Debug_DataBit;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Bottom_Calc;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Bottom_Note;
        private System.Windows.Forms.ToolStripDropDownButton Tsdbtn_Set;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_HMI_Set;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Help;
        private System.Windows.Forms.Label Lab_Debug_Delay;
        private System.Windows.Forms.ComboBox Cbx_Debug_RTS_Delay;
        private Control.TabControlPlus Tc_Main;
        private System.Windows.Forms.TabPage Tp_Help;
        private System.Windows.Forms.Button Btn_Serial_Debug_Fresh;
        private System.IO.Ports.SerialPort Sp_Debug;
        private System.Windows.Forms.ToolTip Tt_Msg;
        private System.Windows.Forms.TextBox Tbx_Debug_Send_One;
        private System.Windows.Forms.Button Btn_Debug_Send;
        private System.Windows.Forms.GroupBox Gbx_Option_Byte;
        private System.Windows.Forms.Label Lab_DL_UserDataByteExplain2;
        private System.Windows.Forms.Label Lab_DL_UserDataByteExplain1;
        private System.Windows.Forms.TextBox Tbx_DL_User_Data2;
        private System.Windows.Forms.TextBox Tbx_DL_User_Data1;
        private System.Windows.Forms.Label Lab_DL_UserDataByte0x2;
        private System.Windows.Forms.Label Lab_DL_UserDataByte0x1;
        private System.Windows.Forms.Label Lab_DL_UserDataByte;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByteExplain4;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByteExplain3;
        private System.Windows.Forms.TextBox Tbx_DL_Write_Protect4;
        private System.Windows.Forms.TextBox Tbx_DL_Write_Protect3;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByte0x4;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByte0x3;
        private System.Windows.Forms.TextBox Tbx_DL_HW_Byte;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByteExplain2;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByteExplain1;
        private System.Windows.Forms.TextBox Tbx_DL_Write_Protect2;
        private System.Windows.Forms.Label Lab_DL_HardwareOptionByte0x;
        private System.Windows.Forms.TextBox Tbx_DL_Read_Protect;
        private System.Windows.Forms.TextBox Tbx_DL_Write_Protect1;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByte;
        private System.Windows.Forms.Label Lab_DL_HardwareOptionByteExplain;
        private System.Windows.Forms.Label Lab_DL_HardwareOptionByte;
        private System.Windows.Forms.Button Btn_DetailSet;
        private System.Windows.Forms.Label Lab_DL_ReadProtectByteExplain;
        private System.Windows.Forms.Label Lab_DL_ReadProtectedByte;
        private System.Windows.Forms.Button Btn_Option_Set_Default;
        private System.Windows.Forms.CheckBox Ckbx_DL_Write_Option_Byte;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByte0x2;
        private System.Windows.Forms.Label Lab_DL_WriteProtectedByte0x1;
        private System.Windows.Forms.Label Lab_DL_ReadProtectByte0x;
        private System.Windows.Forms.GroupBox Gbx_DL_Option;
        private System.Windows.Forms.CheckBox Ckbx_DL_Auto_Close_Debug_Port;
        private System.Windows.Forms.CheckBox Cbx_Auto_DL;
        private System.Windows.Forms.Label Lab_EraseWay;
        private System.Windows.Forms.TextBox Tbx_DL_Adress;
        private System.Windows.Forms.RadioButton Rbtn_Erase_Part;
        private System.Windows.Forms.CheckBox Ckbx_Check;
        private System.Windows.Forms.CheckBox Ckbx_Auto_Match;
        private System.Windows.Forms.RadioButton Rbtn_Erase_All;
        private System.Windows.Forms.ComboBox Cbx_Go_BL_Way;
        private System.Windows.Forms.Label Lab_DownloadStartAddress;
        private System.Windows.Forms.TextBox Tbx_Run_Adress;
        private System.Windows.Forms.Label Lab_ProgramRunAddress;
        private System.Windows.Forms.CheckBox Ckbx_DL_After_Dir_Run;
        private System.Windows.Forms.Button Btn_Serial_DL_Fresh;
        private System.Windows.Forms.Label Lab_DownloadFilePath;
        private System.Windows.Forms.ComboBox Cbx_DL_BaudRate;
        private System.Windows.Forms.ComboBox Cbx_DL_Serial_Num;
        private System.Windows.Forms.Label Lab_DL_BaudRate;
        private System.Windows.Forms.TextBox Tbx_DL_File_Path;
        private System.Windows.Forms.Label Lab_DL_SerialNum;
        private System.Windows.Forms.Button Btn_DL_Select_File;
        private System.Windows.Forms.Button Btn_DL_DownLoad_File;
        private System.Windows.Forms.Button Btn_DL_Read_Chip_Info;
        private System.Windows.Forms.Button Btn_DL_Erase_Chip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private Control.TabCon Tc_Debug;
        private System.Windows.Forms.TabPage Tp_Debug_Send_One;
        private System.Windows.Forms.TabPage Tp_Debug_Send_More;
        private System.Windows.Forms.ToolStripLabel Tlab_CTS_Val;
        private System.Windows.Forms.TabPage Tp_Debug_Send_Protocol;
        private System.Windows.Forms.Button Btn_Debug_Stop_Send_File;
        private System.Windows.Forms.Button Btn_Debug_Clear_Send;
        private System.Windows.Forms.Button Btn_Debug_Clear_Recv;
        private System.Windows.Forms.Button Btn_Debug_Save_Window;
        private System.Windows.Forms.Button Btn_Debug_Select_File;
        private System.Windows.Forms.Button Btn_Debug_Start_Send_File;
        private System.Windows.Forms.CheckBox Ckbx_Debug_Send_NewLine;
        private System.Windows.Forms.CheckBox Ckbx_Debug_Send_Hex;
        private System.Windows.Forms.TextBox Tbx_Debug_Resend_Time;
        private System.Windows.Forms.Label Lab_Debug_CycleUnit;
        private System.Windows.Forms.Label Lab_Debug_Cycle;
        private System.Windows.Forms.CheckBox Ckbx_Debug_Send_Ontime;
        private System.Windows.Forms.TextBox Tbx_Debug_Send_File_Name;
        private System.Windows.Forms.Timer Tmr_Debug_Recv;
        private System.Windows.Forms.Label Lab_Debug_RX;
        private System.Windows.Forms.Label Lab_Debug_TX;
        private System.Windows.Forms.Label Lab_Debug_RX_T;
        private System.Windows.Forms.Label Lab_Debug_TX_T;
        private System.Windows.Forms.TextBox Tbx_Debug_Show_Time;
        private System.Windows.Forms.Label Lab_Show_Time;
        private System.Windows.Forms.SplitContainer Spc_DL;
        private System.Windows.Forms.CheckBox Ckbx_DL_Show_Time;
        private System.Windows.Forms.CheckBox Ckbx_Debug_Show_Time;
        private System.Windows.Forms.Label Lab_Debug_Task_Process;
        private System.Windows.Forms.ProgressBar Pgb_Debug_Task_Process;
        private System.Windows.Forms.Panel Pal_Debug_Serial_Option;
        private System.Windows.Forms.TextBox Tbx_Msg_Debug;
        private System.Windows.Forms.Timer Tmr_Debug_ReSend;
        private System.Windows.Forms.ToolStripLabel Tlab_DSR_Val;
        private System.Windows.Forms.ToolStripLabel Tlab_DCD_Val;
        private System.Windows.Forms.OpenFileDialog Ofd_Debug_File;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Window_Para_Set;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Reset_Window_Para;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Save_Window_Para;
        private System.Windows.Forms.Timer Tmr_Btm_Msg;
        private System.Windows.Forms.PictureBox Pbx_Fix;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M4;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M3;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M2;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M1;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M0;
        private System.Windows.Forms.Button Btn_Debug_M4;
        private System.Windows.Forms.Button Btn_Debug_M3;
        private System.Windows.Forms.Button Btn_Debug_M2;
        private System.Windows.Forms.Button Btn_Debug_M1;
        private System.Windows.Forms.Button Btn_Debug_M0;
        private System.Windows.Forms.TextBox Tbx_Debug_M7;
        private System.Windows.Forms.TextBox Tbx_Debug_M8;
        private System.Windows.Forms.TextBox Tbx_Debug_M9;
        private System.Windows.Forms.TextBox Tbx_Debug_M6;
        private System.Windows.Forms.TextBox Tbx_Debug_M5;
        private System.Windows.Forms.Button Btn_Debug_M9;
        private System.Windows.Forms.Button Btn_Debug_M8;
        private System.Windows.Forms.Button Btn_Debug_M7;
        private System.Windows.Forms.Button Btn_Debug_M6;
        private System.Windows.Forms.Button Btn_Debug_M5;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M9;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M8;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M7;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M6;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M5;
        private System.Windows.Forms.TextBox Tbx_Debug_M2;
        private System.Windows.Forms.TextBox Tbx_Debug_M3;
        private System.Windows.Forms.TextBox Tbx_Debug_M4;
        private System.Windows.Forms.TextBox Tbx_Debug_M1;
        private System.Windows.Forms.TextBox Tbx_Debug_M0;
        private System.Windows.Forms.ListBox Lbx_Debug_Project;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M_Send_NewLine;
        private System.Windows.Forms.Label Lab_Debug_MutilCycleUnit;
        private System.Windows.Forms.TextBox Tbx_Debug_M_Resend_Time;
        private System.Windows.Forms.Label Lab_Debug_MutilCycle;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M_Resend;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M_Con_NumKey;
        private System.Windows.Forms.CheckBox Ckbx_Debug_M_Send_Hex;
        private System.Windows.Forms.TextBox Tbx_Debug_Project;
        private System.Windows.Forms.TextBox Tbx_Debug_M_Go_Page;
        private System.Windows.Forms.Label Lab_Debug_Sort2;
        private System.Windows.Forms.Label Lab_Debug_Sort1;
        private System.Windows.Forms.Button Btn_Debug_M_Rmv;
        private System.Windows.Forms.Button Btn_Debug_M_Go_Page;
        private System.Windows.Forms.Button Btn_Debug_M_Last;
        private System.Windows.Forms.Button Btn_Debug_M_Next;
        private System.Windows.Forms.Button Btn_Debug_M_Pre;
        private System.Windows.Forms.Button Btn_Debug_M_First;
        private System.Windows.Forms.Button Btn_Debug_M_Add;
        private System.Windows.Forms.Button Btn_Debug_M_Output;
        private System.Windows.Forms.Label Lab_Debug_M_Page;
        private System.Windows.Forms.TextBox Tbx_Help;
        private System.Windows.Forms.Label Lab_Copyright;
        private System.Windows.Forms.PictureBox Pbx_SWORLD;
        private System.Windows.Forms.LinkLabel Llab_PersonHomePage;
        private System.Windows.Forms.TableLayoutPanel Tblp_Send_M;
        private System.Windows.Forms.Panel Pal_Debug_MutilCycleSet;
        private System.Windows.Forms.Panel Pal_Debug_SwitchProject;
        private System.Windows.Forms.Panel Pal_Debug_Operate;
        private System.Windows.Forms.Button Btn_Debug_Prj_Add;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Exit;
        private System.Windows.Forms.Label Lab_Debug_Switch_ProjectTip;
        private System.Windows.Forms.Timer Tmr_Debug_Resend_M;
        private System.Windows.Forms.ContextMenuStrip Cms_Send_Prj;
        private System.Windows.Forms.ToolStripMenuItem CmsBtn_Send_Prj_Swch;
        private System.Windows.Forms.ToolStripMenuItem CmsBtn_Send_Prj_Add;
        private System.Windows.Forms.ToolStripMenuItem CmsBtn_Send_Prj_Del;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ToolStripMenuItem 接收界面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 发送界面设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Check_Update;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Start_Check_Update;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_About;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_FeedBack;
        private System.Windows.Forms.TabPage Tp_Code;
        private System.Windows.Forms.SplitContainer Spc_Code_Lib;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.CheckBox Ckbx_Set_Read_Protect;
        private System.Windows.Forms.TabPage Tp_Tools;
        private System.Windows.Forms.TableLayoutPanel TlPal_Tools;
        private System.Windows.Forms.Button Btn_Tools_CalcTransf;
        private System.Windows.Forms.Button Btn_Tools_FileMerge;
        private System.Windows.Forms.Button Btn_Tools_BinEditor;
        private System.Windows.Forms.Button Btn_Tools_CodeFormat;
        private System.Windows.Forms.Button Btn_Tools_QrCode;
        private System.Windows.Forms.Button Btn_Tools_FileTimeAlter;
        private System.Windows.Forms.Button Btn_Tools_ResourceList;
        private System.Windows.Forms.Button Btn_Tools_FileEncryptionDecrypt;
        private System.Windows.Forms.Button Btn_Tools_TTS;
        private System.Windows.Forms.Button Btn_Tools_FontCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Tools_GeekUninstaller;
        private System.Windows.Forms.Button Btn_Tools_FolderPainter;
        private System.Windows.Forms.Button Btn_Tools_EmptyFolderNuker;
        private System.Windows.Forms.Button Btn_Tools_ToolsPanel;
        private System.Windows.Forms.Label Lab_Donate;
        private System.Windows.Forms.PictureBox Pbx_Wxpay;
        private System.Windows.Forms.PictureBox Pbx_Alipay;
        private System.Windows.Forms.Label Lab_Personal_Elucidation;
        private System.Windows.Forms.LinkLabel Llab_PersonEmail;
        private System.Windows.Forms.ToolStripMenuItem TsBtn_Bottom_ControlPanle;
        private System.Windows.Forms.Button button1;
    }
}

