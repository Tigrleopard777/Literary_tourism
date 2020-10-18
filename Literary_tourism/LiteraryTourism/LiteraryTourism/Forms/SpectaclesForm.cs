/*
 * Spectacles form
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
    public partial class SpectaclesForm : Form
    {
        List<SpectacleTheater> spectacle_theater = new List<SpectacleTheater>();
        string response;

        public SpectaclesForm()
        {
            InitializeComponent();
            string spectacle_title = search_spectacle_txt.Text;
            string theater_name = search_theater_txt.Text;
            string writer_name = search_writer_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_spectacles.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Spectacles?spectacle_title=" + spectacle_title + "&theater_name=" + theater_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                spectacle_theater = JsonConvert.DeserializeObject<List<SpectacleTheater>>(response);
                data_spectacles.Rows.Clear();
                for (int i = 0; i < spectacle_theater.Count; i++)
                {
                    data_spectacles.Rows.Add();
                    data_spectacles.Rows[i].Cells[0].Value = spectacle_theater[i].Spectacle_title;
                    data_spectacles.Rows[i].Cells[1].Value = spectacle_theater[i].Director;
                    data_spectacles.Rows[i].Cells[2].Value = spectacle_theater[i].Spectacle_type;
                    data_spectacles.Rows[i].Cells[3].Value = spectacle_theater[i].Spectacle_link;
                    data_spectacles.Rows[i].Cells[4].Value = spectacle_theater[i].Spectacle_rating;
                    data_spectacles.Rows[i].Cells[5].Value = spectacle_theater[i].Theater_name;
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
                data_spectacles.Enabled = true;
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
            string spectacle_title = search_spectacle_txt.Text;
            string theater_name = search_theater_txt.Text;
            string writer_name = search_writer_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_spectacles.Enabled = false;

            var webClient = new WebClient();
            string url;
            if (string.IsNullOrEmpty(writer_name) || string.IsNullOrWhiteSpace(writer_name))
            {
                url = "http://94.230.164.34:8080/api/Spectacles?spectacle_title=" + spectacle_title + "&theater_name=" + theater_name;
            }
            else
            {
                url = "http://94.230.164.34:8080/api/Spectacles?spectacle_title=" + spectacle_title + "&theater_name=" + theater_name+"&writer_name=" + writer_name;
            }
            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void data_spectacles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SpectacleTheater spectacle = new SpectacleTheater();
            spectacle = spectacle_theater[e.RowIndex];
            SpectacleForm spectacle_form = new SpectacleForm(spectacle);
            spectacle_form.Show();
        }
    }
}
