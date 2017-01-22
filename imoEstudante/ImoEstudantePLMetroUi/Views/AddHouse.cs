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
using GMap.NET.WindowsForms.Markers;

namespace ImoEstudantePLMetroUi
{
    public partial class AddHouse : MetroFramework.Controls.MetroUserControl
    {
        private static AddHouse _instance;
        internal readonly GMapOverlay markers = new GMapOverlay("markers");
        Example pois;
        GMapMarker marker;

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

            double latit = 41.5361453446439;
            double longit = -8.6068868637085;

            lB_POI.Items.Clear();
            //use google provider
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            gMapControl1.Position = new PointLatLng(latit, longit);

            //gMapControl1.SetPositionByKeywords("Braga, Portugal");

            //gMapControl1.SetPositionByKeywords("Barcelos, Portugal");




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

            pois = jss.Deserialize<Example>(results);

            marker = new GMarkerGoogle(new PointLatLng(latit, longit), GMarkerGoogleType.blue);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);

            for (int i = 0; i < pois.results.Count; i++)
            {
                // apresentar o nome do POI em portugues
                byte[] bytes = Encoding.Default.GetBytes(pois.results[i].name);
                string myString = Encoding.UTF8.GetString(bytes);
                lB_POI.Items.Add(myString);

                //marker = new GMarkerGoogle(new PointLatLng(pois.results[i].geometry.location.lat, pois.results[i].geometry.location.lng), GMarkerGoogleType.green_small);
                //markers.Markers.Add(marker);
                //gMapControl1.Overlays.Add(markers);
            }
        }

        private void bT_addHouse_inserirFoto_Click(object sender, EventArgs e)
        {
            AddHouseImages.Instance.BringToFront();

            //Idioma.switchLanguage(panel, cul, res_man);
        }

        private bool MarkerExist(GMapMarker marker)
        {
            foreach( GMapMarker x in markers.Markers)
            {
                if (x.Position.Lat == marker.Position.Lat && x.Position.Lng == marker.Position.Lng)
                    return true;
            }
            return false;
        }

        private void lB_POI_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = lB_POI.SelectedItem.ToString();
            gMapControl1.Overlays.Clear();

            for (int i = 0; i < pois.results.Count; i++)
            {
                // apresentar o nome do POI em portugues
                byte[] bytes = Encoding.Default.GetBytes(pois.results[i].name);
                string myString = Encoding.UTF8.GetString(bytes);
                if (curItem == myString)
                {
                    marker = new GMarkerGoogle(new PointLatLng(pois.results[i].geometry.location.lat, pois.results[i].geometry.location.lng), GMarkerGoogleType.green_small);

                    if (!MarkerExist(marker))
                    {
                        markers.Markers.Add(marker);
                        gMapControl1.Overlays.Add(markers);
                    }
                }
            }

        }
    }
}
