using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Horizontal_Line: Figure
    {
        public Horizontal_Line(int xLeft, int xRight, int y)
        {
            char sym = '-';
            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y,(i==xLeft||i==xRight) ? '+' : sym);
                pList.Add(p);
            }
        }
    }
}
