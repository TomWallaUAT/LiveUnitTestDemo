using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUnitTestDemo
{
    public class Program
    {
        private static string[] VNL = { "John", "Jacob", "JingleHeimer","Schmidt"};

        public static void Main()
        {
            Console.WriteLine("Live Unit Test Demo");
        }

        public static string[] GiveData()
        {
            return VNL;
        }

        public static int MultiplyValues(int a, int b)
        {
            return a * b;
        }
    }
}
