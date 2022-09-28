using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Amevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("A Mevzuatına göre değerlendirildi...");
        }
    }
}
