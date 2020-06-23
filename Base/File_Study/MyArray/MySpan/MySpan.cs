using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray.MySpan
{
    class MySpan
    {
        public static void Test() 
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(arr[1]);

            Span<int> span = new Span<int>(arr);

            span[1] = 10;

            Console.WriteLine($"legth:{span.Length}  " +arr[1]);

            foreach (var item in span)
            {
                Console.WriteLine(item);
            }

            span.Clear();

            Console.WriteLine("span.Clear");
            foreach (var item in span)
            {
                Console.WriteLine(item);
            }
        }

        public static void TestSlice()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Span<int> span = new Span<int>(arr, 3, 6);

            Console.WriteLine($"span legth:{span.Length}  " + span[1]);

            foreach (var item in span)
            {
                Console.WriteLine(item);
            }

            var span2 = span.Slice(2);

            foreach (var item in span2)
            {
                Console.WriteLine("span2: "+ item);
            }

            span2.Clear();

            span.Fill(10);
            foreach (var item in span)
            {
                Console.WriteLine("span1: " + item);
            }

            span2.Fill(10);
            //foreach (var item in span2)
            //{
            //    Console.WriteLine("span2: " + item);
            //}
        }
    }
}
