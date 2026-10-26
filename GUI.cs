using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//

namespace Snake
{
    internal class GUI
    {
        public static int x = 0;
        public static int y = 1;
        public static char[,] frame = new char[50, 10];


        public static void SnakeDraw(SnakeS.SnakePix snakepix1)
        {
            frame[snakepix1.cord[x], snakepix1.cord[y]] = '*';
         
        }
        public static void AppleDraw(Program.Apple apple)
        {
            frame[apple.cord[x], apple.cord[y]] = '*';

        }
        public static void FrameDraw()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.Write(frame[j, i]);
                }
            }
        }
    }

}
