using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Dirrection
    {
        Up,
        Down,
        Left,
        Right
    }
    class Snake: Figure
    {
        public Snake(Point tail,char head, short length, Dirrection dirr)
        {
            pList = new List<Point>();
            for(short i = 0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dirr);
                if (i == length - 1) p.sym = head;
                pList.Add(p);
            }
        }
    }
}
