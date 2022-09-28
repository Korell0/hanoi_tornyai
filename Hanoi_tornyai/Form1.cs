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
    public partial class Form1 : Form
    {
        static List<Korong> Korongok = new List<Korong>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 2; i++)
            {
                Korongok.Add(new Korong(new Point(600, 600), new Size(200, 100), 10, this.Location));
                this.Controls.Add(Korongok[i].Panel);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {





            RelMousPoz position = new RelMousPoz(this.Location.X, this.Location.Y);
            if (e.Button == MouseButtons.Left)
            {
                panel1.Location = new Point(position.CursorX - panel1.Width/2, position.CursorY - panel1.Height/2);
            }

            button1.Click += new EventHandler(this.klikk);
        }

        private void klikk(object sender, EventArgs e)
        {
            MessageBox.Show("jeeeeeeeeeeeeeee");
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Korongok.Count; i++)
            {
                Korongok[i].Winpos = this.Location;
            }
        }
    }
}
