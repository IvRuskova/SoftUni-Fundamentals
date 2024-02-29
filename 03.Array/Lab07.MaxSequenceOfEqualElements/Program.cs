
int[] array = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int startNum = 0;
int countNums = 0;
int maxLength = int.MinValue;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == array[i+1])
    {
        countNums++;
        if (countNums>maxLength)
        {
            maxLength = countNums;
            startNum = i-countNums;
        }
    }
    else
    {
        countNums = 0;
    }
}
for (int j = startNum+1; j < startNum+maxLength; j++)
{
    Console.Write(array[j]+" ");
}
