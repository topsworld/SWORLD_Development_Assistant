using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMap_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;//选择地图
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.SetPositionByKeywords("吉林农业大学");//设定初始中心位置为Chengdu，成都坐标为西纬30.67度，东经104.06
            gMapControl1.ShowCenter = false;//不显示中心的红色十字
            gMapControl1.DragButton = System.Windows.Forms.MouseButtons.Left;  //左键拖动地图            
            //设置地图分辨率信息
            gMapControl1.MaxZoom = 24;
            gMapControl1.MinZoom = 3;
            gMapControl1.Zoom = 15;
        }
    }
}
