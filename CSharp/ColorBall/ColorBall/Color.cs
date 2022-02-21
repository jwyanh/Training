using System;
namespace ColorBall
{
     class Color
	{
		int Red;
		int Blue;
		int Green;
		int Alpha = 225;


		public Color(int Red, int Blue, int Green, int Alpha)
		{
			this.Red = Red;
			this.Green = Green;
			this.Blue = Blue;
			this.Alpha = Alpha;
		}

		public Color(int Red, int Blue, int Green)
		{
			this.Red = Red;
			this.Green = Green;
			this.Blue = Blue;
		}

		public void getGreyScale()
        {
			double grey = (Red+Blue+Green)/3;
			Console.WriteLine("The greyscale is :"+grey.ToString());
        }
	}
}

