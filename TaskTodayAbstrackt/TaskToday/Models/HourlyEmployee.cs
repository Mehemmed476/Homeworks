using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskToday.Models
{
    internal class HourlyEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public double HourlyWorked { get; set; }

        public HourlyEmployee(string name, string surname, int age, double hourlyRate, double hourlyWorked) : base(name, surname, age)
        {
            HourlyRate = hourlyRate;
            HourlyWorked = hourlyWorked;
        }

        protected override double CalculateSalary()
        {
            return HourlyRate * HourlyWorked;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id} \nName: {Name} \nSurname: {Surname}\nAge: {Age} \nHourly Salary: {HourlyRate} \nWorked Hours: {HourlyWorked} \nSalary: {CalculateSalary()}");
        }
    }
}
