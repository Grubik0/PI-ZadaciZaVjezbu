using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace AutobusniKolodvor1
{
    public partial class Linije : Form
    {
        public Linija OdabranaLinija;
        public Linije()
        {
            InitializeComponent();
        }

        private void Osvjezi()
        {
            List<Linija> lista = AutobusniKolodvor.DohvatiLinije();
            dgvLinije.DataSource = null;
            dgvLinije.DataSource = lista;
        }

        private void Linije_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            OdabranaLinija = dgvLinije.CurrentRow.DataBoundItem as Linija;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
