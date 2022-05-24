using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
     class MyList<T> // ben MyList'imde T ile çalışıcam demek.  //List tarzı çalışıcaz
    {
        T[] items;

        //constructor  -- newlediğimiz anda çalışır
        public MyList()
        {
            items = new T[0]; // arrayi newlemek için 
        }

        public void Add(T item) 
        {
 
            T[] tempArry = items; // gecici olarak items arrayının referans numrasını tutturduk. çünlü newleyince referans numarası gider
            items = new T[items.Length+1]; // diziye yeni eleman eklemek için ama yeni referans numarası aldı

            for (int i = 0; i < tempArry.Length; i++)  //tempArrayden verileri geri almak için
            {
                items[i] = tempArry[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count // eleman sayısını öğrenmek için
        {
            get { return items.Length; }
        }

       

    }

}