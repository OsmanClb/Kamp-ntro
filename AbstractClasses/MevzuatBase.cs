using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class MevzuatBase
    {
        public abstract void Degerlendir(); //Bu abstract classı kullanan classlar bu fonfsiyonu kendine göre değişik biçimde kullanabilir. (kullanmak zorunlu).

        public void Kaydet() // BU abstract classı kullanan claslarda bu metot hepsinde ortaktır ve aynıdır.
        {
            Console.WriteLine("kaydedildi");
        }
    }
}
