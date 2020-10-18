/*
 * Theaters form
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
    public partial class TheatersForm : Form
    {
        List<Theaters> theaters = new List<Theaters>();
        string response;
        public TheatersForm()
        {
            InitializeComponent();
            string theater_name = search_theater_txt.Text;
            string spectacle_title = search_spectacle_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_theaters.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Theaters?theater_name=" + theater_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                Console.WriteLine(raw.Length + " bytes received");
                theaters = JsonConvert.DeserializeObject<List<Theaters>>(response);
                data_theaters.Rows.Clear();
                for (int i = 0; i < theaters.Count; i++)
                {
                    data_theaters.Rows.Add();
                    data_theaters.Rows[i].Cells[0].Value = theaters[i].Theater_name;
                    data_theaters.Rows[i].Cells[1].Value = theaters[i].Theater_site;
                    data_theaters.Rows[i].Cells[2].Value = theaters[i].Theater_address;
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
                data_theaters.Enabled = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string theater_name = search_theater_txt.Text;
            string spectacle_title = search_spectacle_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_theaters.Enabled = false;

            var webClient = new WebClient();
            string url;

            if (string.IsNullOrEmpty(spectacle_title) || string.IsNullOrWhiteSpace(spectacle_title))
            {            
                url = "http://94.230.164.34:8080/api/Theaters?theater_name=" + theater_name;
            }
            else
            {
                url = "http://94.230.164.34:8080/api/Theaters?theater_name=" + theater_name + "&spectacle_title=" + spectacle_title;
            }
            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(MainForm.user);
            mainForm.Show();
        }

        private void data_theaters_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Theaters theater = new Theaters();
            theater = theaters[e.RowIndex];
            TheaterForm theater_form = new TheaterForm(theater);
            theater_form.Show();
        }
    }
}
