/*
 * Main form
 * contains the main menu
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

namespace LiteraryTourism
{
    public partial class MainForm : Form
    {
        public static Users user = new Users();

        public MainForm()
        {
            InitializeComponent();
            user = null;
        }

        public MainForm(Users user_auth)
        {
            InitializeComponent();
            user = user_auth;
            if(user.User_type=="Admin")
            {
                reg_btn.Visible = true;
            }
        }


        private void routes_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoutesForm routes_form = new RoutesForm();
            routes_form.Show();
        }


        private void movies__btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoviesForm movies_form = new MoviesForm();
            movies_form.Show();
        }

        private void works_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorksForm works_form = new WorksForm();
            works_form.Show();
        }

        private void spectacles_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SpectaclesForm spectacles_form = new SpectaclesForm();
            spectacles_form.Show();
        }

        private void museums_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MuseumsForm museums_form = new MuseumsForm();
            museums_form.Show();
        }

        private void places_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlacesForm places_form = new PlacesForm();
            places_form.Show();
        }

        private void theaters_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TheatersForm theaters_form = new TheatersForm();
            theaters_form.Show();
        }

        private void writers_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WritersForm writers_form = new WritersForm();
            writers_form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void places_works_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlacesWorksForm places_works_form = new PlacesWorksForm();
            places_works_form.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            user = null;
            this.Hide();
            AuthForm auth_form = new AuthForm();
            auth_form.Show();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm reg_form = new RegistrationForm();
            reg_form.Show();
        }
    }
}
