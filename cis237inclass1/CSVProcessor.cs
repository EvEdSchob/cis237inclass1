using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToCSVFile, Employee[] employees)
        {
            //Declare the StreamReader
            StreamReader streamReader = null;

            try
            {
                string line;
                 
                //Instantiate the StreamReader
                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;


                //While we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Process the line
                    processLine(line, employees, counter++);
                }
                return true;
            }
            catch (Exception e)
            {
                //Output the details of the error. Exception and StackTrace
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
               //If the stream reader was instanciated, make sure it is closed
               //before exiting the reader
               if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

        private void processLine(string line, Employee[] employees, int index)
        {
            //Declare array of parts that will contain the results of splitting
            //the read in string
            string[] parts = line.Split(',');

            //Assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = decimal.Parse(parts[2]);

            //Add a new employee into the array that was passed in.
            employees[index] = new Employee(firstName, lastName, salary);
        }
    }
}
