using MyArray.ArrayPools;
using MyArray.MySpan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyArrayPool.Test();

            //MyArrayPool.Shared();

            //MySpan.MySpan.Test();
            MySpan.MySpan.TestSlice();

            Console.ReadKey();
        }
    }
}
