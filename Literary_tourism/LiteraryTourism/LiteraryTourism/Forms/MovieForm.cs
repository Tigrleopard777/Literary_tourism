/*
 * Movie form
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
    public partial class MovieForm : Form
    {
        MovieWriter movie_Writer = new MovieWriter();
        List<Comment_Movie> comments = new List<Comment_Movie>();
        List<RouteWriter> route_writer = new List<RouteWriter>();

        string response;
        public MovieForm(MovieWriter movie_writer)
        {
            InitializeComponent();
            movie_Writer = movie_writer;

            var webClient = new WebClient();
            var webClient2 = new WebClient();


            movie_title_lbl.Text = movie_Writer.Movie_title;
            year_of_issue.Text += movie_Writer.Year_of_issue;
            rating_lbl.Text += movie_Writer.Movie_rating;
            movie_title_lbl.Left = 750 - movie_title_lbl.Width / 2;
            year_of_issue.Left = 750 - year_of_issue.Width / 2;
            if (MainForm.user != null)
            {
                mark_lbl.Visible = true;
                mark_combo.Visible = true;
                add_lbl.Visible = true;
                add_combo.Visible = true;
                data_comments.AllowUserToAddRows = true;
            }
            if (movie_Writer.Movie_description != null)
            {
                web.DocumentText = movie_Writer.Movie_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
            }

            string url = "http://94.230.164.34:8080/api/CommentMovie?id=" + movie_Writer.Id_movie;
            try
            {
                string response_comments = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                comments = JsonConvert.DeserializeObject<List<Comment_Movie>>(response_comments);

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

            if (MainForm.user != null)
            {
                url = "http://94.230.164.34:8080/api/Routes?nick=" + MainForm.user.Nick;
                try
                {
                    response = Encoding.UTF8.GetString(webClient.DownloadData(url));
                    route_writer = JsonConvert.DeserializeObject<List<RouteWriter>>(response);
                    add_combo.Items.Clear();
                    for (int i = 0; i < route_writer.Count; i++)
                    {
                        add_combo.Items.Add(route_writer[i].Route_name);
                    }
                }
                catch
                {
                    Messages.ErrorRoutes();
                }
            }
        }

        private void mark_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mark_Of_Movie newmark = new Mark_Of_Movie();
                newmark.Id_movie = movie_Writer.Id_movie;
                newmark.Id_user = MainForm.user.Id_user;
                newmark.Date = null;
                newmark.Time = null;
                newmark.Mark_of_movie = Convert.ToDecimal(mark_combo.Text);
                newmark.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newmark);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/MarkOfMovie";
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
                Comment_Movie newcomment = new Comment_Movie();
                newcomment.Id_comment = 0;
                newcomment.Id_movie = movie_Writer.Id_movie;
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
                string url = "http://94.230.164.34:8080/api/CommentMovie";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
            }
            catch
            {

            }
        }

        private void add_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Route_Movie route_movie = new Route_Movie();
                route_movie.Id_route = route_writer[add_combo.SelectedIndex].Id_route;
                route_movie.Id_movie = movie_Writer.Id_movie;
                string data = JsonConvert.SerializeObject(route_movie);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/RouteMovie";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
                MessageBox.Show("Фильм добавлен в маршрут!", "Успех!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Messages.ErrorRoutes();
            }
        }
    }
}
