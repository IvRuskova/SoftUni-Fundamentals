﻿using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (typeOfDay == "Weekday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("12$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("18$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("12$");
                }
                else if (age < 0)
                {
                    Console.WriteLine("Error!");
                }

            }
            else if (typeOfDay == "Weekend")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("15$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else if (64 < age && age <= 122)
                {
                    Console.WriteLine("15$");
                }
                else if (age < 0)
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (typeOfDay == "Holiday")
            {
                if (0 <= age && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if(64 < age && age<= 122)
                {
                    Console.WriteLine("10$");
                }
                else if (age < 0)
                {
                    Console.WriteLine("Error!");
                }
            }
            
            
        }
    }
}
