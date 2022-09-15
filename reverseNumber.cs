using System;

namespace ReverseNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            string number, reversed;
            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();
            char[] array = number.ToCharArray();

            Array.Reverse(array);
            reversed = new string(array);
            
            Console.WriteLine(reversed);
        }
    }
}