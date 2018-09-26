/**
 * Write a function that accepts a single string, and returns the first duplicated character in the string.
 * ie: 'abcdc' should return 'c', and 'abcdbc' should return 'b'
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_FindFirstDuplicateChar
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Enter a string of characters\n\n>>> ");
                    string input = Console.ReadLine();
                    Console.WriteLine("\nFirst duplicated char: " + FindFirstDuplicatedChar(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n" + ex.Message);
                }
                Console.Write("\nPress Enter to try another string...");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }

        static char FindFirstDuplicatedChar(string input)
        {
            int duplicateIndex = -1;
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        // stores the duplicate's index if 1) it's the first duplicate encounterred 2) if it appears in the string before the previously saved duplicate does.
                        if (duplicateIndex == -1 || j < duplicateIndex)
                        {
                            // stores the duplicated char's index
                            duplicateIndex = j;
                        }
                    }
                }
            }
            // if duplicateIndex's value hasn't changed then no duplicates were encountered.
            if (duplicateIndex == -1)
            {
                throw new Exception("No duplicate characters were found");
            }
            else
            {
                return array[duplicateIndex];
            }
        }
    }
}
