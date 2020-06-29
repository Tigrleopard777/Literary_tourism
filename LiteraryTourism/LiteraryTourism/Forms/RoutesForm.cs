/*
 * Routes form
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
    public partial class RoutesForm : Form
    {
        List<RouteWriter> route_writer = new List<RouteWriter>();
        string response;
        public RoutesForm()
        {
            InitializeComponent();
            if(MainForm.user!=null)
            {
                add_route_btn.Visible = true;
            }
            string name = search_writer_txt.Text;
            string route_name = search_route_txt.Text;
            string nick = search_user_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_routes.Enabled = false;
            add_route_btn.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Routes?name=" + name + "&route_name=" + route_name + "&nick=" + nick;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                route_writer = JsonConvert.DeserializeObject<List<RouteWriter>>(response);
                data_routes.Rows.Clear();
                for (int i = 0; i < route_writer.Count; i++)
                {
                    data_routes.Rows.Add();
                    data_routes.Rows[i].Cells[0].Value = route_writer[i].Route_name;
                    data_routes.Rows[i].Cells[1].Value = route_writer[i].Full_name;
                    if (route_writer[i].Date != null)
                    {
                        data_routes.Rows[i].Cells[2].Value = route_writer[i].Date.Value.ToShortDateString();
                    }
                    else
                    {
                        data_routes.Rows[i].Cells[2].Value = route_writer[i].Date;
                    }
                    data_routes.Rows[i].Cells[3].Value = route_writer[i].Nick;
                    data_routes.Rows[i].Cells[4].Value = route_writer[i].Route_rating;
                }
            }
            catch
            {
                Messages.ErrorConnection();
            }
            finally
            {
                this.Cursor = Cursors.Default;
                search_btn.Enabled = true;
                data_routes.Enabled = true;
                add_route_btn.Enabled = true;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(MainForm.user);
            mainForm.Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = search_writer_txt.Text;
            string route_name = search_route_txt.Text;
            string nick = search_user_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_routes.Enabled = false;
            add_route_btn.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Routes?name=" + name + "&route_name=" + route_name + "&nick=" + nick;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void add_route_btn_Click(object sender, EventArgs e)
        {
            AddRouteForm add_route_form = new AddRouteForm();
            add_route_btn.Show();
        }

        private void data_routes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RouteWriter route = new RouteWriter();
            route = route_writer[e.RowIndex];
            RouteForm route_form = new RouteForm(route);
            route_form.Show();
        }
    }
}
