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
    public partial class UserProfile : Form
    {
        public User user;
        public UserProfile()
        {
            InitializeComponent();
            user = Autentificator.LoggedUser;

            textBoxFirst.Text = user.FirstName;
            textBoxLast.Text = user.LastName;
            textBoxUser.Text = user.UserName;
            textBoxPass.Text = user.Password;

            if (Convert.ToString(user.UserType) == "Administrator") radioButtonAdmin.Checked = true;
            else if (Convert.ToString(user.UserType) == "Guest") radioButtonGuest.Checked = true;
            else radioButtonEmp.Checked = true;

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Autentificator.LogOut();
            Close();
        }
    }
}
