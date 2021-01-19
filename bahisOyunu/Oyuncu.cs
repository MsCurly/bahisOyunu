using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahisOyunu
{
    public class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Zar OyuncununZari { get; set; }
        public int Bahis { get; set; }
        public int Bakiye { get; set; }
        


        public void Oyna()
        {
            OyuncununZari.At();
        }
      
        public Oyuncu(string ad)
        {
            Ad = ad;
            //Bakiye = 100;
        }

        public Oyuncu(int bahis)
        {
            Bahis = bahis;
            Bakiye = 100;

        }

    }
}
