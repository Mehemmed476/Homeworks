using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToday.Models
{
    internal class SalariedEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public SalariedEmployee(string name, string surname, int age, double monthlySalary) : base(name, surname, age)
        { 
            MonthlySalary = monthlySalary;
        }

        protected override double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id} \nName: {Name} \nSurname: {Surname}\nAge: {Age} \nMonthly Salary: {CalculateSalary}");
        }
    }
}
