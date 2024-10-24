using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToday.Models
{
    internal abstract class Employee
    {
        private static int id;
        public int Id => id; 
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        protected Employee(string name, string surname, int age)
        {
            id++;
            Name = name;
            Surname = surname;
            Age = age;
        }

        protected abstract double CalculateSalary();
        public abstract void DisplayDetails();

    }
}
