using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mathias Beharry
            *CSC-153-0001
            */

            //string firstname;
            //Console.WriteLine("Hello");
            //Console.Write("Enter your First name: ");
            //firstname = Console.ReadLine();


            string[] employeeNames = new string[5];
            Console.Write("Enter employee's name: ");
            employeeNames[0] = Console.ReadLine();
            Console.Write("Enter employee's name: ");
            employeeNames[1] = Console.ReadLine();
            Console.Write("Enter employee's name: ");
            employeeNames[2] = Console.ReadLine();
            Console.Write("Enter employee's name: ");
            employeeNames[3] = Console.ReadLine();
            Console.Write("Enter employee's name: ");
            employeeNames[4] = Console.ReadLine();

            string[] employeeNumbers = new string[5] {$"910-813-6373 {employeeNames[0]}", $"910-465-8971 {employeeNames[1]}", $"910-851-3514 {employeeNames[2]}", $"910-165-1365 {employeeNames[3]}", $"910-135-1651 {employeeNames[4]}" };
            Console.WriteLine(employeeNumbers[0]);
            Console.WriteLine(employeeNumbers[1]);
            Console.WriteLine(employeeNumbers[2]);
            Console.WriteLine(employeeNumbers[3]);
            Console.WriteLine(employeeNumbers[4]);
            Console.Write("Enter employee's phone number: ");
            employeeNumbers[0] = Console.ReadLine();


            List<int> employeeAge = new List<int>();
            Console.Write("Enter employee's age: ");
            employeeAge[0] = Console.Read();

            Console.WriteLine(employeeNames[0], employeeNumbers[0], employeeAge[0]);

            Console.ReadLine();
        }
    }
}
