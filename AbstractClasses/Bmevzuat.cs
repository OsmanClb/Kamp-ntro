using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Bmevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("b mevzuatına göre değerlendirildi...");       
        }
    }
}
