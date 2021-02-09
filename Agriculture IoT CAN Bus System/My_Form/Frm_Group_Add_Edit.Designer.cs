namespace Agriculture_IoT_CAN_Bus_System.My_Form
{
    partial class Frm_Group_Add_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Group_Add_Edit));
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tbx_Group_ID = new System.Windows.Forms.TextBox();
            this.Tbx_Group_Name = new System.Windows.Forms.TextBox();
            this.Tbx_Group_Name_CN = new System.Windows.Forms.TextBox();
            this.Tbx_Group_Sensor = new System.Windows.Forms.TextBox();
            this.Tbx_Type_Info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancel.Location = new System.Drawing.Point(257, 200);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(70, 30);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "取消(&C)";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(181, 200);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(70, 30);
            this.Btn_OK.TabIndex = 5;
            this.Btn_OK.Text = "添加(&A)";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "类型信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "固件编码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "固件名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "传感器型号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "固件中文名：";
            // 
            // Tbx_Group_ID
            // 
            this.Tbx_Group_ID.Location = new System.Drawing.Point(86, 53);
            this.Tbx_Group_ID.Name = "Tbx_Group_ID";
            this.Tbx_Group_ID.Size = new System.Drawing.Size(241, 23);
            this.Tbx_Group_ID.TabIndex = 1;
            // 
            // Tbx_Group_Name
            // 
            this.Tbx_Group_Name.Location = new System.Drawing.Point(86, 88);
            this.Tbx_Group_Name.Name = "Tbx_Group_Name";
            this.Tbx_Group_Name.Size = new System.Drawing.Size(241, 23);
            this.Tbx_Group_Name.TabIndex = 2;
            // 
            // Tbx_Group_Name_CN
            // 
            this.Tbx_Group_Name_CN.Location = new System.Drawing.Point(86, 123);
            this.Tbx_Group_Name_CN.Name = "Tbx_Group_Name_CN";
            this.Tbx_Group_Name_CN.Size = new System.Drawing.Size(241, 23);
            this.Tbx_Group_Name_CN.TabIndex = 3;
            // 
            // Tbx_Group_Sensor
            // 
            this.Tbx_Group_Sensor.Location = new System.Drawing.Point(86, 158);
            this.Tbx_Group_Sensor.Name = "Tbx_Group_Sensor";
            this.Tbx_Group_Sensor.Size = new System.Drawing.Size(241, 23);
            this.Tbx_Group_Sensor.TabIndex = 4;
            // 
            // Tbx_Type_Info
            // 
            this.Tbx_Type_Info.Enabled = false;
            this.Tbx_Type_Info.Location = new System.Drawing.Point(86, 16);
            this.Tbx_Type_Info.Name = "Tbx_Type_Info";
            this.Tbx_Type_Info.Size = new System.Drawing.Size(241, 23);
            this.Tbx_Type_Info.TabIndex = 0;
            // 
            // Frm_Group_Add_Edit
            // 
            this.AcceptButton = this.Btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancel;
            this.ClientSize = new System.Drawing.Size(339, 242);
            this.Controls.Add(this.Tbx_Type_Info);
            this.Controls.Add(this.Tbx_Group_Sensor);
            this.Controls.Add(this.Tbx_Group_Name_CN);
            this.Controls.Add(this.Tbx_Group_Name);
            this.Controls.Add(this.Tbx_Group_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
            this.Name = "Frm_Group_Add_Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加固件";
            this.Load += new System.EventHandler(this.Frm_Group_Add_Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tbx_Group_ID;
        private System.Windows.Forms.TextBox Tbx_Group_Name;
        private System.Windows.Forms.TextBox Tbx_Group_Name_CN;
        private System.Windows.Forms.TextBox Tbx_Group_Sensor;
        private System.Windows.Forms.TextBox Tbx_Type_Info;
    }
}