using System;

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void PrintDetails()
    {
        Console.WriteLine("Printing details for shape...");
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * (Length + Breadth);
}

public class Square : Rectangle
{
    public double Side { get; set; }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}


//Single inheritance
//Multilevel inheritance
//Multiple inheritance

class A
{
}

class B : A
{
}

class C : B
{
}

class D: A, IX, IY
{
}

interface IX
{
}

interface IY
{
}