using System;

namespace GradeMatch
{
    class Program
    {
        static void Main(string[] args)
        {

            String grade = "";
            Console.WriteLine("Input the grade:");
            grade = Console.ReadLine();

            if (grade == "e" || grade == "E")
            {
                Console.WriteLine("You have chosen: Excellent");
            }
            else if (grade == "g" || grade == "G")
            {
                Console.WriteLine("You have chosen: Good");
            }
            else if (grade == "v" || grade == "V")
            {
                Console.WriteLine("You have chosen: Very good");
            }
            else if (grade == "a" || grade == "A")
            {
                Console.WriteLine("You have chosen: Average");
            }
            else if (grade == "f" || grade == "F")
            {
                Console.WriteLine("You have chosen: Fail");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
