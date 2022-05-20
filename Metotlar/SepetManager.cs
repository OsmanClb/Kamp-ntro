using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //name convention
        //syntax

        public void Ekle(Urun urun) // metot oluşturduk.  Urun = veri tipi   urun = parametre (metot içinde kullanmak için)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
