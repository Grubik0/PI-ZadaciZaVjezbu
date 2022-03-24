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
    public partial class Kupnja : Form
    {
        Linija odabrana;
        AutobusniKolodvor kolodvor;
        Karta kupljenaKarta;
        public Kupnja(Linija linija)
        {
            InitializeComponent();
            kolodvor = new AutobusniKolodvor();
            odabrana = linija;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            VrstaKarte karta = new VrstaKarte();
            if (cbVrsta.SelectedIndex == 0) karta = VrstaKarte.Regularna;
            else karta = VrstaKarte.Studentska;

            Karta kupljenaKarta = kolodvor.KupiKartu(odabrana, karta, cbPovrat.Checked, cbPrtljaga.Checked);

            string povratna = "";
            string prtljaga = "";
            
            if (cbPovrat.Checked) povratna = "Da";
            else povratna = "Ne";

            if (cbPrtljaga.Checked) prtljaga = "Da";
            else prtljaga = "Ne";

            tbIspis.Text = $"Broj karte: {kupljenaKarta.BrojKarte} {Environment.NewLine}" +
                $"Relacija: {kupljenaKarta.Linija.Polaziste}-{kupljenaKarta.Linija.Odrediste} {Environment.NewLine}" +
                $"Udaljenost: {kupljenaKarta.Linija.Udaljenost} {Environment.NewLine}" +
                $"Autoprijevoznik: {kupljenaKarta.Linija.Autoprijevoznik} {Environment.NewLine}" +
                $"Vrsta karte: {kupljenaKarta.Vrsta} {Environment.NewLine}" +
                $"Povratna karta: {povratna} {Environment.NewLine}" +
                $"Naplati prtljagu: {prtljaga} {Environment.NewLine}" +
                $"---------------- {Environment.NewLine}" +
                $"Cijena karte: {kupljenaKarta.Cijena} kn";
        }
    }
}
