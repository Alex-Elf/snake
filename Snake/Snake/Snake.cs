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
        Dirrection dirrection;
        public Snake(Point tail, short length, Dirrection dirr)
        {
            dirrection = dirr;
            pList = new List<Point>();
            for(short i = 0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, dirr);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, dirrection);
            return nextPoint;

        }
    }
}
