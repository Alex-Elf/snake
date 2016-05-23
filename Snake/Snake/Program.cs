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
            Horizontal_Line hLine_Top = new Horizontal_Line(0, Console.WindowWidth-1, 0);
            hLine_Top.Draw();
            Vertical_Line vLine_Left = new Vertical_Line(0, Console.WindowHeight - 1, 0);
            vLine_Left.Draw();

            Console.Read();
        }
    }
}
