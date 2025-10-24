using System.ComponentModel.DataAnnotations;

namespace Random_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Only want ONE instance of random per project
            Random rng = new Random();
            int[] randomNums = new int[100];
            for (int i = 0; i<randomNums.Length;i++)
            {
                // BAD Random rng = new Random();
                //Console.WriteLine(rng.Next(20));
                randomNums[i] = rng.Next(randomNums.Length); // [0, len-1)
            }
        }
    }
}
