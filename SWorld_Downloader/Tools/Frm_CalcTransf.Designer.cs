
namespace SWorld_Downloader.Tools
{
    partial class Frm_CalcTransf
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
            this.Tc_Tools = new System.Windows.Forms.TabControl();
            this.Tp_CalcTrasf = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Pal_Tools_CalcTansf = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lab_Tools_Input = new System.Windows.Forms.Label();
            this.Lab_Tools_Output = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tp_BinEditor = new System.Windows.Forms.TabPage();
            this.Tp_FileMerge = new System.Windows.Forms.TabPage();
            this.Tp_CodeFormat = new System.Windows.Forms.TabPage();
            this.Tp_QrCode = new System.Windows.Forms.TabPage();
            this.Tp_ChineseCharacter = new System.Windows.Forms.TabPage();
            this.Tp_TTS = new System.Windows.Forms.TabPage();
            this.Tp_FileEncrypt = new System.Windows.Forms.TabPage();
            this.Tp_Source = new System.Windows.Forms.TabPage();
            this.Tc_Tools.SuspendLayout();
            this.Tp_CalcTrasf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Pal_Tools_CalcTansf.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tc_Tools
            // 
            this.Tc_Tools.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Tc_Tools.Controls.Add(this.Tp_CalcTrasf);
            this.Tc_Tools.Controls.Add(this.Tp_BinEditor);
            this.Tc_Tools.Controls.Add(this.Tp_FileMerge);
            this.Tc_Tools.Controls.Add(this.Tp_CodeFormat);
            this.Tc_Tools.Controls.Add(this.Tp_QrCode);
            this.Tc_Tools.Controls.Add(this.Tp_ChineseCharacter);
            this.Tc_Tools.Controls.Add(this.Tp_TTS);
            this.Tc_Tools.Controls.Add(this.Tp_FileEncrypt);
            this.Tc_Tools.Controls.Add(this.Tp_Source);
            this.Tc_Tools.Location = new System.Drawing.Point(190, 41);
            this.Tc_Tools.Name = "Tc_Tools";
            this.Tc_Tools.SelectedIndex = 0;
            this.Tc_Tools.Size = new System.Drawing.Size(421, 368);
            this.Tc_Tools.TabIndex = 12;
            // 
            // Tp_CalcTrasf
            // 
            this.Tp_CalcTrasf.Controls.Add(this.splitContainer1);
            this.Tp_CalcTrasf.Location = new System.Drawing.Point(4, 25);
            this.Tp_CalcTrasf.Name = "Tp_CalcTrasf";
            this.Tp_CalcTrasf.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_CalcTrasf.Size = new System.Drawing.Size(413, 339);
            this.Tp_CalcTrasf.TabIndex = 0;
            this.Tp_CalcTrasf.Text = "计算/转换";
            this.Tp_CalcTrasf.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1MinSize = 230;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Pal_Tools_CalcTansf);
            this.splitContainer1.Size = new System.Drawing.Size(407, 333);
            this.splitContainer1.SplitterDistance = 230;
            this.splitContainer1.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "00：校验和",
            "01：XOR异或",
            "02：CRC8",
            "03：CRC16",
            "04：CRC32",
            "05：字符串MD5",
            "06：文件MD5（选择文件路径）",
            "07：BASE64编码（字符串）",
            "08：BASE64解码（字符串）",
            "09：进制转换",
            "10：GBK转UNICODE",
            "11：UNICODE转GBK",
            "12：mm转mil",
            "13：mil转mm",
            "14：文件转C数组",
            "15：AES字符串加密",
            "16：AES字符串解密",
            "17：时间戳->字符串",
            "18：字符串->时间戳"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 331);
            this.listBox1.TabIndex = 0;
            // 
            // Pal_Tools_CalcTansf
            // 
            this.Pal_Tools_CalcTansf.Controls.Add(this.textBox2);
            this.Pal_Tools_CalcTansf.Controls.Add(this.Lab_Tools_Input);
            this.Pal_Tools_CalcTansf.Controls.Add(this.Lab_Tools_Output);
            this.Pal_Tools_CalcTansf.Controls.Add(this.textBox1);
            this.Pal_Tools_CalcTansf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pal_Tools_CalcTansf.Location = new System.Drawing.Point(0, 0);
            this.Pal_Tools_CalcTansf.Name = "Pal_Tools_CalcTansf";
            this.Pal_Tools_CalcTansf.Size = new System.Drawing.Size(171, 331);
            this.Pal_Tools_CalcTansf.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 215);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(520, 154);
            this.textBox2.TabIndex = 3;
            // 
            // Lab_Tools_Input
            // 
            this.Lab_Tools_Input.AutoSize = true;
            this.Lab_Tools_Input.Location = new System.Drawing.Point(3, 10);
            this.Lab_Tools_Input.Name = "Lab_Tools_Input";
            this.Lab_Tools_Input.Size = new System.Drawing.Size(41, 12);
            this.Lab_Tools_Input.TabIndex = 2;
            this.Lab_Tools_Input.Text = "输入：";
            // 
            // Lab_Tools_Output
            // 
            this.Lab_Tools_Output.AutoSize = true;
            this.Lab_Tools_Output.Location = new System.Drawing.Point(3, 197);
            this.Lab_Tools_Output.Name = "Lab_Tools_Output";
            this.Lab_Tools_Output.Size = new System.Drawing.Size(41, 12);
            this.Lab_Tools_Output.TabIndex = 1;
            this.Lab_Tools_Output.Text = "输出：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 155);
            this.textBox1.TabIndex = 0;
            // 
            // Tp_BinEditor
            // 
            this.Tp_BinEditor.Location = new System.Drawing.Point(4, 25);
            this.Tp_BinEditor.Name = "Tp_BinEditor";
            this.Tp_BinEditor.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_BinEditor.Size = new System.Drawing.Size(413, 339);
            this.Tp_BinEditor.TabIndex = 1;
            this.Tp_BinEditor.Text = "二进制编辑器";
            this.Tp_BinEditor.UseVisualStyleBackColor = true;
            // 
            // Tp_FileMerge
            // 
            this.Tp_FileMerge.Location = new System.Drawing.Point(4, 25);
            this.Tp_FileMerge.Name = "Tp_FileMerge";
            this.Tp_FileMerge.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_FileMerge.Size = new System.Drawing.Size(413, 339);
            this.Tp_FileMerge.TabIndex = 6;
            this.Tp_FileMerge.Text = "文件合并";
            this.Tp_FileMerge.UseVisualStyleBackColor = true;
            // 
            // Tp_CodeFormat
            // 
            this.Tp_CodeFormat.Location = new System.Drawing.Point(4, 25);
            this.Tp_CodeFormat.Name = "Tp_CodeFormat";
            this.Tp_CodeFormat.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_CodeFormat.Size = new System.Drawing.Size(413, 339);
            this.Tp_CodeFormat.TabIndex = 2;
            this.Tp_CodeFormat.Text = "代码格式化";
            this.Tp_CodeFormat.UseVisualStyleBackColor = true;
            // 
            // Tp_QrCode
            // 
            this.Tp_QrCode.Location = new System.Drawing.Point(4, 25);
            this.Tp_QrCode.Name = "Tp_QrCode";
            this.Tp_QrCode.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_QrCode.Size = new System.Drawing.Size(413, 339);
            this.Tp_QrCode.TabIndex = 3;
            this.Tp_QrCode.Text = "二维码生成";
            this.Tp_QrCode.UseVisualStyleBackColor = true;
            // 
            // Tp_ChineseCharacter
            // 
            this.Tp_ChineseCharacter.Location = new System.Drawing.Point(4, 25);
            this.Tp_ChineseCharacter.Name = "Tp_ChineseCharacter";
            this.Tp_ChineseCharacter.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_ChineseCharacter.Size = new System.Drawing.Size(413, 339);
            this.Tp_ChineseCharacter.TabIndex = 4;
            this.Tp_ChineseCharacter.Text = "汉字库";
            this.Tp_ChineseCharacter.UseVisualStyleBackColor = true;
            // 
            // Tp_TTS
            // 
            this.Tp_TTS.Location = new System.Drawing.Point(4, 25);
            this.Tp_TTS.Name = "Tp_TTS";
            this.Tp_TTS.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_TTS.Size = new System.Drawing.Size(413, 339);
            this.Tp_TTS.TabIndex = 5;
            this.Tp_TTS.Text = "文字转语音（TTS）";
            this.Tp_TTS.UseVisualStyleBackColor = true;
            // 
            // Tp_FileEncrypt
            // 
            this.Tp_FileEncrypt.Location = new System.Drawing.Point(4, 25);
            this.Tp_FileEncrypt.Name = "Tp_FileEncrypt";
            this.Tp_FileEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_FileEncrypt.Size = new System.Drawing.Size(413, 339);
            this.Tp_FileEncrypt.TabIndex = 7;
            this.Tp_FileEncrypt.Text = "文件加密";
            this.Tp_FileEncrypt.UseVisualStyleBackColor = true;
            // 
            // Tp_Source
            // 
            this.Tp_Source.Location = new System.Drawing.Point(4, 25);
            this.Tp_Source.Name = "Tp_Source";
            this.Tp_Source.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Source.Size = new System.Drawing.Size(413, 339);
            this.Tp_Source.TabIndex = 8;
            this.Tp_Source.Text = "资源列表";
            this.Tp_Source.UseVisualStyleBackColor = true;
            // 
            // Frm_CalcTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tc_Tools);
            this.Name = "Frm_CalcTransf";
            this.Text = "Frm_CalcTransf";
            this.Tc_Tools.ResumeLayout(false);
            this.Tp_CalcTrasf.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Pal_Tools_CalcTansf.ResumeLayout(false);
            this.Pal_Tools_CalcTansf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tc_Tools;
        private System.Windows.Forms.TabPage Tp_CalcTrasf;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel Pal_Tools_CalcTansf;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lab_Tools_Input;
        private System.Windows.Forms.Label Lab_Tools_Output;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage Tp_BinEditor;
        private System.Windows.Forms.TabPage Tp_FileMerge;
        private System.Windows.Forms.TabPage Tp_CodeFormat;
        private System.Windows.Forms.TabPage Tp_QrCode;
        private System.Windows.Forms.TabPage Tp_ChineseCharacter;
        private System.Windows.Forms.TabPage Tp_TTS;
        private System.Windows.Forms.TabPage Tp_FileEncrypt;
        private System.Windows.Forms.TabPage Tp_Source;
    }
}