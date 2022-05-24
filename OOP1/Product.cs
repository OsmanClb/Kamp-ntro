using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet - hazır kodlar

     class Product   // özellik sınıfı          //product = ürün 
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; } // ürün ismi
        
        public double UnitPrice { get; set; }  //ürün birim fiyat
        
        public int UnitsInStock { get; set; }  //ürün stok

        //CRUD = eklemek,okumak,güncellemek,silmek


    }
}
