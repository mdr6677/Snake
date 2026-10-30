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
               SnakeS.SnakeInit();

            while (true)

            {  
                Console.Clear();
                GUI.FrameInit();
              
                Control.Controls();
   apple = AppleSpawn(apple);

           apple.isappleexist = snake.AppleEat(apple.cord);
              
               
              SnakeS.snakepix = snake.Pixmove(SnakeS.snakepix);
               SnakeS.SnakeMove();
                 
             
               
               GUI.AppleDraw(apple); 
                GUI.SnakeDraw(SnakeS.snakepix, snake.snakelength);
                GUI.FrameDraw();
                Console.WriteLine(SnakeS.snakepix[0].cord[0] + " " + SnakeS.snakepix[0].cord[1] + " " + apple.cord[0] + " " + apple.cord[1] + "\n " +   apple.isappleexist + " " + SnakeS.snakepix[1].cord[0] + " " + SnakeS.snakepix[1].cord[1] + " " + SnakeS.snakepix[2].cord[0] + " " + SnakeS.snakepix[2].cord[1]);
                Console.WriteLine(snake.snakelength + "🌍");
                Thread.Sleep(40);
              
              
                
            }


        }
    }
}
