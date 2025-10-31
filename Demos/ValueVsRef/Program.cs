namespace ValueVsRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12;
            Console.WriteLine("Hello, World!");
            DoStuff();

            OtherClass c = new OtherClass();
            c.ClassMethod();

        }

        static void DoStuff()
        {
            int a = 5;
            int b = a;
            b++;

            int[] c = { 1, 2, 3, 4, 5 };
            int[] d = c;
            d[0]++;

            //          double c, d, f, g, h;
            double[] nums = new double[10000];
            Console.WriteLine("Stuff");
            //DoStuff();
        }
    }
}
