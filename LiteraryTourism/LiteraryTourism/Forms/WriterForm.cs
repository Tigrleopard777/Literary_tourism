/*
 * Writer form
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
    public partial class WriterForm : Form
    {
        Writers Writer = new Writers();
        List<Pictures> pictures = new List<Pictures>();
        string response;
        int pictures_count = 0;
        int picture_num = 0;
        public WriterForm(Writers writer)
        {
            InitializeComponent();
            Writer = writer;
            this.Cursor = Cursors.WaitCursor;

            var webClient = new WebClient();
            var webClient2 = new WebClient();
            string url = "http://94.230.164.34:8080/api/PictureWriter?id=" + Writer.Id_writer;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);

            writer_name_lbl.Text = Writer.Full_name;
            date_of_birth_lbl.Text = Writer.Date_of_birth.Value.Day.ToString()+"."+ Writer.Date_of_birth.Value.Month.ToString()+"."+Writer.Date_of_birth.Value.Year.ToString();
            date_of_death_lbl.Text = Writer.Date_of_death.Value.Day.ToString() + "." + Writer.Date_of_death.Value.Month.ToString() + "." + Writer.Date_of_death.Value.Year.ToString();
            place_of_birth_lbl.Text += Writer.Place_of_birth;
            place_of_death_lbl.Text += Writer.Place_of_death;
            writer_name_lbl.Left = 750 - writer_name_lbl.Width / 2;
            date_of_birth_lbl.Left = 750 - date_of_birth_lbl.Width / 2;
            date_of_death_lbl.Left = 750 - date_of_death_lbl.Width / 2;
            place_of_birth_lbl.Left = 750 - place_of_birth_lbl.Width / 2;
            place_of_death_lbl.Left = 750 - place_of_death_lbl.Width / 2;
            if (Writer.Biography != null)
            {
                web.DocumentText = Writer.Biography;
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
