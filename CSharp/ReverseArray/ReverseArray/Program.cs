using System;

namespace ReverseArray 
{
    class Program
    {
        public static void Main(string[] args)
        {

            MethodExample methodExample = new MethodExample();

            int[] numbers = methodExample.GenerateNumbers();

            //Printing array
            methodExample.PrintNumbersmethod(numbers);

            int[] ReverseNumber = methodExample.Reverse(numbers);
            methodExample.PrintNumbersmethod(ReverseNumber);


            //Fibonacci
            int input = 10;
            int[] Result = new int[input];

            for (int i = 0; i < Result.Length; i++)
                Result[i] = methodExample.Fibonacci(i+1);

            methodExample.PrintNumbersmethod(Result);

            
        }
    }
}