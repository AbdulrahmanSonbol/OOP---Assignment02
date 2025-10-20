using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment02___OOP
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public decimal salary;
        // prop public int MyProperty { get; set; }
        // propfull

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value < 5000 ? 5000 : value;
            }
        }


        public Employee()
        {
            Id = default;
            Name = default;
            salary = default;
        }

        public Employee(int id, string name, decimal salary)
        {
            this.Id = id;
            this.Name = name;   
            this.salary = salary;

        }

        public override string ToString()
        {
            return $"id =\t {Id}\nname =\t {Name}\nsalary = {salary} ";
        }




        
    }
}
