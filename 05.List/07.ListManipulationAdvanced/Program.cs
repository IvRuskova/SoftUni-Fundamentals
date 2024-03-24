
List<int> nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
bool flag=false;

while (true)
{
   string command = Console.ReadLine();
    if (command == "end")
    {
        if (flag)
        {
            Console.WriteLine(string.Join(" ", nums));
        }
        break;
    }
string[] tokens = command.Split();
switch (tokens[0])
{
    case "Add":
        int numToAdd = int.Parse(tokens[1]);
        nums.Add(numToAdd);
            flag = true;
        break;
    case "Remove":
        int numToRemove = int.Parse(tokens[1]);
        nums.Remove(numToRemove);
            flag = true;
        break;
    case "RemoveAt":
        int indexToRemove = int.Parse(tokens[1]);
        nums.RemoveAt(indexToRemove);
            flag = true;
        break;
    case "Insert":
        int numberToInsert = int.Parse(tokens[1]);
        int indexToInsert = int.Parse(tokens[2]);
        nums.Insert(indexToInsert, numberToInsert);
            flag = true;
        break;
        case "Contains":
            Contains(nums, tokens[1]);
            break;
        case " PrintEven":
            PrintEven(nums);
            break;
        case "PrintOdd":
            PrintOdd(nums);
            break;
        case "GetSum":
            GetSum(nums);
            break;
        case "Filter":
            Filter(nums, tokens[1], int.Parse(tokens[2]));
            break;

}


}
void Contains(List<int> nums, string number)
{
    if (nums.Contains(int.Parse(number)))
    {
        Console.WriteLine("Yes");
    }
    else 
    {
        Console.WriteLine("No such number");
    }
}
void PrintEven(List<int> nums)
{
    List<int> temp = new List<int>();
    temp = nums.Where(x => x % 2 == 0).ToList();
    Console.WriteLine(string.Join(" ",temp));
}
void PrintOdd(List<int> nums)
{
    List<int> temp = new List<int>();
    temp = nums.Where(x => x % 2 != 0).ToList();
    Console.WriteLine(string.Join(" ", temp));
}
void GetSum(List<int> nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Count; i++)
    {
        sum += nums[i];
    }
    Console.WriteLine(sum);
}

void Filter(List<int> nums, string operatorR, int number)
{
    List<int> temp = new List<int>();
    if (operatorR == "<")
    {
        temp = nums.Where(x => x < number).ToList();
    }
    else if(operatorR == ">")
    {
        temp = nums.Where(x=>x > number).ToList();
    }
    else if (operatorR == "<=")
    {
        temp = nums.Where(x => x <= number).ToList();
    }
    else if (operatorR == ">=")
    {
        temp = nums.Where(x => x >= number).ToList();
    }
    Console.WriteLine(string.Join(" ", temp));
}






