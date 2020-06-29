/*
 * Movies form
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
    public partial class MoviesForm : Form
    {
        List<MovieWriter> movie_writer = new List<MovieWriter>();
        string response;
        public MoviesForm()
        {
            InitializeComponent();
            string name = search_writer_txt.Text;
            string movies_title = search_movie_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_movies.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Movies?name=" + name + "&movie_title=" + movies_title;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                movie_writer = JsonConvert.DeserializeObject<List<MovieWriter>>(response);
                data_movies.Rows.Clear();
                for (int i = 0; i < movie_writer.Count; i++)
                {
                    data_movies.Rows.Add();
                    data_movies.Rows[i].Cells[0].Value = movie_writer[i].Movie_title;
                    data_movies.Rows[i].Cells[1].Value = movie_writer[i].Year_of_issue;
                    data_movies.Rows[i].Cells[2].Value = movie_writer[i].Movie_rating;
                    data_movies.Rows[i].Cells[3].Value = movie_writer[i].Full_name;
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
                data_movies.Enabled = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = search_writer_txt.Text;
            string movies_title = search_movie_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_movies.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Movies?name=" + name + "&movie_title=" + movies_title;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(MainForm.user);
            mainForm.Show();
        }

        private void data_movies_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MovieWriter movie = new MovieWriter();
            movie = movie_writer[e.RowIndex];
            MovieForm movie_form = new MovieForm(movie);
            movie_form.Show();
        }
    }
}
