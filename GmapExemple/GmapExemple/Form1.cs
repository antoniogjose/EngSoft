using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.ToolTips;

using System.Globalization;
using System.Net;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

namespace GmapExemple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            //use google provider
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //get tiles from server only
            gMapControl1.Manager.Mode = AccessMode.ServerOnly;
            //not use proxy
            GMapProvider.WebProxy = null;
            //center map on moscow
            // gMapControl1.Position = new PointLatLng(55.755786121111, 37.617633343333);
            gMapControl1.SetPositionByKeywords("Barcelos, Portugal");

            gMapControl1.DragButton = MouseButtons.Left;


            //zoom min/max; default both = 2
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            //set zoom
            gMapControl1.Zoom = 15;

            /**
                        // Add a Marquer
                        GMapOverlay markers = new GMapOverlay("markers");
                        GMapMarker marker = new GMarkerGoogle(
                            new PointLatLng(48.8617774, 2.349272),
                            GMarkerGoogleType.blue_pushpin);
                        markers.Markers.Add(marker);
                        gMapControl1.Overlays.Add(markers);**/
            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(41.5361453446439, -8.6068868637085), GMarkerGoogleType.blue_pushpin);
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);


        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                panel1.Visible = true;
                double latfinal;
                double lngfinal;
                double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
                double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

                lV_Poi.Clear();

                /*
                NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
                    Decimal.TryParse(l, style, culture, out latfinal);
                    Decimal.TryParse(g, style, culture, out lngfinal);
                 
                 */

                tBLat.Text = lat.ToString();//.Replace(',', '.');
                tBLgn.Text = lng.ToString();//.Replace(',', '.');
                string l = lat.ToString().Replace(',', '.');
                string g = lng.ToString().Replace(',', '.');
                NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
                Double.TryParse(l, style, culture, out latfinal);
                Double.TryParse(g, style, culture, out lngfinal);

                // Add a Marquer
              //  GMapOverlay markers = new GMapOverlay("markers");
              //  GMapMarker marker = new GMarkerGoogle( new PointLatLng(latfinal, lngfinal), GMarkerGoogleType.red_big_stop);
              //  markers.Markers.Add(marker);
              //  gMapControl1.Overlays.Add(markers);

                // Adicionar POI´s

                WebClient webClient = new WebClient();

                string uri = "https://maps.googleapis.com/maps/api/place/nearbysearch/json?";

                uri += "location=" + l + "," + g + "&";
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
                    lV_Poi.Items.Add(myString);
                }

            }
        }
    }
}
