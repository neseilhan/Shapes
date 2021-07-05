
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes

{
   
    public partial class Form1 : Form
    {
        DikUcgen dikucgen;
        Daire daire;
        Dikdörtgen dikdörtgen;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

       

        private void bUcgen_Click(object sender, EventArgs e)
        {
              dikucgen = new DikUcgen()
            {
                Kenar = Convert.ToInt32(tbucgenkenar.Text),
                Yükseklik = Convert.ToInt32(tbucgenyukseklik.Text)

             };
            MessageBox.Show("Degerler alindi.");

        }
        private void bucgengetir_Click(object sender, EventArgs e)
        {
            string sonuc2 = "";
            sonuc2 += "Dikücgen Alan: " + dikucgen.AlanHesapla().ToString() + "\n";
            sonuc2 += "Dikücgen Çevre: " + dikucgen.CevreHesapla().ToString() + "\n";
            rtbucgen.Text = sonuc2.Trim();

        }

        private void bDaire_Click(object sender, EventArgs e)
        {
            daire = new Daire()
            {
                yaricap = Convert.ToInt32(tbyarıcap.Text),

            };
            MessageBox.Show("Degerler alindi.");
        }
        private void bdairegetir_Click(object sender, EventArgs e)
        {
            string sonuc3 = "";
            sonuc3 += "Daire Alan: " + daire.AlanHesapla().ToString() + "\n";
            sonuc3 += "Daire Çevre: " + daire.CevreHesapla().ToString() + "\n";
            rtbdaire.Text = sonuc3;
        }

        private void bDikdörtgen_Click(object sender, EventArgs e)
        {
            dikdörtgen = new Dikdörtgen()
            {
                KısaKenar = Convert.ToInt32(tbkarekenar.Text),
                UzunKenar = Convert.ToInt32(tbkareyukseklik.Text)
            };
            MessageBox.Show("Degerler alindi.");
        }

        private void bdikdörtgengetir_Click(object sender, EventArgs e)
        {
            string sonuc1 = "";
            sonuc1 += "Dikdörtgen Alan: " + dikdörtgen.AlanHesapla().ToString() + "\n";
            sonuc1 += "Dikdörtgen Çevre: " + dikdörtgen.CevreHesapla().ToString() + "\n";
            rtbdikdörtgen.Text = sonuc1;
        }

        
    }
}
