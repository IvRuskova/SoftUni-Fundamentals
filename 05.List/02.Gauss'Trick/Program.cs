﻿
List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
int originalLength = nums.Count;
for (int i = 0; i < originalLength/2; i++)
{
    nums[i] += nums[nums.Count - 1];
    nums.RemoveAt(nums.Count - 1);
}
Console.WriteLine(string.Join(" ",nums));