namespace PE_CastingMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int hours = 274;
            int pointOneX;// = -13;
            int pointOneY;// = 51;
            int pointTwoX;// = 17;
            int pointTwoY;// = 28;

            //int a = 3.4;

            // input
            Console.Write("Enter Point 1 X: ");
            pointOneX = int.Parse(Console.ReadLine());

            Console.Write("Enter Point 1 Y: ");
            pointOneY = int.Parse(Console.ReadLine());

            Console.Write("Enter Point 2 X: ");
            pointTwoX = int.Parse(Console.ReadLine());

            Console.Write("Enter Point 2 Y: ");
            pointTwoY = int.Parse(Console.ReadLine());


            Console.WriteLine("--- Distance ---");
            Console.WriteLine($"Point One: {pointOneX}, {pointOneY}");
            Console.WriteLine($"Point Two: {pointTwoX}, {pointTwoY}");
            Console.WriteLine("The distance between these points is {0}",
                (float)Math.Sqrt(Math.Pow(pointTwoX - pointOneX, 2) + Math.Pow(pointTwoY - pointOneY, 2)));
        }
    }
}
