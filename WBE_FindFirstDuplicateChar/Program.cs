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
                    Console.WriteLine(FindFirstDuplicatedChar(input));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
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
                        if (duplicateIndex == -1 || j < duplicateIndex)
                        {
                            duplicateIndex = j;
                        }
                    }
                }
            }
            return array[duplicateIndex];
        }
    }
}
