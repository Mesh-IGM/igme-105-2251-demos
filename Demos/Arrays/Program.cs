namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            string name;
            name = "Shiro";

            char[] nameChars = name.ToCharArray();

            // 1. Declare the array
            int[] nums;

            // 2. Initialize by creating the array and 
            // make the variable refer to it
            nums = new int[5];

            // We now have an array that can hold
            // 5 integers, and we access it through
            // the variable called "nums"

            Console.WriteLine(nums[2]);

            // Create a few arrays
            const int NumPlayers = 2;
            String[] firstNames = new String[NumPlayers];
            String[] lastNames = new String[NumPlayers];
            int[] scores = new int[NumPlayers];

            // Attempt to print some data from arrays
            // The locations will exist, but default to the 
            // default value for the given type
            Console.WriteLine("Player 1, {0} {1} has a score of {2}",
                firstNames[0],
                lastNames[0],
                scores[0]);
            Console.WriteLine();




            for (int playerNum = 0; playerNum < firstNames.Length; playerNum++)
            {
                // Assign some names and scores one at a time
                Console.WriteLine("Player {0}:", playerNum +1);
                Console.Write(" - First name? ");
                firstNames[playerNum] = Console.ReadLine();
                Console.Write(" - Last name? ");
                lastNames[playerNum] = Console.ReadLine();
                Console.Write(" - Score? ");
                scores[playerNum] = int.Parse(Console.ReadLine());
            }


        }
    }
}
