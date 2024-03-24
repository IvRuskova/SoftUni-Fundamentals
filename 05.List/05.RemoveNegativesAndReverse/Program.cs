List<int> numbers =Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
for (int i = 0; i < numbers.Count; i++)
{
    int count = 0;
    if (numbers[i]<= 0 )
    {
        numbers.RemoveAt(i);
        i -= 1;
        count++;
        if (count == numbers.Count)
        {
            Console.WriteLine("empty");
            return;
        }
    }
    
}
numbers.Reverse();
Console.WriteLine(string.Join(" ", numbers));