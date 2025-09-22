
                 
 /* Virtual Pet Simulator Project
 * Pet Creation : allow user to choose and name the pet
 * Pet Care Actions: Feed, Play, Rest
 * Pet Status Monitoring: Hunger, Happiness, Health
 * Time-based Changes: Simulate the passage of time - Hunger increases over time and happiness decreases slightly
 * Enhanced Interaction Logic : Health deterioration if the pet is too hungry or unhappy
 * User Interface and experince: simple, clear, and user-friendly console interface
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


                string petType = Console.ReadLine(); // Getting the type of pet
                Console.WriteLine();

                if (petType == "1" || petType == "Cat")
                {
                    petType = "cat";

                }
                else if (petType == "2" || petType == "Dog")
                {
                    petType = "dog";

                }
                else if (petType == "3" || petType == "Rabbit")
                {
                    petType = "rabbit";
                }
                else
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
                    int PetHunger = 5;
                    int PetHappiness = 5;
                    int PetHealth = 5;
                    int TrackingTimeInHour = 0; // To tracking the time for Time-Based Changes

                    while (validStatus)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Tracking time in hour: " + TrackingTimeInHour + ". Time slightly affects the pet's stats: hunger, happiness and health decrease");
                        Console.WriteLine();

                        /* Action to do with pet */
                        Console.WriteLine("Main Menu");
                        Console.WriteLine("1. Feed " + petName);
                        Console.WriteLine("2. Play with " + petName);
                        Console.WriteLine("3. Let " + petName + " rest");
                        Console.WriteLine("4. Check " + petName + "'s Status");
                        Console.WriteLine("5. Exit");

                        Console.WriteLine();

                        Console.Write("Choose an action:");

                        string UserChoice = Console.ReadLine();
                        Console.WriteLine();

                        /* Time-based Changes: Simulate the passage of time - Hunger increases 
                         * over time and happiness decreases slightly */
                        if (PetHappiness <= 2)
                        {
                            Console.WriteLine("It's time to play with " + petName + ". " + petName + " is not happy");
                        }
                        else
                        {
                            if (UserChoice == "1" || UserChoice == "3")
                            {
                                PetHealth--; // health deterioration if the pet is unhappy.
                                PetHappiness--;
                                TrackingTimeInHour++; // each loop will increate an hour
                            }
                            else if (UserChoice == "2")
                            {
                                PetHunger++;
                                PetHappiness++;
                                TrackingTimeInHour++; // each loop will increate an hour
                            }
                        }

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

