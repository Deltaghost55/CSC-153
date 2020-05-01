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

namespace EmployeeLibrary
{
    public static class StandardMessages
    {
        public static string EnterName(string[] employeeNames, int nameIndex)
        {
            string input = Console.ReadLine();
            employeeNames[nameIndex] = input;
            return "Enter employee's Name -> ";
        }

        public static string EnterNumber()
        {
            return "Enter employee's Phone Number -> ";
        }
        public static string EnterAge()
        {
            return "Enter employee's Age -> ";
        }

        //public static string DisplayEmployee()
        //{
        //    return "Enter employee's Name -> ";
        //}
        //public static string DisplayAverageAge()
        //{
        //    return "Enter employee's Name -> ";
        //}
        //public static string EnterName(string[] employeeNames, int nameIndex, string input)
        //{
        //    //Console.Write("Enter employee's Name -> ");
        //    //input = Console.ReadLine();
        //    //employeeNames[nameIndex] = input;
        //    //nameIndex = nameIndex + nameIndex;
        //    //Console.WriteLine("");
        //    return "test";
        //}

        //public static int EnterNumber()
        //{
        //    Console.WriteLine("2. Enter employee's phone number.");
        //    int output = Convert.ToInt32(Console.ReadLine());
        //    return output;
        //}

        //public static int EnterAge()
        //{
        //    return 20;
        //}

        //public static void DisplayEmployee()
        //{

        //}

        //public static void DisplayAverageAge()
        //{

        //}
    }
}
