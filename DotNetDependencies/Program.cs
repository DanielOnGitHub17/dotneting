﻿using System.ComponentModel.DataAnnotations;
using Humanizer;

Console.WriteLine("Quantities:");
HumanizeQuanties();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizeDates();

static void HumanizeQuanties()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates(){
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}
