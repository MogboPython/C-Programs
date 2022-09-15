using System;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of fibonacci numbers: "); 
            int number = int.Parse(Console.ReadLine());
            int x1, x2, x3;  //initialising the numbers

            x1 = 0;
            x2 = 1;
            
            for(int i = 0; i < number; i++){
                x3 = x1 + x2;
                //Console.Write("{0}, ",x1);
                Console.Write(x1+", ");

                x1 = x2;
                x2 = x3;
            }
        }
    }
}