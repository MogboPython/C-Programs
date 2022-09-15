using System;

namespace DecimalToBinary
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number, num, n;
            string binary = "";

            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());
            num = number;

            while(num > 0){
                n = num%2;
                binary = n.ToString() + binary;
                num = num/2;
            }

            Console.WriteLine(binary);
        }
    }
}