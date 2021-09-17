using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exampleFunctionNotReturnValue
{
    class Program
    {
        static void Hello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        static void Main(string[] args)
        {
            string name = "Саша";
            Hello(name); // Вызов функции
            Console.ReadKey();
        }
    }
}