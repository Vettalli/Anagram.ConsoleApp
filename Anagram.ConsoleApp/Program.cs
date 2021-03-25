using System;
using Anagram.Application;

namespace Anagram.ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            IAnagram wordEx = new AnagramAppllication();

            Console.WriteLine("Please, write some text");

            string word = Console.ReadLine();
            Console.WriteLine(wordEx.Reverse(word));
            Console.ReadKey();
        }
    }
}