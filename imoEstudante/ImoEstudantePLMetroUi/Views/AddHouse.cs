using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET.MapProviders;
using GMap.NET;

namespace ImoEstudantePLMetroUi
{
    public partial class AddHouse : MetroFramework.Controls.MetroUserControl
    {
        private static AddHouse _instance;

        public static AddHouse Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddHouse();
                return _instance;
            }
        }
        public AddHouse()
        {
            InitializeComponent();
        }

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            //use google provider
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            // gMapControl1.Position = new PointLatLng(55.755786121111, 37.617633343333);

            gMapControl1.SetPositionByKeywords("Braga, Portugal");

            gMapControl1.SetPositionByKeywords("Barcelos, Portugal");


            gMapControl1.DragButton = MouseButtons.Left;

            //zoom min/max; default both = 2
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            //set zoom
            gMapControl1.Zoom = 15;
        }


    }
}
