//Input
int n = int.Parse(Console.ReadLine());
int totalPassengers = 0;
int[] passengerPerWagon = new int[n];

//Act
for (int i = 0; i < n; i++)
{
    int passengers = int.Parse((Console.ReadLine()));
    passengerPerWagon[i] = passengers;
    totalPassengers += passengers;
}
//Output
foreach (int passengers in passengerPerWagon)
{
    Console.Write(passengers+" ");
}
Console.WriteLine();
Console.WriteLine(totalPassengers);