using GMap.NET.MapProviders;
using System.Security.AccessControl;

namespace locationbasedservice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(txtLat.Text);
            double longt = Convert.ToDouble(txtLong.Text);
            map.Position = new GMap.NET.PointLatLng(lat, longt);
            map.Zoom = 20;
            map.MinZoom = 10;
            map.MaxZoom = 200;
            map.DragButton = MouseButtons.Left;
        }
    }
}
