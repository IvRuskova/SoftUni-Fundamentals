//Input
int[] array = Console.ReadLine()
    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rotation = int.Parse(Console.ReadLine());
//int rotaionCountReduced = rotation % array.Length; 
//Act
for (int i = 0; i < rotation; i++)
{
    int firtElement = array[0];
    for (int j = 0; j < array.Length-1; j++)
    {
        array[j] = array[j+1];
    }
    array[array.Length-1] = firtElement;
}
//Output
Console.WriteLine(string.Join(" ",array));


