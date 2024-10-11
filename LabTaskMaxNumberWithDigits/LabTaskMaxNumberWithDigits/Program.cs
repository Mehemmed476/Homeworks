Console.Write("number: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[0];
int i = 0;

while (n > 0)
{
    Array.Resize(ref arr, arr.Length + 1);
    arr[i] = n % 10;
    n = n / 10;
    i++;
}

for (int j = 0; j < arr.Length; j++)
{
    for (int m = 0; m < arr.Length - 1; m++)
    {
        if (arr[m + 1] > arr[m])
        {
            int a = arr[m];
            arr[m] = arr[m + 1];
            arr[m + 1] = a;
        }
    }
}
double newNum = 0;
for (int j = 0; j < arr.Length; j++)
{
    newNum += arr[j] * Math.Pow(10, (arr.Length - 1) - j);
}

Console.WriteLine(newNum);