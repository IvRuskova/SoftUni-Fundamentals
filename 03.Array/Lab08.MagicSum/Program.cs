﻿
int[] array = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int sum=int.Parse(Console.ReadLine());

for (int i = 0; i < array.Length; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if (sum == array[i] + array[j])
        {
            Console.WriteLine(array[i]+ " "+ array[j]);
            
        }
    }
}