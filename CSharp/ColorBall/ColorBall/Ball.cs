using System;
namespace ColorBall
{
    class Ball
	{
		public Color color;
		public int size;
		public int num = 0;//number of times it has been thrown

		public Ball(int size, Color color)
        {
			this.color = color;
			this.size = size;
		}
        public void Pop()
        {
			size = 0;
			Console.Write("You just pop this ball. It has size 0 and cannot be thrown \n");


		}

		public void Throw()
		{
			if (size != 0)
            {
				num += 1;
            }
			Console.Write("You just throw this ball \n");
		}
	}
}

