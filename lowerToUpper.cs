//Program that converts a lowercase character to a uppercase character and vice versa and then prints the result

using System;
namespace lowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            Console.WriteLine("Enter A Letter Between a-z or A-Z:");
            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;
            if (b >= 97 && b <= 122)
            {
                b = b - 32;
                a = (char)b;
                Console.WriteLine("In Upper Case Letter: " + a);
            }
            else if (b >= 65 && b <= 90)
            {
                b = b + 32;
                a = (char)b;
                Console.WriteLine("In Lower Case Letter: " + a);
            }
            else
            {
                Console.WriteLine("You Enter Wrong Letter, Please Enter Letter Between a-z....!");
            }
            Console.ReadKey();
        }
    }
}