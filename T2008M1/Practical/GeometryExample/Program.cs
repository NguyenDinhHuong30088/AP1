using System;
namespace T2008M_AP.Practical.GeometryExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            while (true) {
                try {
                    Console.WriteLine("Enter the dimensions of the cylinder:");
                    Console.Write("Radius: ");
                    cylinder.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Height: ");
                    cylinder.Height = Convert.ToDouble(Console.ReadLine());
                    cylinder.Process();
                    Console.WriteLine("Cylinder Characteristics");
                    Console.WriteLine(cylinder.Result());
                }
                catch (Exception n) {
                    Console.WriteLine(n.Message);
                }
            }
        }
    }
}