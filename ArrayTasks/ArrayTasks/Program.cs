#region task1

int n;

Console.WriteLine("How much number do you want?");
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int max = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0 && arr[i] > max)
    {
       max = arr[i]; 
    }
    else
    {
        continue;
    }
}

if (max == 0)
{
    Console.WriteLine("We don't have an even number"); 
}
else
{
    Console.WriteLine("The answer is: " + max);
}

#endregion

#region task2

int n;

Console.WriteLine("How much number do you want?");
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int min = 0;

foreach (int num in arr)
{
    if (num % 2 != 0)
    {
        min = num;
        break;
    }
}

if (min == 0)
{
    Console.WriteLine("We don't have an odd number");
}
else
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1 && arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            continue;
        }
    }

    Console.WriteLine("The answer is: " + min); 
}

#endregion

#region task3

int n;

Console.WriteLine("How much number do you want?");
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
int[] negativArr = new int[n];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int reversedIndex;
for (int i = 0; i < arr.Length; i++)
{
    reversedIndex = (arr.Length - 1) - i;
    negativArr[i] = arr[reversedIndex];
}

for (int i = 0;i < negativArr.Length; i++)
{
    Console.WriteLine(negativArr[i]);
}

#endregion

#region task4

int n;

Console.WriteLine("How much number do you want?");
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    count++;
}

Console.WriteLine("Arrays lenght is " + count);

#endregion

#region task5

Console.WriteLine("How much number do you want?");

int n;
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Which value do you look for?");
int value = int.Parse(Console.ReadLine());

Console.WriteLine("Arrays are: );
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int checker = 0, indexData = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == value)
    {
        indexData = i;
        checker++;
    }
}

if (checker > 0)
{
    Console.WriteLine("The answer is: YES its index is" + indexData);
    
}
else
{
    Console.WriteLine("This number isn't in our array");
}

#endregion

#region task6

Console.WriteLine("How much number do you want?");

int n;
n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

Console.WriteLine("Which value do you look for?");
int value = int.Parse(Console.ReadLine());

Console.WriteLine("Arrays are: );
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

int checker = 0, indexData = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == value)
    {
        indexData = i;
        checker++;
    }
}

if (checker > 0)
{
    Console.WriteLine("The answer is: " + checker);
}
else
{
    Console.WriteLine("This number isn't in our array");
}

#endregion