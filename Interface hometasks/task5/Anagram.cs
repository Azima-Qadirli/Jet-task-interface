using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task 1 : Write a C# program to check if two given strings are anagrams or not.
namespace Interface_hometasks.task5
{
    class Anagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls,enter your first string:");
            string first = Console.ReadLine();

            Console.WriteLine("Pls, enter your second string:");
            string second = Console.ReadLine();

            if (AreAnagrams(first,second))
            {
                Console.WriteLine("These two strings are anagram:");
            }
            else
            {
                Console.WriteLine("Unfortunately, they are not anagram:");
            }
            
        }
         static bool AreAnagrams(string first, string second)
        {
            
            char[] char1 = first.ToCharArray();
            char[] char2 = second.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            return new string(char1) == new string(char2);


        }
    }
    
}
