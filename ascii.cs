// Write a program to print all the ASCII values and their equivalent characters using a while loop. 
// The ASCII values vary from 0 to 255.

using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
        char ch;
        int i = 0;
        while (i <= 255)
        {
            Console.Write(i);
            Console.Write(" ");
            ch = (char) i;
            Console.WriteLine(ch);
            i++;
        }
        Console.ReadKey();
        }
    }
}