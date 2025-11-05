namespace Exam3Review
{
    /*
     * how does the "this" keyword work again?
     * Can you go over how to use TryParse?
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /* - not finished by I know I need to ....
            Math.Pow()
            */

            /*
            int age;
            bool readAge = false;

            while (!readAge)
            {
                try
                {
                    Console.Write("How old are you? ");
                    age = int.Parse(Console.ReadLine());
                    readAge = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("\n\n\n");
            readAge = false;
            age = -1;
            while (!readAge)
            {
                Console.Write("How old are you? ");
                readAge = int.TryParse(Console.ReadLine(), out age);
                if(!readAge)
                { 
                    Console.WriteLine("Invalid number"); 
                }
            }
            */

            string name = "Shiro";
            string other = new string("lacy");
            int[] nums = new int[3] { 1, 2, 3 };
            int[] nums2 = { 1, 2, 3 };

            char firstLetter = name[0]; // ok
            // name[0] = 'a'; // not okay
            char letter = 'b';
            letter = (char)(((int)letter - (int)'a') + (int)'A');

            Horse aiden = new Horse("palamino",1);
            Horse cosmo = new Horse("grey",1.5);

            //Horse.Run(10);
            Horse.PrintFacts();
            aiden.Run(10);
            cosmo.Run(10);

           // aiden.Flee();

           // Console.WriteLine(aiden.color);
        }
    }
}
