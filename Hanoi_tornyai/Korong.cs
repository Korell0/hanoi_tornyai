using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Hanoi_tornyai
{
    class Korong
    {
        public Panel Panel;
        public int Nev;
        public Point Winpos;


        public Korong(Point position, Size size, int nev, Point winpos)
        {
            Panel = new Panel();
            Panel.Enabled = true;
            Panel.Size = size;
            Panel.Location = position;
            Nev = nev;
            Winpos = winpos;
            Panel.BackColor = Color.Black;

            Panel.MouseMove += new MouseEventHandler(this.Event);
        }

        private void Event(object sender, MouseEventArgs e)
        {
            RelMousPoz mouseposition = new RelMousPoz(Winpos);
            if (e.Button == MouseButtons.Left)
            {
                Panel.Location = new Point(mouseposition.CursorPoz.X - Panel.Width / 2, mouseposition.CursorPoz.Y - Panel.Height / 2);
            }
        }
    }
}
