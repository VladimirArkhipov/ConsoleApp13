using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0;true; i++)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                Console.WriteLine((byte)key.KeyChar);
                //лох
            }
        }
    }
}
