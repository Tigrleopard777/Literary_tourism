/*
 * Writers form
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
    public partial class WritersForm : Form
    {
        List<Writers> writers = new List<Writers>();
        string response;

        public WritersForm()
        {
            InitializeComponent();
            string name = search_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_writers.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Writers?name=" + name;
            Uri uri = new Uri( "http://94.230.164.34:8080/api/Writers?name=" + name);

            //string response = Encoding.UTF8.GetString(webClient.DownloadDataTaskAsync(uri));
            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
  

        }


         void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                //DateTime? moment = new DateTime(1999, 1, 13, 3, 57, 32, 11);
                //int year = moment.Value.Year;
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                writers = JsonConvert.DeserializeObject<List<Writers>>(response);
               // writers.Sort();
                data_writers.Rows.Clear();
                for (int i = 0; i < writers.Count; i++)
                {
                    data_writers.Rows.Add();
                    data_writers.Rows[i].Cells[0].Value = writers[i].Full_name;
                    if (writers[i].Date_of_birth != null)
                    {
                        data_writers.Rows[i].Cells[1].Value = writers[i].Date_of_birth.Value.ToShortDateString();
                    }
                    else
                    {
                        data_writers.Rows[i].Cells[1].Value = writers[i].Date_of_birth;
                    }
                    if (writers[i].Date_of_death != null)
                    {
                        data_writers.Rows[i].Cells[2].Value = writers[i].Date_of_death.Value.ToShortDateString();
                    }
                    else
                    {
                        data_writers.Rows[i].Cells[2].Value = writers[i].Date_of_death;
                    }
                    data_writers.Rows[i].Cells[3].Value = writers[i].Place_of_birth;
                    data_writers.Rows[i].Cells[4].Value = writers[i].Place_of_death;
                    data_writers.Rows[i].Tag = writers;
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
                data_writers.Enabled = true;
            }
        }

        private void writers_lv_DoubleClick(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = search_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_writers.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Writers?name=" + name;

            //string response = Encoding.UTF8.GetString(webClient.DownloadDataTaskAsync(uri));
            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(MainForm.user);
            mainForm.Show();
        }

        private void data_writers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Writers writer = new Writers();
            writer = writers[e.RowIndex];
            WriterForm writer_form = new WriterForm(writer);
            writer_form.Show();
        }
    }
}
