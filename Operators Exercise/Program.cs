using System;

namespace Operators_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            var b = 3;

            var div = a / b;
            Console.WriteLine(div);

            var mod = a % b;
            Console.WriteLine(mod);

            Console.WriteLine($"{a}/{b} is {div} remainder of {mod}");

            var rad = 20;
            var pi = Math.PI;
            var A = pi * (rad * rad);
            Console.WriteLine(A);

            var i = 3;
            var j = 4;

            var k = ++i * j++;
            Console.WriteLine(k);

            var areaOfCircle = CalculateArea(rad);

            Console.WriteLine($"The area of a circle with the radius of {rad} is {CalculateArea(rad)}");   
        }


            public static double CalculateArea(double radius)
            {
               return Math.PI * (radius * radius); 
                
            }

        
    }
}
