using System;

namespace FindLargest
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third;

            Console.WriteLine("Input the 1st number:");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number:");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number:");
            third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("The first number is the greatest among the three");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("The second number is the greatest among the three");
            }
            else if (third > first && third > second)
            {
                Console.WriteLine("The third number is the greatest among the three");
            }
            else
            {
                Console.WriteLine("error"); 
            }
        }
    }
}
