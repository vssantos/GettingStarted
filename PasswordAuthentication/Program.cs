using System;

namespace PasswordAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            String userIn = "";
            String passIn = "";
            int attempts = 0;

            while (attempts < 3)
            {
                Console.WriteLine("Enter a username.");
                userIn = Console.ReadLine();
                Console.WriteLine("Enter a password.");
                passIn = Console.ReadLine();

                if (userIn.Equals("root") && passIn.Equals("letmein"))
                {
                    Console.WriteLine("Username and password authenticated. You may proceed.");
                    break;
                }
                else
                {
                    attempts++;
                }
            }
            Console.WriteLine("Too many incorrect login attempts! Try again later!");
        }
    }
}
