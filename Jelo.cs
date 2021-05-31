using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutty2._0
{
    class Jelo
    {
        public List<Artikal> Jela = new List<Artikal>();
        public void DodajJelo(Artikal artikal)
        {
            Jela.Add(artikal);
        }
        public void izbaciJelo(string str)
        {
            foreach (var item in Jela)
            {
                if (item.naziv == str)
                {
                    Jela.Remove(item);
                }
            }
        }
        public int NadjiCenu(string str)
        {
            foreach (var item in Jela)
            {
                if (item.naziv == str)
                {
                    return item.cena;
                }
            }
            return 0;
        }
    }
}
