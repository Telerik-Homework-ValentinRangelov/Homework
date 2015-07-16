using System;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

class Program
{
    static decimal TriangleSurfaceBySideAndAltitude(decimal side, decimal altitude)
    {
        Console.WriteLine("Surface = (Side * Altitude) / 2 ");
        decimal surface = (side * altitude) / 2;
        return surface;
    }
    static decimal TriangleSurfaceByThreeSides(decimal sideA, decimal sideB, decimal sideC)
    {
        Console.WriteLine("Surface = √S*(S-A)(S-B)(S-C)");
        Console.WriteLine("S=(A+B+C)/2 ");
        decimal s = (sideA + sideB + sideC) / 2;
        decimal surface = (decimal)Math.Sqrt((double)(s * (s - sideA) * (s - sideB) * (s - sideC)));
        return surface;
    }
    static decimal TriangleSurfaceByTwoSidesAndAnAngle(decimal sideA, decimal sideB, decimal angle)
    {
        Console.WriteLine("Surface = (A*B*SinC)/2");

        decimal surface = (sideA * sideB * (decimal)(Math.Sin((double)angle))) / 2;
        return surface;
    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("How do you want to find the surface of the triangle: ");
            Console.WriteLine("1.:By side and an altitude to it. ");
            Console.WriteLine("2.:By three sides. ");
            Console.WriteLine("3.:By two sides and an angle between them. ");
            decimal choose = decimal.Parse(Console.ReadLine());
            if (choose == 1)
            {
                Console.Write("Enter your side:");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.Write("Enter your altitude to it:");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Surface = {0:0.00}", TriangleSurfaceBySideAndAltitude(a, b));
                break;
            }
            else if (choose == 2)
            {
                Console.WriteLine("Enter your first side:");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second side:");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter your third side:");
                decimal c = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Surface = {0:0.00}", TriangleSurfaceByThreeSides(a, b, c)); 
                break;


            }
            else if (choose == 3)
            {
                Console.WriteLine("Enter your first side:");
                decimal a = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second side:");
                decimal b = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter your angle between them:");
                decimal c = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Surface = {0:0.00}", TriangleSurfaceByTwoSidesAndAnAngle(a, b, c));
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter 1 , 2 or 3.");
                Console.WriteLine("Enter your value again:");

            }
        }
    }
}

