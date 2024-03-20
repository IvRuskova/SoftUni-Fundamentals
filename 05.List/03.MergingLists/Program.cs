
List<int> num1 = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> num2 = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> resultNums = new List<int>();
int count = 0;
if (num1.Count >= num2.Count)
{
    count = num1.Count;
}
else
{
    count = num2.Count;
}
for (int i = 0; i < count; i++)
{
    if (num1.Count>i)
    {
        resultNums.Add(num1[i]);
    }
    if (num2.Count > i)
    {
        resultNums.Add(num2[i]);
    }
}

Console.WriteLine(string.Join(" ", resultNums));