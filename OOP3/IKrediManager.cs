using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface = belirlenen şablona uymalısın demek, kuralları içerir  //IKrediManager referan tutuyor ve yapılması zorunlu seyleri belirler
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
