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
    public partial class KreiranjeKarte : Form
    {
        public Linija OdabranaLinija;
        public KreiranjeKarte()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btOdaberi_Click(object sender, EventArgs e)
        {
            using(Linije form = new Linije())
            {
                var rez = form.ShowDialog();
                if(rez == DialogResult.OK)
                {
                    OdabranaLinija = form.OdabranaLinija;
                    tbPol.Text = OdabranaLinija.Polaziste;
                    tbOdr.Text = OdabranaLinija.Odrediste;
                    tbUd.Text = OdabranaLinija.Udaljenost.ToString();
                    tbAuto.Text = OdabranaLinija.Autoprijevoznik;
                }
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            VrstaKarte karta = new VrstaKarte();
            if (rbReg.Checked)
                karta = VrstaKarte.Regularna;
            else if (rbStud.Checked) karta = VrstaKarte.Studentska;
            else
            {
                MessageBox.Show("Odaberite vrstu karte!");
                return;
            }
            bool povratnaKarta = cbPovrat.Checked;
            bool prtljaga = cbPrtljaga.Checked;

            Karta novaKarta = new Karta(OdabranaLinija,karta,povratnaKarta,prtljaga);
            tbBroj.Text = novaKarta.BrojKarte.ToString();
            tbCijena.Text = novaKarta.Cijena.ToString();





        }
    }
}
