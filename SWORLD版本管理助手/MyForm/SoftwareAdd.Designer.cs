
namespace SWORLD版本管理助手.MyForm
{
    partial class SoftwareAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_SoftwareCode = new System.Windows.Forms.TextBox();
            this.Tbx_SoftwareName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dtp_AddDate = new System.Windows.Forms.DateTimePicker();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "软件编码：";
            // 
            // Tbx_SoftwareCode
            // 
            this.Tbx_SoftwareCode.Location = new System.Drawing.Point(86, 29);
            this.Tbx_SoftwareCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_SoftwareCode.Name = "Tbx_SoftwareCode";
            this.Tbx_SoftwareCode.Size = new System.Drawing.Size(179, 23);
            this.Tbx_SoftwareCode.TabIndex = 1;
            // 
            // Tbx_SoftwareName
            // 
            this.Tbx_SoftwareName.Location = new System.Drawing.Point(86, 71);
            this.Tbx_SoftwareName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tbx_SoftwareName.Name = "Tbx_SoftwareName";
            this.Tbx_SoftwareName.Size = new System.Drawing.Size(179, 23);
            this.Tbx_SoftwareName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "软件名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "添加时间：";
            // 
            // Dtp_AddDate
            // 
            this.Dtp_AddDate.Enabled = false;
            this.Dtp_AddDate.Location = new System.Drawing.Point(86, 115);
            this.Dtp_AddDate.Name = "Dtp_AddDate";
            this.Dtp_AddDate.Size = new System.Drawing.Size(179, 23);
            this.Dtp_AddDate.TabIndex = 3;
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(12, 169);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(75, 35);
            this.Btn_OK.TabIndex = 4;
            this.Btn_OK.Text = "确定";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(190, 169);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 35);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // SoftwareAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 226);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Dtp_AddDate);
            this.Controls.Add(this.Tbx_SoftwareName);
            this.Controls.Add(this.Tbx_SoftwareCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SoftwareAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "软件添加";
            this.Load += new System.EventHandler(this.SoftwareAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbx_SoftwareCode;
        private System.Windows.Forms.TextBox Tbx_SoftwareName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Dtp_AddDate;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}