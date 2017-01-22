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
using GMap.NET.WindowsForms;
using ImoEstudantePLMetroUi.Views;
using System.Net;
using System.Web.Script.Serialization;
using ImoEstudantePLMetroUi.Resources;

namespace ImoEstudantePLMetroUi
{
    public partial class AddHouse : MetroFramework.Controls.MetroUserControl
    {
        private static AddHouse _instance;
        internal readonly GMapOverlay objects = new GMapOverlay("objects");

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
            lB_POI.Items.Clear();
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

            WebClient webClient = new WebClient();

            string uri = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";

            uri += "location=" + "41.5343785144371" + "," + "-8.61559867858887" + "&";
            uri += "radius=" + "500" + "&";
            uri += "types=point_of_interest&";
            uri += "key=AIzaSyAk7AXTSD8FhpqAixnP6_Alh3uOh4v1198";

            string results = webClient.DownloadString(uri);

            JavaScriptSerializer jss = new JavaScriptSerializer();

            Example pois = jss.Deserialize<Example>(results);



            for (int i = 0; i < pois.results.Count; i++)
            {
                // apresentar o nome do POI em portugues
                byte[] bytes = Encoding.Default.GetBytes(pois.results[i].name);
                string myString = Encoding.UTF8.GetString(bytes);
                lB_POI.Items.Add(myString);
            }
        }

        private void bT_addHouse_inserirFoto_Click(object sender, EventArgs e)
        {
            AddHouseImages.Instance.BringToFront();

            //Idioma.switchLanguage(panel, cul, res_man);
        }
    }
}
