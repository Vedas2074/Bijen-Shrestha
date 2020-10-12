using System;
class IterationStatement
{
    static void Main12()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnForLoops();
        iterationStatement.LearnWhileLoops();
    }
    void LearnForLoops()
    {
        //For loop cannot be used if we dont know the upper bound.
        for(int i=0; i < 10; i++)
        {
            Console.WriteLine("Hello World!");
        }
        int[] numbers = { 4,5,65,75,45,67, 66 };
        // for (int x = 0; x < numbers.Length; x++)
        // {
        //     Console.WriteLine(numbers[x]);
        // }
        for (int x = 0; x < numbers.Length; x++)
         {
            if(numbers[x] % 2 == 0)
            Console.WriteLine(numbers[x]);
         }

        foreach (int num in numbers)
        {
            if(num % 2 == 0)
            Console.WriteLine(num);
        }

    }
    void LearnWhileLoops()
    {
        int[] numbers = { 4,5,65,75,45,67, 66 };
        int i = 0;
        while(i < numbers.Length)
        {
            if(numbers[i] % 2 != 0)  
            Console.WriteLine(numbers[i]);
            i++;
        }
    }
}