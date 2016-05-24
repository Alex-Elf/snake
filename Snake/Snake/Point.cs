using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            sym = point.sym;
        }
        public Point(){ }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move(short distance, Dirrection dirr)
        {
            switch(dirr)
            {
                case Dirrection.Down:
                    y += distance;
                    break;
                case Dirrection.Left:
                    x =(x-distance >=0)? x -distance : 0;
                    break;
                case Dirrection.Right:
                    x += distance;
                    break;
                case Dirrection.Up:
                    y = (y - distance >= 0) ? y - distance : 0;
                    break;
            }
        }
        public override string ToString()
        {
            return x + ", " + ", " + sym;
        }
    }
}
