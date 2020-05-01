using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class StandardMessages
    {
        public static string DisplayMenu()
        {
            return "1. Enter employee's information.\n"+
                "2. Display employee's information.\n"+
                "3. Display average age of employees.\n"+
                "4. Exit\n"+
                "--> ";
        }

        public static string PromptForName()
        {
            return "Enter employee's Full Name -> ";
        }

        public static string PromptForNumber()
        {
            return "Enter employee's Phone Number -> ";
        }

        public static string PromptForAge()
        {
            return "Enter employee's Age -> ";
        }

        public static string DisplayNumberError()
        {
            return "\nNot a vaild number!\n";
        }

        public static string ListIsEmptyError()
        {
            return "Please enter an employee first.";
        }

        public static string DisplayEmployee(Employee employee)
        {
            return $"Employee's Name: {employee.EmpName} \nEmployee's Phone Number: {employee.EmpPhoneNumber} \nEmployee's Age: {employee.EmpAge}\n";
        }

        public static string DisplayAverageAge(List<Employee> employees)
        {
            return $"Average age of employees: {employees.Average(item => item.EmpAge)}";
        }
    }
}
