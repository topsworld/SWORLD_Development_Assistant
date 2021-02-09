
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_FileMerge
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
            this.Lv_FileList = new System.Windows.Forms.ListView();
            this.LvCol_Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_FileAdd = new System.Windows.Forms.Button();
            this.Btn_FileRemove = new System.Windows.Forms.Button();
            this.Btn_FileMerge = new System.Windows.Forms.Button();
            this.Lab_FileMergeType = new System.Windows.Forms.Label();
            this.Cbx_FileMergeType = new System.Windows.Forms.ComboBox();
            this.Ofd_FileAdd = new System.Windows.Forms.OpenFileDialog();
            this.Sfd_MergePath = new System.Windows.Forms.SaveFileDialog();
            this.Lab_FileList = new System.Windows.Forms.Label();
            this.Btn_MoveUp = new System.Windows.Forms.Button();
            this.Btn_MoveDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lv_FileList
            // 
            this.Lv_FileList.AllowColumnReorder = true;
            this.Lv_FileList.AllowDrop = true;
            this.Lv_FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvCol_Num,
            this.LvCol_FileName,
            this.LvCol_FilePath,
            this.LvCol_FileType});
            this.Lv_FileList.FullRowSelect = true;
            this.Lv_FileList.HideSelection = false;
            this.Lv_FileList.LabelWrap = false;
            this.Lv_FileList.Location = new System.Drawing.Point(3, 20);
            this.Lv_FileList.Name = "Lv_FileList";
            this.Lv_FileList.ShowItemToolTips = true;
            this.Lv_FileList.Size = new System.Drawing.Size(470, 381);
            this.Lv_FileList.TabIndex = 0;
            this.Lv_FileList.UseCompatibleStateImageBehavior = false;
            this.Lv_FileList.View = System.Windows.Forms.View.Details;
            this.Lv_FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.Lv_FileList_DragDrop);
            this.Lv_FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.Lv_FileList_DragEnter);
            // 
            // LvCol_Num
            // 
            this.LvCol_Num.Text = "序号";
            this.LvCol_Num.Width = 40;
            // 
            // LvCol_FileName
            // 
            this.LvCol_FileName.Text = "文件名";
            this.LvCol_FileName.Width = 170;
            // 
            // LvCol_FilePath
            // 
            this.LvCol_FilePath.Text = "文件路径";
            this.LvCol_FilePath.Width = 170;
            // 
            // LvCol_FileType
            // 
            this.LvCol_FileType.Text = "文件类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 68);
            this.label1.TabIndex = 1;
            this.label1.Text = "先添加一个图片文件（jpg、png等），然后添加一个压缩文件（zip、\r\nrar、7z等），合并为对应格式的图片文件，就可以实现将压缩文件内\r\n嵌至图片文件，之后" +
    "需要访问压缩文件中内容，只需要将文件扩展名改\r\n为压缩文件的拓展名即可。\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_FileAdd
            // 
            this.Btn_FileAdd.Location = new System.Drawing.Point(3, 475);
            this.Btn_FileAdd.Name = "Btn_FileAdd";
            this.Btn_FileAdd.Size = new System.Drawing.Size(75, 30);
            this.Btn_FileAdd.TabIndex = 2;
            this.Btn_FileAdd.Text = "添加文件";
            this.Btn_FileAdd.UseVisualStyleBackColor = true;
            this.Btn_FileAdd.Click += new System.EventHandler(this.Btn_FileAdd_Click);
            // 
            // Btn_FileRemove
            // 
            this.Btn_FileRemove.Location = new System.Drawing.Point(84, 475);
            this.Btn_FileRemove.Name = "Btn_FileRemove";
            this.Btn_FileRemove.Size = new System.Drawing.Size(75, 30);
            this.Btn_FileRemove.TabIndex = 3;
            this.Btn_FileRemove.Text = "移除文件";
            this.Btn_FileRemove.UseVisualStyleBackColor = true;
            this.Btn_FileRemove.Click += new System.EventHandler(this.Btn_FileRemove_Click);
            // 
            // Btn_FileMerge
            // 
            this.Btn_FileMerge.Location = new System.Drawing.Point(398, 475);
            this.Btn_FileMerge.Name = "Btn_FileMerge";
            this.Btn_FileMerge.Size = new System.Drawing.Size(75, 30);
            this.Btn_FileMerge.TabIndex = 3;
            this.Btn_FileMerge.Text = "合并文件";
            this.Btn_FileMerge.UseVisualStyleBackColor = true;
            this.Btn_FileMerge.Click += new System.EventHandler(this.Btn_FileMerge_Click);
            // 
            // Lab_FileMergeType
            // 
            this.Lab_FileMergeType.AutoSize = true;
            this.Lab_FileMergeType.Location = new System.Drawing.Point(229, 482);
            this.Lab_FileMergeType.Name = "Lab_FileMergeType";
            this.Lab_FileMergeType.Size = new System.Drawing.Size(92, 17);
            this.Lab_FileMergeType.TabIndex = 4;
            this.Lab_FileMergeType.Text = "合并文件类型：";
            // 
            // Cbx_FileMergeType
            // 
            this.Cbx_FileMergeType.FormattingEnabled = true;
            this.Cbx_FileMergeType.Items.AddRange(new object[] {
            "jpg",
            "png",
            "txt",
            "mp4",
            "wav",
            "zip",
            "rar",
            "7z"});
            this.Cbx_FileMergeType.Location = new System.Drawing.Point(319, 478);
            this.Cbx_FileMergeType.Name = "Cbx_FileMergeType";
            this.Cbx_FileMergeType.Size = new System.Drawing.Size(73, 25);
            this.Cbx_FileMergeType.TabIndex = 5;
            // 
            // Ofd_FileAdd
            // 
            this.Ofd_FileAdd.Filter = "所有文件|*";
            this.Ofd_FileAdd.Title = "选择待合并文件";
            // 
            // Sfd_MergePath
            // 
            this.Sfd_MergePath.Title = "保存合并文件";
            // 
            // Lab_FileList
            // 
            this.Lab_FileList.AutoSize = true;
            this.Lab_FileList.Location = new System.Drawing.Point(3, 0);
            this.Lab_FileList.Name = "Lab_FileList";
            this.Lab_FileList.Size = new System.Drawing.Size(140, 17);
            this.Lab_FileList.TabIndex = 6;
            this.Lab_FileList.Text = "文件列表（支持拖拽）：";
            // 
            // Btn_MoveUp
            // 
            this.Btn_MoveUp.Location = new System.Drawing.Point(398, 407);
            this.Btn_MoveUp.Name = "Btn_MoveUp";
            this.Btn_MoveUp.Size = new System.Drawing.Size(75, 28);
            this.Btn_MoveUp.TabIndex = 7;
            this.Btn_MoveUp.Text = "上移";
            this.Btn_MoveUp.UseVisualStyleBackColor = true;
            this.Btn_MoveUp.Click += new System.EventHandler(this.Btn_MoveUp_Click);
            // 
            // Btn_MoveDown
            // 
            this.Btn_MoveDown.Location = new System.Drawing.Point(398, 441);
            this.Btn_MoveDown.Name = "Btn_MoveDown";
            this.Btn_MoveDown.Size = new System.Drawing.Size(75, 28);
            this.Btn_MoveDown.TabIndex = 8;
            this.Btn_MoveDown.Text = "下移";
            this.Btn_MoveDown.UseVisualStyleBackColor = true;
            this.Btn_MoveDown.Click += new System.EventHandler(this.Btn_MoveDown_Click);
            // 
            // UC_Tools_FileMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_MoveDown);
            this.Controls.Add(this.Btn_MoveUp);
            this.Controls.Add(this.Lab_FileList);
            this.Controls.Add(this.Cbx_FileMergeType);
            this.Controls.Add(this.Lab_FileMergeType);
            this.Controls.Add(this.Btn_FileMerge);
            this.Controls.Add(this.Btn_FileRemove);
            this.Controls.Add(this.Btn_FileAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lv_FileList);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_FileMerge";
            this.Size = new System.Drawing.Size(476, 508);
            this.Load += new System.EventHandler(this.UC_Tools_FileMerge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lv_FileList;
        private System.Windows.Forms.ColumnHeader LvCol_Num;
        private System.Windows.Forms.ColumnHeader LvCol_FilePath;
        private System.Windows.Forms.ColumnHeader LvCol_FileType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_FileAdd;
        private System.Windows.Forms.Button Btn_FileRemove;
        private System.Windows.Forms.Button Btn_FileMerge;
        private System.Windows.Forms.Label Lab_FileMergeType;
        private System.Windows.Forms.ComboBox Cbx_FileMergeType;
        private System.Windows.Forms.OpenFileDialog Ofd_FileAdd;
        private System.Windows.Forms.ColumnHeader LvCol_FileName;
        private System.Windows.Forms.SaveFileDialog Sfd_MergePath;
        private System.Windows.Forms.Label Lab_FileList;
        private System.Windows.Forms.Button Btn_MoveUp;
        private System.Windows.Forms.Button Btn_MoveDown;
    }
}
