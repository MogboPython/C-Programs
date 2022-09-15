using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args){
            int result = 1;
            Console.WriteLine("Enter a Number");
            int number = int.Parse(Console.ReadLine());

            for(int i = 1; i <= number; i++){
                result = result * i;
            }
        Console.WriteLine(result);
        }
    }
}