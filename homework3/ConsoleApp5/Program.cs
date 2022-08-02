using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            double perimeter;
            Console.WriteLine( "Enter Radius: ");
                radius = Convert.ToDouble( Console.ReadLine());
            perimeter = 2 * Math.PI * radius;
            area = Math.PI * radius * radius;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
