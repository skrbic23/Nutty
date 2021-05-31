using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutty2._0
{
    public partial class Racun : Form
    {
        Pica pica = new Pica();
        Jelo jela = new Jelo();
        Desert desert = new Desert();
        public Racun()
        {
            InitializeComponent();
        }
        Form opener;

        public Racun (Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opener.Close();
            this.Close();
        }

        private void Racun_Load(object sender, EventArgs e)
        {
            Artikal espreso = new Artikal(120, "Espreso");
            Artikal naranga = new Artikal(200, "Cedjena naracga");
            Artikal domaca = new Artikal(90, "Domaca kafa");
            Artikal kola = new Artikal(110, "Kola");
            Artikal kapricoza = new Artikal(450, "Kapricoza");
            Artikal margarita = new Artikal(400, "Margarita");
            Artikal tortajagode = new Artikal(180, "Torta sa jagodama");
            Artikal piletina4 = new Artikal(350, "piletina sa 4 vrste sira");
            Artikal piletinagorgonzola = new Artikal(450, "piletina u gorgonzola sosu");
            Artikal pirekesten = new Artikal(180, "Pire od kestena");
            Artikal pacetinavisnja = new Artikal(580, "Pacije grudi u sosu od visanja");
            Artikal kuglicevoce = new Artikal(240, "Vocnje kuglice");
            pica.DodajPice(espreso);
            pica.DodajPice(naranga);
            pica.DodajPice(domaca);
            pica.DodajPice(kola);
            jela.DodajJelo(kapricoza);
            jela.DodajJelo(margarita);
            jela.DodajJelo(kapricoza);
            jela.DodajJelo(piletina4);
            jela.DodajJelo(piletinagorgonzola);
            jela.DodajJelo(pacetinavisnja);
            desert.DodajDesert(tortajagode);
            desert.DodajDesert(pirekesten);
            desert.DodajDesert(kuglicevoce);

            foreach (var item in pica.Pice)
            {
                Pica.Items.Add(item.naziv);
            }
            foreach (var item in jela.Jela)
            {
                Jelo.Items.Add(item.naziv);
            }
            foreach (var item in desert.Deserti)
            {
                Desert.Items.Add(item.naziv);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0, racun = 0;

            for (i = 0; i <= Pica.Items.Count-1; i++)
            {
                if (Pica.GetItemChecked(i))
                {
                    racun += pica.NadjiCenu(Pica.Items[i].ToString());
                }
            }
            for (i = 0; i <= Jelo.Items.Count - 1; i++)
            {
                if (Jelo.GetItemChecked(i))
                {
                    string str = Jelo.Items[i].ToString();
                    racun += jela.NadjiCenu(str);
                }
            }
            for (i = 0; i <= Desert.Items.Count - 1; i++)
            {
                if (Desert.GetItemChecked(i))
                {
                    string str = Pica.Items[i].ToString();
                    racun += desert.NadjiCenu(str);
                }
            }
            MessageBox.Show(racun.ToString());
        }
    }
}
