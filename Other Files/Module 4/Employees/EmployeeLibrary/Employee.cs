using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        // Fields
        private string _empName;
        private string _empPhoneNumber;
        private int _empAge;

        //Constructors
        public Employee()
        {
            EmpName = "";
            EmpPhoneNumber = "";
            EmpAge = 0;
        }

        public Employee(string name, string number, int age)
        {
            EmpName = name;
            EmpPhoneNumber = number;
            EmpAge = age;
        }

        // Properties
        public string EmpName
        {
            get
            {
                return _empName;
            }
            set
            {
                _empName = value;
            }
        }

        public string EmpPhoneNumber
        {
            get
            {
                return _empPhoneNumber;
            }
            set
            {
                _empPhoneNumber = value;
            }
        }

        public int EmpAge
        {
            get
            {
                return _empAge;
            }
            set
            {
                _empAge = value;
            }
        }
    }
}
