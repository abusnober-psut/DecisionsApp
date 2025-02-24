using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int n1 = int.Parse( Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            /*
             Decision in C#:
                if-else
                cond. statement
                switch case
             */
            if (n1 > n2)
                Console.WriteLine($"{n1} is greater than {n2}");
            else
                Console.WriteLine($"{n2} is greater than or equal {n1}");

            switch(n1)
            {
                case 1: Console.WriteLine("ONE"); break;
                case 2: Console.WriteLine("TWO"); break;
                case '3': Console.WriteLine("THREE"); break; // char is considered as int
                default: Console.WriteLine("Error"); break;

            }

        }
    }
}
