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

namespace AdministriranjeKorisnika
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            Autentificator.LoggedUser = null;
            Autentificator.LogIn(tb_user.Text, tb_pass.Text);
          
            if (Autentificator.LoggedUser == null){
                MessageBox.Show("You must be administrator to log in!");
                return;
            }
            else
            {
                tb_user.Text = "";
                tb_pass.Text = "";
            }

            var adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
