using System.Diagnostics.Metrics;

namespace DbgDemo_pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Data, variables, math expressions, string concatenation, assignments

            // ***** collisions *******

            // center 1
            int xA = 0;
            int yA = 0;

            // center 2
            int xB = 5;
            int yB = 5;

            // radii
            int rA = 1;
            int rB = 1;

            // https://www.mathsisfun.com/algebra/distance-2-points.html
            double distSquared = (xA - xB) * (xA - xB) + (yA - yB) * (yA - yB);
            int sumRadii = rA + rB;

            Console.WriteLine("Distance squared: "+distSquared);
            Console.WriteLine("Sum radii - squared: " + sumRadii * sumRadii);

            /*
            // Get a name from the user
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();

            // Determine how many copies of that
            // name will fit in 100 characters
            // eventually need to check name length before doing this
            int howManyFit = 100 / name.Length;
            */

            // gravitational math

        }
    }
}
