using System;
using AccessModifierAndMethods;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifier accessModifier = new AccessModifier();
            accessModifier.DoSomething();

            
            Person person = new Person();
            person.name = "Bijen";
            person.Age = 67;

            var x = person.Adress;
        }
    }
}
