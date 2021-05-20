using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWorld_Downloader.Control
{
    [ToolboxBitmap(typeof(TabCon))]
    /// <summary>
    /// Summary description for DraggableTabPage.
    /// </summary>
    public class TabCon : TabControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public TabCon()
        {
            SetStyle
                       (ControlStyles.AllPaintingInWmPaint  //全部在窗口绘制消息中绘图
                       | ControlStyles.OptimizedDoubleBuffer //使用双缓冲
                       , true);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

    }
}
