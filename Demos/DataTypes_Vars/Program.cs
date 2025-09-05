namespace DataTypes_Vars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare AND initialize together
            const int DaysInWeek = 7;
            int myAge = 5;
            // NO int MyAge = 5;
            string address = "1 Lomb Memorial";
            double accountBalance = 12.34;

            // declare only
            int num;

            Console.WriteLine("Shiro" + myAge);

            // init later - just has to be done before I use it
            num = myAge % 5;

            // all the same
            num = num + 1;
            num += 1;
            num++;

            Console.WriteLine(num);
            Console.WriteLine(DaysInWeek);

        }
    }
}
