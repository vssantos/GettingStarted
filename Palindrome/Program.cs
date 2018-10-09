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

            foreach (char c in phrase)
            {
                reverse = c + reverse;
            }

            if (reverse == phrase)
            {
                Console.WriteLine("\"" + phrase + "\"" + " is a palindrome.");
            }
            else
            {
                Console.WriteLine("\"" + phrase + "\"" + " is not a palindrome.");
            }
        }
    }
}
