namespace SWORLD开发助手.Forms
{
    partial class Frm_FeedBack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FeedBack));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Tbx_Problem_Sketch = new System.Windows.Forms.TextBox();
            this.Tbx_Problem_Detail = new System.Windows.Forms.TextBox();
            this.Tbx_User_Mail = new System.Windows.Forms.TextBox();
            this.Lab_Tip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "问题简述：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "您的邮箱：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "问题详情：";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Close.Location = new System.Drawing.Point(417, 277);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 32);
            this.Btn_Close.TabIndex = 4;
            this.Btn_Close.Text = "关闭(&C)";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Submit.Location = new System.Drawing.Point(326, 277);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(75, 32);
            this.Btn_Submit.TabIndex = 3;
            this.Btn_Submit.Text = "提交(&S)";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Tbx_Problem_Sketch
            // 
            this.Tbx_Problem_Sketch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Problem_Sketch.Location = new System.Drawing.Point(80, 20);
            this.Tbx_Problem_Sketch.Name = "Tbx_Problem_Sketch";
            this.Tbx_Problem_Sketch.Size = new System.Drawing.Size(412, 22);
            this.Tbx_Problem_Sketch.TabIndex = 0;
            // 
            // Tbx_Problem_Detail
            // 
            this.Tbx_Problem_Detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_Problem_Detail.Location = new System.Drawing.Point(80, 84);
            this.Tbx_Problem_Detail.Multiline = true;
            this.Tbx_Problem_Detail.Name = "Tbx_Problem_Detail";
            this.Tbx_Problem_Detail.Size = new System.Drawing.Size(412, 179);
            this.Tbx_Problem_Detail.TabIndex = 2;
            // 
            // Tbx_User_Mail
            // 
            this.Tbx_User_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_User_Mail.Location = new System.Drawing.Point(80, 52);
            this.Tbx_User_Mail.Name = "Tbx_User_Mail";
            this.Tbx_User_Mail.Size = new System.Drawing.Size(412, 22);
            this.Tbx_User_Mail.TabIndex = 1;
            // 
            // Lab_Tip
            // 
            this.Lab_Tip.AutoSize = true;
            this.Lab_Tip.Location = new System.Drawing.Point(12, 283);
            this.Lab_Tip.Name = "Lab_Tip";
            this.Lab_Tip.Size = new System.Drawing.Size(49, 14);
            this.Lab_Tip.TabIndex = 5;
            this.Lab_Tip.Text = "提示：";
            // 
            // Frm_FeedBack
            // 
            this.AcceptButton = this.Btn_Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Close;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.Lab_Tip);
            this.Controls.Add(this.Tbx_User_Mail);
            this.Controls.Add(this.Tbx_Problem_Detail);
            this.Controls.Add(this.Tbx_Problem_Sketch);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(520, 360);
            this.Name = "Frm_FeedBack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "反馈";
            this.Load += new System.EventHandler(this.Frm_FeedBack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.TextBox Tbx_Problem_Sketch;
        private System.Windows.Forms.TextBox Tbx_Problem_Detail;
        private System.Windows.Forms.TextBox Tbx_User_Mail;
        private System.Windows.Forms.Label Lab_Tip;
    }
}