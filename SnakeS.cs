using System;

public class SnakeS {
	public string axis = "+y";
	public static SnakePix[] snakepix = new SnakePix[snakelenght];
	public static int snakelenght = 4;

	static SnakePix[] Pixmove(SnakePix[] snakepix)
	{
		for (int i = snakelenght-1; i > 0; i--)
		{ snakepix[i] = snakepix[i - 1]; }


		return snakepix;
	}
			public struct SnakePix()
			{
			int[] cord = new int[2];
			}
	 public SnakeS()
		{

		}

	}
  
  
}
