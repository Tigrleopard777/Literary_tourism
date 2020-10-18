/*
 * Works form
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
    public partial class WorksForm : Form
    {
        List<WorkWriter> work_writer = new List<WorkWriter>();
        string response;
        public WorksForm()
        {
            InitializeComponent();
            string name = search_writer_txt.Text;
            string work_name = search_work_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_works.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Works?name=" + name + "&work_name=" + work_name;

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
                work_writer = JsonConvert.DeserializeObject<List<WorkWriter>>(response);
                data_works.Rows.Clear();
                for (int i = 0; i < work_writer.Count; i++)
                {
                    data_works.Rows.Add();
                    data_works.Rows[i].Cells[0].Value = work_writer[i].Work_name;
                    data_works.Rows[i].Cells[1].Value = work_writer[i].Work_link;
                    data_works.Rows[i].Cells[2].Value = work_writer[i].Genre_name;
                    data_works.Rows[i].Cells[3].Value = work_writer[i].Work_rating;
                    data_works.Rows[i].Cells[4].Value = work_writer[i].Full_name;
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
                data_works.Enabled = true;
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
            string work_name = search_work_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_works.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Works?name=" + name + "&work_name=" + work_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void data_works_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkWriter work = new WorkWriter();
            work = work_writer[e.RowIndex];
            WorkForm work_form = new WorkForm(work);
            work_form.Show();
        }
    }
}
