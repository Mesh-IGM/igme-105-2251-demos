namespace InputStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "???";
            string allCaps;

            Console.Write("Enter your name: ");
            //name = Console.ReadLine();
            //name = name.Trim();
            name = Console.ReadLine().Trim();

            Console.WriteLine("Hi "+name+"!\nYour name has "+name.Length+"!");

            Console.WriteLine("String with escape chars\n\t\"skjhskjfghdksfgh\\dkjfghdkjfhgdkjghf\"");

            name.ToUpper();
            Console.WriteLine(name);

            allCaps = name.ToUpper();
            Console.WriteLine(allCaps);

            Console.WriteLine("The first 3 letters are: " + allCaps.Substring(0, 3));
        }
    }
}
