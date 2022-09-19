//A program that takes a character from the user and determines whether the character entered 
//is a capital letter, a small case letter, a digit or a special symbol.

using System;

namespace AsciiValue
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            int b;
            Console.WriteLine("Enter A Charater:");
            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;
            if (b >= 65 && b <= 90)
            {
                Console.WriteLine("Entered Character Is Capital Letter:");
            }
            else if (b >= 97 && b <= 122)
            {
                Console.WriteLine("Entered Character Is Small Letter:");
            }
            else if (b >= 48 && b <= 57)
            {
                Console.WriteLine("Entered Character Is  Digit:");
            }
            //else if (b == 0 && b <= 47 || b >= 58 && b <= 64 || b >= 91 && b <= 96 || b >= 123 && b <= 127)
            else
            {
                Console.WriteLine("Entered Character Is Special Symbols:");
            }
            Console.ReadKey();
        }
    }
}