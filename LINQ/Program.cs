  
using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // LINQ - Language INtegrated Query
            int[] numbers = { 23, 45, 67, 12, 34, 45, 78, 90, 11, 14, 16, 27 };
            //Find all the elements from numbers array which are less than 75 and greater than 20

            // Using method syntax - lambda expression
            var result1 = numbers.Where(x => x < 75 && x > 20);

            // Query syntax - query expression 
            var result2 = from x in numbers
                          where x < 75 && x > 20
                          select x;

            string[] names = { "Bijen", "Bipin", "Rojeena", "Sanjana", "Anjana" };

            // Find names that starts with letter 'B' and having length less than 6
            var result3 = from name in names
                          where name.StartsWith("B") && name.Length < 6
                          select name;

            // Projections
            var result4 = from num in numbers
                          select num * num;

            // Ordering
            var result5 = from num in numbers
                          orderby num
                          select num;

            // Partitioning
            var result6 = numbers.Take(5);
            var result7 = numbers.Skip(5).Take(5);

            // Quantifiers
            var isEvenThere = numbers.Any(num => num % 2 == 0);
            var areAllEvens = numbers.All(num => num % 2 == 0);
            var is26there = numbers.Contains(26);

            var result8 = Enumerable.Range(1, 1000);
            var result9 = Enumerable.Repeat("Hello world", 10);


            List<Person> people = new List<Person>()
            {
                new Person() {Id = 1, FirstName = "Bijen", LastName = "Shrestha", Address="Bhaktapur", Age = 24},
                new Person() {Id = 2, FirstName = "Sabin", LastName = "Thapa", Address="ktm", Age = 12},
                new Person() {Id = 3, FirstName = "A", LastName = "Thapa", Address="ktm", Age = 34},
                new Person() {Id = 4, FirstName = "B", LastName = "Shrestha", Address="Bhaktapur", Age = 45},
                new Person() {Id = 5, FirstName = "C", LastName = "Shrestha", Address="Bhaktapur", Age = 11},
                new Person() {Id = 6, FirstName = "D", LastName = "Lama", Address="ktm", Age = 16},
            };


            // Find all people who live in kathmandu?
            var result10 = from person in people
                           where person.Address == "ktm"
                           select person;
            
            //Find all minors who live in bhaktapur
            var result11 = from person in people
                           where person.Age < 18 && person.Address == "Bhaktapur"
                           select person;


        }
    }
}