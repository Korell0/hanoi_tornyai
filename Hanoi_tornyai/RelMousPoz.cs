using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;



namespace Hanoi_tornyai
{
    class RelMousPoz
    {
        public Point CursorPoz;


        public RelMousPoz(Point cursorPoz)
        {
            CursorPoz = new Point(Form1.MousePosition.X - cursorPoz.X, Form1.MousePosition.Y - cursorPoz.Y);
        }




    }
}
