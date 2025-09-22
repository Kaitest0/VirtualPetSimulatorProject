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

                    /* Pet Care Action Start **/

                    if (UserChoice == "1") // Decreases hunger, slightly increases health
                    {
                        PetHunger -= 2;
                        PetHealth += 2;
                    
                        Console.WriteLine("You fed " + petName + ", his hunger decreses and health improves slightly");
                    }
                    else if (UserChoice == "2") // Increases happiness, increases hunger
                    {
                        if (PetHunger >= 8)
                        {
                            Console.WriteLine(petName + " is too hungry to play!");
                        }
                        else
                        {
                            PetHappiness += 2;
                            PetHunger += 2;
                        }
                    
                        Console.WriteLine("You played with " + petName + ". His happiness increases, but he is a bit hungrier.");
                    }
                    else if (UserChoice == "3") // Improves health, decreases happiness.
                    {
                        PetHealth += 2;
                        PetHappiness -= 2;
                    
                        Console.WriteLine(petName + " feels rested.");
                    }
                    else if (UserChoice == "4") // Check the pet's status
                    {
                        Console.WriteLine(petName + "'s Status");
                        Console.WriteLine("Pet Hunger: " + PetHunger + "/10");
                        Console.WriteLine("Pet Happiness: " + PetHappiness + "/10");
                        Console.WriteLine("Pet Health: " + PetHealth + "/10");
                        Console.WriteLine();
                    
                    }
                    else if (UserChoice == "5") // User chose to exit the app
                    {
                        validStatus = false;
                        Console.WriteLine("Thank you for playing with " + petName + ". Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please try again");
                    }
                    
                    /* Resetting the value to keep them between 0 to 10 */
                    
                    if (PetHappiness < 0)
                    {
                        PetHappiness = 0;
                    }
                    else if (PetHappiness > 10)
                    {
                        PetHappiness = 10;
                    }
                    
                    if (PetHealth < 0)
                    {
                        PetHealth = 0;
                    }
                    else if (PetHealth > 10)
                    {
                        PetHealth = 10;
                    }
                    
                    if (PetHunger < 0)
                    {
                        PetHunger = 0;
                    }
                    else if (PetHunger > 10)
                    {
                        PetHunger = 10;
                    }
                    
                    /* Pet Care Action End */


                } // end of while loop

            }

        }
    }
}


