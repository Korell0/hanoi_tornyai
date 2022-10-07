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
        static int korongszam = 0;
        static int gap = 10; //px


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
            gap = 10; //px
            korongszam = Convert.ToInt32(ComboBox.Text);
            for (int i = 0; i < korongszam; i++)
            {
                int szelesseg = max_szelesseg - i * ((max_szelesseg - min_szelesseg) / korongszam);
                int yHelyzet = Indulo.Groupbox.Location.Y + Indulo.Groupbox.Height - magassag - gap * i - i * magassag;
                int xHelyzet = Indulo.Groupbox.Location.X + Indulo.Groupbox.Width / 2 - szelesseg / 2;

                Indulo.Bucket.Add(new Korong(new Point(xHelyzet, yHelyzet), new Size(szelesseg, magassag), korongszam - i, this.Location));
                this.Controls.Add(Indulo.Bucket[i].Panel);
                Indulo.Bucket[i].Panel.BringToFront();
                Indulo.Bucket[i].Panel.MouseUp += new MouseEventHandler(this.UjHely);
            }
            MinErtekHatarozo();
        }

        private void UjHely(object sender, MouseEventArgs e)
        {
            MinErtekHatarozo();
            Korong aktiv = AktivHatarozo(new RelMousPoz(this.Location));
            Oszlop korai = new List<Oszlop>() { Indulo, Erkezo, Seged }.Find(x => x.Bucket.Contains(aktiv));
            Oszlop hova = OszlopHatarozo(new RelMousPoz(this.Location));
            if (hova != null)
            {
                if (aktiv.Ertek < hova.MinErtek)
                {

                    int xHelyzet = hova.Groupbox.Location.X + hova.Groupbox.Width / 2 - aktiv.Panel.Width / 2;
                    int yHelyzet = hova.Groupbox.Location.Y + hova.Groupbox.Height - aktiv.Panel.Height - gap * hova.Bucket.Count - hova.Bucket.Count * aktiv.Panel.Height;

                    korai.Bucket.Remove(aktiv);
                    hova.Bucket.Add(aktiv);

                    aktiv.Panel.Location = new Point(xHelyzet, yHelyzet);
                }
                else
                {
                    Visszarak(korai, aktiv);
                }
            }
            else
            {
                Visszarak(korai, aktiv);
            }

            MinErtekHatarozo();
        }

        private void Visszarak(Oszlop hova, Korong aktiv)
        {
            int xHelyzet = hova.Groupbox.Location.X + hova.Groupbox.Width / 2 - aktiv.Panel.Width / 2;
            int yHelyzet = hova.Groupbox.Location.Y + hova.Groupbox.Height - aktiv.Panel.Height - gap * (hova.Bucket.Count -1) - (hova.Bucket.Count-1) * aktiv.Panel.Height;
            aktiv.Panel.Location = new Point(xHelyzet, yHelyzet);
        }

        private Oszlop OszlopHatarozo(RelMousPoz mouseposition)
        {
            List<Oszlop> oszlopok = new List<Oszlop>() { Erkezo, Indulo, Seged };
            foreach (Oszlop item in oszlopok)
            {
                if (item.Groupbox.Location.X < mouseposition.CursorPoz.X && item.Groupbox.Location.X + item.Groupbox.Width > mouseposition.CursorPoz.X
                                                                         &&
                    item.Groupbox.Location.Y < mouseposition.CursorPoz.Y && item.Groupbox.Location.Y + item.Groupbox.Height > mouseposition.CursorPoz.Y)
                {
                    return item;
                }
            }
            return null;
        }

        private Korong AktivHatarozo(RelMousPoz mouseposition)
        {
            List<Oszlop> oszlopok = new List<Oszlop>() { Erkezo, Indulo, Seged};
            foreach (Oszlop item in oszlopok)
            {
                foreach (Korong element in item.Bucket)
                {
                    if (element.Panel.Location.X < mouseposition.CursorPoz.X && element.Panel.Location.X + element.Panel.Width > mouseposition.CursorPoz.X
                                                                             &&
                        element.Panel.Location.Y < mouseposition.CursorPoz.Y && element.Panel.Location.Y + element.Panel.Height > mouseposition.CursorPoz.Y)
                    {
                        return element;
                    }
                }
            }
            return null;
        }

        private void MinErtekHatarozo()
        {
            List<Oszlop> oszlopok = new List<Oszlop>() { Indulo, Erkezo, Seged };
            foreach (Oszlop oszlop in oszlopok)
            {
                if (oszlop.Bucket.Count == 0)
                {
                    oszlop.MinErtek = korongszam + 1;
                }
                else
                {
                    foreach (Korong item in oszlop.Bucket)
                    {
                        item.MinErtek = oszlop.Bucket.Min(x => x.Ertek);
                    }
                    oszlop.MinErtek = oszlop.Bucket.Min(x => x.Ertek);
                }
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
