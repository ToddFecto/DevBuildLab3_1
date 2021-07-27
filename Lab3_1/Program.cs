using System;

namespace Lab3_1
{
    class Program
    {
        static bool KeepGoing()
        {
            // Version 0.04. (Agile Programming)

            while (true)
            {
                // Print out message asking if user wants to continue

                Console.Write("Would you like to know about another student? (enter 'yes' or 'no'): ");
                
                // Ask the user for their input

                string response = Console.ReadLine();
                response = response.ToLower();
                //Console.WriteLine();

                // Check if they typed "y". If so, return true.
                // Otherwise return false.   YES   yes

                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter yes or no");
                    //Console.WriteLine();
                }
            }

        }

        static bool outRange()
        {
            // Version 0.04. (Agile Programming)

            while (true)
            {
                // Ask the user for valid input range choice
                Console.WriteLine("That student does not exist. Please try again. (enter a number 1 - 3): ");
                string entry = Console.ReadLine();
                int userIn = int.Parse(entry);

                if (userIn < 0 || userIn > 3)
                {
                    return true;
                }
                else if (userIn == 1 || userIn == 2 || userIn == 3)
                {
                    return false;
                }
                //else
                //{
                //    Console.WriteLine("That student does not exist. Please try again. (enter a number 1 - 3): ");
                //}
            }

        }
        static void Main(string[] args)
        {
            do
            {
                string entry;
                int input = 0;
                string[] names = { "Luke Skywalker", "Han Solo", "Lando Calrissian" };
                string[] favFood = { "Lasagna", "Steak", "chicken" };
                string[] prevTitle = { "Jedi Master", "Scoundrel", "Smuggler" };

                Console.WriteLine("Welcome to our DevBuild class. Which student would you like to learn more about?");

                do
                {
                    Console.Write("Enter a number 1 - 3: ");
                    entry = Console.ReadLine();

                    do
                    {
                        Console.WriteLine("That student does not exist. Please try again. (enter a number 1 - 3): ");
                    } while (outRange());
                }
                while (int.TryParse(entry, out input) == false);

                //for (int i = 0; i < names.Length; i++)
                // {
                //Console.WriteLine($"{userIn} {names[userIn]}");
                // }



            //if (entry == "A")
            //{
            //    // print everything
            //    for (int i = 0; i < names.Length; i++)
            //    {
            //        Console.WriteLine($"{i + 1} {names[i]} {favFood[i]} {prevTitle[i]}");
            //    }
            //}
            //else

            // Convert it to a number, for an index into the arrays
            int choice = int.Parse(entry);
                    Console.Write($"Student {choice} is {names[choice - 1]}. What would you like to know about {names[choice - 1]}? (enter 'favorite food' or 'previous title'): ");

                    string moreInfo = Console.ReadLine();
                    moreInfo = moreInfo.ToLower();

                    // Check if they typed "y". If so, return true.
                    // Otherwise return false.   YES   yes

                    if (moreInfo == "favorite food")
                    {
                        Console.Write($"{names[choice - 1]}'s favorite food is {favFood[choice - 1]}.");
                    }
                    else if (moreInfo == "previous title")
                    {
                        Console.Write($"{names[choice - 1]}'s previous title was {prevTitle[choice - 1]}.");
                    }
            }
            while (KeepGoing());
            Console.WriteLine("Thanks!");
        }
    }
}
