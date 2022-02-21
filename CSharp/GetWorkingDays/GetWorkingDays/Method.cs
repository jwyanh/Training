using System;


namespace ConvertDate_Jiewen
{
	public class Method
	{
		public string[] InputDate()
		{
			Console.WriteLine("Input first Date:");
			string[] Num = new string[2];

			Num[0] = Console.ReadLine();

			Console.WriteLine("Input Second Date:");
			Num[1] = Console.ReadLine();

			return Num;
		}


	}
}
