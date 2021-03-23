using System;
using System.Linq;

namespace ClassWorkDelegates
{
    delegate void DrawDelegate(ConsoleColor c, int height, char symb);
    class Drawers
    {
        
        public static void DrawTriangle(ConsoleColor c, int height,char symb) {
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = c;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symb);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = tmp;
        }
       
        public static void DrawSquare(ConsoleColor c, int height,char symb) {
            var tmp = Console.ForegroundColor;
            Console.ForegroundColor = c;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(symb);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = tmp;
        }
    }
    class Program
    {
        delegate bool MyPredicate(int number);
    static uint MyCount(int[] arr,MyPredicate predic) { 
            uint count = 0;
            foreach (var item in arr)
            {
                if (predic(item))
                {
                    ++count;
                }
            }
            return count;
    }
    static void Main(string[] args)
        {
            //Drawers dw = new Drawers();
            DrawDelegate dd = new DrawDelegate(Drawers.DrawTriangle);
            dd.Invoke(ConsoleColor.Red, 10, '*');
            dd = Drawers.DrawSquare;
            dd.Invoke(ConsoleColor.Green, 10, '*');
            //Drawers.DrawTriangle(ConsoleColor.Red, 10, '*');
            //DrawSquare(ConsoleColor.Green, 5, '.');
            Console.WriteLine("Hello World!");
            dd += Drawers.DrawTriangle;
            dd.Invoke(ConsoleColor.Blue, 8, '-');
            Console.WriteLine("Next Task:");

        }
    }
}
