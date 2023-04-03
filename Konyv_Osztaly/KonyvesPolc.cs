using Osztaly_Konyv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konyv_Osztaly
{
    public class KonyvesPolc
    {
       List<Konyv> _konyvek = new List<Konyv>();

        public void konyvHozzaAdasa(Konyv konyv)
        {
            _konyvek.Add(konyv);
        }

        public void konyvSelejtezese(Konyv konyv)
        {
                _konyvek.Remove(konyv);
        }
       //public KonyvesPolc() { } 
       public int konyvekSzama
        {
            get { return _konyvek.Count;}
        }

        public int KonyvekSzamaFugveny()
        {
            return _konyvek.Count;
        }
    }
}
