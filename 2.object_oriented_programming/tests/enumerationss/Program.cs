// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


Season current = Season.Summer;

if (current == Season.Summer || current == Season.Winter)
    Console.WriteLine("Happy solstice!");
else
    Console.WriteLine("Happy equinox!");

enum Season { Winter, Spring, Summer, Fall }


// Enum precisa