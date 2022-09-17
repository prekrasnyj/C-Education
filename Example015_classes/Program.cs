using System;
using System.Collections.Generic;
using System.Threading.Tasks;


enum Color
{
    Red,
    Green,
    Orange
}
class Point
{
    public int x;
    public int y;

}

class Program
{
    static void Main(string[] args)
    {
        Point p = new Point();
        p.x = 4;
        p.y = 2;

        Point p2 = new Point();
        p2.x = 2;
        p2.y = 6;

        Console.WriteLine(p.x);
        Console.WriteLine(p.y);
        Console.WriteLine($"X: {p.x}  |  Y: {p.y}");
    }
}
