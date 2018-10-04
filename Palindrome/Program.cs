using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            String phrase = "";
            String reverse = "";

            Console.WriteLine("Enter a phrase:");
            phrase = Console.ReadLine();

            for (int i = 0; i < phrase.Length - 1; i++)
            {
                reverse = phrase.Substring(i, i + 1) + reverse;
            }

            Console.WriteLine(reverse);
        }
    }
}
