using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Muğla");
            sehirler.Add("Antalya");
            sehirler.Add("İstanbul");
            sehirler.Add("Bursa");
            sehirler.Add("Adana");
            sehirler.Add("Malatya");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Ankara");
            sehirler2.Add("İstanbul");
            sehirler2.Add("Antalya");
            sehirler2.Add("Bursa");
            sehirler2.Add("İzmir");
            sehirler2.Add("Adana");
            sehirler2.Add("Adıyaman");
            Console.WriteLine(sehirler2.Count);

            MyList<int> sayilar = new MyList<int>();
            sayilar.Add(31);
        }
    }
    class MyList<T> //Generic Class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
        }

    }
}
