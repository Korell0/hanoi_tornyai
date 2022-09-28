using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Hanoi_tornyai
{
    class RelMousPoz
    {
        public int CursorX, CursorY;


        public RelMousPoz(int winpozX, int winpozY)
        {
            CursorX = Form1.MousePosition.X - winpozX;
            CursorY = Form1.MousePosition.Y - winpozY;
        }




    }
}
