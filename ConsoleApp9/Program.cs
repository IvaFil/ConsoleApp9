using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введи степень: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int res = A;

            for (int i = 1; i < B; i++)
            {

                A *= res;
            }
            Console.WriteLine(A);
        }
    }
}
