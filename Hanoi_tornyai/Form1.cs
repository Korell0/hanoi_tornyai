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
        static Oszlop Indulo = new Oszlop();
        static Oszlop Erkezo = new Oszlop();
        static Oszlop Seged = new Oszlop();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            foreach (Korong item in Indulo.Bucket)
            {
                item.Winpos = this.Location;
            }
            foreach (Korong item in Erkezo.Bucket)
            {
                item.Winpos = this.Location;
            }
            foreach (Korong item in Seged.Bucket)
            {
                item.Winpos = this.Location;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ThirdVisibleStatus();

            int max_szelesseg = 180; //px
            int min_szelesseg = 50; //px
            int magassag = 20; //px
            int gap = 10; //px
            int korongszam = Convert.ToInt32(ComboBox.Text);
            for (int i = 0; i < korongszam; i++)
            {
                int szelesseg = max_szelesseg - i * ((max_szelesseg - min_szelesseg) / korongszam);
                int yHelyzet = Indulo.Groupbox.Location.Y + Indulo.Groupbox.Height - magassag - gap * i - i * magassag;
                int xHelyzet = Indulo.Groupbox.Location.X + Indulo.Groupbox.Width / 2 - szelesseg / 2;

                Indulo.Bucket.Add(new Korong(new Point(xHelyzet, yHelyzet), new Size(szelesseg, magassag), korongszam - i, this.Location));
                this.Controls.Add(Indulo.Bucket[i].Panel);
                Indulo.Bucket[i].Panel.BringToFront();
                MinErtekHatarozo(Indulo);
            }
        }

        private void MinErtekHatarozo(Oszlop oszlop)
        {
            foreach (Korong item in oszlop.Bucket)
            {
                item.MinErtek = oszlop.Bucket.Min(x=>x.Ertek);
            }

        }

        private void startOszlop1_Click(object sender, EventArgs e)
        {
            ChangeToSecondStatus(groupBox1, startOszlop1);
        }
        private void startOszlop2_Click(object sender, EventArgs e)
        {
            ChangeToSecondStatus(groupBox2, startOszlop2);
        }

        private void startOszlop3_Click(object sender, EventArgs e)
        {
            ChangeToSecondStatus(groupBox3, startOszlop3);
        }

        private void ChangeToSecondStatus(GroupBox groupbox, Button button)
        {
            if (Indulo.Groupbox == null)
            {
                Indulo.Groupbox = groupbox;
                button.Enabled = false;
                label.Text = "Érkező oszlop száma:";
            }
            else
            {
                Erkezo.Groupbox = groupbox;
                Seged.Groupbox = new List<GroupBox> { groupBox1, groupBox2, groupBox3 }.Find(x => x!= Indulo.Groupbox && x!= Erkezo.Groupbox);
                SecondVisibleStatus();
            }
        }

        private void SecondVisibleStatus()
        {
            startOszlop1.Visible = false;
            startOszlop2.Visible = false;
            startOszlop3.Visible = false;

            ComboBox.Visible = true;
            StartBtn.Visible = true;

            label.Visible = false;
        }

        private void ThirdVisibleStatus()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            StartBtn.Visible = false;
            ComboBox.Visible = false;
        }
    }
}
