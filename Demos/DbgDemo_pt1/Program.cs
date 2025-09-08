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
            int xB = 4;
            int yB = 5;

            // radii
            int rA = 1;
            int rB = 2;

            // https://www.mathsisfun.com/algebra/distance-2-points.html
            int distSquared = (xA - xB) * (xA - xB) + (yA - yB) * (yA - yB);
            int sumRadii = rA + rB;

            Console.WriteLine("Distance squared: "+distSquared);
            Console.WriteLine("Sum radii - squared: " + sumRadii*sumRadii);
            


            // gravitational math

        }
    }
}
