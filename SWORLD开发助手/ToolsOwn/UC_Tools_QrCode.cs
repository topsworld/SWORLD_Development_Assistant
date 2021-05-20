using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWORLD开发助手.ToolsOwn
{
    public partial class UC_Tools_QrCode : UserControl
    {
        public UC_Tools_QrCode()
        {
            InitializeComponent();
        }

        Bitmap _bitmap_QrCode ;
        Bitmap _bitmap_BarCode;

        private void UC_Tools_QrCode_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Logo选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SelectLogoPath_Click(object sender, EventArgs e)
        {
            if (Tbx_LogoPath.Text.Trim() != "")
                Ofd_LogoSelect.InitialDirectory = Tbx_LogoPath.Text;
            else
                Ofd_LogoSelect.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Ofd_LogoSelect.ShowDialog() == DialogResult.OK)
            {
                Tbx_LogoPath.Text = Ofd_LogoSelect.FileName;
            }
        }
        /// <summary>
        /// 生死二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_GenQrCode_Click(object sender, EventArgs e)
        {
            if (Tbx_GenContent.Text.Trim() == "")
            {
                MessageBox.Show("请输入文字内容后继续！","提示");
                return;
            }
            // 生成模式 0~3
            int _genModel = 0;
            if (Rbtn_VersionWithLogo.Checked)
                _genModel += 1;
            if (Rbtn_ColorCustom.Checked)
                _genModel += 2;
            
            switch (_genModel)
            {
                case 0:// 正常
                    _bitmap_QrCode = QrCode.QrCode.GenNormal(Tbx_GenContent.Text,(int)Nud_CodeSize.Value,(int)Nud_MarginSize.Value);
                    break;
                case 1:// 带Logo
                    if (Tbx_LogoPath.Text.Trim() == "")
                    {
                        MessageBox.Show("请选择Logo后继续！","提示");
                        return;
                    }
                    _bitmap_QrCode = QrCode.QrCode.GenWithLogo(Tbx_GenContent.Text,Tbx_LogoPath.Text, (int)Nud_CodeSize.Value, (int)Nud_MarginSize.Value,
                        Color.White,Color.Black);
                    break;
                case 2:// 颜色自定义
                    _bitmap_QrCode = QrCode.QrCode.GenColorCustom(Tbx_GenContent.Text, (int)Nud_CodeSize.Value,Pal_ColorBack.BackColor,Pal_ColorFront.BackColor);
                    break;
                case 3:// 带Logo 颜色自定义
                    _bitmap_QrCode = QrCode.QrCode.GenWithLogo(Tbx_GenContent.Text, Tbx_LogoPath.Text, (int)Nud_CodeSize.Value, (int)Nud_MarginSize.Value,
                        Pal_ColorBack.BackColor, Pal_ColorFront.BackColor);
                    break;
            }
            if (_bitmap_QrCode != null)
            {
                Pbx_Preview.Image = Image.FromHbitmap(_bitmap_QrCode.GetHbitmap());
            }
        }
        /// <summary>
        /// 保存二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_SaveQrCode_Click(object sender, EventArgs e)
        {
            if (Sfd_QrCodeSave.InitialDirectory.Trim() == "")
                Sfd_QrCodeSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Sfd_QrCodeSave.FileName = DateTime.Now.ToString("yyyyMMddhhmmss二维码");
            if (Sfd_QrCodeSave.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(Sfd_QrCodeSave.FileName).Replace(".",""))
                {
                    case "jpg":
                        _bitmap_QrCode.Save(Sfd_QrCodeSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "png":
                        _bitmap_QrCode.Save(Sfd_QrCodeSave.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "bmp":
                        _bitmap_QrCode.Save(Sfd_QrCodeSave.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        return;
                }
                if (MessageBox.Show($"二维码保存成功，是否打开？\r\n保存路径：{Sfd_QrCodeSave.FileName}"
                    ,"提示",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Sfd_QrCodeSave.FileName);
                }
            }
        }
        /// <summary>
        /// 解析二维码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_QrCodeParse_Click(object sender, EventArgs e)
        {
            if(Ofd_QrCodeParse.InitialDirectory.Trim()=="")
                Ofd_QrCodeParse.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Ofd_QrCodeParse.ShowDialog() == DialogResult.OK)
            {
                if (Tc_QrorBarCode.SelectedIndex == 0)
                    Pbx_Preview.ImageLocation = Ofd_QrCodeParse.FileName;
                else
                    Pbx_Bar_Preview.ImageLocation = Ofd_QrCodeParse.FileName;
                Tbx_ParseResult.Text = QrCode.QrCode.ReadQrCode(Ofd_QrCodeParse.FileName);
                if (Tbx_ParseResult.Text.Trim() == "")
                {
                    MessageBox.Show("解析失败，无二维码及条形码数据，请重试！","提示");
                }
            }
        }

        /// <summary>
        /// 版本选择，是否带Logo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rbtn_VersionNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_VersionNormal.Checked)
                VersionStatus(0);
            else
                VersionStatus(1);
        }
        /// <summary>
        /// 颜色选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rbtn_ColorNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_ColorNormal.Checked)
                ColorStatus(0);
            else
                ColorStatus(1);
        }
        
        /// <summary>
        /// 版本状态
        /// 0：正常
        /// 1：带Logo
        /// </summary>
        /// <param name="statu"></param>
        public void VersionStatus(int status)
        {
            switch (status)
            {
                case 0:// 正常
                    Lab_LogoPath.Enabled = false;
                    Tbx_LogoPath.Enabled = false;
                    Btn_SelectLogoPath.Enabled = false;
                    break;
                case 1:// 带Logo
                    Lab_LogoPath.Enabled = true;
                    Tbx_LogoPath.Enabled = true;
                    Btn_SelectLogoPath.Enabled = true;
                    break;
            }
        }

        // 前景色
        Color _colorFont = Color.Black;
        // 背景色
        Color _colorBack = Color.White;

        /// <summary>
        /// 颜色选择
        /// </summary>
        /// <param name="status"></param>
        public void ColorStatus(int status)
        {
            switch (status)
            {
                case 0:// 黑白
                    Lab_ColorFront.Enabled = false;
                    Lab_ColorBack.Enabled = false;
                    Pal_ColorFront.BackColor = Color.Black;
                    Pal_ColorBack.BackColor = Color.White;
                    break;
                case 1:// 自定义
                    Lab_ColorFront.Enabled = true;
                    Lab_ColorBack.Enabled = true;
                    Pal_ColorFront.BackColor = _colorFont;
                    Pal_ColorBack.BackColor = _colorBack;
                    break;
            }
        }

        /// <summary>
        /// 前景色选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pal_ColorFront_Click(object sender, EventArgs e)
        {
            if (!Rbtn_ColorCustom.Checked)
                return;
            ColorDialog _cd = new ColorDialog();
            _cd.Color = _colorFont;
            if (_cd.ShowDialog() == DialogResult.OK)
            {
                _colorFont = _cd.Color;
                Pal_ColorFront.BackColor = _colorFont;
            }
        }

        /// <summary>
        /// 背景色选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pal_ColorBack_Click(object sender, EventArgs e)
        {
            if (!Rbtn_ColorCustom.Checked)
                return;
            ColorDialog _cd = new ColorDialog();
            _cd.Color = _colorBack;
            if (_cd.ShowDialog() == DialogResult.OK)
            {
                _colorBack = _cd.Color;
                Pal_ColorBack.BackColor = _colorBack;
            }
        }

        #region 条形码相关
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Bar_Gen_Click(object sender, EventArgs e)
        {
            if (Tbx_Bar_Content.Text.Trim() == "")
            {
                MessageBox.Show("请输入文字内容后继续！", "提示");
                return;
            }
            _bitmap_BarCode = QrCode.QrCode.GenBarCode(Tbx_Bar_Content.Text, (int)Nud_Bar_SizeLength.Value
                , (int)Nud_Bar_SizeWidth.Value, (int)Nud_Bar_Margin.Value);
            if (_bitmap_BarCode != null)
            {
                Pbx_Bar_Preview.Image = Image.FromHbitmap(_bitmap_BarCode.GetHbitmap());
            }
        }
        /// <summary>
        /// 保存条形码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Bar_Save_Click(object sender, EventArgs e)
        {
            if(Sfd_QrCodeSave.InitialDirectory.Trim()=="")
                Sfd_QrCodeSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Sfd_QrCodeSave.FileName = DateTime.Now.ToString("yyyyMMddhhmmss条形码");
            if (Sfd_QrCodeSave.ShowDialog() == DialogResult.OK)
            {
                switch (Path.GetExtension(Sfd_QrCodeSave.FileName).Replace(".", ""))
                {
                    case "jpg":
                        _bitmap_QrCode.Save(Sfd_QrCodeSave.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "png":
                        _bitmap_QrCode.Save(Sfd_QrCodeSave.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "bmp":
                        _bitmap_QrCode.Save(Sfd_QrCodeSave.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        return;
                }
                if (MessageBox.Show($"条形码保存成功，是否打开？\r\n保存路径：{Sfd_QrCodeSave.FileName}"
                    , "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Sfd_QrCodeSave.FileName);
                }
            }
        }        
        
        /// <summary>
        /// 内容输入限制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tbx_Bar_Content_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        #endregion


    }
}
