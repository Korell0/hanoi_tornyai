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
        static Korong Aktiv;
        static int korongszam = 0;
        static List<Lepes> Vissza = new List<Lepes>();
        static List<Lepes> Elore = new List<Lepes>();

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
            korongszam = Convert.ToInt32(ComboBox.Text);
            for (int i = 0; i < korongszam; i++)
            {
                int szelesseg = max_szelesseg - i * ((max_szelesseg - min_szelesseg) / korongszam);

                Indulo.Bucket.Add(new Korong(new Size(szelesseg, magassag), korongszam - i, this.Location));
                Athelyez(Indulo, Indulo.Bucket[i]);

                this.Controls.Add(Indulo.Bucket[i].Panel);
                Indulo.Bucket[i].Panel.BringToFront();

                Indulo.Bucket[i].Panel.MouseUp += new MouseEventHandler(this.UjHely);
                Indulo.Bucket[i].Panel.MouseDown += new MouseEventHandler(this.GetAktiv);
            }
            MinErtekHatarozo();
        }
        private void GetAktiv(object sender, MouseEventArgs e)
        {
            MinErtekHatarozo();
            RelMousPoz mouseposition = new RelMousPoz(this.Location); 
            foreach (Oszlop item in new List<Oszlop>() { Erkezo, Indulo, Seged })
            {
                foreach (Korong element in item.Bucket)
                {
                    if (element.Panel.Location.X < mouseposition.CursorPoz.X && element.Panel.Location.X + element.Panel.Width > mouseposition.CursorPoz.X
                                                                             &&
                        element.Panel.Location.Y < mouseposition.CursorPoz.Y && element.Panel.Location.Y + element.Panel.Height > mouseposition.CursorPoz.Y)
                    {
                        if (element.Ertek == element.MinErtek)
                        {
                            Aktiv = element;
                            Aktiv.Panel.BringToFront();
                        }
                    }
                }
            }
        }

        private void UjHely(object sender, MouseEventArgs e)
        {
            Oszlop hova = OszlopHatarozo(new RelMousPoz(this.Location));
            Oszlop korai = new List<Oszlop>() { Indulo, Erkezo, Seged }.Find(x => x.Bucket.Contains(Aktiv));
            if (Aktiv != null)
            {
                if (hova != null && Aktiv.Ertek < hova.MinErtek)
                {
                    Vissza.Add(new Lepes(korai, hova, Aktiv.Ertek));
                    lepesLabel.Text = Vissza.Count.ToString();
                    Elore.Clear();
                    VisszaBtn.Enabled = true;
                    EloreBtn.Enabled = false;
                    korai.Bucket.Remove(Aktiv);
                    hova.Bucket.Add(Aktiv);
                    Athelyez(hova, Aktiv);
                }
                else
                {
                    Athelyez(korai, Aktiv);
                }
            }
            Aktiv = null;
            MinErtekHatarozo();
            Wincheck();
        }

        private void Wincheck()
        {
            if (korongszam == Erkezo.Bucket.Count)
            {
                DialogResult valasz = MessageBox.Show("Gratulálok nyertél!🤗🤗🍾🥂🍺🍆🍆🍆💦✡🕎☢⛔🔞🚳\nSzeretnél új játékot kezdeni?","YEEEEEEEEEEEEEEEEEEE",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (valasz == DialogResult.No)
                {
                    Application.Exit();
                }
                MessageBox.Show("Akkor inditsd el újra!");
                Application.Exit();
            }
        }

        private void Athelyez(Oszlop hova, Korong aktiv)
        {
            int xHelyzet = hova.Groupbox.Location.X + hova.Groupbox.Width / 2 - aktiv.Panel.Width / 2;
            int yHelyzet = hova.Groupbox.Location.Y + hova.Groupbox.Height - aktiv.Panel.Height - gap * (hova.Bucket.Count -1) - (hova.Bucket.Count - 1) * aktiv.Panel.Height;
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

        private void MinErtekHatarozo()
        {
            foreach (Oszlop oszlop in new List<Oszlop>() { Indulo, Erkezo, Seged })
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
                        item.Panel.Cursor = System.Windows.Forms.Cursors.No;
                        if (item.MinErtek == item.Ertek)
                        {
                            item.Panel.Cursor = System.Windows.Forms.Cursors.Hand;
                        }
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

            label.Text = "Korongok száma:";

        }

        private void ThirdVisibleStatus()
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            StartBtn.Visible = false;
            ComboBox.Visible = false;

            label.Visible = false;

            idealLabel.Visible = false;
            lepesLabel.Visible = true;
            VisszaBtn.Visible = true;
            EloreBtn.Visible = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            StartBtn.Enabled = true;

            idealLabel.Text = $"Minimum lépések száma:\n{Math.Pow(2, Convert.ToInt32(ComboBox.Text))-1}";
            idealLabel.Visible = true;
        }

        private void VisszaBtn_Click(object sender, EventArgs e)
        {
            Oszlop honnan = Vissza[Vissza.Count - 1].Hova;
            Oszlop hova = Vissza[Vissza.Count - 1].Honnan;
            Korong mit = Vissza[Vissza.Count - 1].Hova.Bucket.Find(x => x.Ertek == Vissza[Vissza.Count - 1].Ertek);
            mit.Panel.Location = new Point(hova.Groupbox.Location.X + hova.Groupbox.Width / 2 - mit.Panel.Width / 2, (hova.Groupbox.Location.Y + hova.Groupbox.Height - (hova.Bucket.Count)*gap - (hova.Bucket.Count + 1)*mit.Panel.Height ));
            honnan.Bucket.Remove(mit);
            hova.Bucket.Add(mit);
            Elore.Add(Vissza[Vissza.Count - 1]);
            Vissza.RemoveAt(Vissza.Count - 1);
            MinErtekHatarozo();
            lepesLabel.Text = Vissza.Count.ToString();
            EloreBtn.Enabled = true;
            if (Vissza.Count < 1)
            {
                VisszaBtn.Enabled = false;
            }
        }

        private void EloreBtn_Click(object sender, EventArgs e)
        {
            Oszlop hova = Elore[Elore.Count - 1].Hova;
            Oszlop honnan = Elore[Elore.Count - 1].Honnan;
            Korong mit = Elore[Elore.Count - 1].Honnan.Bucket.Find(x => x.Ertek == Elore[Elore.Count - 1].Ertek);
            mit.Panel.Location = new Point(hova.Groupbox.Location.X + hova.Groupbox.Width / 2 - mit.Panel.Width / 2, (hova.Groupbox.Location.Y + hova.Groupbox.Height - (hova.Bucket.Count) * gap - (hova.Bucket.Count + 1) * mit.Panel.Height));
            honnan.Bucket.Remove(mit);
            hova.Bucket.Add(mit);
            Vissza.Add(Elore[Elore.Count - 1]);
            Elore.RemoveAt(Elore.Count - 1);
            MinErtekHatarozo();
            lepesLabel.Text = Vissza.Count.ToString();
            VisszaBtn.Enabled = true;
            if (Elore.Count < 1)
            {
                EloreBtn.Enabled = false;
            }
        }
    }
}
