namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // while - check first
            char letter = 'a';
            while(letter <= 'z')
            {
                Console.Write(letter);
                letter = (char)(letter + 3);
            }


            // do-while - always run once before checking
            string userInput = "";
            do
            {
                Console.Write("\nEnter a word: ");
                userInput = Console.ReadLine().Trim();
            }
            while (userInput.Length <= 0);



            /*
            int i= 0;
            while (i < 3)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();

            double i = 0;
            while (i < 3)
            {
                Console.Write(i);
                i += 0.5;
            }
            Console.WriteLine();
            */

            for (int i = 0; i < 3; i ++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            for (double i = 0; i < 3; i += 0.5)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            // Using a nested loop to print some values
            const double N = 5;
            Console.WriteLine(
                "\nNested loop that goes NxN times with N={0}:", N);
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    // Print the next coordinate pair for this row
                    Console.Write(x + "," + y + "\t");
                }
                // Move to a new line
                Console.WriteLine();
            }
        }
    }
}
