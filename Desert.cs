using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutty2._0
{
    class Desert
    {
        public List<Artikal> Deserti = new List<Artikal>();
        public void DodajDesert(Artikal artikal)
        {
            Deserti.Add(artikal);
        }
        public void izbaciDesert(string str)
        {
            foreach (var item in Deserti)
            {
                if (item.naziv == str)
                {
                    Deserti.Remove(item);
                }
            }
        }
        public int NadjiCenu(string str)
        {
            foreach (var item in Deserti)
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
