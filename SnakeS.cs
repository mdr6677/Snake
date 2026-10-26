using System;
namespace Snake
{ 
	public class SnakeS { //class parent of snake
        public static int x = 0;
        public static int y = 1;
        public static string axis = "+y";
		public static SnakePix[] snakepix = new SnakePix[snakelenght];
		private static int snakelenght = 4;

		public SnakePix[] Pixmove(SnakePix[] snakepix)
		{ //each pixel take after forvard
			for (int i = snakelenght - 1; i > 0; i--)
			{ snakepix[i] = snakepix[i - 1]; }
			return snakepix;
		}
		public static void SnakeMove(ConsoleKeyInfo keyInfo)
        {
			switch (keyInfo.Key)
			{

				case ConsoleKey.UpArrow:
                    snakepix[0].cord[y]++;
                    break;
				case ConsoleKey.DownArrow:
                    snakepix[0].cord[y]--;
                    break;
				case ConsoleKey.RightArrow:
                    snakepix[0].cord[x]++;
                    break;
				case ConsoleKey.LeftArrow:
                    snakepix[0].cord[x]--;
                    break;
                default:
					break;
            }
                    
		}
		public bool AppleEat(int[] cord)
		{ if (snakepix[0].cord == cord)
			{ snakelenght++;
				return false;
			}
			else
			{ return true; }

		}
		public struct SnakePix()
		{
			public int[] cord = new int[2];
		}
		public SnakeS()
		{

		}


	}
  
}
