namespace Exceptions_TryParse
{
    internal class Program
    {
        const ConsoleColor PromptColor = ConsoleColor.White;
        const ConsoleColor ErrorColor = ConsoleColor.Red;
        const ConsoleColor ResultColor = ConsoleColor.Green;
        const ConsoleColor UserEntryColor = ConsoleColor.Cyan;
        const ConsoleColor Background = ConsoleColor.Black;

        static void Main(string[] args)
        {
            //int myNum = int.Parse(PromptForInput("Enter a whole number:"));

            int myNum = -1;
            bool success = false;
            while (!success)
            {
                success = int.TryParse(PromptForInput("Enter a whole number:"), out myNum);
            }
            Console.WriteLine(myNum);

            while (!int.TryParse(PromptForInput("Enter a whole number:"), out myNum))
            {
                Console.WriteLine("\ttry again");
            }
            Console.WriteLine(myNum);

            /*
                        int result = 0;
                        try
                        {
                            int numA = PromptForInt("Num A: ", int.MinValue, int.MaxValue);
                            int numB = PromptForInt("Num B: ", int.MinValue, int.MaxValue);
                            result = numA / numB;
                           // DoStuff();
                            Console.WriteLine("!!!");
                        }
                        catch(FormatException ex)
                        {
                            Console.WriteLine("Not an int");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        Console.WriteLine("result = " + (result));
                        */
        }

        public static void DoStuff()
        {
            int numA = PromptForInt("Other A: ", int.MinValue, int.MaxValue);
            int numB = PromptForInt("Other B: ", int.MinValue, int.MaxValue);
            int result = numA / numB;
        }

        /// <summary>
        /// Prompts the user for string
        /// TODO: Add more info about the parameter and return value
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static String PromptForInput(string prompt)
        {
            string result;
            Console.ForegroundColor = PromptColor;
            Console.Write(prompt);
            Console.ForegroundColor = UserEntryColor;
            result = Console.ReadLine().Trim();
            Console.ForegroundColor = PromptColor;
            return result;
        }

        /// <summary>
        /// Prompts the user for an integer between min and max (inclusive for both the min & max)
        /// </summary>
        /// <param name="prompt">The </param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int PromptForInt(string prompt, int min, int max)
        {
            int result; // LCV

            // data validation of the range
            do
            {
                // get the string input
                // get the int
                result = int.Parse(
                    PromptForInput(
                        prompt +
                        String.Format("[{0},{1}] ", min, max)
                    )
                );
            }
            while (result < min || result > max);

            return result;
        }
    }
}
