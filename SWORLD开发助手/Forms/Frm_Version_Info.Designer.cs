namespace SWORLD开发助手.Forms
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
            this.Rtbx_UpdateInfo = new System.Windows.Forms.RichTextBox();
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
            // Rtbx_UpdateInfo
            // 
            this.Rtbx_UpdateInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rtbx_UpdateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Rtbx_UpdateInfo.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Rtbx_UpdateInfo.Location = new System.Drawing.Point(12, 13);
            this.Rtbx_UpdateInfo.Name = "Rtbx_UpdateInfo";
            this.Rtbx_UpdateInfo.Size = new System.Drawing.Size(450, 388);
            this.Rtbx_UpdateInfo.TabIndex = 1;
            this.Rtbx_UpdateInfo.Text = "2021.01.25更新（V21.01.25）：\n1、下载助手支持STM32F1、F4系列MCU芯片下载；\n2、调试助手满足大部分串口调试需求；\n3、工具箱集成单" +
    "片机开发常用工具及软件，内容正在逐步完善，敬请期待；\n4、选型助手开发中，敬请期待；\n5、代码助手开发中，敬请期待。";
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
            this.Controls.Add(this.Rtbx_UpdateInfo);
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
        private System.Windows.Forms.RichTextBox Rtbx_UpdateInfo;
        private System.Windows.Forms.Button Btn_OK;
    }
}