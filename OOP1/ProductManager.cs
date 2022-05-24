using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class ProductManager
    {
        public void Add(Product product)  //Add = ekleme  // 101 numaralı adresi parametre olarak aldı.
        {
            Console.WriteLine(product.ProductName + "Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }

        
    }
}
