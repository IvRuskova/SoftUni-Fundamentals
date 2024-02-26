//Input
int n = int.Parse(Console.ReadLine());
string[] array1=new string[n];
string[] array2 = new string[n];


//Act
for (int i = 0; i < n; i++)
{
	string[] num =Console.ReadLine()
		.Split(" ")
		.ToArray();
	string indexZeroElement = num[0];
	string indexOneElement = num[1];
	if (i%2 == 0)
	{
		array1[i] = indexZeroElement;
		array2[i] = indexOneElement;
	}
	else
	{
		array1[i] = indexOneElement;
		array2[i]= indexZeroElement;
	}
}

//Output
Console.WriteLine(string.Join(" ", array1)); 
Console.WriteLine(string.Join(" ", array2));