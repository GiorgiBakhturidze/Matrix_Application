using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Push Enter . . .");
            Console.ReadLine();
            Random r = new Random();
            while (true)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(0,16);
                int i = r.Next(0,2);
                Console.Write(i + "   ");
            }
            Console.ReadLine();
        }
    }
}
