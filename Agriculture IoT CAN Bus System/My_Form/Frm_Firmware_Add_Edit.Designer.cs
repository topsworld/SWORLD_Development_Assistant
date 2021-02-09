namespace Agriculture_IoT_CAN_Bus_System.My_Form
{
    partial class Frm_Firmware_Add_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Firmware_Add_Edit));
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Select = new System.Windows.Forms.Button();
            this.Tbx_Type_Info = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbx_Group_Info = new System.Windows.Forms.TextBox();
            this.Tbx_File_Path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tbx_Time = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tbx_Size = new System.Windows.Forms.TextBox();
            this.Tbx_Version = new System.Windows.Forms.TextBox();
            this.Tbx_MD5 = new System.Windows.Forms.TextBox();
            this.Tbx_SHA1 = new System.Windows.Forms.TextBox();
            this.Ofd_File = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(335, 267);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(70, 30);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "取消(&C)";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(259, 267);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(70, 30);
            this.Btn_OK.TabIndex = 7;
            this.Btn_OK.Text = "添加(&A)";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "固件信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "类型信息：";
            // 
            // Btn_Select
            // 
            this.Btn_Select.Location = new System.Drawing.Point(348, 116);
            this.Btn_Select.Name = "Btn_Select";
            this.Btn_Select.Size = new System.Drawing.Size(57, 30);
            this.Btn_Select.TabIndex = 11;
            this.Btn_Select.Text = "选择";
            this.Btn_Select.UseVisualStyleBackColor = true;
            this.Btn_Select.Click += new System.EventHandler(this.Btn_Select_Click);
            // 
            // Tbx_Type_Info
            // 
            this.Tbx_Type_Info.Location = new System.Drawing.Point(86, 15);
            this.Tbx_Type_Info.Name = "Tbx_Type_Info";
            this.Tbx_Type_Info.ReadOnly = true;
            this.Tbx_Type_Info.Size = new System.Drawing.Size(319, 23);
            this.Tbx_Type_Info.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "文件目录：";
            // 
            // Tbx_Group_Info
            // 
            this.Tbx_Group_Info.Location = new System.Drawing.Point(86, 50);
            this.Tbx_Group_Info.Name = "Tbx_Group_Info";
            this.Tbx_Group_Info.ReadOnly = true;
            this.Tbx_Group_Info.Size = new System.Drawing.Size(319, 23);
            this.Tbx_Group_Info.TabIndex = 14;
            // 
            // Tbx_File_Path
            // 
            this.Tbx_File_Path.Location = new System.Drawing.Point(86, 85);
            this.Tbx_File_Path.Name = "Tbx_File_Path";
            this.Tbx_File_Path.ReadOnly = true;
            this.Tbx_File_Path.Size = new System.Drawing.Size(319, 23);
            this.Tbx_File_Path.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "固件大小：";
            // 
            // Tbx_Time
            // 
            this.Tbx_Time.Location = new System.Drawing.Point(86, 120);
            this.Tbx_Time.Name = "Tbx_Time";
            this.Tbx_Time.ReadOnly = true;
            this.Tbx_Time.Size = new System.Drawing.Size(85, 23);
            this.Tbx_Time.TabIndex = 17;
            this.Tbx_Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "更新时间：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "版本号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "MD5值：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "SHA1值：";
            // 
            // Tbx_Size
            // 
            this.Tbx_Size.Location = new System.Drawing.Point(257, 120);
            this.Tbx_Size.Name = "Tbx_Size";
            this.Tbx_Size.ReadOnly = true;
            this.Tbx_Size.Size = new System.Drawing.Size(85, 23);
            this.Tbx_Size.TabIndex = 22;
            this.Tbx_Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_Version
            // 
            this.Tbx_Version.Location = new System.Drawing.Point(86, 155);
            this.Tbx_Version.Name = "Tbx_Version";
            this.Tbx_Version.Size = new System.Drawing.Size(319, 23);
            this.Tbx_Version.TabIndex = 23;
            // 
            // Tbx_MD5
            // 
            this.Tbx_MD5.Location = new System.Drawing.Point(86, 190);
            this.Tbx_MD5.Name = "Tbx_MD5";
            this.Tbx_MD5.ReadOnly = true;
            this.Tbx_MD5.Size = new System.Drawing.Size(319, 23);
            this.Tbx_MD5.TabIndex = 24;
            this.Tbx_MD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tbx_SHA1
            // 
            this.Tbx_SHA1.Location = new System.Drawing.Point(86, 225);
            this.Tbx_SHA1.Name = "Tbx_SHA1";
            this.Tbx_SHA1.ReadOnly = true;
            this.Tbx_SHA1.Size = new System.Drawing.Size(319, 23);
            this.Tbx_SHA1.TabIndex = 25;
            this.Tbx_SHA1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ofd_File
            // 
            this.Ofd_File.Filter = "HEX文件|*.hex|BIN文件|*.bin";
            this.Ofd_File.Title = "选择固件版本文件";
            // 
            // Frm_Firmware_Add_Edit
            // 
            this.AcceptButton = this.Btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(417, 309);
            this.Controls.Add(this.Tbx_SHA1);
            this.Controls.Add(this.Tbx_MD5);
            this.Controls.Add(this.Tbx_Version);
            this.Controls.Add(this.Tbx_Size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tbx_Time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tbx_File_Path);
            this.Controls.Add(this.Tbx_Group_Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tbx_Type_Info);
            this.Controls.Add(this.Btn_Select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_OK);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Firmware_Add_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加版本";
            this.Load += new System.EventHandler(this.Frm_Firmware_Add_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Select;
        private System.Windows.Forms.TextBox Tbx_Type_Info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tbx_Group_Info;
        private System.Windows.Forms.TextBox Tbx_File_Path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tbx_Time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tbx_Size;
        private System.Windows.Forms.TextBox Tbx_Version;
        private System.Windows.Forms.TextBox Tbx_MD5;
        private System.Windows.Forms.TextBox Tbx_SHA1;
        private System.Windows.Forms.OpenFileDialog Ofd_File;
    }
}