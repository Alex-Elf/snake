using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(120, 42);
            Console.SetWindowSize(120, 45);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Walls walls = new Walls();
            

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Red;

            walls.Draw();
            Console.SetCursorPosition(0, 0);
            Console.Read();
            
        }
    }
}
