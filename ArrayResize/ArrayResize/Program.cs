#region task1

Console.WriteLine("Arrays length:");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Enter arrays " + i + " element:");
    arr[i] = int.Parse(Console.ReadLine());
}

int currentLenght = arr.Length;
int sqrt;
for (int i = 0; i < currentLenght; i++)
{
    sqrt = arr[i] * arr[i];
    Array.Resize(ref arr, arr.Length + 1);
    arr[arr.Length - 1] = sqrt;
}
Console.WriteLine("-----------------------");

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i]);
}

#endregion

#region task2

Console.WriteLine("Arrays length:");
int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Enter arrays " + (i + 1) + " element:");
    arr[i] = int.Parse(Console.ReadLine());
}

int[] arr = {1, 2, 3, 4, 5, 6 };

int[] copyArr = new int[arr.Length];

Array.Copy(arr, copyArr, arr.Length);

int currentLength = arr.Length;

for (int i = 0; i < currentLength * 2; i++)
{
    Array.Resize(ref arr, arr.Length + 1);
    
    if (i % 2 == 1)
    {
        arr[i + 1] = copyArr[i / 2];
        continue;
    }
    
    if (arr[i] % 2 == 0)
    {
        arr[i + 1] = arr[i] - 3;
    }
    else
    {
        arr[i + 1] = arr[i] + 5;
    }
}

foreach (int i in arr)
{
    Console.Write(i + " ");
}

#endregion