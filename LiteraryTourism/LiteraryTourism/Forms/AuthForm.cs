/*
 * Authorization form
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using LiteraryTourism.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace LiteraryTourism
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Users user = new Users();
            var webClient = new WebClient();
            string url = "http://94.230.164.34:8080/api/Users?log=" + login_txt.Text+"&pass="+pass_txt.Text;
            try
            {
                // string response = webClient.DownloadString(url);
                string response = Encoding.UTF8.GetString(webClient.DownloadData(url));
               // byte[] utfResponse = Encoding.UTF8.GetBytes(response);
               // response = Encoding.UTF8.GetString(utfResponse);
                if (response.Length != 2)
                {
                    user = JsonConvert.DeserializeObject<Users>(response.Substring(1, response.Length - 2));
                    //Nick_lbl.Text = user.Nick;
                    //this.Cursor = Cursors.Default;
                    this.Hide();
                    MainForm main_form = new MainForm(user);
                    main_form.Show();
                }
                else
                {
                    Messages.ErrorAuth();
                    //this.Cursor = Cursors.Default;
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

        private void go_reg_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void GoMain_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MainForm main_form = new MainForm();
            main_form.Show();
        }

        private void Reg_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm reg_form = new RegistrationForm();
            reg_form.Show();
        }

        private void AuthForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
