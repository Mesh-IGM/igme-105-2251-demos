namespace StaticMethods_Review
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
            string name = PromptForInput("What is your name? ");
            int number = PromptForInt("What is your favorite number? ", 0, 100);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(
                    "Hello, {0}!",
                    name
                    );
            }
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
        /// TODO: Add more info about the parameters and return value
        /// </summary>
        /// <param name="prompt">The </param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int PromptForInt(string prompt, int min, int max)
        {
            // TODO: Replace the following line with your code to implement the method.
            // Use PromptForInput to get the input from the user.
            // There should be no calls to Write or ReadLine in this method!
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
