using LearningClasses;
using System;
class Program
{
    static void Main()
    {       
        // var person1 = new Person("Bijen", "Bhaktapur");
        // var person2 = new Person("Ram", "Bhaktapur", 23);
        // var person3 = new Person("Hari", "Thimi", 20);

        // var person4 = new Person();
        
        // // implementing static
        // var x = Person.ScientificName;
        // Person.Do();
        // var y = Math.Sqrt(144);

        // var s1 = Calculator.Sum<int>(23,45);
        // var s2 = Calculator.Sum<decimal>(23234.34m,234.324m);
        
        // Inheritance example
        Rectangle rectangle = new Rectangle(23.6, 6.32);
        Rectangle r = new Rectangle(25.6, 16.32);
        
        // {
        //     // object initializer
        //     Length = 23.6;
        //     Breadth = 6.32;
        // };

        // rectangle.Length = 23.6;
        // rectangle.Breadth = 6.32;

        r.GetDiagonalLength();
        
        var result = rectangle.GetArea();  
        rectangle.PrintDetails(); 

        Square s = new Square(34.56);
        var resultSquare = s.GetPerimeter();
        s.PrintDetails(); 

        Circle c = new Circle();
        c.Radius = 1.1;
    }
}
