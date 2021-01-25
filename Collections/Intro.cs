﻿using System;

namespace Collections
{
    class Intro
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wensday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine("Before:");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nAfter:");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            Console.WriteLine("Which day do you want to display?");
            Console.Write("(Monday = 1, etc.) > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay-1];
            Console.WriteLine($"That day is {chosenDay}");

        }
    }
}
