﻿using System;
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
        public int Ertek;
        public Point Winpos;
        public int MinErtek;


        public Korong(Point position, Size size, int ertek, Point winpos)
        {
            Panel = new Panel();
            Panel.Enabled = true;
            Panel.Size = size;
            Panel.Location = position;
            Ertek = ertek;
            Winpos = winpos;
            Panel.BackColor = Color.BlueViolet;

            Panel.MouseMove += new MouseEventHandler(this.Event);
        }

        private void Event(object sender, MouseEventArgs e)
        {
            RelMousPoz mouseposition = new RelMousPoz(Winpos);
            if (e.Button == MouseButtons.Left && MinErtek == Ertek)
            {
                Panel.Location = new Point(mouseposition.CursorPoz.X - Panel.Width / 2, mouseposition.CursorPoz.Y - Panel.Height / 2);
            } 
            else
            {
                
            }
        }
    }
}
