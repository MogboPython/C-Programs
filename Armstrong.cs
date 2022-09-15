using System;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, number, k;
            double result = 0, j, power, numberCheck;
            string numberString;
            
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            numberCheck = Convert.ToDouble(number);

            numberString = number.ToString();

            count = numberString.Length;
            power = Convert.ToDouble(count);

            foreach (char i in numberString)
            {
                k = Convert.ToInt32(i.ToString());
                j = Convert.ToDouble(k);
                result = result + Math.Pow(j, power);
            }
            
            if(numberCheck == result){
                Console.WriteLine("The number is an Armstrong Number");
            }
            else{
                Console.WriteLine("The number is not an Armstrong Number");
            }
        }
    }
}