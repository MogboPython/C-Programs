//A program that takes a coordinate, center coordinate and radius of a circle from the user, the program
//will determine whether the point lies inside the circle, on the circle or outside the circle.

using System;
namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a, b, radius;
            int radius_square, coordinates_calculation;
            Console.WriteLine("Enter X coordinates of circle:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinates of circle:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X coordinates of the center of the circle:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinates of the center of the circle:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Radius of circle:");
            radius = Convert.ToInt32(Console.ReadLine());
            radius_square = radius * radius; // Because equation of a circle is (x-a)^2+(y-b)^2=r^2

            coordinates_calculation = ((x-a) * (x-a)) + ((y-b) * (y-b));
            if (coordinates_calculation == radius_square)
            {
                Console.WriteLine("Points Lies On The Circle");
            }
            if (coordinates_calculation> radius_square )
            {
                Console.WriteLine("Points Lies OutSide The Circle");
            }
            if(coordinates_calculation <radius_square )
            {
                Console.WriteLine("Points Lies InSide The Circle");
            }
            Console.ReadKey();
        }
    }
}