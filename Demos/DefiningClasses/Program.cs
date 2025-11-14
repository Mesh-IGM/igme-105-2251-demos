namespace DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Ant defaultAnt = new Ant();
            Ant shiro = new Ant("Shiro", "black", false);
            Ant lacy = new Ant("Lacy", "red", true);
            Random rng = new Random();

            for(int i = 0; i < 10; i++)
            {
                shiro.StoreFood(rng.Next(5,20));
                lacy.StoreFood(rng.Next(5, 20));
            }

            Console.WriteLine(lacy.CurrentLoad);
            // lacy.CurrentLoad = 3;

            lacy.BiteLikelihood = 0.67;
            lacy.BiteLikelihood += 0.02;

            // lacy.SetXXX(lacy.GetXXX + 0.02));

            lacy.BiteLikelihood++;

            Console.WriteLine(lacy.Age);
            */

            List<Ant> colony = new List<Ant>();

            for(int i = 0;i < 4; i++)
            {
                colony.Add(new Ant("Ant " + i, "black", false));
            }

            colony.Insert(3, new Ant("Shiro", "black", true));

            // for(int i=0; i<colony.Count; i++) { Ant ant = colony[i];
            foreach(Ant ant in colony)
            {
                Console.WriteLine(ant);
                //if(ant.CurrentLoad <= 0)
                    // BAD colony.Remove(ant);
            }

            //~~~~~~~~~~~~~~~~~~~~~~~
            Random rng = new Random();
            List<int> nums = new List<int>();
            for(int i = 0;i<10;i++)
            {
                nums.Add(rng.Next(100));
                //nums.Add(42);
            }
           // nums[6] = 42;
           // nums[7] = 42;
           // nums[8] = 42;

            if (nums.Contains(42))
            {
                Console.WriteLine("YAY");
            }

            // nums.Remove(42); // remove the first one

            for(int i = 0; i<nums.Count; i++)
            {
                if(nums[i] == 42)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }


        }

        public static void DoStuff()
        {

        }
    }

}
