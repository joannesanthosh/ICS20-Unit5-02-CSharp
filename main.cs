// Created by: Joanne Santhosh
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int number;
      
        // input
        Console.WriteLine("Please enter a positive or negative number:");
        number = int.Parse(Console.ReadLine());

        // process
        if (number < 0)  {
        Console.WriteLine("The number is negative!");
        } else  {
        Console.WriteLine("The number is positive!");
        }
        Console.WriteLine("Done.");
    }
}    