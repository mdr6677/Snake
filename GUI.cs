using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Snake.Program;
//

namespace Snake
{
    internal class GUI
    {

        //public static string GUIFile() 
        //{
        //    using (FileStream stream = new FileStream("C:\\Users\\Дима\\Desktop\\работы\\vs prj\\Snake\\GUIF.txt", FileMode.OpenOrCreate)) 
        //    {
        //        byte[] arr = new byte[stream.Length];
        //        stream.Read(arr, 0, arr.Length);
        //        string gui = System.Text.Encoding.Default.GetString(arr);
        //       return gui;
        //    }
           
        //}
       
        public static char[,] frame = new char[w, h];
        //private static StringBuilder sb = new StringBuilder("████████████████████████████████████████████████████\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n█                                                  █\n████████████████████████████████████████████████████");
        private static StringBuilder sb = new StringBuilder("████████████████████████████████\n█                              █\n█                              █\n█                              █\n█                              █\n█                              █\n█                              █\n█                              █\n█                              █\n█                              █\n█                              █\n████████████████████████████████");
        public static void FrameInit()
        {
           
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    frame[j, i] = ' ';
                 
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
           
            frame[apple.cord[x], apple.cord[y]] = '○';

        }
        public static void FrameDraw()
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(frame[j, i]);
                }
                Console.WriteLine();
            }
        }
        public static void FrameDr()

        {
            int s = w+3;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sb[s + j + 1] = frame[j, i];
                }
                s += w+3;
            }
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(sb.ToString());
         
        }
    }

}
