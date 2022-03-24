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
    public partial class Detalji : Form
    {
        public Detalji(Racun racun)
        {
            InitializeComponent();
            textBoxIBAN.Text = racun.IBAN;
            textBoxVlasnik.Text = racun.Vlasnik;
            textBoxStanje.Text = racun.Stanje.ToString();
            textBoxPromet.Text = racun.IzracunajUkupanPromet().ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
