using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        //No Variables
        //No Properties
        //No Constructors

        //********************************
        //Methods
        //********************************
        public int GetUserInput()
        {
            //Print out a menu
            printMenu();
            //Get the input from the user
            String input = Console.ReadLine();
            //While the input is not valid re-get the input
            while (input != "1" && input != "2")
            {
                //Print Error message
                printErrorMessage();
                //Re-Print the menu
                printMenu();

                //Get the input from the console again.
                input = Console.ReadLine();
            }
            //Input has been verified as valid as 1 or 2

            return Int32.Parse(input);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private void printMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print list");
            Console.WriteLine("2. Exit");
        }

        private void printErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please select a valid entry." + Environment.NewLine);
        }

    }
}
