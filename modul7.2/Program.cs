using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7._2
{
    public class MyClass
    {
        private int[] array;

        public MyClass(int[] arr)
        {
            array = arr;
        }

        // Сумма элементов массива
        public int Sum()
        {
            return array.Sum();
        }

        public static bool operator <(MyClass a, MyClass b)
        {
            return a.Sum() < b.Sum();
        }

        public static bool operator >(MyClass a, MyClass b)
        {
            return a.Sum() > b.Sum();
        }
    }
}