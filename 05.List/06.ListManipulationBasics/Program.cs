
List<int> nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
string command; 
while (true)
{
   command = Console.ReadLine();
    if (command == "end")
    {
        break;
    }
    
}
string[] tokens = command.Split();
switch (tokens[0])
{
    case "Add":
        int numToAdd = int.Parse(tokens[1]);
        nums.Add(numToAdd);
        break;
    case "Remove":
        int numToRemove = int.Parse(tokens[1]);
        nums.Remove(numToRemove);
        break;
    case "RemoveAt":
        int indexToRemove = int.Parse(tokens[1]);
        nums.RemoveAt(indexToRemove);
        break;
    case "Insert":
        int numberToInsert = int.Parse(tokens[1]);
        int indexToInsert = int.Parse(tokens[2]);
        nums.Insert(indexToInsert, numberToInsert);
        break;
}
Console.WriteLine(string.Join(" ",nums));
