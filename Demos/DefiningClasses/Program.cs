namespace DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }

        public static void DoStuff()
        {

        }
    }

}
