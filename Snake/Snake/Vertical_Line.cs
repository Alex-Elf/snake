using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Vertical_Line: Figure
    {
        public Vertical_Line(int yTop, int yBottom, int x)
        {
            char sym = '|';
            pList = new List<Point>();
            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, (i == yTop || i == yBottom) ? '+' : sym);
                pList.Add(p);
            }
        }
    }
}
