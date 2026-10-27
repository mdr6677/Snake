using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Snake.Program;

namespace Snake
{
    internal class MainCycle
    {  public static int x = 0;
        public static int y = 1;

        public static void Maincycle()
        {
            SnakeS snake = new SnakeS();
            Apple apple = new Apple();
            
            while (true)

            {
                GUI.FrameInit();
                Console.Clear();
                Control.Controls();
               apple.isappleexist = (snake.AppleEat(apple.cord);
                apple = AppleSpawn(apple);
                GUI.AppleDraw(apple);
                GUI.SnakeDraw(SnakeS.snakepix[0]);
              
                GUI.FrameDraw();

                Console.WriteLine();
                Thread.Sleep(500);
            }


        }
    }
}
