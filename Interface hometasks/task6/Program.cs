using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interface_hometasks.task6
{
    //Task 2 : Write a method that takes two integers, base and exponent, and returns the result of raising the base to the power of the exponent.(without any Math method)
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number as base:");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second number as exponent:");
            int second = int.Parse(Console.ReadLine()); 

            long result = Power(first,second);
            Console.WriteLine($"Result: {result}");
        }
        static long Power(int first , int second)
        {
            if (second<0)
            {
                Console.WriteLine("Sorry, you have to enter positive integer for exponent:");
            }
            long result = 1;
            result *= second;

            return result;
        }
        
    }
}
