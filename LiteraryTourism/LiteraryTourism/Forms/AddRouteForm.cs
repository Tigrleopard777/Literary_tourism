/*
 * Add route form
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

namespace LiteraryTourism.Forms
{
    public partial class AddRouteForm : Form
    {
        List<Writers> writers = new List<Writers>();
        string response;

        public AddRouteForm()
        {
            InitializeComponent();
            this.Visible = true;
            this.Cursor = Cursors.WaitCursor;
            add_btn.Enabled = false;
            writers_combo.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Writers?name=";

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Routes route = new Routes();
            route.Id_route = 0;
            route.Route_name = route_name_txt.Text;
            route.Id_user = MainForm.user.Id_user;
            route.Id_writer = writers[writers_combo.SelectedIndex].Id_writer;
            route.Date =null;
            route.Route_description = null;
            route.Route_rating = 5;
            try
            {
                string data = JsonConvert.SerializeObject(route);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/Routes";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
                MessageBox.Show("Маршрут добавлен!", "Успех!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch
            {
                Messages.ErrorConnection();
            }
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                writers = JsonConvert.DeserializeObject<List<Writers>>(response);
                writers_combo.Items.Clear();

                for (int i = 0; i < writers.Count; i++)
                {
                    writers_combo.Items.Add(writers[i].Full_name);
                }
            }
            catch
            {
                Messages.ErrorConnection();
            }
            finally
            {
                this.Cursor = Cursors.Default;
                add_btn.Enabled = true;
                writers_combo.Enabled = true;
            }
        }
    }
}
