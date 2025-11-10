using System;

namespace DefiningClasses
{
    internal class Ant
    {
        // Fields
        private string color;
        private string name;
        private int limbCount;
        private double biteStr; // percent of max
        private double biteLikelihood;
        private bool isQueen;
        private int currentLoad;
        private double size;
        private const int WeightMax = 100;

        // Properties -- coming soon

        // Default Constructor
        public Ant()
            : this("Worker", "black", false)
        {
            Console.WriteLine("default");
            /*
            color = "black";
            name = "Worker";
            limbCount = 6;
            biteStr = 1.0;
            biteLikelihood = 0.0;
            size = 0.005;
            isQueen = false;
            */
        }

        // Param Constructor
        public Ant(/*string nameParam,*/ string name, string color, bool isQueen)
        {
            Console.WriteLine("params");
            //name = nameParam;
            this.name = name;
            this.color = color;
            this.isQueen = isQueen;
            size = 0.005;
            limbCount = 6;
            biteStr = 1.0;
            biteLikelihood = 0.0;

            if(isQueen)
            {
                size *= 4;
            }
        }

        // Methods

        public void GetFood(int amount)
        {
            currentLoad += amount;
            currentLoad = Math.Min(currentLoad, WeightMax);
            Console.WriteLine($"{name} - {currentLoad}");
        }


    }
}
