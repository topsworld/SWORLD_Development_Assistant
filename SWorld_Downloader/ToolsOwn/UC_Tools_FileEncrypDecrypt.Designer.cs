
namespace SWORLD开发助手.ToolsOwn
{
    partial class UC_Tools_FileEncrypDecrypt
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.Lv_Encrypt_File = new System.Windows.Forms.ListView();
            this.LvCol_Encrypt_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_Encrypt_FileStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc_FileEncryptiDecrypt = new System.Windows.Forms.TabControl();
            this.Tp_FileEncrypt = new System.Windows.Forms.TabPage();
            this.Lab_Encrypt_File = new System.Windows.Forms.Label();
            this.Pbar_Encrypt_AllProces = new System.Windows.Forms.ProgressBar();
            this.Tbx_Encrypt_Passwd = new System.Windows.Forms.TextBox();
            this.Lab_Encrypt_AllProces = new System.Windows.Forms.Label();
            this.Lab_Encrypt_Passwd = new System.Windows.Forms.Label();
            this.Cbx_Encrypt_DelSource = new System.Windows.Forms.CheckBox();
            this.Btn_Encrypt_All = new System.Windows.Forms.Button();
            this.Btn_Encrypt_DelSelect = new System.Windows.Forms.Button();
            this.Btn_Encrypt_Clear = new System.Windows.Forms.Button();
            this.Btn_Encrypt_MultipleAdd = new System.Windows.Forms.Button();
            this.Btn_Encrypt_FileAdd = new System.Windows.Forms.Button();
            this.Tp_Decrypt = new System.Windows.Forms.TabPage();
            this.Lab_Decrypt_File = new System.Windows.Forms.Label();
            this.Pbar_Decrypt_AllProces = new System.Windows.Forms.ProgressBar();
            this.Tbx_Decrypt_Passwd = new System.Windows.Forms.TextBox();
            this.Lab_Decrypt_AllProces = new System.Windows.Forms.Label();
            this.Lab_Decrypt_Passwd = new System.Windows.Forms.Label();
            this.Cbx_Decrypt_DelSource = new System.Windows.Forms.CheckBox();
            this.Btn_Decrypt_All = new System.Windows.Forms.Button();
            this.Btn_Decrypt_DelSelect = new System.Windows.Forms.Button();
            this.Btn_Decrypt_Clear = new System.Windows.Forms.Button();
            this.Btn_Decrypt_MultipleAdd = new System.Windows.Forms.Button();
            this.Btn_Decrypt_Add = new System.Windows.Forms.Button();
            this.Lv_Decrypt_File = new System.Windows.Forms.ListView();
            this.LvCol_Decrypt_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LvCol_Decrypt_FileStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tc_FileEncryptiDecrypt.SuspendLayout();
            this.Tp_FileEncrypt.SuspendLayout();
            this.Tp_Decrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lv_Encrypt_File
            // 
            this.Lv_Encrypt_File.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvCol_Encrypt_FileName,
            this.LvCol_Encrypt_FileStatus});
            this.Lv_Encrypt_File.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.Lv_Encrypt_File.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.Lv_Encrypt_File.Location = new System.Drawing.Point(6, 27);
            this.Lv_Encrypt_File.Name = "Lv_Encrypt_File";
            this.Lv_Encrypt_File.Size = new System.Drawing.Size(456, 373);
            this.Lv_Encrypt_File.TabIndex = 0;
            this.Lv_Encrypt_File.UseCompatibleStateImageBehavior = false;
            this.Lv_Encrypt_File.View = System.Windows.Forms.View.Details;
            // 
            // LvCol_Encrypt_FileName
            // 
            this.LvCol_Encrypt_FileName.Text = "文件";
            this.LvCol_Encrypt_FileName.Width = 370;
            // 
            // LvCol_Encrypt_FileStatus
            // 
            this.LvCol_Encrypt_FileStatus.Text = "状态";
            // 
            // Tc_FileEncryptiDecrypt
            // 
            this.Tc_FileEncryptiDecrypt.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tc_FileEncryptiDecrypt.Controls.Add(this.Tp_FileEncrypt);
            this.Tc_FileEncryptiDecrypt.Controls.Add(this.Tp_Decrypt);
            this.Tc_FileEncryptiDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tc_FileEncryptiDecrypt.ItemSize = new System.Drawing.Size(236, 22);
            this.Tc_FileEncryptiDecrypt.Location = new System.Drawing.Point(0, 0);
            this.Tc_FileEncryptiDecrypt.Name = "Tc_FileEncryptiDecrypt";
            this.Tc_FileEncryptiDecrypt.SelectedIndex = 0;
            this.Tc_FileEncryptiDecrypt.Size = new System.Drawing.Size(476, 508);
            this.Tc_FileEncryptiDecrypt.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Tc_FileEncryptiDecrypt.TabIndex = 3;
            // 
            // Tp_FileEncrypt
            // 
            this.Tp_FileEncrypt.Controls.Add(this.Lab_Encrypt_File);
            this.Tp_FileEncrypt.Controls.Add(this.Pbar_Encrypt_AllProces);
            this.Tp_FileEncrypt.Controls.Add(this.Tbx_Encrypt_Passwd);
            this.Tp_FileEncrypt.Controls.Add(this.Lab_Encrypt_AllProces);
            this.Tp_FileEncrypt.Controls.Add(this.Lab_Encrypt_Passwd);
            this.Tp_FileEncrypt.Controls.Add(this.Cbx_Encrypt_DelSource);
            this.Tp_FileEncrypt.Controls.Add(this.Btn_Encrypt_All);
            this.Tp_FileEncrypt.Controls.Add(this.Btn_Encrypt_DelSelect);
            this.Tp_FileEncrypt.Controls.Add(this.Btn_Encrypt_Clear);
            this.Tp_FileEncrypt.Controls.Add(this.Btn_Encrypt_MultipleAdd);
            this.Tp_FileEncrypt.Controls.Add(this.Btn_Encrypt_FileAdd);
            this.Tp_FileEncrypt.Controls.Add(this.Lv_Encrypt_File);
            this.Tp_FileEncrypt.Location = new System.Drawing.Point(4, 4);
            this.Tp_FileEncrypt.Name = "Tp_FileEncrypt";
            this.Tp_FileEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_FileEncrypt.Size = new System.Drawing.Size(468, 478);
            this.Tp_FileEncrypt.TabIndex = 0;
            this.Tp_FileEncrypt.Text = "加密";
            this.Tp_FileEncrypt.UseVisualStyleBackColor = true;
            // 
            // Lab_Encrypt_File
            // 
            this.Lab_Encrypt_File.AutoSize = true;
            this.Lab_Encrypt_File.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Encrypt_File.Location = new System.Drawing.Point(6, 3);
            this.Lab_Encrypt_File.Name = "Lab_Encrypt_File";
            this.Lab_Encrypt_File.Size = new System.Drawing.Size(90, 21);
            this.Lab_Encrypt_File.TabIndex = 7;
            this.Lab_Encrypt_File.Text = "加密文件：";
            // 
            // Pbar_Encrypt_AllProces
            // 
            this.Pbar_Encrypt_AllProces.Location = new System.Drawing.Point(218, 450);
            this.Pbar_Encrypt_AllProces.Name = "Pbar_Encrypt_AllProces";
            this.Pbar_Encrypt_AllProces.Size = new System.Drawing.Size(163, 15);
            this.Pbar_Encrypt_AllProces.TabIndex = 3;
            // 
            // Tbx_Encrypt_Passwd
            // 
            this.Tbx_Encrypt_Passwd.Location = new System.Drawing.Point(218, 410);
            this.Tbx_Encrypt_Passwd.Name = "Tbx_Encrypt_Passwd";
            this.Tbx_Encrypt_Passwd.PasswordChar = '*';
            this.Tbx_Encrypt_Passwd.Size = new System.Drawing.Size(112, 23);
            this.Tbx_Encrypt_Passwd.TabIndex = 6;
            // 
            // Lab_Encrypt_AllProces
            // 
            this.Lab_Encrypt_AllProces.AutoSize = true;
            this.Lab_Encrypt_AllProces.Location = new System.Drawing.Point(168, 448);
            this.Lab_Encrypt_AllProces.Name = "Lab_Encrypt_AllProces";
            this.Lab_Encrypt_AllProces.Size = new System.Drawing.Size(56, 17);
            this.Lab_Encrypt_AllProces.TabIndex = 5;
            this.Lab_Encrypt_AllProces.Text = "总进度：";
            // 
            // Lab_Encrypt_Passwd
            // 
            this.Lab_Encrypt_Passwd.AutoSize = true;
            this.Lab_Encrypt_Passwd.Location = new System.Drawing.Point(168, 413);
            this.Lab_Encrypt_Passwd.Name = "Lab_Encrypt_Passwd";
            this.Lab_Encrypt_Passwd.Size = new System.Drawing.Size(44, 17);
            this.Lab_Encrypt_Passwd.TabIndex = 5;
            this.Lab_Encrypt_Passwd.Text = "密码：";
            // 
            // Cbx_Encrypt_DelSource
            // 
            this.Cbx_Encrypt_DelSource.AutoSize = true;
            this.Cbx_Encrypt_DelSource.Location = new System.Drawing.Point(339, 411);
            this.Cbx_Encrypt_DelSource.Name = "Cbx_Encrypt_DelSource";
            this.Cbx_Encrypt_DelSource.Size = new System.Drawing.Size(123, 21);
            this.Cbx_Encrypt_DelSource.TabIndex = 2;
            this.Cbx_Encrypt_DelSource.Text = "加密后删除原文件";
            this.Cbx_Encrypt_DelSource.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt_All
            // 
            this.Btn_Encrypt_All.Location = new System.Drawing.Point(387, 442);
            this.Btn_Encrypt_All.Name = "Btn_Encrypt_All";
            this.Btn_Encrypt_All.Size = new System.Drawing.Size(75, 30);
            this.Btn_Encrypt_All.TabIndex = 1;
            this.Btn_Encrypt_All.Text = "加密全部";
            this.Btn_Encrypt_All.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt_DelSelect
            // 
            this.Btn_Encrypt_DelSelect.Location = new System.Drawing.Point(6, 442);
            this.Btn_Encrypt_DelSelect.Name = "Btn_Encrypt_DelSelect";
            this.Btn_Encrypt_DelSelect.Size = new System.Drawing.Size(75, 30);
            this.Btn_Encrypt_DelSelect.TabIndex = 1;
            this.Btn_Encrypt_DelSelect.Text = "删除所选";
            this.Btn_Encrypt_DelSelect.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt_Clear
            // 
            this.Btn_Encrypt_Clear.Location = new System.Drawing.Point(87, 442);
            this.Btn_Encrypt_Clear.Name = "Btn_Encrypt_Clear";
            this.Btn_Encrypt_Clear.Size = new System.Drawing.Size(75, 30);
            this.Btn_Encrypt_Clear.TabIndex = 1;
            this.Btn_Encrypt_Clear.Text = "清空列表";
            this.Btn_Encrypt_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt_MultipleAdd
            // 
            this.Btn_Encrypt_MultipleAdd.Location = new System.Drawing.Point(87, 406);
            this.Btn_Encrypt_MultipleAdd.Name = "Btn_Encrypt_MultipleAdd";
            this.Btn_Encrypt_MultipleAdd.Size = new System.Drawing.Size(75, 30);
            this.Btn_Encrypt_MultipleAdd.TabIndex = 1;
            this.Btn_Encrypt_MultipleAdd.Text = "批量导入";
            this.Btn_Encrypt_MultipleAdd.UseVisualStyleBackColor = true;
            // 
            // Btn_Encrypt_FileAdd
            // 
            this.Btn_Encrypt_FileAdd.Location = new System.Drawing.Point(6, 406);
            this.Btn_Encrypt_FileAdd.Name = "Btn_Encrypt_FileAdd";
            this.Btn_Encrypt_FileAdd.Size = new System.Drawing.Size(75, 30);
            this.Btn_Encrypt_FileAdd.TabIndex = 1;
            this.Btn_Encrypt_FileAdd.Text = "添加文件";
            this.Btn_Encrypt_FileAdd.UseVisualStyleBackColor = true;
            // 
            // Tp_Decrypt
            // 
            this.Tp_Decrypt.Controls.Add(this.Lab_Decrypt_File);
            this.Tp_Decrypt.Controls.Add(this.Pbar_Decrypt_AllProces);
            this.Tp_Decrypt.Controls.Add(this.Tbx_Decrypt_Passwd);
            this.Tp_Decrypt.Controls.Add(this.Lab_Decrypt_AllProces);
            this.Tp_Decrypt.Controls.Add(this.Lab_Decrypt_Passwd);
            this.Tp_Decrypt.Controls.Add(this.Cbx_Decrypt_DelSource);
            this.Tp_Decrypt.Controls.Add(this.Btn_Decrypt_All);
            this.Tp_Decrypt.Controls.Add(this.Btn_Decrypt_DelSelect);
            this.Tp_Decrypt.Controls.Add(this.Btn_Decrypt_Clear);
            this.Tp_Decrypt.Controls.Add(this.Btn_Decrypt_MultipleAdd);
            this.Tp_Decrypt.Controls.Add(this.Btn_Decrypt_Add);
            this.Tp_Decrypt.Controls.Add(this.Lv_Decrypt_File);
            this.Tp_Decrypt.Location = new System.Drawing.Point(4, 4);
            this.Tp_Decrypt.Name = "Tp_Decrypt";
            this.Tp_Decrypt.Padding = new System.Windows.Forms.Padding(3);
            this.Tp_Decrypt.Size = new System.Drawing.Size(468, 478);
            this.Tp_Decrypt.TabIndex = 1;
            this.Tp_Decrypt.Text = "解密";
            this.Tp_Decrypt.UseVisualStyleBackColor = true;
            // 
            // Lab_Decrypt_File
            // 
            this.Lab_Decrypt_File.AutoSize = true;
            this.Lab_Decrypt_File.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lab_Decrypt_File.Location = new System.Drawing.Point(6, 3);
            this.Lab_Decrypt_File.Name = "Lab_Decrypt_File";
            this.Lab_Decrypt_File.Size = new System.Drawing.Size(90, 21);
            this.Lab_Decrypt_File.TabIndex = 18;
            this.Lab_Decrypt_File.Text = "解密文件：";
            // 
            // Pbar_Decrypt_AllProces
            // 
            this.Pbar_Decrypt_AllProces.Location = new System.Drawing.Point(218, 450);
            this.Pbar_Decrypt_AllProces.Name = "Pbar_Decrypt_AllProces";
            this.Pbar_Decrypt_AllProces.Size = new System.Drawing.Size(163, 15);
            this.Pbar_Decrypt_AllProces.TabIndex = 14;
            // 
            // Tbx_Decrypt_Passwd
            // 
            this.Tbx_Decrypt_Passwd.Location = new System.Drawing.Point(218, 410);
            this.Tbx_Decrypt_Passwd.Name = "Tbx_Decrypt_Passwd";
            this.Tbx_Decrypt_Passwd.PasswordChar = '*';
            this.Tbx_Decrypt_Passwd.Size = new System.Drawing.Size(112, 23);
            this.Tbx_Decrypt_Passwd.TabIndex = 17;
            // 
            // Lab_Decrypt_AllProces
            // 
            this.Lab_Decrypt_AllProces.AutoSize = true;
            this.Lab_Decrypt_AllProces.Location = new System.Drawing.Point(168, 448);
            this.Lab_Decrypt_AllProces.Name = "Lab_Decrypt_AllProces";
            this.Lab_Decrypt_AllProces.Size = new System.Drawing.Size(56, 17);
            this.Lab_Decrypt_AllProces.TabIndex = 15;
            this.Lab_Decrypt_AllProces.Text = "总进度：";
            // 
            // Lab_Decrypt_Passwd
            // 
            this.Lab_Decrypt_Passwd.AutoSize = true;
            this.Lab_Decrypt_Passwd.Location = new System.Drawing.Point(168, 413);
            this.Lab_Decrypt_Passwd.Name = "Lab_Decrypt_Passwd";
            this.Lab_Decrypt_Passwd.Size = new System.Drawing.Size(44, 17);
            this.Lab_Decrypt_Passwd.TabIndex = 16;
            this.Lab_Decrypt_Passwd.Text = "密码：";
            // 
            // Cbx_Decrypt_DelSource
            // 
            this.Cbx_Decrypt_DelSource.AutoSize = true;
            this.Cbx_Decrypt_DelSource.Location = new System.Drawing.Point(339, 411);
            this.Cbx_Decrypt_DelSource.Name = "Cbx_Decrypt_DelSource";
            this.Cbx_Decrypt_DelSource.Size = new System.Drawing.Size(123, 21);
            this.Cbx_Decrypt_DelSource.TabIndex = 13;
            this.Cbx_Decrypt_DelSource.Text = "解密后删除原文件";
            this.Cbx_Decrypt_DelSource.UseVisualStyleBackColor = true;
            // 
            // Btn_Decrypt_All
            // 
            this.Btn_Decrypt_All.Location = new System.Drawing.Point(387, 442);
            this.Btn_Decrypt_All.Name = "Btn_Decrypt_All";
            this.Btn_Decrypt_All.Size = new System.Drawing.Size(75, 30);
            this.Btn_Decrypt_All.TabIndex = 8;
            this.Btn_Decrypt_All.Text = "解密全部";
            this.Btn_Decrypt_All.UseVisualStyleBackColor = true;
            // 
            // Btn_Decrypt_DelSelect
            // 
            this.Btn_Decrypt_DelSelect.Location = new System.Drawing.Point(6, 442);
            this.Btn_Decrypt_DelSelect.Name = "Btn_Decrypt_DelSelect";
            this.Btn_Decrypt_DelSelect.Size = new System.Drawing.Size(75, 30);
            this.Btn_Decrypt_DelSelect.TabIndex = 9;
            this.Btn_Decrypt_DelSelect.Text = "删除所选";
            this.Btn_Decrypt_DelSelect.UseVisualStyleBackColor = true;
            // 
            // Btn_Decrypt_Clear
            // 
            this.Btn_Decrypt_Clear.Location = new System.Drawing.Point(87, 442);
            this.Btn_Decrypt_Clear.Name = "Btn_Decrypt_Clear";
            this.Btn_Decrypt_Clear.Size = new System.Drawing.Size(75, 30);
            this.Btn_Decrypt_Clear.TabIndex = 10;
            this.Btn_Decrypt_Clear.Text = "清空列表";
            this.Btn_Decrypt_Clear.UseVisualStyleBackColor = true;
            // 
            // Btn_Decrypt_MultipleAdd
            // 
            this.Btn_Decrypt_MultipleAdd.Location = new System.Drawing.Point(87, 406);
            this.Btn_Decrypt_MultipleAdd.Name = "Btn_Decrypt_MultipleAdd";
            this.Btn_Decrypt_MultipleAdd.Size = new System.Drawing.Size(75, 30);
            this.Btn_Decrypt_MultipleAdd.TabIndex = 11;
            this.Btn_Decrypt_MultipleAdd.Text = "批量导入";
            this.Btn_Decrypt_MultipleAdd.UseVisualStyleBackColor = true;
            // 
            // Btn_Decrypt_Add
            // 
            this.Btn_Decrypt_Add.Location = new System.Drawing.Point(6, 406);
            this.Btn_Decrypt_Add.Name = "Btn_Decrypt_Add";
            this.Btn_Decrypt_Add.Size = new System.Drawing.Size(75, 30);
            this.Btn_Decrypt_Add.TabIndex = 12;
            this.Btn_Decrypt_Add.Text = "添加文件";
            this.Btn_Decrypt_Add.UseVisualStyleBackColor = true;
            // 
            // Lv_Decrypt_File
            // 
            this.Lv_Decrypt_File.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LvCol_Decrypt_FileName,
            this.LvCol_Decrypt_FileStatus});
            this.Lv_Decrypt_File.HideSelection = false;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            this.Lv_Decrypt_File.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.Lv_Decrypt_File.Location = new System.Drawing.Point(6, 27);
            this.Lv_Decrypt_File.Name = "Lv_Decrypt_File";
            this.Lv_Decrypt_File.Size = new System.Drawing.Size(456, 373);
            this.Lv_Decrypt_File.TabIndex = 7;
            this.Lv_Decrypt_File.UseCompatibleStateImageBehavior = false;
            this.Lv_Decrypt_File.View = System.Windows.Forms.View.Details;
            // 
            // LvCol_Decrypt_FileName
            // 
            this.LvCol_Decrypt_FileName.Text = "文件";
            this.LvCol_Decrypt_FileName.Width = 370;
            // 
            // LvCol_Decrypt_FileStatus
            // 
            this.LvCol_Decrypt_FileStatus.Text = "状态";
            // 
            // UC_Tools_FileEncrypDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Tc_FileEncryptiDecrypt);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(476, 508);
            this.MinimumSize = new System.Drawing.Size(476, 508);
            this.Name = "UC_Tools_FileEncrypDecrypt";
            this.Size = new System.Drawing.Size(476, 508);
            this.Load += new System.EventHandler(this.UC_Tools_FileEncryptionDecrypt_Load);
            this.Tc_FileEncryptiDecrypt.ResumeLayout(false);
            this.Tp_FileEncrypt.ResumeLayout(false);
            this.Tp_FileEncrypt.PerformLayout();
            this.Tp_Decrypt.ResumeLayout(false);
            this.Tp_Decrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Encrypt_File;
        private System.Windows.Forms.ColumnHeader LvCol_Encrypt_FileName;
        private System.Windows.Forms.ColumnHeader LvCol_Encrypt_FileStatus;
        private System.Windows.Forms.TabControl Tc_FileEncryptiDecrypt;
        private System.Windows.Forms.TabPage Tp_FileEncrypt;
        private System.Windows.Forms.CheckBox Cbx_Encrypt_DelSource;
        private System.Windows.Forms.Button Btn_Encrypt_Clear;
        private System.Windows.Forms.Button Btn_Encrypt_MultipleAdd;
        private System.Windows.Forms.Button Btn_Encrypt_FileAdd;
        private System.Windows.Forms.TabPage Tp_Decrypt;
        private System.Windows.Forms.ProgressBar Pbar_Encrypt_AllProces;
        private System.Windows.Forms.TextBox Tbx_Encrypt_Passwd;
        private System.Windows.Forms.Label Lab_Encrypt_AllProces;
        private System.Windows.Forms.Label Lab_Encrypt_Passwd;
        private System.Windows.Forms.Button Btn_Encrypt_All;
        private System.Windows.Forms.Button Btn_Encrypt_DelSelect;
        private System.Windows.Forms.Label Lab_Encrypt_File;
        private System.Windows.Forms.Label Lab_Decrypt_File;
        private System.Windows.Forms.ProgressBar Pbar_Decrypt_AllProces;
        private System.Windows.Forms.TextBox Tbx_Decrypt_Passwd;
        private System.Windows.Forms.Label Lab_Decrypt_AllProces;
        private System.Windows.Forms.Label Lab_Decrypt_Passwd;
        private System.Windows.Forms.CheckBox Cbx_Decrypt_DelSource;
        private System.Windows.Forms.Button Btn_Decrypt_All;
        private System.Windows.Forms.Button Btn_Decrypt_DelSelect;
        private System.Windows.Forms.Button Btn_Decrypt_Clear;
        private System.Windows.Forms.Button Btn_Decrypt_MultipleAdd;
        private System.Windows.Forms.Button Btn_Decrypt_Add;
        private System.Windows.Forms.ListView Lv_Decrypt_File;
        private System.Windows.Forms.ColumnHeader LvCol_Decrypt_FileName;
        private System.Windows.Forms.ColumnHeader LvCol_Decrypt_FileStatus;
    }
}
