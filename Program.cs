using System;

namespace Snake
{    
    internal class Program
    {
        public static int x = 0;
        public static int y = 1;
        static public void Main(string[] args)
        {
          
            Apple apple = new Apple();
            AppleSpawn(apple);
          
        }
      public struct Apple()
        {
            public int[] cord = new int[2];
         bool isappleexist = false;
        }
        static Apple AppleSpawn(Apple apple )
        { 
            Random rnd = new Random();
            apple.cord[x] = rnd.Next(51);
            apple.cord[y] = rnd.Next(11);
            return apple;
        }
    }
}