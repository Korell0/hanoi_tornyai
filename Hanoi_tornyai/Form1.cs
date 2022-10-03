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
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Korongok.Count; i++)
            {
                Korongok[i].Winpos = this.Location;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            int max_szelesseg = 180; //px
            int min_szelesseg = 50; //px
            int magassag = 20; //px
            int gap = 10; //px
            int korongszam = Convert.ToInt32(ComboBox.Text);
            for (int i = 0; i < korongszam; i++)
            {

                int szelesseg = max_szelesseg - i * ((max_szelesseg - min_szelesseg) / korongszam);
                int yHelyzet = groupBox1.Location.Y + groupBox1.Height + gap * i + i * magassag;

                Korongok.Add(new Korong(new Point(100, yHelyzet), new Size(szelesseg, magassag), 10, this.Location));
                this.Controls.Add(Korongok[i].Panel);
                Korongok[i].Panel.BringToFront();
            }
        }
    }
}
