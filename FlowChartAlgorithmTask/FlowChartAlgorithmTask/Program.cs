#region Task1

int num;

do
{
    Console.WriteLine("Enter three-digit number: ");
    num = int.Parse(Console.ReadLine());
    
    if (num > 99 && num < 1000)
    {
        int firstStage, secondStage, thirdStage;

        firstStage = num / 100;
        secondStage = (num / 10) % 10;
        thirdStage = num % 10;

        int sum = firstStage + secondStage + thirdStage;

        if (sum % 2 == 0)
        {
            Console.WriteLine("The answer is even.");
            break;
        }
        else
        {
            Console.WriteLine("The answer is odd.");
            break;
        }
    }
    else
    {
        Console.WriteLine("The number isn't three-digit. Please try again.");
    }
} while (true);

#endregion

#region Task2

int num;

do
{
    Console.WriteLine("Enter four-digit number: ");
    num = int.Parse(Console.ReadLine());
    
    if (num > 999 && num < 10000)
    {
        int firstStage, secondStage, thirdStage, fourthStage;

        firstStage = num / 1000;
        secondStage = (num / 100) % 10;
        thirdStage = (num / 10) % 10;
        fourthStage = num % 10;

        float numAverage = (firstStage + secondStage + thirdStage + fourthStage) / 4f;
        Console.WriteLine("The Answer is: " + numAverage);
        break;
    }
    else
    {
        Console.WriteLine("The number isn't four-digit. Please try again.");
    }
} while (true);

#endregion

#region Task3

int num;

do
{
    Console.WriteLine("Enter three-digit number: ");
    num = int.Parse(Console.ReadLine());
    
    if (num > 99 && num < 1000)
    {
        int firstStage, secondStage, thirdStage;

        firstStage = num / 100;
        secondStage = (num / 10) % 10;
        thirdStage = num % 10;

        int sum = firstStage + secondStage + thirdStage;
        int checkValue1 = 3, checkValue2 = 5;
        
        if (sum % checkValue1 == 0 && sum % checkValue2 == 0)
        {
            Console.WriteLine("Its True.");
            break;
        }
        
        else if (sum % checkValue1 != 0 && sum % checkValue2 == 0)
        {
            Console.WriteLine("Its False, because it is not divisible by 3.");
            break;
        }
        else if (sum % checkValue1 == 0 && sum % checkValue2 != 0)
        {
            Console.WriteLine("Its False, because it is not divisible by 3.");
            break;
        }
        else
        {
            Console.WriteLine("Its absolutely false.");
            break;
        }
    }
    else
    {
        Console.WriteLine("The number isn't three-digit. Please try again.");
    }
} while (true);

#endregion

#region Task4

Console.WriteLine("Your Exam Point: ");
float examPoint= float.Parse(Console.ReadLine());

switch (examPoint)
{
    case float n when (n >= 51f && n < 61f):
        Console.WriteLine("E");
        break;
    case float n when (n >= 61f && n < 71f):
        Console.WriteLine("D");
        break;
    case float n when (n >= 71f && n < 81f):
        Console.WriteLine("C");
        break;
    case float n when (n >= 81f && n < 91f):
        Console.WriteLine("B");
        break;
    case float n when (n >= 91f && n <= 100f):
        Console.WriteLine("A");
        break;
    default:
        Console.WriteLine("you are disqualified");
        break;
}

#endregion

#region Task5

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

#endregion

#region Task6

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

#endregion
