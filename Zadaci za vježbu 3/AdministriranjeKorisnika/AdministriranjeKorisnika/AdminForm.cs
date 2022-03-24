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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            Osvjezi();
            dgv_users.SelectionChanged += Promjena;
        }

        private void Promjena(object sender, EventArgs e)
        {
            if(dgv_users.CurrentRow.Cells[5].Value.ToString() == "Activated")
            {
                btn_a.Enabled = false;
                btn_d.Enabled = true;
            }
            else
            {
                btn_a.Enabled = true;
                btn_d.Enabled = false;
            }
        }

        private void Osvjezi()
        {
            List<User> lista = UsersRepository.GetUsers();
            dgv_users.DataSource = null;
            dgv_users.DataSource = lista;
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            User korisnik = dgv_users.CurrentRow.DataBoundItem as User;
            korisnik.Status = UserStatus.Activated;
            Osvjezi();
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            User korisnik = dgv_users.CurrentRow.DataBoundItem as User;
            korisnik.Status = UserStatus.Deactivated;
            Osvjezi();
        }
    }
}
