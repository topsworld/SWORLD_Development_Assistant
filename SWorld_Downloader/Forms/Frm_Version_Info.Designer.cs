namespace SWorld_Downloader.Forms
{
    partial class Frm_Version_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Version_Info));
            this.Ckbx_Not_Tip = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ckbx_Not_Tip
            // 
            this.Ckbx_Not_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Ckbx_Not_Tip.AutoSize = true;
            this.Ckbx_Not_Tip.Checked = true;
            this.Ckbx_Not_Tip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbx_Not_Tip.Location = new System.Drawing.Point(12, 415);
            this.Ckbx_Not_Tip.Name = "Ckbx_Not_Tip";
            this.Ckbx_Not_Tip.Size = new System.Drawing.Size(82, 18);
            this.Ckbx_Not_Tip.TabIndex = 0;
            this.Ckbx_Not_Tip.Text = "不在提示";
            this.Ckbx_Not_Tip.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(12, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(450, 388);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "整理中。。。";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_OK.Location = new System.Drawing.Point(376, 407);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(86, 32);
            this.Btn_OK.TabIndex = 2;
            this.Btn_OK.Text = "确定(&O)";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Frm_Version_Info
            // 
            this.AcceptButton = this.Btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 451);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Ckbx_Not_Tip);
            this.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(490, 490);
            this.Name = "Frm_Version_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "软件信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Version_Info_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Version_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Ckbx_Not_Tip;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Btn_OK;
    }
}