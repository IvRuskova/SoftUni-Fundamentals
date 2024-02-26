//Input
int[] array = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
//Act
if (array.Length == 1)
{
    Console.WriteLine(0);
    return;
}
int leftSum = 0;
int rightSum = 0;
for (int i = 0; i <= array.Length-1; i++)
{
    for (int j = 0; j < i; j++)
    {
        leftSum += array[i];
    }
    for (int j = array.Length-1; j > i; j--)
    {
        rightSum += array[j];
    }
    if (leftSum == rightSum)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine("no");