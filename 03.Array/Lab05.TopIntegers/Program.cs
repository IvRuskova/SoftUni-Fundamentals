//Input
int[] array = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

//Act
int[] topInt =new int[array.Length];
int topIntIndex = 0;
for (int i = 0; i <= array.Length-1; i++)
{
    bool isTopInt = true;
    for (int j = i+1; j <= array.Length-1; j++)
    {
        if (array[i] <= array[j])
        {
            isTopInt = false;
            break;
        }
    }
    if (isTopInt)
    {
        topInt[topIntIndex] = array[i];
        topIntIndex++;
    }
}

//Input
for (int i = 0; i < topIntIndex; i++)
{
    Console.Write($"{topInt[i]} ");
}