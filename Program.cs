using System;
using System.Text;
using System.Xml.Linq;

    namespace Snake
    {     
     internal class Program
     {  public static int x = 0;
        public static int y = 1;
        public static int h = 10;
        public static int w = 30;
        public static int gamespeed = 200;
        //static SnakeS snake = new SnakeS();
        static public void Main(string[] args)
         {
            
          Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
            //Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            while (true)
            {
                Console.WriteLine("PRESS TO START");
                Console.ReadKey(true);
                Console.Clear();
   try
            {
   MainCycle.Maincycle();
            }
            catch {
                    Console.WriteLine("GAME OVER");
                   
                }
            }

           
         
          
         }
         public struct Apple()
         {
            public int[] cord = { 0, 0 };
          public bool isappleexist = false;
         }
         static public Apple AppleSpawn(Apple apple, int snakelen)
         {  
            if (!apple.isappleexist) { 
                Random rnd = new Random();
            apple.cord[x] = rnd.Next(w);
            apple.cord[y] = rnd.Next(h);
                for (int i = 0; i < snakelen; i++)
                {
                    if (apple.cord[x] == SnakeS.snakepix[i].cord[x] && apple.cord[y] == SnakeS.snakepix[i].cord[y])
                    {
                        apple.isappleexist = false;
                        break;
                    }
                    else
                    {
                        apple.isappleexist = true;
                    }
                }

               
                return apple;
            }
            return apple;     
         }
       
     }
    }