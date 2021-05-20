
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_CalcTransf
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
            this.Lbx_CalcTransfItems = new System.Windows.Forms.ListBox();
            this.Btn_CalcTransf_SelectFile = new System.Windows.Forms.Button();
            this.LLab_CalcTransf_Output_Clear = new System.Windows.Forms.LinkLabel();
            this.LLab_CalcTransf_Input_Clear = new System.Windows.Forms.LinkLabel();
            this.Btn_CalcTransf_Start = new System.Windows.Forms.Button();
            this.Lab_CalcTransf_Output = new System.Windows.Forms.Label();
            this.Tbx_CalcTransf_Output = new System.Windows.Forms.TextBox();
            this.Lab_CalcTransf_Input = new System.Windows.Forms.Label();
            this.Tbx_CalcTransf_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbx_CalcTransfItems
            // 
            this.Lbx_CalcTransfItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbx_CalcTransfItems.FormattingEnabled = true;
            this.Lbx_CalcTransfItems.IntegralHeight = false;
            this.Lbx_CalcTransfItems.ItemHeight = 17;
            this.Lbx_CalcTransfItems.Items.AddRange(new object[] {
            "00: 校验和",
            "01: XOR异或",
            "02: CRC8",
            "03: CRC16",
            "04: CRC32",
            "05: 字符串MD5",
            "06: 进制转换",
            "07: GBK转UNICODE",
            "08: UNICODE转GBK",
            "09: mm转mil",
            "10: mil转mm",
            "11：AES字符串加密",
            "12：AES字符串解密",
            "13：时间戳->字符串",
            "14：字符串->时间戳",
            "50: 文件MD5（选择文件）",
            "51: 文件转C数组（选择文件）",
            "52: BASE64编码（选择文件）",
            "53: BASE64解码（选择文件）"});
            this.Lbx_CalcTransfItems.Location = new System.Drawing.Point(3, 4);
            this.Lbx_CalcTransfItems.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Lbx_CalcTransfItems.Name = "Lbx_CalcTransfItems";
            this.Lbx_CalcTransfItems.Size = new System.Drawing.Size(178, 500);
            this.Lbx_CalcTransfItems.TabIndex = 0;
            this.Lbx_CalcTransfItems.SelectedIndexChanged += new System.EventHandler(this.Lbx_CalcTransfItems_SelectedIndexChanged);
            // 
            // Btn_CalcTransf_SelectFile
            // 
            this.Btn_CalcTransf_SelectFile.Enabled = false;
            this.Btn_CalcTransf_SelectFile.Location = new System.Drawing.Point(187, 216);
            this.Btn_CalcTransf_SelectFile.Name = "Btn_CalcTransf_SelectFile";
            this.Btn_CalcTransf_SelectFile.Size = new System.Drawing.Size(87, 33);
            this.Btn_CalcTransf_SelectFile.TabIndex = 7;
            this.Btn_CalcTransf_SelectFile.Text = "选择文件";
            this.Btn_CalcTransf_SelectFile.UseVisualStyleBackColor = true;
            this.Btn_CalcTransf_SelectFile.Click += new System.EventHandler(this.Btn_CalcTransf_SelectFile_Click);
            // 
            // LLab_CalcTransf_Output_Clear
            // 
            this.LLab_CalcTransf_Output_Clear.AutoSize = true;
            this.LLab_CalcTransf_Output_Clear.Location = new System.Drawing.Point(417, 257);
            this.LLab_CalcTransf_Output_Clear.Name = "LLab_CalcTransf_Output_Clear";
            this.LLab_CalcTransf_Output_Clear.Size = new System.Drawing.Size(56, 17);
            this.LLab_CalcTransf_Output_Clear.TabIndex = 6;
            this.LLab_CalcTransf_Output_Clear.TabStop = true;
            this.LLab_CalcTransf_Output_Clear.Text = "清空输出";
            this.LLab_CalcTransf_Output_Clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLab_CalcTransf_Output_Clear_LinkClicked);
            // 
            // LLab_CalcTransf_Input_Clear
            // 
            this.LLab_CalcTransf_Input_Clear.AutoSize = true;
            this.LLab_CalcTransf_Input_Clear.Location = new System.Drawing.Point(420, 4);
            this.LLab_CalcTransf_Input_Clear.Name = "LLab_CalcTransf_Input_Clear";
            this.LLab_CalcTransf_Input_Clear.Size = new System.Drawing.Size(56, 17);
            this.LLab_CalcTransf_Input_Clear.TabIndex = 5;
            this.LLab_CalcTransf_Input_Clear.TabStop = true;
            this.LLab_CalcTransf_Input_Clear.Text = "清空输入";
            this.LLab_CalcTransf_Input_Clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLab_CalcTransf_Input_Clear_LinkClicked);
            // 
            // Btn_CalcTransf_Start
            // 
            this.Btn_CalcTransf_Start.Location = new System.Drawing.Point(386, 216);
            this.Btn_CalcTransf_Start.Name = "Btn_CalcTransf_Start";
            this.Btn_CalcTransf_Start.Size = new System.Drawing.Size(87, 33);
            this.Btn_CalcTransf_Start.TabIndex = 4;
            this.Btn_CalcTransf_Start.Text = "计算/转换";
            this.Btn_CalcTransf_Start.UseVisualStyleBackColor = true;
            this.Btn_CalcTransf_Start.Click += new System.EventHandler(this.Btn_CalcTransf_Start_Click);
            // 
            // Lab_CalcTransf_Output
            // 
            this.Lab_CalcTransf_Output.AutoSize = true;
            this.Lab_CalcTransf_Output.Location = new System.Drawing.Point(187, 257);
            this.Lab_CalcTransf_Output.Name = "Lab_CalcTransf_Output";
            this.Lab_CalcTransf_Output.Size = new System.Drawing.Size(44, 17);
            this.Lab_CalcTransf_Output.TabIndex = 1;
            this.Lab_CalcTransf_Output.Text = "输出：";
            // 
            // Tbx_CalcTransf_Output
            // 
            this.Tbx_CalcTransf_Output.Location = new System.Drawing.Point(187, 278);
            this.Tbx_CalcTransf_Output.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_CalcTransf_Output.Multiline = true;
            this.Tbx_CalcTransf_Output.Name = "Tbx_CalcTransf_Output";
            this.Tbx_CalcTransf_Output.ReadOnly = true;
            this.Tbx_CalcTransf_Output.Size = new System.Drawing.Size(286, 226);
            this.Tbx_CalcTransf_Output.TabIndex = 3;
            // 
            // Lab_CalcTransf_Input
            // 
            this.Lab_CalcTransf_Input.AutoSize = true;
            this.Lab_CalcTransf_Input.Location = new System.Drawing.Point(187, 4);
            this.Lab_CalcTransf_Input.Name = "Lab_CalcTransf_Input";
            this.Lab_CalcTransf_Input.Size = new System.Drawing.Size(44, 17);
            this.Lab_CalcTransf_Input.TabIndex = 2;
            this.Lab_CalcTransf_Input.Text = "输入：";
            // 
            // Tbx_CalcTransf_Input
            // 
            this.Tbx_CalcTransf_Input.Location = new System.Drawing.Point(187, 25);
            this.Tbx_CalcTransf_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_CalcTransf_Input.Multiline = true;
            this.Tbx_CalcTransf_Input.Name = "Tbx_CalcTransf_Input";
            this.Tbx_CalcTransf_Input.Size = new System.Drawing.Size(286, 184);
            this.Tbx_CalcTransf_Input.TabIndex = 0;
            // 
            // UC_Tools_CalcTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tbx_CalcTransf_Output);
            this.Controls.Add(this.Lab_CalcTransf_Output);
            this.Controls.Add(this.LLab_CalcTransf_Output_Clear);
            this.Controls.Add(this.Tbx_CalcTransf_Input);
            this.Controls.Add(this.Btn_CalcTransf_Start);
            this.Controls.Add(this.LLab_CalcTransf_Input_Clear);
            this.Controls.Add(this.Btn_CalcTransf_SelectFile);
            this.Controls.Add(this.Lbx_CalcTransfItems);
            this.Controls.Add(this.Lab_CalcTransf_Input);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_CalcTransf";
            this.Size = new System.Drawing.Size(476, 508);
            this.Load += new System.EventHandler(this.UC_Tools_CalcTransf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox Lbx_CalcTransfItems;
        private System.Windows.Forms.Button Btn_CalcTransf_SelectFile;
        private System.Windows.Forms.LinkLabel LLab_CalcTransf_Output_Clear;
        private System.Windows.Forms.LinkLabel LLab_CalcTransf_Input_Clear;
        private System.Windows.Forms.Button Btn_CalcTransf_Start;
        private System.Windows.Forms.Label Lab_CalcTransf_Output;
        private System.Windows.Forms.TextBox Tbx_CalcTransf_Output;
        private System.Windows.Forms.Label Lab_CalcTransf_Input;
        private System.Windows.Forms.TextBox Tbx_CalcTransf_Input;
    }
}
