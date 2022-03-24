using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KucnaKnjiznicaLib2;

namespace KucnaKnjiznica2
{
    public partial class Form1 : Form
    {
        public Knjiznica knjiznica = new Knjiznica();
        public List<Posudba> listaKnjiga;
        public Posudba knjiga;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonSve.Checked = true;
            listaKnjiga = knjiznica.DohvatiSvePosudbe();
            dgvIspis.DataSource = listaKnjiga;
            Bojanje();
            dgvIspis.SelectionChanged += PromjenaRedka;
            
        }

        private void Osvjezi()
        {
            dgvIspis.DataSource = listaKnjiga;
            Bojanje();
        }

        private void PromjenaRedka(object sender, EventArgs e)
        {
            if ((Convert.ToBoolean(dgvIspis.CurrentRow.Cells[4].Value)) == true) buttonVrati.Enabled = false;
            else buttonVrati.Enabled = true;
        }

        private void Bojanje()
        {
            foreach (DataGridViewRow row in dgvIspis.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value) == true) row.DefaultCellStyle.BackColor = Color.Green;
                else row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void radioButtonSve_MouseClick(object sender, MouseEventArgs e)
        {
            listaKnjiga = knjiznica.DohvatiSvePosudbe();

            
            Osvjezi();
        }

        private void radioButtonTren_MouseClick(object sender, MouseEventArgs e)
        {
            listaKnjiga = knjiznica.DohvatiTrenutnePosudbe();
            Osvjezi();
        }

        private void radioButtonProsle_MouseClick(object sender, MouseEventArgs e)
        {
            listaKnjiga = knjiznica.DohvatiProslePosudbe();
            Osvjezi();
        }

        private void buttonVrati_Click(object sender, EventArgs e)
        {
            knjiga = dgvIspis.CurrentRow.DataBoundItem as Posudba;
            knjiznica.VratiKnjigu(knjiga);
            Osvjezi();
        }
    }
}
