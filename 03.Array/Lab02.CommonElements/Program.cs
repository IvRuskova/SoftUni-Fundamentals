//Input
string[] strings1=Console.ReadLine()
    .Split(" ")
    .ToArray();
string[] strings2= Console.ReadLine()
    .Split(" ")
    .ToArray();

//Act
foreach (string element in strings2)
{
    if (Array.Exists(strings1,e=>e==element))
    {
        //Output
        Console.Write(element+" ");
    }
}
