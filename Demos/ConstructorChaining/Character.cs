using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    // This is intentionally poorly commented.
    class Character
    {
        private string name;
        private string weapon;
        private int strength;
        private double defensePerc;

        public Character(string name, string weapon, int strength = 10, double defensePerc = 0.5)
        {
            this.name = name;
            this.weapon = weapon;
            this.strength = strength;
            this.defensePerc = defensePerc;
        }

        // A copy constructor is a parameterized constructor that takes an object
        // of the same type and copies each of its values
        public Character(Character other)
            :  // TODO: Chain this so it calls the parameterized constructor using each value from other
        {
            // There should be no code added here!
        }

        // TODO: Add a default constructor that chains to the parameterized constructor

        // public methods to get and set the fields
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void PrintStats()
        {
            Console.WriteLine("{0} wields their {1} with {2} strength and {3:P2} defense.", name, weapon, strength, defensePerc);
        }
    }



}
