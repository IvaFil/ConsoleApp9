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
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (; number >0; number/=10)
            {
                sum += number % 10;
               

            }


            Console.WriteLine(sum);


        }
    }
}
