// Write a program using conditional operators to determine whether 
// a year entered through the keyboard is a leap year or not.

using System;

namespace LeapYear
{
  class Program
  {
    static void Main(string[] args)
    {
      int year;
      string a;
      Console.WriteLine("Enter A Year:");
      year = Convert.ToInt32(Console.ReadLine());
      a = year % 4 == 0 ? "Year Is Leap" : "It Is Not A Leap Year:";
      Console.WriteLine(a);
      Console.ReadKey();
    }
  }
}