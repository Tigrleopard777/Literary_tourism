/*
 * Registration form
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
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace LiteraryTourism
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_txt.Text) || string.IsNullOrWhiteSpace(login_txt.Text))
            {
                MessageBox.Show("Поле логин не заполнено!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(pass_txt.Text) || string.IsNullOrWhiteSpace(pass_txt.Text))
                {
                    MessageBox.Show("Поле пароль не заполнено!", "Ошибка!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (string.IsNullOrEmpty(confirm_pass_txt.Text) || string.IsNullOrWhiteSpace(confirm_pass_txt.Text))
                    {
                        MessageBox.Show("Поле подтверждения пароля не заполнено!", "Ошибка!",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (confirm_pass_txt.Text!=pass_txt.Text)
                        {
                            MessageBox.Show("Пароли не совпадают!", "Ошибка!",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(nick_txt.Text) || string.IsNullOrWhiteSpace(nick_txt.Text))
                            {
                                MessageBox.Show("Поле ник не заполнено!", "Ошибка!",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                this.Cursor = Cursors.WaitCursor;
                                Users reg_user = new Users();
                                reg_user.Id_user = 0;
                                reg_user.Login = login_txt.Text;
                                reg_user.Password = pass_txt.Text;
                                reg_user.Nick = nick_txt.Text;
                                reg_user.User_type = "User";
                                try
                                {
                                    string data = JsonConvert.SerializeObject(reg_user);
                                    Users user = new Users();
                                    var webClient = new WebClient();
                                    webClient.Encoding = System.Text.Encoding.UTF8;
                                    string url = "http://94.230.164.34:8080/api/Users";
                                    webClient.Headers[HttpRequestHeader.ContentType] = "application/json";
                                    string response = webClient.UploadString(url, data);
                                    if (response.Length != 2)
                                    {
                                        user = JsonConvert.DeserializeObject<Users>(response);
                                        MessageBox.Show(user.Nick, "Пользователь зарегистрирован!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Cursor = Cursors.Default;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Возможно пользователь с таким логином или ником уже существует!", "Ошибка регистрации!",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Cursor = Cursors.Default;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Возможно пользователь с таким логином или ником уже существует!", "Ошибка регистрации!",
                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Cursor = Cursors.Default;
                                }
                            }
                        }
                    }
                }
            }
            

        }

        private void auth_lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.Show();
        }
    }
}
