using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray.ArrayPools
{
    class MyArrayPool
    {
        public static void Test() 
        {
            ArrayPool<int> pool = ArrayPool<int>.Create(10000, 10);
            int arrayLength = 5;
            //租借
            var array = pool.Rent(arrayLength);
            Console.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine(array.Length);
            //归还
            pool.Return(array, false);
             
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //归还
            pool.Return(array, true);
            Console.WriteLine("归还");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void Shared()
        {
            ArrayPool<int> arrayPool = ArrayPool<int>.Shared;
            int[] array = arrayPool.Rent(16);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            Console.WriteLine(array.Length);

            arrayPool.Return(array);

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            //arrayPool.Return(array,true);

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            int[] array2 = arrayPool.Rent(14);

            foreach (var item in array2)
            {
                Console.WriteLine("array: "+ item);
            }
        }
    }
}
