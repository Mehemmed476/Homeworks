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


