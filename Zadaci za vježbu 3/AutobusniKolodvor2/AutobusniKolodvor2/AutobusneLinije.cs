using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace AutobusniKolodvor2
{
    public partial class AutobusneLinije : Form
    {
        public AutobusniKolodvor kolodvor = new AutobusniKolodvor();
        public List<Linija> lista = new List<Linija>();
        public AutobusneLinije()
        {
            InitializeComponent();
        }

        private void AutobusneLinije_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            lista = kolodvor.DohvatiLinije();
            dgvLinije.DataSource = null;
            dgvLinije.DataSource = lista;
        }



        private void dgvLinije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(tbFilter.Text == "")
            {
                Osvjezi();
            }
            else
            {
                lista = kolodvor.DohvatiLinije(tbFilter.Text);
                dgvLinije.DataSource = lista;
            }
            
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            Kupnja formKupnja = new Kupnja(dgvLinije.CurrentRow.DataBoundItem as Linija);
            
            formKupnja.ShowDialog();
            Close();

        }
    }
}
