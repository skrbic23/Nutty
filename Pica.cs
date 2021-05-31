using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutty2._0
{
    class Pica
    {
        public List<Artikal> Pice = new List<Artikal>();
        public void DodajPice(Artikal artikal)
        {
            Pice.Add(artikal);
        }
        public void izbaciPice(string str)
        {
            foreach (var item in Pice)
            {
                if (item.naziv == str)
                {
                    Pice.Remove(item);
                }
            }
        }
        public int NadjiCenu(string str)
        {
            foreach (var item in Pice)
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
