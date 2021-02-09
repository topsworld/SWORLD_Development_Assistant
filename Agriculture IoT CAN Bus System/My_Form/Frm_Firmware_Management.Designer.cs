namespace Agriculture_IoT_CAN_Bus_System.My_Form
{
    partial class Frm_Firmware_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Firmware_Management));
            this.Lv_Type = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Type_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Type_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lv_Group = new System.Windows.Forms.ListView();
            this.col_id2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Group_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Group_Name_CN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Sensor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Type_Add = new System.Windows.Forms.Button();
            this.Btn_Type_Update = new System.Windows.Forms.Button();
            this.Btn_Type_Del = new System.Windows.Forms.Button();
            this.Btn_Group_Del = new System.Windows.Forms.Button();
            this.Btn_Group_Update = new System.Windows.Forms.Button();
            this.Btn_Group_Add = new System.Windows.Forms.Button();
            this.Btn_Version_Del = new System.Windows.Forms.Button();
            this.Btn_Version_Update = new System.Windows.Forms.Button();
            this.Btn_Version_Add = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Lv_Version = new System.Windows.Forms.ListView();
            this.col_id3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Stat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Btn_Fresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lv_Type
            // 
            this.Lv_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_Type.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_Type_ID,
            this.col_Type_Name});
            this.Lv_Type.FullRowSelect = true;
            this.Lv_Type.HideSelection = false;
            this.Lv_Type.Location = new System.Drawing.Point(3, 43);
            this.Lv_Type.MultiSelect = false;
            this.Lv_Type.Name = "Lv_Type";
            this.Lv_Type.Size = new System.Drawing.Size(309, 210);
            this.Lv_Type.TabIndex = 0;
            this.Lv_Type.UseCompatibleStateImageBehavior = false;
            this.Lv_Type.View = System.Windows.Forms.View.Details;
            this.Lv_Type.SelectedIndexChanged += new System.EventHandler(this.Lv_Type_SelectedIndexChanged);
            this.Lv_Type.DoubleClick += new System.EventHandler(this.Lv_Type_DoubleClick);
            // 
            // col_id
            // 
            this.col_id.Text = "序号";
            this.col_id.Width = 50;
            // 
            // col_Type_ID
            // 
            this.col_Type_ID.Text = "类型编码";
            // 
            // col_Type_Name
            // 
            this.col_Type_Name.Text = "类型名称";
            this.col_Type_Name.Width = 180;
            // 
            // Lv_Group
            // 
            this.Lv_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_Group.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id2,
            this.col_Group_ID,
            this.col_Group_Name_CN,
            this.col_Sensor});
            this.Lv_Group.FullRowSelect = true;
            this.Lv_Group.HideSelection = false;
            this.Lv_Group.Location = new System.Drawing.Point(3, 295);
            this.Lv_Group.MultiSelect = false;
            this.Lv_Group.Name = "Lv_Group";
            this.Lv_Group.Size = new System.Drawing.Size(309, 293);
            this.Lv_Group.TabIndex = 1;
            this.Lv_Group.UseCompatibleStateImageBehavior = false;
            this.Lv_Group.View = System.Windows.Forms.View.Details;
            this.Lv_Group.SelectedIndexChanged += new System.EventHandler(this.Lv_Group_SelectedIndexChanged);
            this.Lv_Group.DoubleClick += new System.EventHandler(this.Lv_Group_DoubleClick);
            // 
            // col_id2
            // 
            this.col_id2.Text = "序号";
            this.col_id2.Width = 50;
            // 
            // col_Group_ID
            // 
            this.col_Group_ID.Text = "固件编码";
            // 
            // col_Group_Name_CN
            // 
            this.col_Group_Name_CN.Text = "固件名称";
            this.col_Group_Name_CN.Width = 120;
            // 
            // col_Sensor
            // 
            this.col_Sensor.Text = "传感器";
            // 
            // Btn_Type_Add
            // 
            this.Btn_Type_Add.Location = new System.Drawing.Point(3, 7);
            this.Btn_Type_Add.Name = "Btn_Type_Add";
            this.Btn_Type_Add.Size = new System.Drawing.Size(70, 30);
            this.Btn_Type_Add.TabIndex = 16;
            this.Btn_Type_Add.Text = "增加";
            this.Btn_Type_Add.UseVisualStyleBackColor = true;
            this.Btn_Type_Add.Click += new System.EventHandler(this.Btn_Type_Add_Click);
            // 
            // Btn_Type_Update
            // 
            this.Btn_Type_Update.Location = new System.Drawing.Point(79, 7);
            this.Btn_Type_Update.Name = "Btn_Type_Update";
            this.Btn_Type_Update.Size = new System.Drawing.Size(70, 30);
            this.Btn_Type_Update.TabIndex = 17;
            this.Btn_Type_Update.Text = "修改";
            this.Btn_Type_Update.UseVisualStyleBackColor = true;
            this.Btn_Type_Update.Click += new System.EventHandler(this.Btn_Type_Update_Click);
            // 
            // Btn_Type_Del
            // 
            this.Btn_Type_Del.Location = new System.Drawing.Point(155, 7);
            this.Btn_Type_Del.Name = "Btn_Type_Del";
            this.Btn_Type_Del.Size = new System.Drawing.Size(70, 30);
            this.Btn_Type_Del.TabIndex = 18;
            this.Btn_Type_Del.Text = "删除";
            this.Btn_Type_Del.UseVisualStyleBackColor = true;
            this.Btn_Type_Del.Click += new System.EventHandler(this.Btn_Type_Del_Click);
            // 
            // Btn_Group_Del
            // 
            this.Btn_Group_Del.Location = new System.Drawing.Point(155, 259);
            this.Btn_Group_Del.Name = "Btn_Group_Del";
            this.Btn_Group_Del.Size = new System.Drawing.Size(70, 30);
            this.Btn_Group_Del.TabIndex = 21;
            this.Btn_Group_Del.Text = "删除";
            this.Btn_Group_Del.UseVisualStyleBackColor = true;
            this.Btn_Group_Del.Click += new System.EventHandler(this.Btn_Group_Del_Click);
            // 
            // Btn_Group_Update
            // 
            this.Btn_Group_Update.Location = new System.Drawing.Point(79, 259);
            this.Btn_Group_Update.Name = "Btn_Group_Update";
            this.Btn_Group_Update.Size = new System.Drawing.Size(70, 30);
            this.Btn_Group_Update.TabIndex = 20;
            this.Btn_Group_Update.Text = "修改";
            this.Btn_Group_Update.UseVisualStyleBackColor = true;
            this.Btn_Group_Update.Click += new System.EventHandler(this.Btn_Group_Update_Click);
            // 
            // Btn_Group_Add
            // 
            this.Btn_Group_Add.Location = new System.Drawing.Point(3, 259);
            this.Btn_Group_Add.Name = "Btn_Group_Add";
            this.Btn_Group_Add.Size = new System.Drawing.Size(70, 30);
            this.Btn_Group_Add.TabIndex = 19;
            this.Btn_Group_Add.Text = "增加";
            this.Btn_Group_Add.UseVisualStyleBackColor = true;
            this.Btn_Group_Add.Click += new System.EventHandler(this.Btn_Group_Add_Click);
            // 
            // Btn_Version_Del
            // 
            this.Btn_Version_Del.Location = new System.Drawing.Point(155, 7);
            this.Btn_Version_Del.Name = "Btn_Version_Del";
            this.Btn_Version_Del.Size = new System.Drawing.Size(70, 30);
            this.Btn_Version_Del.TabIndex = 24;
            this.Btn_Version_Del.Text = "删除";
            this.Btn_Version_Del.UseVisualStyleBackColor = true;
            this.Btn_Version_Del.Click += new System.EventHandler(this.Btn_Version_Del_Click);
            // 
            // Btn_Version_Update
            // 
            this.Btn_Version_Update.Location = new System.Drawing.Point(79, 7);
            this.Btn_Version_Update.Name = "Btn_Version_Update";
            this.Btn_Version_Update.Size = new System.Drawing.Size(70, 30);
            this.Btn_Version_Update.TabIndex = 23;
            this.Btn_Version_Update.Text = "修改";
            this.Btn_Version_Update.UseVisualStyleBackColor = true;
            this.Btn_Version_Update.Click += new System.EventHandler(this.Btn_Version_Update_Click);
            // 
            // Btn_Version_Add
            // 
            this.Btn_Version_Add.Location = new System.Drawing.Point(3, 7);
            this.Btn_Version_Add.Name = "Btn_Version_Add";
            this.Btn_Version_Add.Size = new System.Drawing.Size(70, 30);
            this.Btn_Version_Add.TabIndex = 22;
            this.Btn_Version_Add.Text = "增加";
            this.Btn_Version_Add.UseVisualStyleBackColor = true;
            this.Btn_Version_Add.Click += new System.EventHandler(this.Btn_Version_Add_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Type_Add);
            this.splitContainer1.Panel1.Controls.Add(this.Lv_Type);
            this.splitContainer1.Panel1.Controls.Add(this.Lv_Group);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Type_Update);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Group_Del);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Type_Del);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Group_Update);
            this.splitContainer1.Panel1.Controls.Add(this.Btn_Group_Add);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Fresh);
            this.splitContainer1.Panel2.Controls.Add(this.Lv_Version);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Version_Add);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Version_Del);
            this.splitContainer1.Panel2.Controls.Add(this.Btn_Version_Update);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(926, 591);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 25;
            // 
            // Lv_Version
            // 
            this.Lv_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lv_Version.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id3,
            this.col_Version,
            this.group_ID,
            this.group_Name,
            this.col_Size,
            this.col_Time,
            this.col_Stat});
            this.Lv_Version.FullRowSelect = true;
            this.Lv_Version.HideSelection = false;
            this.Lv_Version.Location = new System.Drawing.Point(3, 43);
            this.Lv_Version.MultiSelect = false;
            this.Lv_Version.Name = "Lv_Version";
            this.Lv_Version.Size = new System.Drawing.Size(601, 545);
            this.Lv_Version.TabIndex = 25;
            this.Lv_Version.UseCompatibleStateImageBehavior = false;
            this.Lv_Version.View = System.Windows.Forms.View.Details;
            this.Lv_Version.DoubleClick += new System.EventHandler(this.Lv_Version_DoubleClick);
            // 
            // col_id3
            // 
            this.col_id3.Text = "序号";
            this.col_id3.Width = 50;
            // 
            // col_Version
            // 
            this.col_Version.Text = "版本号";
            this.col_Version.Width = 90;
            // 
            // group_ID
            // 
            this.group_ID.Text = "固件编码";
            // 
            // group_Name
            // 
            this.group_Name.Text = "固件名称";
            this.group_Name.Width = 160;
            // 
            // col_Size
            // 
            this.col_Size.Text = "固件大小";
            this.col_Size.Width = 70;
            // 
            // col_Time
            // 
            this.col_Time.Text = "固件更新时间";
            this.col_Time.Width = 90;
            // 
            // col_Stat
            // 
            this.col_Stat.Text = "状态";
            // 
            // Btn_Fresh
            // 
            this.Btn_Fresh.Location = new System.Drawing.Point(545, 7);
            this.Btn_Fresh.Name = "Btn_Fresh";
            this.Btn_Fresh.Size = new System.Drawing.Size(59, 30);
            this.Btn_Fresh.TabIndex = 26;
            this.Btn_Fresh.Text = "刷新";
            this.Btn_Fresh.UseVisualStyleBackColor = true;
            this.Btn_Fresh.Click += new System.EventHandler(this.Btn_Fresh_Click);
            // 
            // Frm_Firmware_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 591);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Firmware_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "固件管理";
            this.Load += new System.EventHandler(this.Frm_Firmware_Management_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Type;
        private System.Windows.Forms.ListView Lv_Group;
        private System.Windows.Forms.Button Btn_Type_Add;
        private System.Windows.Forms.Button Btn_Type_Update;
        private System.Windows.Forms.Button Btn_Type_Del;
        private System.Windows.Forms.Button Btn_Group_Del;
        private System.Windows.Forms.Button Btn_Group_Update;
        private System.Windows.Forms.Button Btn_Group_Add;
        private System.Windows.Forms.Button Btn_Version_Del;
        private System.Windows.Forms.Button Btn_Version_Update;
        private System.Windows.Forms.Button Btn_Version_Add;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_Type_ID;
        private System.Windows.Forms.ColumnHeader col_Type_Name;
        private System.Windows.Forms.ColumnHeader col_id2;
        private System.Windows.Forms.ColumnHeader col_Group_ID;
        private System.Windows.Forms.ColumnHeader col_Group_Name_CN;
        private System.Windows.Forms.ColumnHeader col_Sensor;
        private System.Windows.Forms.ListView Lv_Version;
        private System.Windows.Forms.ColumnHeader col_id3;
        private System.Windows.Forms.ColumnHeader col_Version;
        private System.Windows.Forms.ColumnHeader group_ID;
        private System.Windows.Forms.ColumnHeader group_Name;
        private System.Windows.Forms.ColumnHeader col_Size;
        private System.Windows.Forms.ColumnHeader col_Time;
        private System.Windows.Forms.ColumnHeader col_Stat;
        private System.Windows.Forms.Button Btn_Fresh;
    }
}