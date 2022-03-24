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

namespace FiltriranjeTransakcija
{
    public partial class Transakcije : Form
    {
        public List<Transakcija> popisTransakcija;
        Racun racun = new Racun();
        public Transakcije()
        {
            InitializeComponent();
        }

        private void Transakcije_Load(object sender, EventArgs e)
        {
            comboBoxRacuni.DataSource = Banka.DohvatiPopisRacuna();
            Ocisti();
        }

        private void Ocisti()
        {
            comboBoxRacuni.SelectedIndex = 0;
            radioButtonSve.Checked = true;
            radioButtonIsplate.Checked = false;
            radioButtonUplate.Checked = false;
            dgvIspis.DataSource = null;
        }

        private void buttonOcisti_Click(object sender, EventArgs e)
        {
            Ocisti();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            racun = comboBoxRacuni.SelectedItem as Racun;

            if (radioButtonSve.Checked) popisTransakcija = racun.DohvatiTransakcije();
            else if (radioButtonUplate.Checked) popisTransakcija = racun.DohvatiUplate();
            else if (radioButtonIsplate.Checked) popisTransakcija = racun.DohvatiIsplate();

            dgvIspis.DataSource = popisTransakcija;
        }

        private void buttonDetalji_Click(object sender, EventArgs e)
        {
            var formDetalji = new Detalji(racun);
            formDetalji.ShowDialog();
        }
    }
}
