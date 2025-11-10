namespace ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SmartConsole refactor tests
            int num1 = SmartConsole.Prompt("Enter a number between 1 and 10:", 1, 10);
            double num2 = SmartConsole.Prompt("Enter a number between 1.0 and 10.0:", 1.0, 10.0);
            string word = SmartConsole.Prompt("Enter a word:");

            // Create a default Character object
            Character char0 = new Character();

            // Create a new Character object using the parameterized constructor
            Character char1 = new Character(
                SmartConsole.Prompt("Enter character 1's name:"),
                SmartConsole.Prompt("Enter their weapon:"),
                SmartConsole.Prompt("Enter their strength:", 1, 100),
                SmartConsole.Prompt("Enter their defense percentage:", 0, 1.0));

            // Create a new Character object using the copy constructor and then prompt the user for the new character's name
            Character char2 = new Character(char1);
            char2.SetName(SmartConsole.Prompt("Enter the new character's name:"));

            // Display all the info
            Console.WriteLine("num1: {0}", num1);
            Console.WriteLine("num2: {0}", num2);
            Console.WriteLine("word: {0}", word);
            char0.PrintStats();
            char1.PrintStats();
            char2.PrintStats();
        }
    }
}
