// A program using a switch statement that takes one value from the user and asks about the 
// type of conversion and then performs a conversion depending on the type of conversion. 
// If user enters:

// I -> convert from inches to centimeters.
// G -> convert from gallons to liters.
// M -> convert from mile to kilometer.
// P -> convert from pound to kilogram.

// If the user enters any other character then show a proper message.

using System;
using Conversion;
namespace Conversion
{
    class Program
    {

        //Function to check to see if the choice is a lowercase character then convert it to uppercase.
        public static char check(char c) {
            int b = (int)c;
            if (b >= 97 && b <= 122)
            {
                b = b - 32;
                c = (char)b;
            }
            return c;
        }

        static void Main(string[] args) {
            int value;
            char choice;
            double centimeter, liters, kilometer, kilogram;

            Console.WriteLine("Enter A Digit Value:");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n Press Any Of The Given Choices \n I -> convert from inches to centimeters.\n G -> convert from gallons to liters.\n M -> convert from mile to kilometer.\n P - > convert from pound to kilogram.\n");
            choice = Convert.ToChar(Console.ReadLine());

            choice = check(choice);

            switch (choice) {
                case 'I':
                    centimeter = value / 0.3937; //1 cm is equal is 0.3037 inch
                    Console.WriteLine("\n\nIn Centimeters:" + centimeter);
                    break;
                
                case 'G':
                    liters = value * 3.78; // 1 gallon=3.78 litters
                    Console.WriteLine("\n\nIn Litters:" + liters);
                    break;
                
                case 'M':
                    kilometer = value * 1.60;
                    Console.WriteLine("\n\nIn kilometers:" + kilometer);
                    break;
                
                case 'P':
                    kilogram = value * 0.453;
                    Console.WriteLine("\n\nIn KiloGrams:" + kilogram);
                    break;
                
                default:
                    Console.WriteLine("You Enter A Invalid Choice, Please Enter A Valid Choice...!");
                    break;
            }
            Console.ReadKey();
        }
    }
}