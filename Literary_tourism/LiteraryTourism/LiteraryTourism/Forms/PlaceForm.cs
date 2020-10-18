/*
 * Place form
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
    public partial class PlaceForm : Form
    {
        PlaceWriter place_Writer = new PlaceWriter();
        PlaceWork place_Work = new PlaceWork();
        List<Pictures> pictures = new List<Pictures>();
        List<Comment_Place> comments = new List<Comment_Place>();
        List<RouteWriter> route_writer = new List<RouteWriter>();
        string response;
        int pictures_count = 0;
        int picture_num = 0;
        public PlaceForm(PlaceWriter place_writer)
        {
            InitializeComponent();
            place_Work = null;

            place_Writer = place_writer;
            this.Cursor = Cursors.WaitCursor;

            var webClient = new WebClient();
            var webClient2 = new WebClient();
            string url = "http://94.230.164.34:8080/api/PicturePlace?id=" + place_Writer.Id_place;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);



            place_name_lbl.Text = place_Writer.Place_name;
            adress_lbl.Text += place_Writer.Place_address;
            rating_lbl.Text += place_Writer.Place_rating;
            place_name_lbl.Left = 750 - place_name_lbl.Width / 2;
            adress_lbl.Left = 750 - adress_lbl.Width / 2;
            rating_lbl.Left = 750 - rating_lbl.Width / 2;
            if (MainForm.user != null)
            {
                mark_lbl.Visible = true;
                mark_combo.Visible = true;
                add_lbl.Visible = true;
                add_combo.Visible = true;
                data_comments.AllowUserToAddRows = true;
            }
            if (place_Writer.Place_description != null)
            {
                web.DocumentText = place_Writer.Place_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
            }

            url = "http://94.230.164.34:8080/api/CommentPlace?id=" + place_Writer.Id_place;
            try
            {
                string response_comments = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                comments = JsonConvert.DeserializeObject<List<Comment_Place>>(response_comments);

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
        public PlaceForm(PlaceWork place_work)
        {
            InitializeComponent();
            place_Writer = null;

            place_Work = place_work;
            this.Cursor = Cursors.WaitCursor;

            var webClient = new WebClient();
            var webClient2 = new WebClient();
            string url = "http://94.230.164.34:8080/api/PicturePlace?id=" + place_work.Id_place;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);



            place_name_lbl.Text = place_Work.Place_name;
            adress_lbl.Text += place_Work.Place_address;
            rating_lbl.Text += place_Work.Place_rating;
            place_name_lbl.Left = 750 - place_name_lbl.Width / 2;
            adress_lbl.Left = 750 - adress_lbl.Width / 2;
            rating_lbl.Left = 750 - rating_lbl.Width / 2;
            if (MainForm.user != null)
            {
                mark_lbl.Visible = true;
                mark_combo.Visible = true;
                add_lbl.Visible = true;
                add_combo.Visible = true;
                data_comments.AllowUserToAddRows = true;
            }
            if (place_Work.Place_description != null)
            {
                web.DocumentText = place_Work.Place_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
            }

            url = "http://94.230.164.34:8080/api/CommentPlace?id=" + place_Work.Id_place;
            try
            {
                string response_comments = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                comments = JsonConvert.DeserializeObject<List<Comment_Place>>(response_comments);

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
                Mark_Of_Place newmark = new Mark_Of_Place();
                if (place_Writer != null)
                {
                    newmark.Id_place = place_Writer.Id_place;
                }
                else
                {
                    newmark.Id_place = place_Work.Id_place;
                }
                newmark.Id_user = MainForm.user.Id_user;
                newmark.Date = null;
                newmark.Time = null;
                newmark.Mark_of_place = Convert.ToDecimal(mark_combo.Text);
                newmark.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newmark);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/MarkOfPlace";
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
                if (pictures_count > 0)
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
                Messages.ErrorConnection();
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
                Comment_Place newcomment = new Comment_Place();
                newcomment.Id_comment = 0;
                if (place_Writer != null)
                {
                    newcomment.Id_place = place_Writer.Id_place;
                }
                else
                {
                    newcomment.Id_place = place_Work.Id_place;
                }
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
                string url = "http://94.230.164.34:8080/api/CommentPlace";
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
                Route_Place route_place = new Route_Place();
                route_place.Id_route = route_writer[add_combo.SelectedIndex].Id_route;
                route_place.Id_place = place_Writer.Id_place;
                route_place.Number_in_order = 1;
                string data = JsonConvert.SerializeObject(route_place);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/RoutePlace";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
                MessageBox.Show("Место добавлено в маршрут!", "Успех!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                Messages.ErrorRoutes();
            }
        }
    }
}
