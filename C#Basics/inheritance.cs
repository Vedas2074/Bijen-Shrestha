using System;

// abstract class only let us create derived object, not parent object
public abstract class Shape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Printing details for shape...");
    }
}

// Interface
public interface IDiagonalComputable
{
    public double GetDiagonalLength();
}

public class Rectangle : Shape, IDiagonalComputable
{
    // constructor initialization in object
    public Rectangle(double l, double b)
    {
        this.Length = l;
        this.Breadth = b;
    }

    public double Length { get; set; }
    public double Breadth { get; set; }
    public override double GetArea() => Length * Breadth;
    public override double GetPerimeter() => 2 * (Length + Breadth);

    public double GetDiagonalLength() => Math.Sqrt(Length * Length + Breadth * Breadth);

    public override void PrintDetails()
    {
        Console.WriteLine("Printing details for shape...");
        // string interpolation
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        Console.WriteLine($"Area: {this.GetArea()}, Perimeter: {this.GetPerimeter()}");
        
    }
}

public class Square : Rectangle
{
    public Square(double s) : base(s, s)
    {
    }
   
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