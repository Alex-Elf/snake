using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(120, 42);
            Console.SetWindowSize(120, 45);

            Walls walls = new Walls();
            walls.Draw();

            Snake snake = new Snake(new Point(4,5,'o') , 5, Dirrection.Right);
            snake.Draw();
            for(;;)
            { snake.Move();
               Thread.Sleep(300);
            }
            Console.Read();
            
        }
    }
}
