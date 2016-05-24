using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        Horizontal_Line hLine_Top, hLine_Bottom;
        Vertical_Line vLine_Left, vLine_Right;

        public Walls()
        {
            hLine_Top = new Horizontal_Line(0, Console.BufferWidth - 2, 1);
            vLine_Left = new Vertical_Line(1, Console.BufferHeight - 1, 0);
            vLine_Right = new Vertical_Line(1, Console.BufferHeight - 1, Console.BufferWidth - 1);
            hLine_Bottom = new Horizontal_Line(0, Console.BufferWidth - 2, Console.BufferHeight - 1);
        }
        public void Draw()
        {
            hLine_Top.Draw();
            vLine_Left.Draw();
            vLine_Right.Draw();
            hLine_Bottom.Draw();
        }
    }
}
