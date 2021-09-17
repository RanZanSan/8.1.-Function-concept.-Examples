using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleFunctionThatReturnsValues
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        static void Main(string[] args)
        {
            int a = 3, b = 6;
            int sum = Sum(a, b); // 9
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}