using static System.Runtime.InteropServices.JavaScript.JSType;

namespace enums
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    enum DamageType
    {
        Fire = 5,
        Poison = 10,
        Cold = 3,
        Slashing = 1
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Our switch statement is more readable if we use constants
            const int Fire = 1;
            const int Poison = 2;
            const int Slashing = 3;
            const int Cold = 4;
            int dmgInt = 4;
            switch (dmgInt)
            {
                case Fire:
                    Console.WriteLine(
                         "Fire: We burn to death!");
                    break;
                case Poison:
                    Console.WriteLine(
                         "Poison: Instant death!");
                    break;
                case Slashing:
                    Console.WriteLine(
                         "Slashing: Don't lose your head!");
                    break;
                case Cold:
                    Console.WriteLine(
                         "Cold: Welcome to Rochester");
                    break;
                default:
                    Console.WriteLine(
                         "This probably shouldn't happen...");
                    break;
            }
            // This looks better.
            // But the value has no meaning if we print it out:
            Console.WriteLine(
                "The ToString() of our dmgInt variable is: "
                + dmgInt);

            ///////////////////////////////////////////////////////////
            // If we use an Enum, the code is more readable + we can't accidentally use a value we 
            // don't support (e.g. 5), AND we can print out a nice version of the value
            DamageType dmgEnum = DamageType.Cold;
            switch (dmgEnum)
            {
                case DamageType.Fire:
                    Console.WriteLine("Fire: We burn to death!");
                    break;
                case DamageType.Poison:
                    Console.WriteLine("Poison: Instant death!");
                    break;
                case DamageType.Slashing:
                    Console.WriteLine("Slashing: Don't lose your head!");
                    break;
                case DamageType.Cold:
                    Console.WriteLine("Cold: Welcome to Rochester");
                    break;
                default:
                    Console.WriteLine("This probably shouldn't happen...");
                    break;
            }

            // Print out the ToString of an enum
            Console.WriteLine("The ToString() of our dmgEnum variable is: " + dmgEnum);

        }
    }
}
