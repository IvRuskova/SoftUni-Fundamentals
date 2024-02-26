
int n = int.Parse(Console.ReadLine());

//Dynamic array
int[] array = new int[n];

//Reverse array
for (int i = array.Length-1; i >= 0; i++){}

//
for (int i = 0; i < array.Length; i++)
{
    for (int  j = 0;  j < i ;  j++)
    {
        //Elements before current index i
    }
    for (int j = i; j < array.Length; j++)
    {
        //Elements after current index i
    }
}
Console.WriteLine(string.Join(" ", array));