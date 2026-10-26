using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Control
    {
        public static int x = 0;
        public static int y = 1;
        public static void Controls()
        {
          
          
            if (Console.KeyAvailable)
            {
                
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                SnakeS.SnakeMove(keyInfo);
               
            }

        }
    }
}
