using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3Review
{
    /// <summary>
    /// Store data about a horse
    /// </summary>
    internal class Horse
    {
        // define the class members

        // fields
        private string color;
        private double speed;
        private const int HorsePower = 5; // 5m/sec

        // constructors

        public Horse()
        {
            color = "horse";
            speed = 1;
        }

        public Horse(string colorStr, double speed)
        {
            this.color = colorStr;
            color = colorStr;
            this.speed = speed;
        }

        // methods
        public void Run(int meters)
        {
            Console.WriteLine("The {0} horse went {1}m in {2} seconds.",
                color,
                meters,
                meters * HorsePower * speed);
        }

        public void Flee()
        {
            while(true)
            {
                this.Run(100);
            }
        }

        public static void PrintFacts()
        {
            Console.WriteLine("...facts...");
        }

    }
}
