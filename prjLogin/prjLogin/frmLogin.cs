using prjLogin.DA;
using prjLogin.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //we maken een object van de model en dat gaan we gebruiken voor de validatie van de gegevens
            Login L = new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            bool login = LoginDA.LoginValidate(L);

            //controleren of de login true is
            if (login) {
                this.Hide();
                frmIngelogd frmIngelogd = new frmIngelogd();
                frmIngelogd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Foutieve combinatie!");
            }
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            Login L = new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            LoginDA.Register(L);
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Login L =new Model.Login();

            L.Username = txtNaam.Text;
            L.Password = txtWachtwoord.Text;

            if (LoginDA.LoginValidate(L)) { 
                LoginDA.Delete(L);
            }
            else
            {
                MessageBox.Show("De combinatie van gebruikersnaam en wachtwoord is niet geldig. Er werd geen account verwijderd.");
            }
        }
    }
}
