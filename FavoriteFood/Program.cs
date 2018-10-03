using System;

namespace FavoriteFood
{
    class Program
    {
        static void Main(string[] args)
        {
            String response = "";
            Console.WriteLine("What is your favorite food?");
            response = Console.ReadLine();
            if (response.Equals("pizza"))
            {
                Console.WriteLine("Most excellent and correct! Pizza is indeed one of the best foods ever put on this earth.");
            }
            else
            {
                Console.WriteLine("Wrong! That is a terrible choice and you should feel bad about yourself. Your favorite should be pizza!");
            }


        }
    }
}
