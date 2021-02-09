
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_QrCode
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
            this.Pbx_Preview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tc_QrorBarCode = new System.Windows.Forms.TabControl();
            this.Tp_QrCode = new System.Windows.Forms.TabPage();
            this.Pal_ColorFront = new System.Windows.Forms.Panel();
            this.Lab_MarginSize = new System.Windows.Forms.Label();
            this.Pal_ColorBack = new System.Windows.Forms.Panel();
            this.Nud_MarginSize = new System.Windows.Forms.NumericUpDown();
            this.Lab_ColorFront = new System.Windows.Forms.Label();
            this.Nud_CodeSize = new System.Windows.Forms.NumericUpDown();
            this.Gbx_QrCodeColor = new System.Windows.Forms.GroupBox();
            this.Rbtn_ColorCustom = new System.Windows.Forms.RadioButton();
            this.Rbtn_ColorNormal = new System.Windows.Forms.RadioButton();
            this.Gbx_QrCodeVersion = new System.Windows.Forms.GroupBox();
            this.Rbtn_VersionWithLogo = new System.Windows.Forms.RadioButton();
            this.Rbtn_VersionNormal = new System.Windows.Forms.RadioButton();
            this.Lab_ColorBack = new System.Windows.Forms.Label();
            this.Tbx_LogoPath = new System.Windows.Forms.TextBox();
            this.Btn_SaveQrCode = new System.Windows.Forms.Button();
            this.Btn_GenQrCode = new System.Windows.Forms.Button();
            this.Lab_GenContent = new System.Windows.Forms.Label();
            this.Tbx_GenContent = new System.Windows.Forms.TextBox();
            this.Btn_SelectLogoPath = new System.Windows.Forms.Button();
            this.Lab_CodeSize = new System.Windows.Forms.Label();
            this.Lab_LogoPath = new System.Windows.Forms.Label();
            this.Tp_BarCode = new System.Windows.Forms.TabPage();
            this.Btn_Bar_Save = new System.Windows.Forms.Button();
            this.Btn_Bar_Gen = new System.Windows.Forms.Button();
            this.Lab_Bar_SizeWidth = new System.Windows.Forms.Label();
            this.Lab_Bar_SizeLength = new System.Windows.Forms.Label();
            this.Lab_Bar_Preview = new System.Windows.Forms.Label();
            this.Lab_Bar_Margin = new System.Windows.Forms.Label();
            this.Nud_Bar_Margin = new System.Windows.Forms.NumericUpDown();
            this.Nud_Bar_SizeWidth = new System.Windows.Forms.NumericUpDown();
            this.Nud_Bar_SizeLength = new System.Windows.Forms.NumericUpDown();
            this.Lab_Bar_Size = new System.Windows.Forms.Label();
            this.Pbx_Bar_Preview = new System.Windows.Forms.PictureBox();
            this.Lab_Bar_Content = new System.Windows.Forms.Label();
            this.Tbx_Bar_Content = new System.Windows.Forms.TextBox();
            this.Lab_ParseResult = new System.Windows.Forms.Label();
            this.Tbx_ParseResult = new System.Windows.Forms.TextBox();
            this.Btn_QrCodeParse = new System.Windows.Forms.Button();
            this.Ofd_LogoSelect = new System.Windows.Forms.OpenFileDialog();
            this.Ofd_QrCodeParse = new System.Windows.Forms.OpenFileDialog();
            this.Sfd_QrCodeSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Preview)).BeginInit();
            this.Tc_QrorBarCode.SuspendLayout();
            this.Tp_QrCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MarginSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_CodeSize)).BeginInit();
            this.Gbx_QrCodeColor.SuspendLayout();
            this.Gbx_QrCodeVersion.SuspendLayout();
            this.Tp_BarCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Bar_Margin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Bar_SizeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Bar_SizeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bar_Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbx_Preview
            // 
            this.Pbx_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pbx_Preview.Location = new System.Drawing.Point(6, 166);
            this.Pbx_Preview.Name = "Pbx_Preview";
            this.Pbx_Preview.Size = new System.Drawing.Size(200, 200);
            this.Pbx_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Preview.TabIndex = 0;
            this.Pbx_Preview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "图像预览：";
            // 
            // Tc_QrorBarCode
            // 
            this.Tc_QrorBarCode.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tc_QrorBarCode.Controls.Add(this.Tp_QrCode);
            this.Tc_QrorBarCode.Controls.Add(this.Tp_BarCode);
            this.Tc_QrorBarCode.ItemSize = new System.Drawing.Size(236, 22);
            this.Tc_QrorBarCode.Location = new System.Drawing.Point(0, 0);
            this.Tc_QrorBarCode.Name = "Tc_QrorBarCode";
            this.Tc_QrorBarCode.SelectedIndex = 0;
            this.Tc_QrorBarCode.Size = new System.Drawing.Size(476, 402);
            this.Tc_QrorBarCode.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tc_QrorBarCode.TabIndex = 2;
            // 
            // Tp_QrCode
            // 
            this.Tp_QrCode.Controls.Add(this.Pal_ColorFront);
            this.Tp_QrCode.Controls.Add(this.Lab_MarginSize);
            this.Tp_QrCode.Controls.Add(this.Pal_ColorBack);
            this.Tp_QrCode.Controls.Add(this.Nud_MarginSize);
            this.Tp_QrCode.Controls.Add(this.Lab_ColorFront);
            this.Tp_QrCode.Controls.Add(this.Nud_CodeSize);
            this.Tp_QrCode.Controls.Add(this.Gbx_QrCodeColor);
            this.Tp_QrCode.Controls.Add(this.Gbx_QrCodeVersion);
            this.Tp_QrCode.Controls.Add(this.Lab_ColorBack);
            this.Tp_QrCode.Controls.Add(this.Tbx_LogoPath);
            this.Tp_QrCode.Controls.Add(this.Btn_SaveQrCode);
            this.Tp_QrCode.Controls.Add(this.Btn_GenQrCode);
            this.Tp_QrCode.Controls.Add(this.Lab_GenContent);
            this.Tp_QrCode.Controls.Add(this.Tbx_GenContent);
            this.Tp_QrCode.Controls.Add(this.Btn_SelectLogoPath);
            this.Tp_QrCode.Controls.Add(this.Lab_CodeSize);
            this.Tp_QrCode.Controls.Add(this.Lab_LogoPath);
            this.Tp_QrCode.Controls.Add(this.Pbx_Preview);
            this.Tp_QrCode.Controls.Add(this.label1);
            this.Tp_QrCode.Location = new System.Drawing.Point(4, 4);
            this.Tp_QrCode.Name = "Tp_QrCode";
            this.Tp_QrCode.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_QrCode.Size = new System.Drawing.Size(468, 372);
            this.Tp_QrCode.TabIndex = 0;
            this.Tp_QrCode.Text = "二维码";
            this.Tp_QrCode.UseVisualStyleBackColor = true;
            // 
            // Pal_ColorFront
            // 
            this.Pal_ColorFront.BackColor = System.Drawing.Color.Black;
            this.Pal_ColorFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pal_ColorFront.Location = new System.Drawing.Point(262, 276);
            this.Pal_ColorFront.Name = "Pal_ColorFront";
            this.Pal_ColorFront.Size = new System.Drawing.Size(26, 20);
            this.Pal_ColorFront.TabIndex = 6;
            this.Pal_ColorFront.Click += new System.EventHandler(this.Pal_ColorFront_Click);
            // 
            // Lab_MarginSize
            // 
            this.Lab_MarginSize.AutoSize = true;
            this.Lab_MarginSize.Location = new System.Drawing.Point(209, 346);
            this.Lab_MarginSize.Name = "Lab_MarginSize";
            this.Lab_MarginSize.Size = new System.Drawing.Size(68, 17);
            this.Lab_MarginSize.TabIndex = 16;
            this.Lab_MarginSize.Text = "边缘大小：";
            // 
            // Pal_ColorBack
            // 
            this.Pal_ColorBack.BackColor = System.Drawing.Color.White;
            this.Pal_ColorBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pal_ColorBack.Location = new System.Drawing.Point(349, 276);
            this.Pal_ColorBack.Name = "Pal_ColorBack";
            this.Pal_ColorBack.Size = new System.Drawing.Size(26, 20);
            this.Pal_ColorBack.TabIndex = 5;
            this.Pal_ColorBack.Click += new System.EventHandler(this.Pal_ColorBack_Click);
            // 
            // Nud_MarginSize
            // 
            this.Nud_MarginSize.Location = new System.Drawing.Point(283, 343);
            this.Nud_MarginSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Nud_MarginSize.Name = "Nud_MarginSize";
            this.Nud_MarginSize.Size = new System.Drawing.Size(92, 23);
            this.Nud_MarginSize.TabIndex = 15;
            // 
            // Lab_ColorFront
            // 
            this.Lab_ColorFront.AutoSize = true;
            this.Lab_ColorFront.Enabled = false;
            this.Lab_ColorFront.Location = new System.Drawing.Point(209, 278);
            this.Lab_ColorFront.Name = "Lab_ColorFront";
            this.Lab_ColorFront.Size = new System.Drawing.Size(56, 17);
            this.Lab_ColorFront.TabIndex = 3;
            this.Lab_ColorFront.Text = "前景色：";
            // 
            // Nud_CodeSize
            // 
            this.Nud_CodeSize.Location = new System.Drawing.Point(283, 312);
            this.Nud_CodeSize.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.Nud_CodeSize.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Nud_CodeSize.Name = "Nud_CodeSize";
            this.Nud_CodeSize.Size = new System.Drawing.Size(92, 23);
            this.Nud_CodeSize.TabIndex = 15;
            this.Nud_CodeSize.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // Gbx_QrCodeColor
            // 
            this.Gbx_QrCodeColor.Controls.Add(this.Rbtn_ColorCustom);
            this.Gbx_QrCodeColor.Controls.Add(this.Rbtn_ColorNormal);
            this.Gbx_QrCodeColor.Location = new System.Drawing.Point(209, 207);
            this.Gbx_QrCodeColor.Name = "Gbx_QrCodeColor";
            this.Gbx_QrCodeColor.Size = new System.Drawing.Size(166, 55);
            this.Gbx_QrCodeColor.TabIndex = 14;
            this.Gbx_QrCodeColor.TabStop = false;
            this.Gbx_QrCodeColor.Text = "主题";
            // 
            // Rbtn_ColorCustom
            // 
            this.Rbtn_ColorCustom.AutoSize = true;
            this.Rbtn_ColorCustom.Location = new System.Drawing.Point(83, 24);
            this.Rbtn_ColorCustom.Name = "Rbtn_ColorCustom";
            this.Rbtn_ColorCustom.Size = new System.Drawing.Size(62, 21);
            this.Rbtn_ColorCustom.TabIndex = 4;
            this.Rbtn_ColorCustom.Text = "自定义";
            this.Rbtn_ColorCustom.UseVisualStyleBackColor = true;
            // 
            // Rbtn_ColorNormal
            // 
            this.Rbtn_ColorNormal.AutoSize = true;
            this.Rbtn_ColorNormal.Checked = true;
            this.Rbtn_ColorNormal.Location = new System.Drawing.Point(15, 23);
            this.Rbtn_ColorNormal.Name = "Rbtn_ColorNormal";
            this.Rbtn_ColorNormal.Size = new System.Drawing.Size(50, 21);
            this.Rbtn_ColorNormal.TabIndex = 3;
            this.Rbtn_ColorNormal.TabStop = true;
            this.Rbtn_ColorNormal.Text = "黑白";
            this.Rbtn_ColorNormal.UseVisualStyleBackColor = true;
            this.Rbtn_ColorNormal.CheckedChanged += new System.EventHandler(this.Rbtn_ColorNormal_CheckedChanged);
            // 
            // Gbx_QrCodeVersion
            // 
            this.Gbx_QrCodeVersion.Controls.Add(this.Rbtn_VersionWithLogo);
            this.Gbx_QrCodeVersion.Controls.Add(this.Rbtn_VersionNormal);
            this.Gbx_QrCodeVersion.Location = new System.Drawing.Point(209, 146);
            this.Gbx_QrCodeVersion.Name = "Gbx_QrCodeVersion";
            this.Gbx_QrCodeVersion.Size = new System.Drawing.Size(166, 55);
            this.Gbx_QrCodeVersion.TabIndex = 14;
            this.Gbx_QrCodeVersion.TabStop = false;
            this.Gbx_QrCodeVersion.Text = "版本";
            // 
            // Rbtn_VersionWithLogo
            // 
            this.Rbtn_VersionWithLogo.AutoSize = true;
            this.Rbtn_VersionWithLogo.Location = new System.Drawing.Point(83, 23);
            this.Rbtn_VersionWithLogo.Name = "Rbtn_VersionWithLogo";
            this.Rbtn_VersionWithLogo.Size = new System.Drawing.Size(68, 21);
            this.Rbtn_VersionWithLogo.TabIndex = 4;
            this.Rbtn_VersionWithLogo.Text = "带Logo";
            this.Rbtn_VersionWithLogo.UseVisualStyleBackColor = true;
            // 
            // Rbtn_VersionNormal
            // 
            this.Rbtn_VersionNormal.AutoSize = true;
            this.Rbtn_VersionNormal.Checked = true;
            this.Rbtn_VersionNormal.Location = new System.Drawing.Point(15, 23);
            this.Rbtn_VersionNormal.Name = "Rbtn_VersionNormal";
            this.Rbtn_VersionNormal.Size = new System.Drawing.Size(50, 21);
            this.Rbtn_VersionNormal.TabIndex = 3;
            this.Rbtn_VersionNormal.TabStop = true;
            this.Rbtn_VersionNormal.Text = "正常";
            this.Rbtn_VersionNormal.UseVisualStyleBackColor = true;
            this.Rbtn_VersionNormal.CheckedChanged += new System.EventHandler(this.Rbtn_VersionNormal_CheckedChanged);
            // 
            // Lab_ColorBack
            // 
            this.Lab_ColorBack.AutoSize = true;
            this.Lab_ColorBack.Enabled = false;
            this.Lab_ColorBack.Location = new System.Drawing.Point(295, 278);
            this.Lab_ColorBack.Name = "Lab_ColorBack";
            this.Lab_ColorBack.Size = new System.Drawing.Size(56, 17);
            this.Lab_ColorBack.TabIndex = 3;
            this.Lab_ColorBack.Text = "背景色：";
            // 
            // Tbx_LogoPath
            // 
            this.Tbx_LogoPath.Enabled = false;
            this.Tbx_LogoPath.Location = new System.Drawing.Point(86, 113);
            this.Tbx_LogoPath.Name = "Tbx_LogoPath";
            this.Tbx_LogoPath.ReadOnly = true;
            this.Tbx_LogoPath.Size = new System.Drawing.Size(289, 23);
            this.Tbx_LogoPath.TabIndex = 12;
            // 
            // Btn_SaveQrCode
            // 
            this.Btn_SaveQrCode.Location = new System.Drawing.Point(381, 265);
            this.Btn_SaveQrCode.Name = "Btn_SaveQrCode";
            this.Btn_SaveQrCode.Size = new System.Drawing.Size(81, 31);
            this.Btn_SaveQrCode.TabIndex = 11;
            this.Btn_SaveQrCode.Text = "保存";
            this.Btn_SaveQrCode.UseVisualStyleBackColor = true;
            this.Btn_SaveQrCode.Click += new System.EventHandler(this.Btn_SaveQrCode_Click);
            // 
            // Btn_GenQrCode
            // 
            this.Btn_GenQrCode.Location = new System.Drawing.Point(381, 226);
            this.Btn_GenQrCode.Name = "Btn_GenQrCode";
            this.Btn_GenQrCode.Size = new System.Drawing.Size(81, 31);
            this.Btn_GenQrCode.TabIndex = 10;
            this.Btn_GenQrCode.Text = "生成";
            this.Btn_GenQrCode.UseVisualStyleBackColor = true;
            this.Btn_GenQrCode.Click += new System.EventHandler(this.Btn_GenQrCode_Click);
            // 
            // Lab_GenContent
            // 
            this.Lab_GenContent.AutoSize = true;
            this.Lab_GenContent.Location = new System.Drawing.Point(6, 3);
            this.Lab_GenContent.Name = "Lab_GenContent";
            this.Lab_GenContent.Size = new System.Drawing.Size(68, 17);
            this.Lab_GenContent.TabIndex = 7;
            this.Lab_GenContent.Text = "文字内容：";
            // 
            // Tbx_GenContent
            // 
            this.Tbx_GenContent.Location = new System.Drawing.Point(6, 23);
            this.Tbx_GenContent.Multiline = true;
            this.Tbx_GenContent.Name = "Tbx_GenContent";
            this.Tbx_GenContent.Size = new System.Drawing.Size(456, 80);
            this.Tbx_GenContent.TabIndex = 6;
            this.Tbx_GenContent.Text = "您正在使用SWORLD开发助手！";
            // 
            // Btn_SelectLogoPath
            // 
            this.Btn_SelectLogoPath.Enabled = false;
            this.Btn_SelectLogoPath.Location = new System.Drawing.Point(381, 109);
            this.Btn_SelectLogoPath.Name = "Btn_SelectLogoPath";
            this.Btn_SelectLogoPath.Size = new System.Drawing.Size(81, 31);
            this.Btn_SelectLogoPath.TabIndex = 5;
            this.Btn_SelectLogoPath.Text = "选择";
            this.Btn_SelectLogoPath.UseVisualStyleBackColor = true;
            this.Btn_SelectLogoPath.Click += new System.EventHandler(this.Btn_SelectLogoPath_Click);
            // 
            // Lab_CodeSize
            // 
            this.Lab_CodeSize.AutoSize = true;
            this.Lab_CodeSize.Location = new System.Drawing.Point(209, 315);
            this.Lab_CodeSize.Name = "Lab_CodeSize";
            this.Lab_CodeSize.Size = new System.Drawing.Size(68, 17);
            this.Lab_CodeSize.TabIndex = 3;
            this.Lab_CodeSize.Text = "尺寸大小：";
            // 
            // Lab_LogoPath
            // 
            this.Lab_LogoPath.AutoSize = true;
            this.Lab_LogoPath.Enabled = false;
            this.Lab_LogoPath.Location = new System.Drawing.Point(6, 116);
            this.Lab_LogoPath.Name = "Lab_LogoPath";
            this.Lab_LogoPath.Size = new System.Drawing.Size(74, 17);
            this.Lab_LogoPath.TabIndex = 2;
            this.Lab_LogoPath.Text = "Logo路径：";
            // 
            // Tp_BarCode
            // 
            this.Tp_BarCode.Controls.Add(this.Btn_Bar_Save);
            this.Tp_BarCode.Controls.Add(this.Btn_Bar_Gen);
            this.Tp_BarCode.Controls.Add(this.Lab_Bar_SizeWidth);
            this.Tp_BarCode.Controls.Add(this.Lab_Bar_SizeLength);
            this.Tp_BarCode.Controls.Add(this.Lab_Bar_Preview);
            this.Tp_BarCode.Controls.Add(this.Lab_Bar_Margin);
            this.Tp_BarCode.Controls.Add(this.Nud_Bar_Margin);
            this.Tp_BarCode.Controls.Add(this.Nud_Bar_SizeWidth);
            this.Tp_BarCode.Controls.Add(this.Nud_Bar_SizeLength);
            this.Tp_BarCode.Controls.Add(this.Lab_Bar_Size);
            this.Tp_BarCode.Controls.Add(this.Pbx_Bar_Preview);
            this.Tp_BarCode.Controls.Add(this.Lab_Bar_Content);
            this.Tp_BarCode.Controls.Add(this.Tbx_Bar_Content);
            this.Tp_BarCode.Location = new System.Drawing.Point(4, 4);
            this.Tp_BarCode.Name = "Tp_BarCode";
            this.Tp_BarCode.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_BarCode.Size = new System.Drawing.Size(468, 372);
            this.Tp_BarCode.TabIndex = 1;
            this.Tp_BarCode.Text = "条形码";
            this.Tp_BarCode.UseVisualStyleBackColor = true;
            // 
            // Btn_Bar_Save
            // 
            this.Btn_Bar_Save.Location = new System.Drawing.Point(378, 177);
            this.Btn_Bar_Save.Name = "Btn_Bar_Save";
            this.Btn_Bar_Save.Size = new System.Drawing.Size(84, 31);
            this.Btn_Bar_Save.TabIndex = 24;
            this.Btn_Bar_Save.Text = "保存";
            this.Btn_Bar_Save.UseVisualStyleBackColor = true;
            this.Btn_Bar_Save.Click += new System.EventHandler(this.Btn_Bar_Save_Click);
            // 
            // Btn_Bar_Gen
            // 
            this.Btn_Bar_Gen.Location = new System.Drawing.Point(378, 140);
            this.Btn_Bar_Gen.Name = "Btn_Bar_Gen";
            this.Btn_Bar_Gen.Size = new System.Drawing.Size(84, 31);
            this.Btn_Bar_Gen.TabIndex = 23;
            this.Btn_Bar_Gen.Text = "生成";
            this.Btn_Bar_Gen.UseVisualStyleBackColor = true;
            this.Btn_Bar_Gen.Click += new System.EventHandler(this.Btn_Bar_Gen_Click);
            // 
            // Lab_Bar_SizeWidth
            // 
            this.Lab_Bar_SizeWidth.AutoSize = true;
            this.Lab_Bar_SizeWidth.Location = new System.Drawing.Point(6, 188);
            this.Lab_Bar_SizeWidth.Name = "Lab_Bar_SizeWidth";
            this.Lab_Bar_SizeWidth.Size = new System.Drawing.Size(44, 17);
            this.Lab_Bar_SizeWidth.TabIndex = 22;
            this.Lab_Bar_SizeWidth.Text = "宽度：";
            // 
            // Lab_Bar_SizeLength
            // 
            this.Lab_Bar_SizeLength.AutoSize = true;
            this.Lab_Bar_SizeLength.Location = new System.Drawing.Point(6, 157);
            this.Lab_Bar_SizeLength.Name = "Lab_Bar_SizeLength";
            this.Lab_Bar_SizeLength.Size = new System.Drawing.Size(44, 17);
            this.Lab_Bar_SizeLength.TabIndex = 22;
            this.Lab_Bar_SizeLength.Text = "长度：";
            // 
            // Lab_Bar_Preview
            // 
            this.Lab_Bar_Preview.AutoSize = true;
            this.Lab_Bar_Preview.Location = new System.Drawing.Point(6, 219);
            this.Lab_Bar_Preview.Name = "Lab_Bar_Preview";
            this.Lab_Bar_Preview.Size = new System.Drawing.Size(68, 17);
            this.Lab_Bar_Preview.TabIndex = 21;
            this.Lab_Bar_Preview.Text = "图像预览：";
            // 
            // Lab_Bar_Margin
            // 
            this.Lab_Bar_Margin.AutoSize = true;
            this.Lab_Bar_Margin.Location = new System.Drawing.Point(177, 157);
            this.Lab_Bar_Margin.Name = "Lab_Bar_Margin";
            this.Lab_Bar_Margin.Size = new System.Drawing.Size(68, 17);
            this.Lab_Bar_Margin.TabIndex = 20;
            this.Lab_Bar_Margin.Text = "边缘大小：";
            // 
            // Nud_Bar_Margin
            // 
            this.Nud_Bar_Margin.Location = new System.Drawing.Point(251, 154);
            this.Nud_Bar_Margin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_Bar_Margin.Name = "Nud_Bar_Margin";
            this.Nud_Bar_Margin.Size = new System.Drawing.Size(92, 23);
            this.Nud_Bar_Margin.TabIndex = 18;
            // 
            // Nud_Bar_SizeWidth
            // 
            this.Nud_Bar_SizeWidth.Location = new System.Drawing.Point(56, 185);
            this.Nud_Bar_SizeWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Nud_Bar_SizeWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nud_Bar_SizeWidth.Name = "Nud_Bar_SizeWidth";
            this.Nud_Bar_SizeWidth.Size = new System.Drawing.Size(92, 23);
            this.Nud_Bar_SizeWidth.TabIndex = 19;
            this.Nud_Bar_SizeWidth.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Nud_Bar_SizeLength
            // 
            this.Nud_Bar_SizeLength.Location = new System.Drawing.Point(56, 154);
            this.Nud_Bar_SizeLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Nud_Bar_SizeLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nud_Bar_SizeLength.Name = "Nud_Bar_SizeLength";
            this.Nud_Bar_SizeLength.Size = new System.Drawing.Size(92, 23);
            this.Nud_Bar_SizeLength.TabIndex = 19;
            this.Nud_Bar_SizeLength.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // Lab_Bar_Size
            // 
            this.Lab_Bar_Size.AutoSize = true;
            this.Lab_Bar_Size.Location = new System.Drawing.Point(6, 134);
            this.Lab_Bar_Size.Name = "Lab_Bar_Size";
            this.Lab_Bar_Size.Size = new System.Drawing.Size(68, 17);
            this.Lab_Bar_Size.TabIndex = 17;
            this.Lab_Bar_Size.Text = "尺寸大小：";
            // 
            // Pbx_Bar_Preview
            // 
            this.Pbx_Bar_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pbx_Bar_Preview.Location = new System.Drawing.Point(6, 239);
            this.Pbx_Bar_Preview.Name = "Pbx_Bar_Preview";
            this.Pbx_Bar_Preview.Size = new System.Drawing.Size(456, 130);
            this.Pbx_Bar_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_Bar_Preview.TabIndex = 10;
            this.Pbx_Bar_Preview.TabStop = false;
            // 
            // Lab_Bar_Content
            // 
            this.Lab_Bar_Content.AutoSize = true;
            this.Lab_Bar_Content.Location = new System.Drawing.Point(6, 3);
            this.Lab_Bar_Content.Name = "Lab_Bar_Content";
            this.Lab_Bar_Content.Size = new System.Drawing.Size(68, 17);
            this.Lab_Bar_Content.TabIndex = 9;
            this.Lab_Bar_Content.Text = "文字内容：";
            // 
            // Tbx_Bar_Content
            // 
            this.Tbx_Bar_Content.Location = new System.Drawing.Point(6, 23);
            this.Tbx_Bar_Content.Multiline = true;
            this.Tbx_Bar_Content.Name = "Tbx_Bar_Content";
            this.Tbx_Bar_Content.Size = new System.Drawing.Size(456, 100);
            this.Tbx_Bar_Content.TabIndex = 8;
            this.Tbx_Bar_Content.Text = "SWORLD";
            this.Tbx_Bar_Content.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tbx_Bar_Content_KeyPress);
            // 
            // Lab_ParseResult
            // 
            this.Lab_ParseResult.AutoSize = true;
            this.Lab_ParseResult.Location = new System.Drawing.Point(10, 405);
            this.Lab_ParseResult.Name = "Lab_ParseResult";
            this.Lab_ParseResult.Size = new System.Drawing.Size(68, 17);
            this.Lab_ParseResult.TabIndex = 9;
            this.Lab_ParseResult.Text = "解析结果：";
            // 
            // Tbx_ParseResult
            // 
            this.Tbx_ParseResult.Location = new System.Drawing.Point(10, 425);
            this.Tbx_ParseResult.Multiline = true;
            this.Tbx_ParseResult.Name = "Tbx_ParseResult";
            this.Tbx_ParseResult.ReadOnly = true;
            this.Tbx_ParseResult.Size = new System.Drawing.Size(369, 80);
            this.Tbx_ParseResult.TabIndex = 8;
            // 
            // Btn_QrCodeParse
            // 
            this.Btn_QrCodeParse.Location = new System.Drawing.Point(382, 425);
            this.Btn_QrCodeParse.Name = "Btn_QrCodeParse";
            this.Btn_QrCodeParse.Size = new System.Drawing.Size(84, 80);
            this.Btn_QrCodeParse.TabIndex = 5;
            this.Btn_QrCodeParse.Text = "解析";
            this.Btn_QrCodeParse.UseVisualStyleBackColor = true;
            this.Btn_QrCodeParse.Click += new System.EventHandler(this.Btn_QrCodeParse_Click);
            // 
            // Ofd_LogoSelect
            // 
            this.Ofd_LogoSelect.Filter = "图片文件|*.jpg;*.png";
            this.Ofd_LogoSelect.Title = "选择Logo图片";
            // 
            // Ofd_QrCodeParse
            // 
            this.Ofd_QrCodeParse.Title = "选择图片";
            // 
            // Sfd_QrCodeSave
            // 
            this.Sfd_QrCodeSave.Filter = "jpg文件|*.jpg|png文件|*.png|bmp文件|*.bmp";
            this.Sfd_QrCodeSave.Title = "选择保存路径";
            // 
            // UC_Tools_QrCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tc_QrorBarCode);
            this.Controls.Add(this.Tbx_ParseResult);
            this.Controls.Add(this.Lab_ParseResult);
            this.Controls.Add(this.Btn_QrCodeParse);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_QrCode";
            this.Size = new System.Drawing.Size(476, 508);
            this.Load += new System.EventHandler(this.UC_Tools_QrCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Preview)).EndInit();
            this.Tc_QrorBarCode.ResumeLayout(false);
            this.Tp_QrCode.ResumeLayout(false);
            this.Tp_QrCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MarginSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_CodeSize)).EndInit();
            this.Gbx_QrCodeColor.ResumeLayout(false);
            this.Gbx_QrCodeColor.PerformLayout();
            this.Gbx_QrCodeVersion.ResumeLayout(false);
            this.Gbx_QrCodeVersion.PerformLayout();
            this.Tp_BarCode.ResumeLayout(false);
            this.Tp_BarCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Bar_Margin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Bar_SizeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Bar_SizeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Bar_Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pbx_Preview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Tc_QrorBarCode;
        private System.Windows.Forms.TabPage Tp_QrCode;
        private System.Windows.Forms.TabPage Tp_BarCode;
        private System.Windows.Forms.Label Lab_CodeSize;
        private System.Windows.Forms.Label Lab_GenContent;
        private System.Windows.Forms.TextBox Tbx_GenContent;
        private System.Windows.Forms.Button Btn_QrCodeParse;
        private System.Windows.Forms.Label Lab_ParseResult;
        private System.Windows.Forms.TextBox Tbx_ParseResult;
        private System.Windows.Forms.Button Btn_SaveQrCode;
        private System.Windows.Forms.Button Btn_GenQrCode;
        private System.Windows.Forms.Label Lab_MarginSize;
        private System.Windows.Forms.NumericUpDown Nud_CodeSize;
        private System.Windows.Forms.GroupBox Gbx_QrCodeColor;
        private System.Windows.Forms.RadioButton Rbtn_ColorCustom;
        private System.Windows.Forms.RadioButton Rbtn_ColorNormal;
        private System.Windows.Forms.GroupBox Gbx_QrCodeVersion;
        private System.Windows.Forms.RadioButton Rbtn_VersionWithLogo;
        private System.Windows.Forms.RadioButton Rbtn_VersionNormal;
        private System.Windows.Forms.TextBox Tbx_LogoPath;
        private System.Windows.Forms.Label Lab_LogoPath;
        private System.Windows.Forms.Button Btn_SelectLogoPath;
        private System.Windows.Forms.Panel Pal_ColorFront;
        private System.Windows.Forms.Panel Pal_ColorBack;
        private System.Windows.Forms.NumericUpDown Nud_MarginSize;
        private System.Windows.Forms.Label Lab_ColorFront;
        private System.Windows.Forms.Label Lab_ColorBack;
        private System.Windows.Forms.Label Lab_Bar_Content;
        private System.Windows.Forms.TextBox Tbx_Bar_Content;
        private System.Windows.Forms.PictureBox Pbx_Bar_Preview;
        private System.Windows.Forms.OpenFileDialog Ofd_LogoSelect;
        private System.Windows.Forms.OpenFileDialog Ofd_QrCodeParse;
        private System.Windows.Forms.SaveFileDialog Sfd_QrCodeSave;
        private System.Windows.Forms.Label Lab_Bar_Preview;
        private System.Windows.Forms.Label Lab_Bar_Margin;
        private System.Windows.Forms.NumericUpDown Nud_Bar_Margin;
        private System.Windows.Forms.NumericUpDown Nud_Bar_SizeLength;
        private System.Windows.Forms.Label Lab_Bar_Size;
        private System.Windows.Forms.Label Lab_Bar_SizeWidth;
        private System.Windows.Forms.Label Lab_Bar_SizeLength;
        private System.Windows.Forms.NumericUpDown Nud_Bar_SizeWidth;
        private System.Windows.Forms.Button Btn_Bar_Save;
        private System.Windows.Forms.Button Btn_Bar_Gen;
    }
}
