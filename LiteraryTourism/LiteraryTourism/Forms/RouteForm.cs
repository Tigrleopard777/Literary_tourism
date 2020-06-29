/*
 * Route form
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using Microsoft.Win32;
using System.Diagnostics;

namespace LiteraryTourism.Forms
{
    public partial class RouteForm : Form
    {
        RouteWriter route_Writer = new RouteWriter();
        List<Comment_Route> comments = new List<Comment_Route>();
        List<Movies> movies = new List<Movies>();
        List<Museums> museums = new List<Museums>();
        List<Places> places = new List<Places>();
        List<SpectacleTheater> spectacle_theater = new List<SpectacleTheater>();
        List<FullRoute> full_route = new List<FullRoute>();
        int numb = 0;
        public RouteForm(RouteWriter route_writer)
        {
            SetBrowserFeatureControl();
            InitializeComponent();
            route_Writer = route_writer;

            var webClient = new WebClient();
            var webClient2 = new WebClient();

            route_name_lbl.Text = route_Writer.Route_name;
            writer_lbl.Text = route_Writer.Full_name;
            rating_lbl.Text += route_Writer.Route_rating;
            route_name_lbl.Left = 750 - route_name_lbl.Width / 2;
            writer_lbl.Left = 750 - writer_lbl.Width / 2;
            rating_lbl.Left = 750 - rating_lbl.Width / 2;
            if (MainForm.user != null)
            {
                mark_lbl.Visible = true;
                mark_combo.Visible = true;
                data_comments.AllowUserToAddRows = true;
            }
            if (route_Writer.Route_description != null)
            {
                web.DocumentText = route_Writer.Route_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
            }

            string url = "http://94.230.164.34:8080/api/CommentRoute?id=" + route_Writer.Id_route;
            try
            {
                string response_comments = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                comments = JsonConvert.DeserializeObject<List<Comment_Route>>(response_comments);

                data_comments.Rows.Clear();
                for (int i = 0; i < comments.Count; i++)
                {
                    data_comments.Rows.Add();
                    data_comments.Rows[i].Cells[0].Value = comments[i].Comment;
                    data_comments.Rows[i].Cells[1].Value = comments[i].Nick;
                    data_comments.Rows[i].Cells[2].Value = comments[i].Date.Value.Day.ToString() + "." + comments[i].Date.Value.Month.ToString() + "." + comments[i].Date.Value.Year.ToString();
                    data_comments.Rows[i].ReadOnly = true;
                }
            }
            catch
            {
                Messages.ErrorComments();
            }

            url = "http://94.230.164.34:8080/api/RouteMovie?id=" + route_Writer.Id_route;
            try
            {
                string response_movies = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                movies = JsonConvert.DeserializeObject<List<Movies>>(response_movies);

                data_movies.Rows.Clear();

                for (int i = 0; i < movies.Count; i++)
                {
                    data_movies.Rows.Add();
                    data_movies.Rows[i].Cells[0].Value = movies[i].Movie_title;
                    data_movies.Rows[i].Cells[1].Value = movies[i].Year_of_issue;
                }

                url = "http://94.230.164.34:8080/api/RouteMuseum?id=" + route_Writer.Id_route;
                string response_museums = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                museums = JsonConvert.DeserializeObject<List<Museums>>(response_museums);

                data_museums.Rows.Clear();

                for (int i = 0; i < museums.Count; i++)
                {
                    data_museums.Rows.Add();
                    data_museums.Rows[i].Cells[0].Value = museums[i].Museum_name;
                    data_museums.Rows[i].Cells[1].Value = museums[i].Museum_site;
                    data_museums.Rows[i].Cells[2].Value = museums[i].Museum_address;
                }

                url = "http://94.230.164.34:8080/api/RoutePlace?id=" + route_Writer.Id_route;
                string response_places = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                places = JsonConvert.DeserializeObject<List<Places>>(response_places);

                data_places.Rows.Clear();

                for (int i = 0; i < places.Count; i++)
                {
                    data_places.Rows.Add();
                    data_places.Rows[i].Cells[0].Value = places[i].Place_name;
                    data_places.Rows[i].Cells[1].Value = places[i].Place_address;
                }

                url = "http://94.230.164.34:8080/api/RouteSpectacle?id=" + route_Writer.Id_route;
                string response_spectacles = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                spectacle_theater = JsonConvert.DeserializeObject<List<SpectacleTheater>>(response_spectacles);

                data_spectacles.Rows.Clear();

                for (int i = 0; i < spectacle_theater.Count; i++)
                {
                    data_spectacles.Rows.Add();
                    data_spectacles.Rows[i].Cells[0].Value = spectacle_theater[i].Spectacle_title;
                    data_spectacles.Rows[i].Cells[1].Value = spectacle_theater[i].Spectacle_link;
                    data_spectacles.Rows[i].Cells[2].Value = spectacle_theater[i].Theater_name;
                    data_spectacles.Rows[i].Cells[3].Value = spectacle_theater[i].Theater_address;
                }
            }
            catch
            {
                Messages.ErrorConnection();
            }

            if(museums.Count!=0)
            {
                for (int i =0; i< museums.Count; i++  )
                {
                    full_route.Add(new FullRoute {Num=numb, Name=museums[i].Museum_name, Address=museums[i].Museum_address,
                    Latitude=museums[i].Latitude, Longitude=museums[i].Longitude});
                }
            }

            if (spectacle_theater.Count != 0)
            {
                for (int i = 0; i < spectacle_theater.Count; i++)
                {
                    full_route.Add(new FullRoute
                    {
                        Num = numb,
                        Name = spectacle_theater[i].Theater_name,
                        Address = spectacle_theater[i].Theater_address,
                        Latitude = spectacle_theater[i].Latitude,
                        Longitude = spectacle_theater[i].Longitude
                    });
                }
            }

            if (places.Count != 0)
            {
                for (int i = 0; i < places.Count; i++)
                {
                    full_route.Add(new FullRoute
                    {
                        Num = numb,
                        Name = places[i].Place_name,
                        Address = places[i].Place_address,
                        Latitude = places[i].Latitude,
                        Longitude = places[i].Longitude
                    });
                }
            }

           
            numb = full_route.Count;
        }

        private void mark_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mark_Of_Route newmark = new Mark_Of_Route();
                newmark.Id_route = route_Writer.Id_route;
                newmark.Id_user = MainForm.user.Id_user;
                newmark.Date = null;
                newmark.Time = null;
                newmark.Mark_of_route = Convert.ToDecimal(mark_combo.Text);
                newmark.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newmark);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/MarkOfRoute";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
            }
            catch
            {

            }
        }

        private void data_comments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Comment_Route newcomment = new Comment_Route();
                newcomment.Id_comment = 0;
                newcomment.Id_route = route_Writer.Id_route;
                newcomment.Id_user = MainForm.user.Id_user;
                newcomment.Date = null;
                newcomment.Time = null;
                newcomment.Comment = data_comments.Rows[e.RowIndex].Cells[0].Value.ToString();
                newcomment.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newcomment);
                data_comments.Rows[e.RowIndex].Cells[1].Value = MainForm.user.Nick;
                data_comments.Rows[e.RowIndex].Cells[2].Value = DateTime.Today.Day.ToString() + "." + DateTime.Today.Month.ToString() + "." + DateTime.Today.Year.ToString();
                data_comments.Rows[e.RowIndex].ReadOnly = true;
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/CommentRoute";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
            }
            catch
            {

            }
        }

        private void google_btn_Click(object sender, EventArgs e)
        {
            string url= "https://www.google.com/maps/dir/";
            for(int i=0; i < numb;i++)
            {
                url += full_route[i].Name + "/";
            }
            MapsForm maps_form = new MapsForm(url);
            maps_form.Show();
        }

        private void yandex_btn_Click(object sender, EventArgs e)
        {
            string url = "https://yandex.ru/maps/2/saint-petersburg/?mode=routes&rtt=auto&rtext=";
            for (int i = 0; i < numb; i++)
            {
                url += full_route[i].Latitude+" "+ full_route[i].Longitude + "~";
            }
            MapsForm maps_form = new MapsForm(url);
            maps_form.Show();
        }


        public void SetBrowserFeatureControlKey(string feature, string appName, uint value)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(
                String.Concat(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature),
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                key.SetValue(appName, (UInt32)value, RegistryValueKind.DWord);
            }
        }

        public void SetBrowserFeatureControl()
        {
            // http://msdn.microsoft.com/en-us/library/ee330720(v=vs.85).aspx

            // FeatureControl settings are per-process
            var fileName = System.IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);

            // make the control is not running inside Visual Studio Designer
            if (String.Compare(fileName, "devenv.exe", true) == 0 || String.Compare(fileName, "XDesProc.exe", true) == 0)
                return;

            SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, GetBrowserEmulationMode()); // Webpages containing standards-based !DOCTYPE directives are displayed in IE10 Standards mode.
            SetBrowserFeatureControlKey("FEATURE_AJAX_CONNECTIONEVENTS", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_MANAGE_SCRIPT_CIRCULAR_REFS", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_DOMSTORAGE ", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_GPU_RENDERING ", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_IVIEWOBJECTDRAW_DMLT9_WITH_GDI  ", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_DISABLE_LEGACY_COMPRESSION", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_LOCALMACHINE_LOCKDOWN", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_OBJECT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_SCRIPT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_DISABLE_NAVIGATION_SOUNDS", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_SCRIPTURL_MITIGATION", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_SPELLCHECKING", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_STATUS_BAR_THROTTLING", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_TABBED_BROWSING", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_VALIDATE_NAVIGATE_URL", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_WEBOC_DOCUMENT_ZOOM", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_WEBOC_POPUPMANAGEMENT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_WEBOC_MOVESIZECHILD", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_ADDON_MANAGEMENT", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_WEBSOCKET", fileName, 1);
            SetBrowserFeatureControlKey("FEATURE_WINDOW_RESTRICTIONS ", fileName, 0);
            SetBrowserFeatureControlKey("FEATURE_XMLHTTP", fileName, 1);
        }

        public UInt32 GetBrowserEmulationMode()
        {
            int browserVersion = 7;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer",
                RegistryKeyPermissionCheck.ReadSubTree,
                System.Security.AccessControl.RegistryRights.QueryValues))
            {
                var version = ieKey.GetValue("svcVersion");
                if (null == version)
                {
                    version = ieKey.GetValue("Version");
                    if (null == version)
                        throw new ApplicationException("Microsoft Internet Explorer is required!");
                }
                int.TryParse(version.ToString().Split('.')[0], out browserVersion);
            }

            UInt32 mode = 11000; // Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode. Default value for Internet Explorer 11.
            switch (browserVersion)
            {
                case 7:
                    mode = 7000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. Default value for applications hosting the WebBrowser Control.
                    break;
                case 8:
                    mode = 8000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode. Default value for Internet Explorer 8
                    break;
                case 9:
                    mode = 9000; // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                    break;
                case 10:
                    mode = 10000; // Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE10 mode. Default value for Internet Explorer 10.
                    break;
                default:
                    // use IE11 mode by default
                    break;
            }

            return mode;
        }
    }
}
