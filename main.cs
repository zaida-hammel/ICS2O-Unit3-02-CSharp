// Created by: Zaida Hammel
// Created on: March 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the volume of a trapezoid
        float length;
        float width;
        float height;
        float volume;

        Console.WriteLine("This program calculates the area of a pyramid.");
        Console.WriteLine("");
        Console.Write("Enter length (mm): ");
        length = float.Parse(Console.ReadLine());
        Console.Write("Enter width (mm): ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter the height (mm): ");
        height = float.Parse(Console.ReadLine());

        volume = (length * width * height) / 3;

        Console.WriteLine("");
        Console.Write("Volume of the pyramid = " + volume.ToString("0.00") + " mm²");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}