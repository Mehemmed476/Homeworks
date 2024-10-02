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