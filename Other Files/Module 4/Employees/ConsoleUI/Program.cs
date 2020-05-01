using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

/**
 * 4/1/2020
 * CSC 153
 * Mathias Beharry
 **/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create variable for user input and sentry for loop
            bool exit = false;

            List<Employee> employees = new List<Employee>();

            // Do while loop for menu
            do
            {
                Console.Write(StandardMessages.DisplayMenu());
                // Switch to direct to proper process
                switch (Console.ReadLine())
                {
                    case "1":
                        BuildEmployees.BuildEmployeeClassObjects(employees);
                        Console.WriteLine("");
                        Console.WriteLine(StandardMessages.DisplayEmployee(employees[employees.Count - 1])); //WL in the create employee case to show the user what info they entered
                        break;
                    case "2":
                        Console.WriteLine("");
                        for (int i = 0; i < employees.Count; i++)
                        {
                            Console.WriteLine(StandardMessages.DisplayEmployee(employees[i])); //For loop to display everything in the list
                        }
                        Console.WriteLine("");
                        break;
                    case "3":
                        Console.WriteLine("");
                        if (employees.Count == 0)  //If statement is created just incase the user enters 3 as the first command
                        {                          //the program will tell the user to enter an employee's information first
                            Console.WriteLine(StandardMessages.ListIsEmptyError()); 
                            Console.WriteLine("");
                            break;
                        }
                        else
                        {
                            Console.WriteLine(StandardMessages.DisplayAverageAge(employees)); //Average age is calculated with the .Average() method
                        }                                                                       //I wasn't sure if it belonged here in main or in StandardMessages since it uses a method
                        Console.WriteLine("");
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayNumberError());
                        Console.WriteLine("");
                        break;
                }
            } while (exit == false);
        }
    }
}
