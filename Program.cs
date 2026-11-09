using System;
using System.Text;
using System.Xml.Linq;

    namespace Snake
    {     
     internal class Program
     {  public static int x = 0;
        public static int y = 1;
       
         static public void Main(string[] args)
         {
          Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.UTF8;
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
         static public Apple AppleSpawn(Apple apple)
         {
            if (!apple.isappleexist) { 
                Random rnd = new Random();
            apple.cord[x] = rnd.Next(50);
            apple.cord[y] = rnd.Next(10);
            apple.isappleexist = true;
                return apple;
            }
            return apple;     
         }
       
     }
    }