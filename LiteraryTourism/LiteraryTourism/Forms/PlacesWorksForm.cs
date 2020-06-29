/*
 * Places relates with works form
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
    public partial class PlacesWorksForm : Form
    {
        List<PlaceWork> place_work = new List<PlaceWork>();
        string response;
        public PlacesWorksForm()
        {
            InitializeComponent();
            string name = search_writer_txt.Text;
            string place_name = search_place_txt.Text;
            string work_name = search_work_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_place_work.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/PlaceWork?name=" + name + "&place_name=" + place_name + "&work_name=" + work_name;

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
                place_work = JsonConvert.DeserializeObject<List<PlaceWork>>(response);
                data_place_work.Rows.Clear();
                for (int i = 0; i < place_work.Count; i++)
                {
                    data_place_work.Rows.Add();
                    data_place_work.Rows[i].Cells[0].Value = place_work[i].Place_name;
                    data_place_work.Rows[i].Cells[1].Value = place_work[i].Place_address;
                    data_place_work.Rows[i].Cells[2].Value = place_work[i].Place_rating;
                    data_place_work.Rows[i].Cells[3].Value = place_work[i].Full_name;
                    data_place_work.Rows[i].Cells[4].Value = place_work[i].Work_name;
                    data_place_work.Rows[i].Cells[5].Value = place_work[i].Excerpt_text;
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
                data_place_work.Enabled = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = search_writer_txt.Text;
            string place_name = search_place_txt.Text;
            string work_name = search_work_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_place_work.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/PlaceWork?name=" + name + "&place_name=" + place_name + "&work_name=" + work_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void data_place_work_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PlaceWork place = new PlaceWork();
            place = place_work[e.RowIndex];
            PlaceForm place_form = new PlaceForm(place);
            place_form.Show();
        }
    }
}
