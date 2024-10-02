Console.WriteLine("Enter first number: ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int num2 = int.Parse(Console.ReadLine());

int answer;

if (num1 % 2 == 0 && num2 % 2 == 0)
{
    answer = num1 + num2;
    Console.WriteLine("Both of numbers are even!!! Answer: " + answer);
}

else if (num1 % 2 != 0 && num2 % 2 == 0)
{
    answer = num1 - num2;
    Console.WriteLine("Your first number is odd!!! Answer: " + answer);
}

else if (num1 % 2 == 0 && num2 % 2 != 0)
{
    answer = num1 - num2;
    Console.WriteLine("Your second number is odd!!! Answer: " + answer);
}

else
{
    answer = num1 - num2;
    Console.WriteLine("Both of numbers are odd!!! Answer: " + answer);
}


