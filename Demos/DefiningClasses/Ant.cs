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
        private const int WeightMax = 100;

        // Properties -- coming soon

        // Default Constructor
        /*
        public Ant()
        {
            color = "black";
            name = "Worker";
            limbCount = 6;
            biteStr = 1.0;
            biteLikelihood = 0.0;
            isQueen = false;
        }
        */

        // Param Constructor
        public Ant(/*string nameParam,*/ string name, string color)
        {
            //name = nameParam;
            this.name = name;
            this.color = color;
            limbCount = 6;
            biteStr = 1.0;
            biteLikelihood = 0.0;
            isQueen = false;
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
