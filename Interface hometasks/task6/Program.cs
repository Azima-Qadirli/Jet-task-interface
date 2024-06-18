using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
//Task 2 : Write a method that takes two integers, base and exponent, and returns the result of raising the base to the power of the exponent.(without any Math method)
namespace Interface_hometasks.task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number as base:");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number as exponent:");
            int second = int.Parse(Console.ReadLine());

            if (second < 0)
            {
                Console.WriteLine("Sorry,You entered negative integer for exponent.");
            }
            else
            {
                long result = Power(first, second);
                Console.WriteLine($"Result: {result}");
            }
        }
        static long Power(int first, int second)
        {
            long result = 1;
            for (int i = 0; i < second; i++)
            {
                result *= first;
            }
            return result;
        }

    }
}
