Console.WriteLine("How much is your salary: ");
float salary = float.Parse(Console.ReadLine());

Console.WriteLine("How much money do you want to get?: ");
float creditAmount = float.Parse(Console.ReadLine());

float percent = 0.6f;
float yearlySalary = salary * 12f;

if (yearlySalary * percent > creditAmount)
{
    Console.WriteLine("You can get credit");
}
else
{
    Console.WriteLine("You can't get credit");
}