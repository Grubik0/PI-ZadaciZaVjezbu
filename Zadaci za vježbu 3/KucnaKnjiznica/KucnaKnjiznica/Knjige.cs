using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib;

namespace KucnaKnjiznica
{
    public partial class Knjige : Form
    {
        public List<Knjiga> dostupno;
        public List<Knjiga> posudba;
        public static Knjiznica knjiznica = new Knjiznica();
        public Knjige()
        {
            InitializeComponent();
        }

        private void Knjige_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dostupno = knjiznica.DohvatiDostupneKnjige();
            posudba = knjiznica.DohvatiKnjigeNaPosudbi();
            dgvDostupno.DataSource = dostupno;
            dgvPosudba.DataSource = posudba;
        }

        private void buttonPosudi_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = dgvDostupno.CurrentRow.DataBoundItem as Knjiga;
            var formPosudba = new Posudba(knjiga);
            formPosudba.ShowDialog();
            Osvjezi();
        }

        private void buttonVrati_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = dgvPosudba.CurrentRow.DataBoundItem as Knjiga;
            knjiznica.VratiKnjigu(knjiga);
            Osvjezi();
        }
    }
}
