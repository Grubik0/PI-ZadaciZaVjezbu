using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace ProvedbaISortiranjeTransakcija
{
    
    public partial class Popis : Form
    {
        public List<Transakcija> popis;
        public Popis()
        {
            InitializeComponent();
            Osvjezi();
        }

        private void Osvjezi()
        {
            popis = Banka.DohvatiPopisTransakcija();
            dgvPopis.DataSource = null;
            dgvPopis.DataSource = popis;
        }

        private void buttonStorno_Click(object sender, EventArgs e)
        {
            Banka.StornirajTransakciju(dgvPopis.CurrentRow.DataBoundItem as Transakcija);
            Osvjezi();
        }

        private void buttonProvedi_Click(object sender, EventArgs e)
        {
            var formProvedi = new Provedi();
            formProvedi.ShowDialog();
            Osvjezi();
        }
    }
}
