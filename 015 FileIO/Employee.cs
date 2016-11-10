using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_FileIO
{
    class Employee
    {
        private string name;
        private float salary;

        public Employee(string name, float salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
