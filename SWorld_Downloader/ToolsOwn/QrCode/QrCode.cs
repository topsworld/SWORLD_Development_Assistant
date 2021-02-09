using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace SWORLD开发助手.ToolsOwn.QrCode
{
    class QrCode
    {
        #region C#生成二维码-基础版本
        //需要引用ZXing.DLL 
        //使用案例：Bitmap img3 = GenByZXingNet("");
        //使用案例：img3.Save(Server.MapPath(@"\testImg\erweima.png"));
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="msg">二维码信息</param>
        /// <param name="codeSizeInPixels">正方形 边长</param>
        /// <param name="codeMargin">二维码边框大小</param>
        /// <returns>图片</returns>
        public static Bitmap GenNormal(string _text, int _codeSize = 250,int _codeMargin=0)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");//编码问题
            writer.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H);
             
            writer.Options.Height = writer.Options.Width = _codeSize;
            writer.Options.Margin = _codeMargin;//设置边框            ZXing.Common.BitMatrix bm = writer.Encode(msg);
            Bitmap img = writer.Write(_text);
            return img;
        }

        #endregion

        #region C#生成带有Logo的二维码
        /// <summary>
        /// 生成带Logo的二维码
        /// </summary>
        /// <param name="_text">文本内容</param>
        /// <param name="_logoPath">Logo路径</param>
        /// <param name="_codeSize">二维码大小</param>
        /// <param name="_codeMargin">边框大小</param>
        /// <returns></returns>
        public static Bitmap GenWithLogo(string _text, string _logoPath, int _codeSize, int _codeMargin, Color _colorBack,Color _colorFront)
        {
            //Logo 图片
            Bitmap logo = new Bitmap(_logoPath);
            //构造二维码写码器
            MultiFormatWriter writer = new MultiFormatWriter();
            Dictionary<EncodeHintType, object> hint = new Dictionary<EncodeHintType, object>();
            hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            hint.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);


            //生成二维码 
            BitMatrix bm = writer.encode(_text, BarcodeFormat.QR_CODE, _codeSize, _codeSize, hint);
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Options.Margin = _codeMargin;
            barcodeWriter.Renderer = new ZXing.Rendering.BitmapRenderer { Background = _colorBack, Foreground = _colorFront };
            Bitmap map = barcodeWriter.Write(bm);


            //获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
            int[] rectangle = bm.getEnclosingRectangle();

            //计算插入图片的大小和位置
            int middleW = Math.Min((int)(rectangle[2] / 3.5), logo.Width);
            int middleH = Math.Min((int)(rectangle[3] / 3.5), logo.Height);
            int middleL = (map.Width - middleW) / 2;
            int middleT = (map.Height - middleH) / 2;

            //将img转换成bmp格式，否则后面无法创建Graphics对象
            Bitmap bmpimg = new Bitmap(map.Width, map.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmpimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.DrawImage(map, 0, 0);
            }
            //将二维码插入图片
            Graphics myGraphic = Graphics.FromImage(bmpimg);
            //白底
            myGraphic.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
            myGraphic.DrawImage(logo, middleL, middleT, middleW, middleH);

            return bmpimg;
        }
        #endregion

        #region C#生成特定颜色二维码-基础版本
        //需要引用ZXing.DLL
        //使用案例：Bitmap img3 = GenByZXingNet("");
        //使用案例：img3.Save(Server.MapPath(@"\testImg\erweima.png"));
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="msg">二维码信息</param>
        /// <param name="codeSizeInPixels">正方形 边长</param>
        /// <returns>图片</returns>
        public static Bitmap GenColorCustom(string msg, int codeSize,Color _colorBack,Color _colorFront)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Renderer = new ZXing.Rendering.BitmapRenderer { Background = _colorBack, Foreground = _colorFront };
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options.Hints.Add(EncodeHintType.CHARACTER_SET, "UTF-8");//编码问题
            writer.Options.Hints.Add(EncodeHintType.ERROR_CORRECTION, ZXing.QrCode.Internal.ErrorCorrectionLevel.H);

            writer.Options.Height = writer.Options.Width = codeSize;
            writer.Options.Margin = 0;//设置边框1            ZXing.Common.BitMatrix bm = writer.Encode(msg);
            Bitmap img = writer.Write(msg);
            return img;
        }

        #endregion

        #region ZXing生成条形码
        /// <summary>
        /// 生成条形码
        /// </summary>
        /// <param name="_text">条形码内容，只支持数字，只支持偶数个，最大长度80</param>
        /// <param name="_codeWidth">条形码宽度</param>
        /// <param name="_codeHeight">条形码高度</param>
        /// <param name="_codeMargin">条形码边框</param>
        /// <returns></returns>
        public static Bitmap GenBarCode(string _text,int _codeWidth=150,int _codeHeight=50, int _codeMargin=0)
        {
            BarcodeWriter writer = new BarcodeWriter();
            //使用ITF 格式，不能被现在常用的支付宝、微信扫出来
            //如果想生成可识别的可以使用 CODE_128 格式
            //writer.Format = BarcodeFormat.ITF;
            writer.Format = BarcodeFormat.CODE_128;
            EncodingOptions options = new EncodingOptions()
            {
                Width = _codeWidth,
                Height = _codeHeight,
                Margin = _codeMargin
            };
            writer.Options = options;
            Bitmap map = writer.Write(_text);
            return map;
        }
        #endregion

        #region 二维码 条形码读取
        /// <summary>
        /// 二维码 条形码读取
        /// </summary>
        /// <param name="filename">文件路径</param>
        /// <returns></returns>
        public static string ReadQrCode(string filename)
        {
            BarcodeReader reader = new BarcodeReader();
            reader.Options.CharacterSet = "UTF-8";
            Bitmap map = new Bitmap(filename);
            Result result = reader.Decode(map);
            return result == null ? "" : result.Text;
        }
        #endregion

        

    }
}
