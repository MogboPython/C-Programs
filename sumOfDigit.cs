using System;

namespace SumOfDigits
{
    class SumOfDigits
    {
        static void Main(string[] args)
        {
            int number, k, result = 0;
            string numberString;
            
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());

            numberString = number.ToString();

            foreach (char i in numberString)
            {
                k = Convert.ToInt32(i.ToString());
                result = result + k;
            }

            Console.WriteLine(result);
        }

    }
}