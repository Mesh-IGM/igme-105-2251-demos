namespace DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ant defaultAnt = new Ant();
            Ant shiro = new Ant("Shiro", "black");
            Ant lacy = new Ant("Lacy", "red");
            Random rng = new Random();

            for(int i = 0; i < 10; i++)
            {
                shiro.GetFood(rng.Next(5,20));
                lacy.GetFood(rng.Next(5, 20));
            }
        }

        public static void DoStuff()
        {

        }
    }

}
