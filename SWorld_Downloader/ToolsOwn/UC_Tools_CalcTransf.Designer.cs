
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
            this.Spc_CalcTransf = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.Lab_Tools_Output = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Lab_Tools_Input = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_CalcTransf)).BeginInit();
            this.Spc_CalcTransf.Panel1.SuspendLayout();
            this.Spc_CalcTransf.Panel2.SuspendLayout();
            this.Spc_CalcTransf.SuspendLayout();
            this.SuspendLayout();
            // 
            // Spc_CalcTransf
            // 
            this.Spc_CalcTransf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spc_CalcTransf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spc_CalcTransf.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.Spc_CalcTransf.IsSplitterFixed = true;
            this.Spc_CalcTransf.Location = new System.Drawing.Point(0, 0);
            this.Spc_CalcTransf.Margin = new System.Windows.Forms.Padding(0);
            this.Spc_CalcTransf.Name = "Spc_CalcTransf";
            // 
            // Spc_CalcTransf.Panel1
            // 
            this.Spc_CalcTransf.Panel1.Controls.Add(this.listBox1);
            this.Spc_CalcTransf.Panel1MinSize = 180;
            // 
            // Spc_CalcTransf.Panel2
            // 
            this.Spc_CalcTransf.Panel2.Controls.Add(this.button2);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.linkLabel2);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.linkLabel1);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.button1);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.Lab_Tools_Output);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.textBox2);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.Lab_Tools_Input);
            this.Spc_CalcTransf.Panel2.Controls.Add(this.textBox1);
            this.Spc_CalcTransf.Size = new System.Drawing.Size(476, 508);
            this.Spc_CalcTransf.SplitterDistance = 180;
            this.Spc_CalcTransf.SplitterWidth = 5;
            this.Spc_CalcTransf.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Items.AddRange(new object[] {
            "00：校验和",
            "01：XOR异或",
            "02：CRC8",
            "03：CRC16",
            "04：CRC32",
            "05：字符串MD5",
            "06：文件MD5（选择文件）",
            "07：BASE64编码（字符串）",
            "08：BASE64解码（字符串）",
            "09：进制转换",
            "10：GBK转UNICODE",
            "11：UNICODE转GBK",
            "12：mm转mil",
            "13：mil转mm",
            "14：文件转C数组（选择文件）",
            "15：AES字符串加密",
            "16：AES字符串解密",
            "17：时间戳->字符串",
            "18：字符串->时间戳"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 506);
            this.listBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "选择文件";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(230, 266);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "清空输出";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(230, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "清空输入";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "计算/转换";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Lab_Tools_Output
            // 
            this.Lab_Tools_Output.AutoSize = true;
            this.Lab_Tools_Output.Location = new System.Drawing.Point(3, 266);
            this.Lab_Tools_Output.Name = "Lab_Tools_Output";
            this.Lab_Tools_Output.Size = new System.Drawing.Size(44, 17);
            this.Lab_Tools_Output.TabIndex = 1;
            this.Lab_Tools_Output.Text = "输出：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 287);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 215);
            this.textBox2.TabIndex = 3;
            // 
            // Lab_Tools_Input
            // 
            this.Lab_Tools_Input.AutoSize = true;
            this.Lab_Tools_Input.Location = new System.Drawing.Point(3, 8);
            this.Lab_Tools_Input.Name = "Lab_Tools_Input";
            this.Lab_Tools_Input.Size = new System.Drawing.Size(44, 17);
            this.Lab_Tools_Input.TabIndex = 2;
            this.Lab_Tools_Input.Text = "输入：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 29);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 184);
            this.textBox1.TabIndex = 0;
            // 
            // UC_Tools_CalcTransf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Spc_CalcTransf);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_CalcTransf";
            this.Size = new System.Drawing.Size(476, 508);
            this.Spc_CalcTransf.Panel1.ResumeLayout(false);
            this.Spc_CalcTransf.Panel2.ResumeLayout(false);
            this.Spc_CalcTransf.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spc_CalcTransf)).EndInit();
            this.Spc_CalcTransf.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Spc_CalcTransf;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lab_Tools_Output;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Lab_Tools_Input;
        private System.Windows.Forms.TextBox textBox1;
    }
}
