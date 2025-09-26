namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // math, format strings, output math
            // input, parse input, variables --> SAVE
            // data types --> casting

            bool isAlive = true;
            int a = 10 + 12;
            //  >, >=, <, <=
            // == --- equals
            // = --- assignment
            // !=

            Console.WriteLine("5 > 5: {0}", 5 > 5);
            Console.WriteLine("5 >= 5: {0}", 5 >= 5);
            Console.WriteLine("5 < 5: {0}", 5 < 5);
            Console.WriteLine("5 <= 5: {0}", 5 <= 5);
            Console.WriteLine("5 == 5: {0}", 5 == 5);
            Console.WriteLine("5 != 5: {0}", 5 != 5);
            Console.WriteLine();

            if (/* some bool value */ 5 >= 3)
            {
                // if true, stuff here runs
                Console.WriteLine("TRUE");
            }

            Console.WriteLine("after if");

            bool isPositive = a >= 0;
            bool isDead = !isAlive;
            // if (/* some bool value */ isDead)
            // if (/* some bool value */ !isAlive)

            // if (/* some bool value */ isPositive)
            if (/* some bool value */ a >= 0)
            {
                // if true, stuff here runs
                Console.WriteLine("TRUE again");
            }

            Console.WriteLine("done");

            // remember I just define variables
            // all over so you can see them zoomed in :)
            string name;
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            if( name == "Shiro")
            {
                Console.WriteLine("That's my name too!");
            }

            if(name.Length <= 0)
            {
                Console.WriteLine("You have no name?");
            }



            // == can be used to compare boolean types
            // but DON’T -- It’s AWFUL!
            bool uselessResult = isPositive == true;

            if (isPositive == true)
            { }

            // has the SAME result as

            if (isPositive)
            { }
            // but the extra == means extra work!

            if (isPositive == false)
            { }

            if (!isPositive)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }

            int num = 9;
            if(num > 10)
            {
                Console.WriteLine("big");
            }
            else if (num > 0) // order matters!
            {
                Console.WriteLine("small");
            }
            else if (num > 8)
            {
                Console.WriteLine("med");
            }
            else
            {
                Console.WriteLine("it's number");
            }


            if (num > 10)
            {
                Console.WriteLine("big");
            }


            if (num > 0) // order matters!
            {
                Console.WriteLine("small");
            }


            if (num > 8)
            {
                Console.WriteLine("med");
            }
            else
            {
                Console.WriteLine("it's number");
            }

            if (name.Length > 0)
            {
                // Only check this if first name is "Shiro"
                if (name == "Shiro")
                {
                    Console.WriteLine("I know that cat!");
                }
            }


        }
    }
}
