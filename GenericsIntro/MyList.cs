using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T yerine string, int, product vs. de yazabilirdik. ihtiyaca göre değişir.
    {
        T[] items;

        //constructor (aşağısı) class'ı new'leyince çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi referans adresi oluşşturduk. önceki elemanlar kaybolmasın diye
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
       
    }
}
