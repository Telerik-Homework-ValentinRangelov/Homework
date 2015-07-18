using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));

            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                MathCalculation.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                MathCalculation.CalcDistance3D(5, 2, -1, 3, -6, 4));


            Console.WriteLine("Volume = {0:f2}", MathCalculation.CalcVolume(2,3,4));
            Console.WriteLine("Diagonal XYZ = {0:f2}", MathCalculation.CalcDiagonalXYZ(2,3,4));
            Console.WriteLine("Diagonal XY = {0:f2}", MathCalculation.CalcDiagonalXY(2,3));
            Console.WriteLine("Diagonal XZ = {0:f2}", MathCalculation.CalcDiagonalXZ(2,4));
            Console.WriteLine("Diagonal YZ = {0:f2}", MathCalculation.CalcDiagonalYZ(3,4));
        }
    }
}
