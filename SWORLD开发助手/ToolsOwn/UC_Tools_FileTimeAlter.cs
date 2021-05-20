using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD开发助手.ToolsOwn
{
    public partial class UC_Tools_FileTimeAlter : UserControl
    {
        public UC_Tools_FileTimeAlter()
        {
            InitializeComponent();
        }
        FileTimeAlter.FileTimeAlter _ftaSelect;
        FileInfo _fiSelect;
        private void UC_Tools_FileTimeAlter_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 选择文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SelectFile_Click(object sender, EventArgs e)
        {
            if (Tbx_SelectFile.Text.Trim() == "")
                Ofd_FileSelect.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            else
                Ofd_FileSelect.InitialDirectory = Tbx_SelectFile.Text;
            if (Ofd_FileSelect.ShowDialog() == DialogResult.OK)
            {
                Tbx_SelectFile.Text = Ofd_FileSelect.FileName;
                // 获取文件信息
                _ftaSelect = new FileTimeAlter.FileTimeAlter(Ofd_FileSelect.FileName);
                _fiSelect = _ftaSelect.GetDetail();
                Pbx_FileIcon.Image = FileTimeAlter.FileTimeAlter.GetFileIcon(Ofd_FileSelect.FileName).ToBitmap();
                Tbx_FileName.Text = _fiSelect.Name;
                Tbx_FileType.Text = _fiSelect.Extension.Replace(".", "");
                Tbx_FilePath.Text = _fiSelect.DirectoryName;
                Tbx_FileSize.Text = $"{_fiSelect.Length.ToString()}字节";
                // 获取文件所有者
                var fs = File.GetAccessControl(Ofd_FileSelect.FileName);
                var sid = fs.GetOwner(typeof(SecurityIdentifier));
                var ntAccount = sid.Translate(typeof(NTAccount));
                Tbx_FileOwner.Text = ntAccount.ToString();
                Tbx_OldCreateTime.Text = _fiSelect.CreationTime.ToString("yyyy-MM-dd HH:mm:ss dddd");
                Tbx_OldUpdateTime.Text = _fiSelect.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss dddd");
                Tbx_OldViewTime.Text = _fiSelect.LastAccessTime.ToString("yyyy-MM-dd HH:mm:ss dddd");
                Dtp_NewCreateTime.Value = _fiSelect.CreationTime;
                Dtp_NewUpdateTime.Value = _fiSelect.LastWriteTime;
                Dtp_NewViewTime.Value = _fiSelect.LastAccessTime;
            }
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FileAlter_Click(object sender, EventArgs e)
        {
            if (_fiSelect == null)
            {
                MessageBox.Show("请选择文件后继续！","提示");
                return;
            }
            // 修改时间
            if (_ftaSelect.AlterInfo(Dtp_NewCreateTime.Value, Dtp_NewUpdateTime.Value, Dtp_NewViewTime.Value))
                MessageBox.Show("时间修改成功！", "提示");
            else 
                MessageBox.Show("时间修改失败！", "提示");
        }

    }
}
