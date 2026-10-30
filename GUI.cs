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
        private StringBuilder sb = new StringBuilder();

        public static void FrameInit()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    frame[j, i] = '.';
                }
            }
          
        }

        public static void SnakeDraw(SnakeS.SnakePix[] snakepix1,int snakelength)
        { 
            for (int i = 0; i < snakelength; i++)
            { frame[snakepix1[i].cord[x], snakepix1[i].cord[y]] = '□'; }
            
         
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
                Console.WriteLine();
            }
        }
        public static void FrameDr()

        {

            
        }
    }

}
