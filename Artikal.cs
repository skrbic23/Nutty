using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutty2._0
{
    class Artikal
    {
        public Artikal(int cena, string naziv)
        {
            this.cena = cena;
            this.naziv = naziv;
        }
        public int cena { get; set; }
        public string naziv { get; set; }
    }
}
