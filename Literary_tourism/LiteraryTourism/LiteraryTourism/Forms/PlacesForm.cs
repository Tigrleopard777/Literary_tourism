/*
 * Places form
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
    public partial class PlacesForm : Form
    {
        List<PlaceWriter> place_writer = new List<PlaceWriter>();
        string response;
        public PlacesForm()
        {
            InitializeComponent();
            string name = search_writer_txt.Text;
            string place_name = search_place_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_places.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Places?name=" + name + "&place_name=" + place_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(MainForm.user);
            mainForm.Show();
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                place_writer = JsonConvert.DeserializeObject<List<PlaceWriter>>(response);
                data_places.Rows.Clear();
                for (int i = 0; i < place_writer.Count; i++)
                {
                    data_places.Rows.Add();
                    data_places.Rows[i].Cells[0].Value = place_writer[i].Place_name;
                    data_places.Rows[i].Cells[1].Value = place_writer[i].Place_address;
                    data_places.Rows[i].Cells[2].Value = place_writer[i].Place_rating;
                    data_places.Rows[i].Cells[3].Value = place_writer[i].Full_name;
                    data_places.Rows[i].Cells[4].Value = place_writer[i].Relation_description;
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
                data_places.Enabled = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = search_writer_txt.Text;
            string place_name = search_place_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_places.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Places?name=" + name + "&place_name=" + place_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void data_places_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaceWriter place = new PlaceWriter();
            place = place_writer[e.RowIndex];
            PlaceForm place_form = new PlaceForm(place);
            place_form.Show();
        }
    }
}
