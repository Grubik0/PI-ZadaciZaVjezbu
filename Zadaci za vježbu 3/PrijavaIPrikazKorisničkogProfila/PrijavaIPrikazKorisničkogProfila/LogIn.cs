using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutentifikacijaLib;

namespace PrijavaIPrikazKorisničkogProfila
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Username and password must be entered!");
                return;
            }
            else
            {
                Autentificator.LogIn(textBoxUser.Text, textBoxPass.Text);
                if(Autentificator.LoggedUser == null)
                {
                    MessageBox.Show("Entered credentials are not valid!");
                    Ocisti();
                    return;
                }
                else
                {
                    var formUser = new UserProfile();
                    formUser.ShowDialog();
                    Ocisti();
                }
            }
                
        }

        private void Ocisti()
        {
            textBoxUser.Text = "";
            textBoxPass.Text = "";
        }
    }
}
