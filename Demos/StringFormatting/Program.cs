namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define text we may use a lot up front with our variables.
            // (or even eventually read the dialog in from a file!)
            const string IntroTextTemplate = 
                "Welcome {0}! How are you this early on a {1}?";

            string name;

            float num = 0;
            string tmpStr;

            Console.Write("Enter a number: ");
            num =  float.Parse(Console.ReadLine());

            // with concatenation
            Console.WriteLine(
                "The square root of your number, " + num 
                + ", is: " + Math.Sqrt(num)
            );

            // with placeholders
            Console.WriteLine(
                "The square root of your number, {0}, is: {1:F}",
                num,            // 0 -- 1st value to sub in
                Math.Sqrt(num)  // 1 -- 2nd
            );

            Console.WriteLine(
                "{1:F5} == square root of {0}",
                num,            // 0 -- 1st value to sub in
                Math.Sqrt(num)  // 1 -- 2nd
            );

            tmpStr = String.Format(
                "{1:F4} == square root of {0}",
                num,            // 0 -- 1st value to sub in
                Math.Sqrt(num)  // 1 -- 2nd
            );

            // shortcut with $ and variable names for string.format
            tmpStr = $"{Math.Sqrt(num):F4} == square root of {num}";

            // Get the values to plug in later via user input...
            Console.Write("What is your name?");
            name = Console.ReadLine().Trim();

            // or other System methods...
            // (DayOfWeek is a System defined type that formatting can
            //  auto-convert to a string)
            DayOfWeek today = DateTime.Today.DayOfWeek;

            // Build the full test as we print to the console
            Console.WriteLine(IntroTextTemplate, name, today);

            // or build the full text as a string to use later 
            // (e.g. to save to a file)
            string text = String.Format(IntroTextTemplate, name, today);

            // We also don't have to only put variables in for the substitute values
            // Expressions, property lookups, or other method calls are fine too
            Console.WriteLine(IntroTextTemplate, name, DateTime.Today.DayOfWeek);

            // If you want to change the whole screen's color,
            // set it and then CLEAR
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Testing a new color scheme");
            Console.WriteLine("Press Enter to clear.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Testing a new color scheme");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            // Reset back to reasonable colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("That's better!");

        }
    }
}
