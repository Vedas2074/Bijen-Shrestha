using System;
using System.Linq;

namespace AccessModifierAndMethods
{
    class Methods
    {
        void PrintInfo()
        {
            Console.WriteLine("Printing something...");
            Multiply(4.6f, 7.5f);
            Sum(8.9,9.8);

            Greet("Bijen", "Mr.");
            Greet("shrestha");

            byte[] sequence = {4, 3, 2, 5, 6, 89};
            //(byte Minimum, byte Maximum) result = FindMinMax(sequence);
            //Console.WriteLine(result.Minimum);

            PrintCustomerDetails(age: 57, name: "Bijen", address: "Thimi");
        }

        void PrintSomething(string message)
        {
            Console.WriteLine(message);
        }

        float Multiply(float firstNum, float secondNum)
        {
            float product = firstNum * secondNum;
            return product;
        }   
        float Multiply(float firstNum, float secondNum, float thirdNum)
        {
            float product = firstNum * secondNum * thirdNum;
            return product;
        }

        // variable arguments 
        double Sum(params double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum = sum + num;
            }

            return sum;
        }

        // optional arguments
        string Greet(string name, string prefix = "Miss")
        {
            string fullName = $"{prefix}, {name}"; //string interpolation
            //string fullName = prefix + "," + name;
            return fullName;
        }

        //Returning Multiple values : using tuple
        // (byte, byte) FindMinMax(byte[] numbers)
        // {
        //     byte max = numbers.Max();
        //     byte min = numbers.MIN();

        //     return (min, max);
        // }

        void PrintCustomerDetails(string name, string address, byte age)
        {
            Console.WriteLine($"{name}, {age}, {address}");
        }

        float Subtract(float firstNum, float secondNum) => firstNum - secondNum;
    }
}
