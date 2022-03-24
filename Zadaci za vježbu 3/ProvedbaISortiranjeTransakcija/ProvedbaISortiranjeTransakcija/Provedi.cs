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
    public partial class Provedi : Form
    {
        public Provedi()
        {
            InitializeComponent();
            List<Racun> popisRacuna1 = Banka.DohvatiPopisRacuna();
            List<Racun> popisRacuna2 = Banka.DohvatiPopisRacuna();
            comboBoxPlatitelj.DataSource = popisRacuna1;
            comboBoxPrimatelj.DataSource = popisRacuna2;
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProvedi_Click(object sender, EventArgs e)
        {
            Banka.ProvediTransakciju(comboBoxPlatitelj.SelectedItem as Racun, comboBoxPrimatelj.SelectedItem as Racun, Convert.ToInt32(textBoxIznos.Text));
            Close();
        }
    }
}
