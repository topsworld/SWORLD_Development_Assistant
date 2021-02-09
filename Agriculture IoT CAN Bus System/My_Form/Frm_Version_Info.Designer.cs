namespace Agriculture_IoT_CAN_Bus_System.My_Form
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
            this.Tbx_Version_Info = new System.Windows.Forms.TextBox();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Ckbx_Not_Show_Again = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Tbx_Version_Info
            // 
            this.Tbx_Version_Info.Location = new System.Drawing.Point(12, 12);
            this.Tbx_Version_Info.Multiline = true;
            this.Tbx_Version_Info.Name = "Tbx_Version_Info";
            this.Tbx_Version_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tbx_Version_Info.Size = new System.Drawing.Size(327, 326);
            this.Tbx_Version_Info.TabIndex = 0;
            this.Tbx_Version_Info.Text = "持续更新中。。。";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(269, 344);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(70, 34);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "确定(&O)";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Ckbx_Not_Show_Again
            // 
            this.Ckbx_Not_Show_Again.AutoSize = true;
            this.Ckbx_Not_Show_Again.Checked = true;
            this.Ckbx_Not_Show_Again.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ckbx_Not_Show_Again.Location = new System.Drawing.Point(12, 352);
            this.Ckbx_Not_Show_Again.Name = "Ckbx_Not_Show_Again";
            this.Ckbx_Not_Show_Again.Size = new System.Drawing.Size(75, 21);
            this.Ckbx_Not_Show_Again.TabIndex = 2;
            this.Ckbx_Not_Show_Again.Text = "不在提示";
            this.Ckbx_Not_Show_Again.UseVisualStyleBackColor = true;
            // 
            // Frm_Version_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 390);
            this.Controls.Add(this.Ckbx_Not_Show_Again);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Tbx_Version_Info);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Version_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "版本信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Version_Info_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Version_Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Version_Info;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.CheckBox Ckbx_Not_Show_Again;
    }
}