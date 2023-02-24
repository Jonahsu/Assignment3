using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnent3
{

      class Program
    { 
        static void Main(string[] args)
        {

        

                 Console.Write("Enter a string: ");
                 string input = Console.ReadLine();

                  Console.Write("Enter the letter to count: ");
                  char letter = char.Parse(Console.ReadLine());

                  int count = CountLetterOccurrences(input, letter);

                  Console.WriteLine("The letter '{letter}' appears {count} times in the string '{input}'.");
                  Console.Read();
        }

        static int CountLetterOccurrences(string input, char letter)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }              
      }
}

