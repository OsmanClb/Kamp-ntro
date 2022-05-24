using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" }; //diziler ilk verilen değerlerle çalışılır
            //Console.WriteLine(isimler[0]);                                          //sonradan fazla deger eklenmez.
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; // new dediğimiz için yeni array oluşturdu 
            //isimler[4] = "ilker";    //sadece 4.elemanı dolu diğerleri boş
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlker"); // ekleme komutu Add  

            Console.WriteLine(isimler2[4]);

            Console.WriteLine(isimler2[0]);



        }
    }
}