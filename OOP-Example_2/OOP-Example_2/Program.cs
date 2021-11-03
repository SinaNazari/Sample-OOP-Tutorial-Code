using System;
using System.Collections.Generic;

namespace OOP_Example_2
{
    class Program
    {
        static void Main(string[] args)


        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 10, 11, 12, 13, 14, 15, 20, 21, 22, 23, 24, 25 };
            //bool isTrue = numbers is IEnumerable<int>;

            //foreach (var n in numbers)
            //{
            //    Console.WriteLine(n);
            //}

            var x = numbers.GetEnumerator();
            //bool test = x.MoveNext();
            //int z = x.Current;
            //bool test1 = x.MoveNext();
            //int z1 = x.Current;
            //bool test2 = x.MoveNext();
            //int z3 = x.Current;



            while (x.MoveNext())
            {
                Console.WriteLine(x.Current);
            }
        }
    }
}
