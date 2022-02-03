using System;

namespace ReverseArray
{
	class MethodExample
	{
		public int[] GenerateNumbers()
		{
			string Num = Console.ReadLine();
			int Input = Int16.Parse(Num);

			int[] Result = new int[Input];
			for (int i = 0; i < Result.Length; i++)
				Result[i] = i+1;

			return Result;
		}

		public void PrintNumbersmethod(int[] numbers)
        {
			foreach (var entry in numbers)
			{
				Console.Write(entry + " ");
			}
			Console.Write("\n");
		}

		public int[] Reverse(int[] array)
        {
			for (int i = 0; i <= array.Length / 2; i++)
			{
				int temp = array[i];
				array[i] = array[array.Length - i -1];
				array[array.Length - i-1] = temp;

			}
			return array;

		}

		public int Fibonacci(int Input)
        {
			if (Input == 1 || Input == 2)
            {
				return 1;
            }

			return Fibonacci(Input - 1) + Fibonacci(Input - 2);

		}
	}
}

