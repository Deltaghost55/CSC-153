using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 2/26/2020
 * CSC 153
 * Mathias Beharry
 **/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input;
            //const int SIZE = 5;
            //string[] employeeNames = new string[SIZE];
            //int nameIndex = 0;
            //int phoneIndex = 0;

            //EnterName(employeeNames);
            //Console.WriteLine(employeeNames[nameIndex]);
            //Console.ReadLine();

            // Create variable for user input and sentry for loop
            string input;
            bool exit = false;
            // Create constant Var
            const int SIZE = 5;

            int nameIndex = 0, phoneIndex = 0;

            string[] employeeNames = new string[SIZE];
            string[] employeePhone = new string[SIZE];
            List<int> employeeAge = new List<int>();

            // Do while loop for menu
            do
            {
                Console.WriteLine("1. Enter employee's name.");
                Console.WriteLine("2. Enter employee's phone number.");
                Console.WriteLine("3. Enter employee's age.");
                Console.WriteLine("4. Display employee's information.");
                Console.WriteLine("5. Display average age of employees.");
                Console.WriteLine("6. Exit");
                Console.Write("--> ");
                input = Console.ReadLine();

                // Switch to direct to proper process
                switch (input)
                {
                    case "1":
                        EmployeeLibrary.StandardMessages.EnterName();
                        Console.Write(EmployeeLibrary.StandardMessages.EnterName());
                        input = Console.ReadLine();
                        employeeNames[nameIndex] = input;
                        nameIndex++;
                        Console.WriteLine("");
                        break;
                    case "2":
                        Console.Write(EmployeeLibrary.StandardMessages.EnterNumber());
                        input = Console.ReadLine();
                        employeePhone[phoneIndex] = input;
                        phoneIndex++;
                        Console.WriteLine("");
                        break;
                    case "3":
                        int number = 0;
                        Console.Write(EmployeeLibrary.StandardMessages.EnterAge());
                        input = Console.ReadLine();

                        if (int.TryParse(input, out number))
                        {
                            employeeAge.Add(number);
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Not a vaild number!");
                            Console.WriteLine("");
                        }
                        break;
                    case "4":
                        for (int index = 0; index < employeeAge.Count; index++)
                        {
                            Console.WriteLine($"Employee Name - {employeeNames[index]}");
                            Console.WriteLine($"Employee Phone - {employeePhone[index]}");
                            Console.WriteLine($"Employee Age - {employeeAge[index]}");
                            Console.WriteLine("");
                        }
                        break;
                    case "5":
                        Console.WriteLine(employeeAge.Average());
                        Console.WriteLine("");
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        Console.WriteLine("");
                        break;
                }
            } while (exit == false);
        }
    }
}


//// Create variable for user input and sentry for loop

//bool exit = false;
//// Create constant Var




//string[] employeePhone = new string[SIZE];
//List<int> employeeAge = new List<int>();

//// Do while loop for menu
//do
//{
//    Console.WriteLine("1. Enter employee's name.");
//    Console.WriteLine("2. Enter employee's phone number.");
//    Console.WriteLine("3. Enter employee's age.");
//    Console.WriteLine("4. Display employee's information.");
//    Console.WriteLine("5. Display average age of employees.");
//    Console.WriteLine("6. Exit");
//    Console.Write("--> ");
//    input = Console.ReadLine();

//    // Switch to direct to proper process
//    switch (input)
//    {
//        case "1":
//            Console.Write("Enter employee's Name -> ");
//            input = Console.ReadLine();
//            employeeNames[nameIndex] = input;
//            nameIndex++;
//            Console.WriteLine("");
//            break;
//        case "2":
//            Console.Write("Enter employee's Phone Number -> ");
//            input = Console.ReadLine();
//            employeePhone[phoneIndex] = input;
//            phoneIndex++;
//            Console.WriteLine("");
//            break;
//        case "3":
//            int number = 0;
//            Console.Write("Enter employee's Age -> ");
//            input = Console.ReadLine();

//            if (int.TryParse(input, out number))
//            {
//                employeeAge.Add(number);
//                Console.WriteLine("");
//            }
//            else
//            {
//                Console.WriteLine("Not a vaild number!");
//                Console.WriteLine("");
//            }
//            break;
//        case "4":
//            for(int index = 0; index < employeeAge.Count; index++)
//            {
//                Console.WriteLine($"Employee Name - {employeeNames[index]}");
//                Console.WriteLine($"Employee Phone - {employeePhone[index]}");
//                Console.WriteLine($"Employee Age - {employeeAge[index]}");
//                Console.WriteLine("");
//            }
//            break;
//        case "5":
//            Console.WriteLine(employeeAge.Average());
//            Console.WriteLine("");
//            break;
//        case "6":
//            exit = true;
//            break;
//        default:
//            Console.WriteLine("Please enter a valid option");
//            Console.WriteLine("");
//            break;
//    }
//} while (exit == false);