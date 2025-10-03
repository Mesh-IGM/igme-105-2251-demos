namespace Switches_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine(count+1);
                count++;
            }

            Console.WriteLine(count+" final value");

            // We need a number between 0 and 100
            int number = -1;  // Start outside the range 

            // While still outside the range:
            while (number < 0 || number > 100)
            {
                // Prompt the user and get input
                Console.Write("(w) Number from 0-100 (inclusive): ");
                number = int.Parse(Console.ReadLine());
            }

            // We need a number between 0 and 100
            int num = 89;  // Start outside the range 

            // While still outside the range:
            do
            {
                // Prompt the user and get input
                Console.Write("(dw) Number from 0-100 (inclusive): ");
                num = int.Parse(Console.ReadLine());
            }
            while (num < 0 || num > 100);

            /*
            double percScary = 0;
            double percVeloc = 0;
            string animal = "";

            Console.WriteLine("What animal becomes sentient?");
            animal = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("What % of {0} are sentient?",animal);
            percScary = double.Parse(Console.ReadLine());

            Console.WriteLine("What % of dogs are transformed?");
            percVeloc = double.Parse(Console.ReadLine());

            if(animal == "frogs")
            {
                Console.WriteLine("Nope");
            }
            else if (animal == "fish")
            {
                Console.WriteLine("Nope");
            }
            else if (animal == "squirrels")
            {
                Console.WriteLine("Nope");
            }
            else if (animal == "cats")
            {
                Console.WriteLine("ok");
            }
            else if (animal == "horses")
            {
                Console.WriteLine("meh");
            }
            else if (animal == "seahorses")
            {
                Console.WriteLine("cool");
            }
            else
            {
                Console.WriteLine("run");
            }


            switch(animal)
            {
                // frogs, fish, squirrels, ants
                // fall through ONLY for empty cases
                case "frogs":
                case "fish":
                case "ants":
                case "squirrels":
                    Console.WriteLine("Goodbye");
                    break;

                // case "dogs":
                   // Console.WriteLine("aww");  // no fall through if non-empty case

                // cats
                case "cats":
                    Console.WriteLine("ok");
                    break;

                // horses
                case "horses":
                    Console.WriteLine("meh");
                    break;

                // seahorse
                case "seahorse":
                    Console.WriteLine("cool");
                    break;

                // everything else
                default:
                    Console.WriteLine("run");
                    break;

        }

*/


        }
    }
}
