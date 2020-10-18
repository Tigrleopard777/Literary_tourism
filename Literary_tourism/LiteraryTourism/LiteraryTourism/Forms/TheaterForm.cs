/*
 * Theateer form
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
    public partial class TheaterForm : Form
    {
        Theaters Theater = new Theaters();
        List<Pictures> pictures = new List<Pictures>();
        string response;
        int pictures_count = 0;
        int picture_num = 0;
        public TheaterForm(Theaters theater)
        {
            InitializeComponent();
            Theater = theater;
            this.Cursor = Cursors.WaitCursor;

            var webClient = new WebClient();
            var webClient2 = new WebClient();
            string url = "http://94.230.164.34:8080/api/PictureTheater?id=" + Theater.Id_theater;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);

            theater_name_lbl.Text = Theater.Theater_name;
            site_lbl.Text = Theater.Theater_site;
            address_lbl.Text += Theater.Theater_address;
            theater_name_lbl.Left = 750 - theater_name_lbl.Width / 2;
            site_lbl.Left = 750 - site_lbl.Width / 2;
            address_lbl.Left = 750 - address_lbl.Width / 2;
            if (Theater.Theater_description != null)
            {
                web.DocumentText = Theater.Theater_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
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
    }
}
