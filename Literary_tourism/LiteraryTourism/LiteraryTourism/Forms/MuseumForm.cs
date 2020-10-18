/*
 * Museum form
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
    public partial class MuseumForm : Form
    {
        MuseumWriter museum_Writer = new MuseumWriter();
        List<Pictures> pictures = new List<Pictures>();
        List<Comment_Museum> comments = new List<Comment_Museum>();
        List<RouteWriter> route_writer = new List<RouteWriter>();
        string response;
        int pictures_count = 0;
        int picture_num = 0;
        public MuseumForm(MuseumWriter museum_writer)
        {
            InitializeComponent();
            museum_Writer = museum_writer;
            this.Cursor = Cursors.WaitCursor; 

            var webClient = new WebClient();
            var webClient2 = new WebClient();
            string url = "http://94.230.164.34:8080/api/PictureMuseum?id=" + museum_Writer.Id_museum;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);

           

            museum_name_lbl.Text = museum_Writer.Museum_name;
            site_lbl.Text = museum_Writer.Museum_site;
            rating_lbl.Text += museum_Writer.Museum_rating;
            museum_name_lbl.Left = 750 - museum_name_lbl.Width / 2;
            site_lbl.Left = 750 - site_lbl.Width / 2;
            rating_lbl.Left = 750 - rating_lbl.Width / 2;
            if(MainForm.user!=null)
            {
                mark_lbl.Visible = true;
                mark_combo.Visible = true;
                add_lbl.Visible = true;
                add_combo.Visible = true;
                data_comments.AllowUserToAddRows = true;
            }
            if (museum_Writer.Museum_description != null)
            {
                web.DocumentText = museum_Writer.Museum_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
            }

            url = "http://94.230.164.34:8080/api/CommentMuseum?id=" + museum_Writer.Id_museum;
            try
            {
                string response_comments = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                comments = JsonConvert.DeserializeObject<List<Comment_Museum>>(response_comments);

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mark_Of_Museum newmark = new Mark_Of_Museum();
                newmark.Id_museum = museum_Writer.Id_museum;
                newmark.Id_user = MainForm.user.Id_user;
                newmark.Date = null;
                newmark.Time = null;
                newmark.Mark_of_museum = Convert.ToDecimal(mark_combo.Text);
                newmark.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newmark);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/MarkOfMuseum";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
            }
            catch
            {

            }
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                pictures = JsonConvert.DeserializeObject<List<Pictures>>(response);
                pictures_count = pictures.Count;
                if(pictures_count>0)
                {               
                    WebClient wc = new WebClient();
                    picture.Image = Image.FromStream(wc.OpenRead("http://94.230.164.34/" + pictures[0].Picture_link));
                    picture_name_lbl.Text = pictures[0].Picture_name;
                    picture_name_lbl.Visible = true;
                    picture_name_lbl.Left = 750 - picture_name_lbl.Width / 2;
                    next_btn.Visible = true;
                    back_btn.Visible = true;
                }
            }
            catch
            {
                Messages.ErrorPictures();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (picture_num > 0)
                {
                    picture_num--;
                    WebClient wc = new WebClient();
                    picture.Image = Image.FromStream(wc.OpenRead("http://94.230.164.34/" + pictures[picture_num].Picture_link));
                    picture_name_lbl.Text = pictures[picture_num].Picture_name;
                    picture_name_lbl.Left = 750 - picture_name_lbl.Width / 2;
                }
            }
            catch
            {
                Messages.ErrorPictures();
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (picture_num < (pictures_count - 1))
                {
                    picture_num++;
                    WebClient wc = new WebClient();
                    picture.Image = Image.FromStream(wc.OpenRead("http://94.230.164.34/" + pictures[picture_num].Picture_link));
                    picture_name_lbl.Text = pictures[picture_num].Picture_name;
                    picture_name_lbl.Left = 750 - picture_name_lbl.Width / 2;
                }
            }
            catch
            {
                Messages.ErrorPictures();
            }
        }

        private void data_comments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Comment_Museum newcomment = new Comment_Museum();
                newcomment.Id_comment = 0;
                newcomment.Id_museum = museum_Writer.Id_museum;
                newcomment.Id_user = MainForm.user.Id_user;
                newcomment.Date = null;
                newcomment.Time = null;
                newcomment.Comment = data_comments.Rows[e.RowIndex].Cells[0].Value.ToString();
                newcomment.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newcomment);
                data_comments.Rows[e.RowIndex].Cells[1].Value = MainForm.user.Nick;
                data_comments.Rows[e.RowIndex].Cells[2].Value = DateTime.Today.Day.ToString()+"."+ DateTime.Today.Month.ToString()+"."+ DateTime.Today.Year.ToString();
                data_comments.Rows[e.RowIndex].ReadOnly = true;
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/CommentMuseum";
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
                Route_Museum route_museum = new Route_Museum();
                route_museum.Id_route = route_writer[add_combo.SelectedIndex].Id_route;
                route_museum.Id_museum = museum_Writer.Id_museum;
                route_museum.Number_in_order = 1;
                string data = JsonConvert.SerializeObject(route_museum);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/RouteMuseum";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
                MessageBox.Show("Музей добавлен в маршрут!", "Успех!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Messages.ErrorRoutes();
            }
        }
    }
}
