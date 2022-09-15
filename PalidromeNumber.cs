using System;

namespace PalidromeNumber
{
    class Program
    {
        static void Main(string[] args){
            string number, reversed;

            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();
            char[] array = number.ToCharArray();

            Array.Reverse(array);
            reversed = new string(array);
            
            if(number == reversed){
                Console.WriteLine("Number is a Palidrome");
            }
            else{
                Console.WriteLine("Number is not a Palidrome");
            }
        }
    }
}