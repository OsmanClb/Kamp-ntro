using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Basvuran bilgilerini degerlendirme

            krediManager.Hesapla(); //gelen bilgiye göre doğru hesaplama yapar.
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //birden fazla kredinin hesabı yapılır
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
