using LearningClasses;
using System;
class Program
{
    static void Main2342()
    {       
        var person1 = new Person("Bijen", "Bhaktapur");
        var person2 = new Person("Ram", "Bhaktapur", 23);
        var person3 = new Person("Hari", "Thimi", 20);

        var person4 = new Person();
        
        // implementing static
        var x = Person.ScientificName;
        Person.Do();
        var y = Math.Sqrt(144);

        var s1 = Calculator.Sum<int>(23,45);
        var s2 = Calculator.Sum<decimal>(23234.34m,234.324m);
    }
}
