using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD开发助手.ToolsOwn
{
    public partial class UC_Tools_FileMerge : UserControl
    {
        public UC_Tools_FileMerge()
        {
            InitializeComponent();
        }

        private void UC_Tools_FileMerge_Load(object sender, EventArgs e)
        {
            // 默认设置
            
        }

        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FileAdd_Click(object sender, EventArgs e)
        {
            if (Ofd_FileAdd.ShowDialog() == DialogResult.OK)
            {
                // 判断文件是否存在
                try
                {
                    if (Lv_FileList.Items.Count > 0
                        && Lv_FileList.Items.Cast<ListViewItem>()
                        .First(x => x.SubItems[2].Text == Ofd_FileAdd.FileName) != null)
                    {
                        MessageBox.Show("选择文件已在列表中，请重新选择其它文件！", "提示");
                        return;
                    }
                }
                catch { }

                ListViewItem _lvi = new ListViewItem();
                _lvi.Text = (Lv_FileList.Items.Count + 1).ToString();
                _lvi.SubItems.Add(Path.GetFileNameWithoutExtension(Ofd_FileAdd.FileName));
                _lvi.SubItems.Add(Ofd_FileAdd.FileName);
                _lvi.SubItems.Add(Path.GetExtension(Ofd_FileAdd.FileName).Replace(".",""));
                // _lvi.Tag = Ofd_FileAdd.FileName;
                Lv_FileList.Items.Add(_lvi);
            }

            
        }

        /// <summary>
        /// 移除文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FileRemove_Click(object sender, EventArgs e)
        {
            if (Lv_FileList.SelectedItems.Count > 0)
            {
                Lv_FileList.Items.Remove(Lv_FileList.SelectedItems[0]);
                // 重新排序
                foreach (ListViewItem _lvi in Lv_FileList.Items)
                {
                    _lvi.Text = (_lvi.Index + 1).ToString();
                }
            }

        }

        /// <summary>
        /// 合并文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_FileMerge_Click(object sender, EventArgs e)
        {
            if (Lv_FileList.Items.Count==0)
            {
                MessageBox.Show("请添加待合并文件后继续！","提示");
                return;
            }
            // 文件后缀
            if (Cbx_FileMergeType.Text.Trim() == "")
            {
                MessageBox.Show("请输入文件扩展名后继续！","提示");
                return;
            }
            // 获取合并文件列表
            string[] _strFileList =  Lv_FileList.Items.Cast<ListViewItem>().Select(a => a.SubItems[2].Text).ToArray();
            Sfd_MergePath.Filter = $"{Cbx_FileMergeType.Text}文件|*.{Cbx_FileMergeType.Text}";
            Sfd_MergePath.DefaultExt = Cbx_FileMergeType.Text;
            Sfd_MergePath.FileName = DateTime.Now.ToString("yyyyMMddhhmmss合并");
            if (Sfd_MergePath.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FileMerge.FileMerge.Merge(_strFileList,Sfd_MergePath.FileName),"提示");
            }

        }

        /// <summary>
        /// 文件拖拽
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_FileList_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> _lstr = new List<string>();
            foreach (string _str in filePaths)
            {
                // 判断文件是否存在
                ListViewItem _lvi_exsit;
                try
                {
                    _lvi_exsit = Lv_FileList.Items.Cast<ListViewItem>()
                    .First(x => x.SubItems[2].Text == _str);
                }
                catch
                {
                    _lvi_exsit = null;
                }
                if (Lv_FileList.Items.Count > 0
                    && _lvi_exsit != null)
                {
                    _lstr.Add(_str);
                }
                else
                {
                    ListViewItem _lvi = new ListViewItem();
                    _lvi.Text = (Lv_FileList.Items.Count + 1).ToString();
                    _lvi.SubItems.Add(Path.GetFileNameWithoutExtension(_str));
                    _lvi.SubItems.Add(_str);
                    _lvi.SubItems.Add(Path.GetExtension(_str).Replace(".", ""));
                    // _lvi.Tag = _str;
                    Lv_FileList.Items.Add(_lvi);
                }
            }
            // 提示未添加文件
            if (_lstr.Count > 0)
            {
                MessageBox.Show("以下文件未添加，所选文件已存在列表中）：\r\n"+string.Join("\r\n", _lstr.ToArray()),"提示");
            }
            // 默认选择第一项
            if (Lv_FileList.Items.Count == filePaths.Length)
                Lv_FileList.Items[0].Selected = true;
        }

        /// <summary>
        ///  鼠标修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lv_FileList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;//调用DragDrop事件
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        /// <summary>
        /// 上移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MoveUp_Click(object sender, EventArgs e)
        {
            if (Lv_FileList.SelectedItems.Count == 0||
                Lv_FileList.SelectedItems[0].Index==0)
                return;

            int _ist_index = Lv_FileList.SelectedItems[0].Index - 1;
            object _lvi = Lv_FileList.SelectedItems[0].Clone();
            Lv_FileList.Items.Insert(Lv_FileList.SelectedItems[0].Index - 1, _lvi as ListViewItem);
            Lv_FileList.Items.Remove(Lv_FileList.SelectedItems[0]);
            Lv_FileList.Items[_ist_index].Selected = true;

            // 重新排序
            foreach (ListViewItem _rlvi in Lv_FileList.Items)
            {
                _rlvi.Text = (_rlvi.Index + 1).ToString();
            }
        }
        /// <summary>
        /// 下移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_MoveDown_Click(object sender, EventArgs e)
        {
            if (Lv_FileList.SelectedItems.Count == 0 ||
                Lv_FileList.SelectedItems[0].Index == Lv_FileList.Items.Count-1)
                return;

            int _ist_index = Lv_FileList.SelectedItems[0].Index + 2;
            object _lvi = Lv_FileList.SelectedItems[0].Clone();
            Lv_FileList.Items.Insert(Lv_FileList.SelectedItems[0].Index + 2, _lvi as ListViewItem);
            Lv_FileList.Items.Remove(Lv_FileList.SelectedItems[0]);
            Lv_FileList.Items[_ist_index-1].Selected = true;

            // 重新排序
            foreach (ListViewItem _rlvi in Lv_FileList.Items)
            {
                _rlvi.Text = (_rlvi.Index + 1).ToString();
            }
        }
    }
}
