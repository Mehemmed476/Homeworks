using TaskToday.Models;

bool running = true;
string workType;
string userName;
string userSurname;
int userAge;
double userHourlyRate;
double userHourlyWorked;
double userMonthlySalary;

while (running)
{
    Console.Write("Monthly / Dayly: ");
    workType = Console.ReadLine();

    Console.Write("Name: ");
    userName = Console.ReadLine();
    Console.Write("Surname: ");
    userSurname = Console.ReadLine();
    Console.Write("Age: ");
    userAge = int.Parse(Console.ReadLine());

    if (workType == "Dayly")
    {
        Console.Write("Hourly Rate: ");
        userHourlyRate = double.Parse(Console.ReadLine());
        Console.Write("Hourly Worked: ");
        userHourlyWorked = double.Parse(Console.ReadLine());

        HourlyEmployee newEmployee = new HourlyEmployee(userName, userSurname, userAge, userHourlyRate, userHourlyWorked);

        newEmployee.DisplayDetails();
    }

    else if (workType == "Monthly")
    {
        Console.Write("Salary: ");
        userMonthlySalary = double.Parse(Console.ReadLine());

        SalariedEmployee newEmployee = new SalariedEmployee(userName, userSurname, userAge, userMonthlySalary);

        newEmployee.DisplayDetails();
    }

    else
    {
        Console.WriteLine("Please check type");
        continue;
    }
}
