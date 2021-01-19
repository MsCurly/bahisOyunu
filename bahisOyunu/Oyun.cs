using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bahisOyunu
{
    public class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu IkinciOyuncu { get; set; }


        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkinciOyuncuZarAt()
        {
            IkinciOyuncu.Oyna();
        }

        public Oyuncu Karsilastir()
        {
            
                if (BirinciOyuncu.OyuncununZari.Deger > IkinciOyuncu.OyuncununZari.Deger)
                {
                    BirinciOyuncu.Bakiye += IkinciOyuncu.Bahis;
                    IkinciOyuncu.Bakiye -= IkinciOyuncu.Bahis;
                    return BirinciOyuncu;
                }
                else if (BirinciOyuncu.OyuncununZari.Deger < IkinciOyuncu.OyuncununZari.Deger)
                {
                    IkinciOyuncu.Bakiye += BirinciOyuncu.Bahis;
                    BirinciOyuncu.Bakiye -= BirinciOyuncu.Bahis;
                    return IkinciOyuncu;
                   }
                else
                {
                    return null;
                }
            
            return BirinciOyuncu;
        }

    }
}
