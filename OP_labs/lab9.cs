using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            words = InputToArray();
            Array.Sort(words);
            DisplaySortedArray(words);
        }

        static string[] InputToArray()
        {
            string input;
            Console.WriteLine("Введiть рядок з словами");
            do
            {
                input = Console.ReadLine();
            } while (input == null);

            string[] words = input.Split(" ");
            return words;
        }

        static void DisplaySortedArray(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}