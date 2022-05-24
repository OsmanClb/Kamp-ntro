using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class My_Dictionary<T, U>  //generic class
    {
        T[] array1;
        U[] array2;

       public My_Dictionary()  // newleyince çalışıyor. //ctor kısa yolu
       {
            array1 = new T[0];
            array2 = new U[0];
       }
        
        public void Add(T item1,U item2)
        {

            T[] tempArray1 = array1;  //geçici arraye referans numarı tutturduk.
            U[] tempArray2 = array2;


            array1 = new T[array1.Length + 1];  // dizinin eleman sayısını bir arttırdık ama referans numarası değişti.
            array2 = new U[array2.Length + 1]; // Bunun çözümü için eski degerleri tutan geçici array yapmamız lazım.

            for (int i = 0; i < tempArray1.Length; i++) //tempArrayden verileri geri almak için
            {
                array1[i] = tempArray1[i];

            }
            for (int i = 0; i < tempArray2.Length; i++) //tempArrayden verileri geri almak için
            {
                array2[i] = tempArray2[i];

            }

            array1[array1.Length - 1] = item1;
            array2[array2.Length - 1] = item2;

        }

        public T[] Array // array1 e ulaşmak için yaptığımız metot
        {
            get { return array1; }
        }

        public U[] Array2 // array2 e ulaşmak için yaptığımız metot
        {
            get { return array2; }
        }


    }
}
