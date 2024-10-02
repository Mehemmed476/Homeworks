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