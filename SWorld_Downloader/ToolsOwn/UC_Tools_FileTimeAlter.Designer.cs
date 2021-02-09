
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_FileTimeAlter
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
            this.Lab_SelectFile = new System.Windows.Forms.Label();
            this.Tbx_SelectFile = new System.Windows.Forms.TextBox();
            this.Btn_SelectFile = new System.Windows.Forms.Button();
            this.Lab_OldCreateTime = new System.Windows.Forms.Label();
            this.Lab_OldUpdateTime = new System.Windows.Forms.Label();
            this.Lab_OldViewTime = new System.Windows.Forms.Label();
            this.Lab_FileSize = new System.Windows.Forms.Label();
            this.Lab_FileName = new System.Windows.Forms.Label();
            this.Lab_FileType = new System.Windows.Forms.Label();
            this.Lab_FileOwner = new System.Windows.Forms.Label();
            this.Lab_FilePath = new System.Windows.Forms.Label();
            this.Pbx_FileIcon = new System.Windows.Forms.PictureBox();
            this.Tbx_FileName = new System.Windows.Forms.TextBox();
            this.Tbx_FileType = new System.Windows.Forms.TextBox();
            this.Tbx_FileSize = new System.Windows.Forms.TextBox();
            this.Tbx_OldUpdateTime = new System.Windows.Forms.TextBox();
            this.Tbx_OldViewTime = new System.Windows.Forms.TextBox();
            this.Tbx_FilePath = new System.Windows.Forms.TextBox();
            this.Tbx_FileOwner = new System.Windows.Forms.TextBox();
            this.Dtp_NewCreateTime = new System.Windows.Forms.DateTimePicker();
            this.Tbx_OldCreateTime = new System.Windows.Forms.TextBox();
            this.Lab_NewCreateTime = new System.Windows.Forms.Label();
            this.Lab_NewUpdateTime = new System.Windows.Forms.Label();
            this.Dtp_NewUpdateTime = new System.Windows.Forms.DateTimePicker();
            this.Lab_NewViewTime = new System.Windows.Forms.Label();
            this.Dtp_NewViewTime = new System.Windows.Forms.DateTimePicker();
            this.Btn_FileAlter = new System.Windows.Forms.Button();
            this.Ofd_FileSelect = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_FileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Lab_SelectFile
            // 
            this.Lab_SelectFile.AutoSize = true;
            this.Lab_SelectFile.Location = new System.Drawing.Point(3, 0);
            this.Lab_SelectFile.Name = "Lab_SelectFile";
            this.Lab_SelectFile.Size = new System.Drawing.Size(68, 17);
            this.Lab_SelectFile.TabIndex = 0;
            this.Lab_SelectFile.Text = "选择文件：";
            // 
            // Tbx_SelectFile
            // 
            this.Tbx_SelectFile.Location = new System.Drawing.Point(3, 20);
            this.Tbx_SelectFile.Name = "Tbx_SelectFile";
            this.Tbx_SelectFile.ReadOnly = true;
            this.Tbx_SelectFile.Size = new System.Drawing.Size(389, 23);
            this.Tbx_SelectFile.TabIndex = 1;
            // 
            // Btn_SelectFile
            // 
            this.Btn_SelectFile.Location = new System.Drawing.Point(398, 17);
            this.Btn_SelectFile.Name = "Btn_SelectFile";
            this.Btn_SelectFile.Size = new System.Drawing.Size(75, 28);
            this.Btn_SelectFile.TabIndex = 2;
            this.Btn_SelectFile.Text = "选择文件";
            this.Btn_SelectFile.UseVisualStyleBackColor = true;
            this.Btn_SelectFile.Click += new System.EventHandler(this.Btn_SelectFile_Click);
            // 
            // Lab_OldCreateTime
            // 
            this.Lab_OldCreateTime.AutoSize = true;
            this.Lab_OldCreateTime.Location = new System.Drawing.Point(3, 265);
            this.Lab_OldCreateTime.Name = "Lab_OldCreateTime";
            this.Lab_OldCreateTime.Size = new System.Drawing.Size(68, 17);
            this.Lab_OldCreateTime.TabIndex = 0;
            this.Lab_OldCreateTime.Text = "创建时间：";
            // 
            // Lab_OldUpdateTime
            // 
            this.Lab_OldUpdateTime.AutoSize = true;
            this.Lab_OldUpdateTime.Location = new System.Drawing.Point(3, 331);
            this.Lab_OldUpdateTime.Name = "Lab_OldUpdateTime";
            this.Lab_OldUpdateTime.Size = new System.Drawing.Size(68, 17);
            this.Lab_OldUpdateTime.TabIndex = 0;
            this.Lab_OldUpdateTime.Text = "修改时间：";
            // 
            // Lab_OldViewTime
            // 
            this.Lab_OldViewTime.AutoSize = true;
            this.Lab_OldViewTime.Location = new System.Drawing.Point(3, 397);
            this.Lab_OldViewTime.Name = "Lab_OldViewTime";
            this.Lab_OldViewTime.Size = new System.Drawing.Size(68, 17);
            this.Lab_OldViewTime.TabIndex = 0;
            this.Lab_OldViewTime.Text = "访问时间：";
            // 
            // Lab_FileSize
            // 
            this.Lab_FileSize.AutoSize = true;
            this.Lab_FileSize.Location = new System.Drawing.Point(3, 199);
            this.Lab_FileSize.Name = "Lab_FileSize";
            this.Lab_FileSize.Size = new System.Drawing.Size(68, 17);
            this.Lab_FileSize.TabIndex = 0;
            this.Lab_FileSize.Text = "文件大小：";
            // 
            // Lab_FileName
            // 
            this.Lab_FileName.AutoSize = true;
            this.Lab_FileName.Location = new System.Drawing.Point(51, 59);
            this.Lab_FileName.Name = "Lab_FileName";
            this.Lab_FileName.Size = new System.Drawing.Size(68, 17);
            this.Lab_FileName.TabIndex = 0;
            this.Lab_FileName.Text = "文件名称：";
            // 
            // Lab_FileType
            // 
            this.Lab_FileType.AutoSize = true;
            this.Lab_FileType.Location = new System.Drawing.Point(3, 133);
            this.Lab_FileType.Name = "Lab_FileType";
            this.Lab_FileType.Size = new System.Drawing.Size(68, 17);
            this.Lab_FileType.TabIndex = 0;
            this.Lab_FileType.Text = "文件类型：";
            // 
            // Lab_FileOwner
            // 
            this.Lab_FileOwner.AutoSize = true;
            this.Lab_FileOwner.Location = new System.Drawing.Point(240, 199);
            this.Lab_FileOwner.Name = "Lab_FileOwner";
            this.Lab_FileOwner.Size = new System.Drawing.Size(56, 17);
            this.Lab_FileOwner.TabIndex = 0;
            this.Lab_FileOwner.Text = "所有者：";
            // 
            // Lab_FilePath
            // 
            this.Lab_FilePath.AutoSize = true;
            this.Lab_FilePath.Location = new System.Drawing.Point(240, 133);
            this.Lab_FilePath.Name = "Lab_FilePath";
            this.Lab_FilePath.Size = new System.Drawing.Size(80, 17);
            this.Lab_FilePath.TabIndex = 0;
            this.Lab_FilePath.Text = "文件夹路径：";
            // 
            // Pbx_FileIcon
            // 
            this.Pbx_FileIcon.Image = global::SWORLD开发助手.Properties.Resources.SWORLD;
            this.Pbx_FileIcon.Location = new System.Drawing.Point(3, 60);
            this.Pbx_FileIcon.Name = "Pbx_FileIcon";
            this.Pbx_FileIcon.Size = new System.Drawing.Size(42, 42);
            this.Pbx_FileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pbx_FileIcon.TabIndex = 3;
            this.Pbx_FileIcon.TabStop = false;
            // 
            // Tbx_FileName
            // 
            this.Tbx_FileName.Location = new System.Drawing.Point(51, 79);
            this.Tbx_FileName.Name = "Tbx_FileName";
            this.Tbx_FileName.ReadOnly = true;
            this.Tbx_FileName.Size = new System.Drawing.Size(422, 23);
            this.Tbx_FileName.TabIndex = 1;
            // 
            // Tbx_FileType
            // 
            this.Tbx_FileType.Location = new System.Drawing.Point(3, 153);
            this.Tbx_FileType.Name = "Tbx_FileType";
            this.Tbx_FileType.ReadOnly = true;
            this.Tbx_FileType.Size = new System.Drawing.Size(230, 23);
            this.Tbx_FileType.TabIndex = 1;
            // 
            // Tbx_FileSize
            // 
            this.Tbx_FileSize.Location = new System.Drawing.Point(3, 219);
            this.Tbx_FileSize.Name = "Tbx_FileSize";
            this.Tbx_FileSize.ReadOnly = true;
            this.Tbx_FileSize.Size = new System.Drawing.Size(230, 23);
            this.Tbx_FileSize.TabIndex = 1;
            // 
            // Tbx_OldUpdateTime
            // 
            this.Tbx_OldUpdateTime.Location = new System.Drawing.Point(3, 351);
            this.Tbx_OldUpdateTime.Name = "Tbx_OldUpdateTime";
            this.Tbx_OldUpdateTime.ReadOnly = true;
            this.Tbx_OldUpdateTime.Size = new System.Drawing.Size(230, 23);
            this.Tbx_OldUpdateTime.TabIndex = 1;
            // 
            // Tbx_OldViewTime
            // 
            this.Tbx_OldViewTime.Location = new System.Drawing.Point(3, 417);
            this.Tbx_OldViewTime.Name = "Tbx_OldViewTime";
            this.Tbx_OldViewTime.ReadOnly = true;
            this.Tbx_OldViewTime.Size = new System.Drawing.Size(230, 23);
            this.Tbx_OldViewTime.TabIndex = 1;
            // 
            // Tbx_FilePath
            // 
            this.Tbx_FilePath.Location = new System.Drawing.Point(243, 153);
            this.Tbx_FilePath.Name = "Tbx_FilePath";
            this.Tbx_FilePath.ReadOnly = true;
            this.Tbx_FilePath.Size = new System.Drawing.Size(230, 23);
            this.Tbx_FilePath.TabIndex = 1;
            // 
            // Tbx_FileOwner
            // 
            this.Tbx_FileOwner.Location = new System.Drawing.Point(243, 219);
            this.Tbx_FileOwner.Name = "Tbx_FileOwner";
            this.Tbx_FileOwner.ReadOnly = true;
            this.Tbx_FileOwner.Size = new System.Drawing.Size(230, 23);
            this.Tbx_FileOwner.TabIndex = 1;
            // 
            // Dtp_NewCreateTime
            // 
            this.Dtp_NewCreateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss dddd";
            this.Dtp_NewCreateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_NewCreateTime.Location = new System.Drawing.Point(243, 285);
            this.Dtp_NewCreateTime.Name = "Dtp_NewCreateTime";
            this.Dtp_NewCreateTime.Size = new System.Drawing.Size(230, 23);
            this.Dtp_NewCreateTime.TabIndex = 5;
            // 
            // Tbx_OldCreateTime
            // 
            this.Tbx_OldCreateTime.Location = new System.Drawing.Point(3, 285);
            this.Tbx_OldCreateTime.Name = "Tbx_OldCreateTime";
            this.Tbx_OldCreateTime.ReadOnly = true;
            this.Tbx_OldCreateTime.Size = new System.Drawing.Size(230, 23);
            this.Tbx_OldCreateTime.TabIndex = 1;
            // 
            // Lab_NewCreateTime
            // 
            this.Lab_NewCreateTime.AutoSize = true;
            this.Lab_NewCreateTime.Location = new System.Drawing.Point(240, 265);
            this.Lab_NewCreateTime.Name = "Lab_NewCreateTime";
            this.Lab_NewCreateTime.Size = new System.Drawing.Size(68, 17);
            this.Lab_NewCreateTime.TabIndex = 0;
            this.Lab_NewCreateTime.Text = "创建时间：";
            // 
            // Lab_NewUpdateTime
            // 
            this.Lab_NewUpdateTime.AutoSize = true;
            this.Lab_NewUpdateTime.Location = new System.Drawing.Point(240, 331);
            this.Lab_NewUpdateTime.Name = "Lab_NewUpdateTime";
            this.Lab_NewUpdateTime.Size = new System.Drawing.Size(68, 17);
            this.Lab_NewUpdateTime.TabIndex = 0;
            this.Lab_NewUpdateTime.Text = "修改时间：";
            // 
            // Dtp_NewUpdateTime
            // 
            this.Dtp_NewUpdateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss dddd";
            this.Dtp_NewUpdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_NewUpdateTime.Location = new System.Drawing.Point(243, 351);
            this.Dtp_NewUpdateTime.Name = "Dtp_NewUpdateTime";
            this.Dtp_NewUpdateTime.Size = new System.Drawing.Size(230, 23);
            this.Dtp_NewUpdateTime.TabIndex = 5;
            // 
            // Lab_NewViewTime
            // 
            this.Lab_NewViewTime.AutoSize = true;
            this.Lab_NewViewTime.Location = new System.Drawing.Point(240, 397);
            this.Lab_NewViewTime.Name = "Lab_NewViewTime";
            this.Lab_NewViewTime.Size = new System.Drawing.Size(68, 17);
            this.Lab_NewViewTime.TabIndex = 0;
            this.Lab_NewViewTime.Text = "访问时间：";
            // 
            // Dtp_NewViewTime
            // 
            this.Dtp_NewViewTime.CustomFormat = "yyyy-MM-dd HH:mm:ss dddd";
            this.Dtp_NewViewTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_NewViewTime.Location = new System.Drawing.Point(243, 417);
            this.Dtp_NewViewTime.Name = "Dtp_NewViewTime";
            this.Dtp_NewViewTime.Size = new System.Drawing.Size(230, 23);
            this.Dtp_NewViewTime.TabIndex = 5;
            // 
            // Btn_FileAlter
            // 
            this.Btn_FileAlter.Location = new System.Drawing.Point(398, 463);
            this.Btn_FileAlter.Name = "Btn_FileAlter";
            this.Btn_FileAlter.Size = new System.Drawing.Size(75, 32);
            this.Btn_FileAlter.TabIndex = 2;
            this.Btn_FileAlter.Text = "修改时间";
            this.Btn_FileAlter.UseVisualStyleBackColor = true;
            this.Btn_FileAlter.Click += new System.EventHandler(this.Btn_FileAlter_Click);
            // 
            // Ofd_FileSelect
            // 
            this.Ofd_FileSelect.Filter = "所有类型|*.*";
            this.Ofd_FileSelect.Title = "选择修改文件";
            // 
            // UC_Tools_FileTimeAlter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tbx_OldViewTime);
            this.Controls.Add(this.Tbx_FileOwner);
            this.Controls.Add(this.Tbx_OldUpdateTime);
            this.Controls.Add(this.Lab_NewCreateTime);
            this.Controls.Add(this.Tbx_OldCreateTime);
            this.Controls.Add(this.Lab_OldCreateTime);
            this.Controls.Add(this.Lab_OldUpdateTime);
            this.Controls.Add(this.Tbx_FileSize);
            this.Controls.Add(this.Lab_OldViewTime);
            this.Controls.Add(this.Dtp_NewViewTime);
            this.Controls.Add(this.Tbx_FileType);
            this.Controls.Add(this.Tbx_FilePath);
            this.Controls.Add(this.Tbx_FileName);
            this.Controls.Add(this.Lab_FileName);
            this.Controls.Add(this.Dtp_NewUpdateTime);
            this.Controls.Add(this.Pbx_FileIcon);
            this.Controls.Add(this.Dtp_NewCreateTime);
            this.Controls.Add(this.Lab_NewUpdateTime);
            this.Controls.Add(this.Lab_FilePath);
            this.Controls.Add(this.Lab_FileType);
            this.Controls.Add(this.Btn_FileAlter);
            this.Controls.Add(this.Btn_SelectFile);
            this.Controls.Add(this.Lab_NewViewTime);
            this.Controls.Add(this.Tbx_SelectFile);
            this.Controls.Add(this.Lab_SelectFile);
            this.Controls.Add(this.Lab_FileSize);
            this.Controls.Add(this.Lab_FileOwner);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_FileTimeAlter";
            this.Size = new System.Drawing.Size(476, 508);
            this.Load += new System.EventHandler(this.UC_Tools_FileTimeAlter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_FileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_SelectFile;
        private System.Windows.Forms.TextBox Tbx_SelectFile;
        private System.Windows.Forms.Button Btn_SelectFile;
        private System.Windows.Forms.Label Lab_OldCreateTime;
        private System.Windows.Forms.Label Lab_OldUpdateTime;
        private System.Windows.Forms.Label Lab_OldViewTime;
        private System.Windows.Forms.Label Lab_FileSize;
        private System.Windows.Forms.Label Lab_FileName;
        private System.Windows.Forms.Label Lab_FileType;
        private System.Windows.Forms.Label Lab_FileOwner;
        private System.Windows.Forms.Label Lab_FilePath;
        private System.Windows.Forms.PictureBox Pbx_FileIcon;
        private System.Windows.Forms.TextBox Tbx_FileOwner;
        private System.Windows.Forms.TextBox Tbx_FilePath;
        private System.Windows.Forms.TextBox Tbx_OldViewTime;
        private System.Windows.Forms.TextBox Tbx_OldUpdateTime;
        private System.Windows.Forms.TextBox Tbx_OldCreateTime;
        private System.Windows.Forms.TextBox Tbx_FileSize;
        private System.Windows.Forms.TextBox Tbx_FileType;
        private System.Windows.Forms.TextBox Tbx_FileName;
        private System.Windows.Forms.DateTimePicker Dtp_NewCreateTime;
        private System.Windows.Forms.Label Lab_NewCreateTime;
        private System.Windows.Forms.Label Lab_NewUpdateTime;
        private System.Windows.Forms.DateTimePicker Dtp_NewUpdateTime;
        private System.Windows.Forms.Label Lab_NewViewTime;
        private System.Windows.Forms.DateTimePicker Dtp_NewViewTime;
        private System.Windows.Forms.Button Btn_FileAlter;
        private System.Windows.Forms.OpenFileDialog Ofd_FileSelect;
    }
}
