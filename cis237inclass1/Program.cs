using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the UI
            //UserInterface ui = new UserInterface();


            //Here is a new employee being created using the default
            //constructor written in the Employee class
            Employee myEmployee = new Employee();

            //Multiple instances of the Employee class using an array
            Employee[] employees = new Employee[10];

            //Put employees into the array
            //employees[0] = new Employee("Evan", "Schober", 343.00m);
            //employees[1] = new Employee("Lars", "Owen", 281.00m);
            //employees[2] = new Employee("Obi-Wan", "Kenobi", 350.00m);
            //employees[3] = new Employee("Jyn", "Urso", 750.00m);
            //employees[4] = new Employee("Cassian", "Andor", 750.00m);
            //employees[5] = new Employee("Wes", "Antilles", 150.00m);


            //Make the string for the path to the csv file
            string pathToCsv = "../employees.csv";

            //Instantiate the csvProcessor
            CSVProcessor csvProcessor = new CSVProcessor();
            //Call the ImportCSV method sending over the path and
            //the array to store th e read in records to.
            csvProcessor.ImportCSV(pathToCsv, employees);

            //Get some input from the user
            int choice = StaticUserInterface.GetUserInput();

            while (choice != 2)
            {
                //See if the input they sent is equal to 1.
                if (choice == 1)
                {
                    //Create a string that can be concantonated to
                    string outputString = "";

                    //Print out employees in the array
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            //Concantonate to outputString
                            outputString += employee.ToString() +
                                Environment.NewLine;
                        }

                    }
                    //Use the UI class to print out the string
                    StaticUserInterface.Output(outputString);
                }

                //Re-prompt for user input
                choice = StaticUserInterface.GetUserInput();
            }
            /* Employee[]
             * Foreach Employee in Employees
             * {
             *  {
             *      if(Emplyee is the one I want)
             *  }
             *  return Employee;
             * }
        }
    }
}
