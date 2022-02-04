using System;
namespace ColorBall
{
    class Program
    {
        public static void Main()
        {

            Color color1 = new Color(112, 12, 12);
            color1.getGreyScale();
            Color color2 = new Color(112, 222, 12);
            color2.getGreyScale();

            Ball ball1 = new Ball(10, color1);
            Ball ball2 = new Ball(20, color2);
            ball1.Throw();
            ball1.Throw();
            ball1.Throw();
            int number = ball1.num;
            Console.WriteLine("The number of times it has been thrown is "+number.ToString());
            ball1.Pop();
        }
    }
}