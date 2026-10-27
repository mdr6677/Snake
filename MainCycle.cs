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
            
                apple = AppleSpawn(apple);
           apple.isappleexist = snake.AppleEat(apple.cord);
                GUI.AppleDraw(apple);
                GUI.SnakeDraw(SnakeS.snakepix[0]);
              
                GUI.FrameDraw();

                Console.WriteLine(SnakeS.snakepix[0].cord[0] + " " + SnakeS.snakepix[0].cord[1] + " " + apple.cord[0] + " " + apple.cord[1] + "\n " +   apple.isappleexist);
                Thread.Sleep(250);
            }


        }
    }
}
