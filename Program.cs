using System;

/* Virtual Pet Simulator Project
 * Pet Creation, Pet Care Actions,Pet Status Monitoring, Time-based Changes, Enhanced Interaction Logic, User Interface and experince.
 */

namespace VirtualPetSimulatorProject
{
    class Program
    {
        static void Main()
        {
            /* Pet Creation */
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog ");
            Console.WriteLine("3. Rabbit ");
            Console.Write("Choose your pet type (1,2,3): ");

            bool validStatus = true; // Using this flag to exit the app when user input invalid data */


            string petType = Console.ReadLine();
            Console.WriteLine();

            if (petType == "1" || petType == "Cat")
            {
                petType = "cat";

            } else if (petType == "2" ||  petType == "Dog")
            {
                petType = "dog";

            } else if (petType == "3" || petType == "Rabbit")
            {
                petType = "rabbit";
            } else
            {
                Console.WriteLine("Invalid Input. Please try again"); // Member enter invalid value
                validStatus = false;
            }

            if (validStatus == true) // Member chose the correct pet type
            {
                Console.Write("You have choosen a " + petType + ". What would you like to name your " + petType + ": ");
                string petName = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Welcome! " + petName + "!. Let's take care of him.");
                Console.WriteLine();

                // Pet Status Monitoring
                int hunger = 5;
                int happiness = 5;
                int health = 5;

                while (validStatus)
                {
                    /* Default Status */
                    Console.WriteLine(petName +"'s Status");
                    Console.WriteLine("Hunger: "+hunger+"/10");
                    Console.WriteLine("Happiness: " + happiness + "/10");
                    Console.WriteLine("Health: " + health + "/10");
                    Console.WriteLine();

                    /* Action to do with play */
                    Console.WriteLine("Main Menu");
                    Console.WriteLine("1. Feed "+petName);
                    Console.WriteLine("2. Play with " +petName);
                    Console.WriteLine("3. Let "+petName+" rest");
                    Console.WriteLine("4. Exit");

                    Console.WriteLine();

                    Console.Write("Choose an action:");

                    string choice = Console.ReadLine();
                    Console.WriteLine();


                } // end of while loop

            }

        }
    }
}


