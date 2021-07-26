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

                Console.Write("Would you like to go again? (y/n)");

                // Ask the user for their input

                string response = Console.ReadLine();
                response = response.ToLower();

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
                    Console.WriteLine("Please enter y or n");
                }
            }

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Lab 3.1: Student Information");
            //Console.WriteLine("Hello from lab 3.1");
            //Console.WriteLine("Here's another message.");
            int input = 0;
            string[] names = { "Todd Fecto", "Jeff Metzner", "Brandon Miller" };
            string[] favFood = { "Lasagna", "Steak", "chicken" };
            string[] prevTitle = { "Desktop Support", "Auditor", "Analyst" };

            do
            {
                Console.WriteLine("Welcome to our DevBuild class. Which student would you like to learn more about?");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1} {names[i]}");
                }
                Console.Write("Enter a number 1 - 3: ");
                string entry = Console.ReadLine();
                input = int.Parse(entry);

                //do
                //{
                //    Console.WriteLine("That student does not exist. Please try again. (enter a number 1 - 3): ");
                //} while (entry < "1" || > "3");
                if (entry == "A")
                {
                    // print everything
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} {names[i]} {favFood[i]} {prevTitle[i]}");
                    }
                }
                else
                {
                    // Convert it to a number, for an index into the arrays
                    int choice = int.Parse(entry);
                    Console.WriteLine($"{choice} {names[choice]}");
                }
            }
            while (KeepGoing());
        }
    }
}
