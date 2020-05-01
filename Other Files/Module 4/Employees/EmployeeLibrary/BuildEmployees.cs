using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class BuildEmployees
    {
        public static void BuildEmployeeClassObjects(List<Employee> classList)
        {
            Employee employees = new Employee();

            Console.Write(StandardMessages.PromptForName());
            employees.EmpName = Console.ReadLine();

            Console.Write(StandardMessages.PromptForNumber());
            employees.EmpPhoneNumber = Console.ReadLine();

            Console.Write(StandardMessages.PromptForAge());
            employees.EmpAge = ConvertToInt(Console.ReadLine());

            classList.Add(employees);
        }

        public static int ConvertToInt(string input)
        {
            int output = 0;

            if (int.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                Console.WriteLine(StandardMessages.DisplayNumberError());
                Console.Write(StandardMessages.PromptForAge());
                output = ConvertToInt(Console.ReadLine());
                return output;
            }
        }
    }
}
