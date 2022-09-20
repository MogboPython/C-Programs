// Write a program that prints an identity matrix using a for loop, 
// in other words takes a value n from the user and shows the identity table of size n * n.

using System;

namespace IdentityMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter The Size Of The Identity Matrix:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n Identity Matrix\n\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write(1);
                    } else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}