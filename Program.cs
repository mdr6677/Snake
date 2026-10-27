using System;

    namespace Snake
    {     
     internal class Program
     {  public static int x = 0;
        public static int y = 1;
       
         static public void Main(string[] args)
         {
            MainCycle.Maincycle();
          
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
            apple.cord[x] = rnd.Next(51);
            apple.cord[y] = rnd.Next(11);
            apple.isappleexist = true; }
            return apple;     
         }
       
     }
    }