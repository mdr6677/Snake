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
		public static SnakePix[] snakepix = new SnakePix[]
			{ new SnakePix()
			};
		private static int snakelenght = 4;
	public static SnakePix[] SnakePar()
		{
			snakepix[0].cord[x] = 25;
            snakepix[0].cord[y] = 5;
            

            return snakepix;
		}
        public SnakePix[] Pixmove(SnakePix[] snakepix)
		{ //each pixel take after forvard
			
			for (int i = snakelenght - 1; i > 0; i--)
			{ snakepix[i] = snakepix[i - 1]; }
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
			if (cord[0] == snakepix[0].cord[0] && cord[1] == snakepix[0].cord[1])
			{
				snakelenght++;
				return false;
				
			}
		
				return true;
			

		}
		public struct SnakePix()
		{
			public int[] cord = {25,5 };
		}


	}
  
}
