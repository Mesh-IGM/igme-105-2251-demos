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
        private DateTime birthday;

        // Properties
        public int CurrentLoad
        {
            get
            {
                return currentLoad;
            }
        }

        public double BiteLikelihood
        {
            get { return biteLikelihood; }
            set
            { 
                biteLikelihood = value;
            }
        }

        // The Age property calculates how old the pet is TODAY
        // There is NO corresponding age field b/c it’s a calc
        // based on the birthday
        public double Age
        {
            get
            {
                // Calculate age in days, return in years
                double ageDays =
                        (DateTime.Today - this.birthday).TotalDays;
                return Math.Round(ageDays / 365, 2);
            }
        }

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
            birthday = new DateTime(1970, 1, 1);

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

        public int GetLoad()
        {
            return currentLoad;
        }

        public void StoreFood(int amount)
        {
            currentLoad += amount;
            currentLoad = Math.Min(currentLoad, WeightMax);
            Console.WriteLine($"{name} - {currentLoad}");
        }


    }
}
