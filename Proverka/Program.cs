using CalcSquare;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        var ewr = new Triangle(3, 4, 5);
        Circle krug = new Circle(2);
        Console.WriteLine($"triangle square = {ewr.GetSquare()}\newr is right angle = {ewr.IsTriangleRightAngled}");
        Console.WriteLine($"circle square = {krug.GetSquare()}");
    }
}