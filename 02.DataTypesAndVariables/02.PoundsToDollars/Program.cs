// See https://aka.ms/new-console-template for more information
decimal britishPounds = decimal.Parse(Console.ReadLine());
decimal usDollars = britishPounds * 1.31m;
Console.WriteLine($"{usDollars:f3}");