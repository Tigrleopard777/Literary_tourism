/*
 * Work form
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
    public partial class WorkForm : Form
    {
        WorkWriter work_Writer = new WorkWriter();
        List<Comment_Work> comments = new List<Comment_Work>();
        public WorkForm(WorkWriter work_writer)
        {
            InitializeComponent();
            work_Writer = work_writer;

            var webClient = new WebClient();
            var webClient2 = new WebClient();

            work_name_lbl.Text = work_Writer.Work_name;
            writer_lbl.Text = work_Writer.Full_name;
            link_lbl.Text = work_Writer.Work_link;
            rating_lbl.Text += work_Writer.Work_rating;
            work_name_lbl.Left = 750 - work_name_lbl.Width / 2;
            writer_lbl.Left = 750 - writer_lbl.Width / 2;
            link_lbl.Left = 750 - link_lbl.Width / 2;
            rating_lbl.Left = 750 - rating_lbl.Width / 2;
            if (MainForm.user != null)
            {
                mark_lbl.Visible = true;
                mark_combo.Visible = true;
                data_comments.AllowUserToAddRows = true;
            }
            if (work_Writer.Work_description != null)
            {
                web.DocumentText = work_Writer.Work_description;
            }
            else
            {
                web.DocumentText = Description.empty_description;
            }

            string url = "http://94.230.164.34:8080/api/CommentWork?id=" + work_Writer.Id_work;
            try
            {
                string response_comments = Encoding.UTF8.GetString(webClient2.DownloadData(url));
                comments = JsonConvert.DeserializeObject<List<Comment_Work>>(response_comments);

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
        }

        private void mark_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Mark_Of_Work newmark = new Mark_Of_Work();
                newmark.Id_work = work_Writer.Id_work;
                newmark.Id_user = MainForm.user.Id_user;
                newmark.Date = null;
                newmark.Time = null;
                newmark.Mark_of_work = Convert.ToDecimal(mark_combo.Text);
                newmark.Edit_flag = false;
                string data = JsonConvert.SerializeObject(newmark);
                var webClient = new WebClient();
                webClient.Encoding = System.Text.Encoding.UTF8;
                string url = "http://94.230.164.34:8080/api/MarkOfWork";
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
                Comment_Work newcomment = new Comment_Work();
                newcomment.Id_comment = 0;
                newcomment.Id_work = work_Writer.Id_work;
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
                string url = "http://94.230.164.34:8080/api/CommentWork";
                webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                string response = webClient.UploadString(url, data);
            }
            catch
            {

            }
        }
    }
}
