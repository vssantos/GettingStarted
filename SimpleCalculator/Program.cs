using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            String expression = "";
            String num1 = "";
            String num2 = "";

            bool digit = false;

            Console.WriteLine("Enter an expression:");
            expression = Console.ReadLine();
            expression = expression.Replace(" ", "");

            foreach (char c in expression)
            {
                digit = c.IsDigit;

                if (c == '+' || c == '-' || c == '*' || c == '/')
                {

                }
                else if (digit)

            }
            
        }
    }
}
