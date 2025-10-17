namespace Methods_Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(GetPromptedInput("Enter a number:"));
            int b = 2;
            Console.WriteLine(AddTwoNumbers((int)a, b));

            Console.WriteLine(FactorialRecursive(5));
        }

        // Input helper written by Prof. Mesh
        public static string GetPromptedInput(string prompt)
        {
            // Always print in white
            Console.ForegroundColor = ConsoleColor.White;

            // Print the prompt
            Console.Write(prompt + " ");

            // Switch color and get user input (trim too)
            Console.ForegroundColor = ConsoleColor.Cyan;
            string response = Console.ReadLine().Trim();

            // Switch back to white and then return response.
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }

        public static int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int FactorialRecursive(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            return n * FactorialRecursive(n - 1);
        }


    }
}
