using System;
namespace Snake
{
	public class SnakeS

	{ //class parent of snake
		public SnakeS() 
		{
			snakepix = SnakePar();
		}

		public static int x = 0;
		public static int y = 1;
		public static string axis = "+y";
       public int snakelength = 3;
		public static SnakePix[] snakepix = new SnakePix[500];
		public static void SnakeInit()
		{
            for (int i = 3; i < snakepix.Length; i++)
            {
				snakepix[i] = new SnakePix();
                
            }
           
		}
	public static SnakePix[] SnakePar()
		{
			snakepix[0].cord = new int[] { 25, 5 };
            snakepix[1].cord = new int[] { 25, 6 };
            snakepix[2].cord = new int[] { 25, 7 };

            return snakepix;
		}
        public SnakePix[] Pixmove(SnakePix[] snakepix)
		{ //each pixel take after forvard

			for (int i = snakelength - 1; i > 0; i--)
			{
				snakepix[i].cord[x] = snakepix[i - 1].cord[x];
				snakepix[i].cord[y] = snakepix[i - 1].cord[y];
            }
		
			return snakepix;
		}
		public static void SnakeMove()
		{
            switch (axis)
            {

                case "+y":
                    snakepix[0].cord[y]--;
                    break;
                case "-y":
                    snakepix[0].cord[y]++;
                    break;
                case "+x":
                    snakepix[0].cord[x]++;
                    break;
                case "-x":
                    snakepix[0].cord[x]--;
                    break;
                default:
                    break;
            }
        }
		public static void SnakeAxis(ConsoleKeyInfo keyInfo)
		{
			switch (keyInfo.Key)
			{

				case ConsoleKey.UpArrow:
                    axis = "+y";
					break;
				case ConsoleKey.DownArrow:
                    axis = "-y";
                    break;
				case ConsoleKey.RightArrow:
                    axis = "+x";
                    break;
				case ConsoleKey.LeftArrow:
					axis = "-x";
					break;
				default:
					break;
			}

		}
		public bool AppleEat(int[] cord)
		{
			if (cord[x] == snakepix[0].cord[x] && cord[y] == snakepix[0].cord[y])
			{
                snakelength++;
				return false;
				
			}
		
				return true;
			

		}
		public struct SnakePix()
		{
			public int[] cord = new int[2];
		}


	}
  
}
