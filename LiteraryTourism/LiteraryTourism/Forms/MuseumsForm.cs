/*
 * Museums form
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
    public partial class MuseumsForm : Form
    {
        List<MuseumWriter> museum_writer = new List<MuseumWriter>();
        string response;
        public MuseumsForm()
        {
            InitializeComponent();
            string name = search_writer_txt.Text;
            string museum_name = search_museum_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_museums.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Museums?name=" + name+"&museum_name="+museum_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
            /*
            label1.Text = MainForm.user.Nick;
            List<Users> users = new List<Users>();
            users.Add(new Users() { Id_user = 1, Login = "Log1", Password = "1234", Nick = "User1", User_type = "User" });
            users.Add(new Users() { Id_user = 2, Login = "Log2", Password = "1234", Nick = "User2", User_type = "User" });
            users.Add(new Users() { Id_user = 3, Login = "Log3", Password = "1234", Nick = "User3", User_type = "User" });
            users.Add(new Users() { Id_user = 4, Login = "Log4", Password = "1234", Nick = "User4", User_type = "User" });
            users.Add(new Users() { Id_user = 5, Login = "Log5", Password = "1234", Nick = "User5", User_type = "User" });
            mus_lv.Tag = users;
            mus_lv.Items.Clear();
            foreach(Users user in users)
            {
                var row = new string[] { user.Nick, user.Login, user.Password };
                var lvi = new ListViewItem(row);
                lvi.Tag = user;
                mus_lv.Items.Add(lvi);

            }*/
        }

        void DownloadDataCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            try
            {
                byte[] raw = e.Result;
                response = Encoding.UTF8.GetString(raw);
                museum_writer = JsonConvert.DeserializeObject<List<MuseumWriter>>(response);
                data_museums.Rows.Clear();
                for (int i = 0; i < museum_writer.Count; i++)
                {
                    data_museums.Rows.Add();
                    data_museums.Rows[i].Cells[0].Value = museum_writer[i].Museum_name;
                    data_museums.Rows[i].Cells[1].Value = museum_writer[i].Museum_site;
                    data_museums.Rows[i].Cells[2].Value = museum_writer[i].Museum_address;
                    data_museums.Rows[i].Cells[3].Value = museum_writer[i].Museum_rating;
                    data_museums.Rows[i].Cells[4].Value = museum_writer[i].Full_name;
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
                data_museums.Enabled = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string name = search_writer_txt.Text;
            string museum_name = search_museum_txt.Text;
            this.Cursor = Cursors.WaitCursor;
            search_btn.Enabled = false;
            data_museums.Enabled = false;

            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Museums?name=" + name + "&museum_name="+museum_name;

            webClient.DownloadDataCompleted += DownloadDataCompleted;
            webClient.DownloadDataTaskAsync(url);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(MainForm.user);
            mainForm.Show();
        }

        private void data_museums_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MuseumWriter museum = new MuseumWriter();
            museum = museum_writer[e.RowIndex];
            MuseumForm museum_form = new MuseumForm(museum);
            museum_form.Show();
        }


        /*private void mus_lv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedItems = (Users)mus_lv.SelectedItems[0].Tag;
            MessageBox.Show(selectedItems.Nick + selectedItems.Login);
        }*/

    }
}
