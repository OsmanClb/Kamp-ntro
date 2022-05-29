using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface = belirlenen şablona uymalısın demek, kuralları içerir  //IKrediManager referans tutuyor ve yapılması zorunlu seyleri belirler
    //interfaceleri birbirlerinin alternatifi olan fakat kod içerikleri farklı olan durumlarda kullanırız.
    interface IKrediManager
    {
        void Hesapla();
        void BiseyYap();
    }
}
