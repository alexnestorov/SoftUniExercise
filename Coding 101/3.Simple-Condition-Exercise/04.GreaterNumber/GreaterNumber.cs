﻿using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Enter two integers:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        if (firstNumber>secondNumber)
        {
            Console.WriteLine("Greater num: " + firstNumber);
        }
        else
        {
            Console.WriteLine("Greater num: " + secondNumber);
        }
    }
}
