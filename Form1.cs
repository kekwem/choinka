using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace choinka
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        bool drzewo = false;
        bool prezent = false;
        bool gwiazda = false;
        bool bombki = false;
        bool lancuchy = false;
        bool swiatelka = false;

        public Form1()
        {
            InitializeComponent();
            player.URL = @"C:\Users\Dimon\source\repos\choinka\We-wish-you-a-merry-Christmas.mp3";
        }

        private void buttonDrzewo_Click(object sender, EventArgs e)
        {
            drzewo = true;
            Graphics g = panel.CreateGraphics();
            Point point1 = new Point(200, 30);
            Point point2 = new Point(130, 100);
            Point point3 = new Point(270, 100);
            Point point4 = new Point(200, 70);
            Point point5 = new Point(130, 140);
            Point point6 = new Point(270, 140);
            Point point7 = new Point(200, 110);
            Point point8 = new Point(130, 180);
            Point point9 = new Point(270, 180);
            Point[] tablica1 =
            {
                point1,
                point2,
                point3,
            };
            Point[] tablica2 =
            {
                point4,
                point5,
                point6
            };
            Point[] tablica3 =
            {
                point7,
                point8,
                point9
            };
            g.FillPolygon(Brushes.Green, tablica1);
            g.FillPolygon(Brushes.Green, tablica2);
            g.FillPolygon(Brushes.Green, tablica3);
            g.FillRectangle(Brushes.Brown, 180, 180, 40, 40);
        }

        private void buttonPrezent_Click(object sender, EventArgs e)
        {
            prezent = true;
            Graphics g = panel.CreateGraphics();
            g.FillRectangle(Brushes.DarkCyan, 120, 200, 50, 30);
            g.FillRectangle(Brushes.Blue, 120, 210, 50, 10);
            g.FillRectangle(Brushes.Blue, 140, 200, 10, 30);

            g.FillRectangle(Brushes.Red, 160, 190, 60, 50);
            g.FillRectangle(Brushes.Yellow, 160, 210, 60, 10);
            g.FillRectangle(Brushes.Yellow, 180, 190, 20, 50);

            g.FillRectangle(Brushes.Pink, 230, 200, 30, 30);
            g.FillRectangle(Brushes.Red, 230, 210, 30, 10);
            g.FillRectangle(Brushes.Red, 240, 200, 10, 30);
        }

        private void buttonGwiazda_Click(object sender, EventArgs e)
        {
            gwiazda = true;
            Graphics g = panel.CreateGraphics();
            Point point1 = new Point(200, 15);
            Point point2 = new Point(210, 35);
            Point point3 = new Point(230, 35);
            Point point4 = new Point(210, 40);
            Point point5 = new Point(220, 60);
            Point point6 = new Point(200, 45);
            Point point7 = new Point(180, 60);
            Point point8 = new Point(190, 40);
            Point point9 = new Point(170, 35);
            Point point10 = new Point(190, 35);
            Point[] tablica = {
                point1,
                point2,
                point3,
                point4,
                point5,
                point6,
                point7,
                point8,
                point9,
                point10
            };
            g.FillPolygon(Brushes.Yellow, tablica);
        }

        Point[] tablica_bombek = null;
        int[] tablica_kolorow = null;

        private void buttonBombki_Click_1(object sender, EventArgs e)
        {
            bombki = true;
            Random r = new Random();
            Graphics g = panel.CreateGraphics();
            if (tablica_bombek == null)
            {
                tablica_bombek = new Point[7];
                tablica_kolorow = new int[7];
                for (int i = 0; i < 7; i++)
                {
                    int x = r.Next(170, 230);
                    int y = r.Next(70, 175);
                    tablica_bombek[i] = new Point(x, y);
                    int color = r.Next(1, 4);
                    if (color == 1)
                    {
                        g.FillEllipse(Brushes.Pink, x, y, 10, 10);
                    }
                    else if (color == 2)
                    {
                        g.FillEllipse(Brushes.Blue, x, y, 10, 10);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.Orange, x, y, 10, 10);
                    }
                    tablica_kolorow[i] = color;
                    g.DrawLine(Pens.Black, x + 5, y, x + 5, y - 5);
                }
            }
            else
            {
                for (int i = 0; i < tablica_bombek.Length; i++)
                {
                    if (tablica_kolorow[i] == 1)
                    {
                        g.FillEllipse(Brushes.Pink, tablica_bombek[i].X, tablica_bombek[i].Y, 10, 10);
                    }
                    else if (tablica_kolorow[i] == 2)
                    {
                        g.FillEllipse(Brushes.Blue, tablica_bombek[i].X, tablica_bombek[i].Y, 10, 10);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.Orange, tablica_bombek[i].X, tablica_bombek[i].Y, 10, 10);
                    }
                    g.DrawLine(Pens.Black, tablica_bombek[i].X + 5, tablica_bombek[i].Y, tablica_bombek[i].X + 5, tablica_bombek[i].Y - 5);
                }
            }
            
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (drzewo) buttonDrzewo_Click(sender, e);
            if (lancuchy) buttonLancuchy_Click(sender, e);
            if (prezent) buttonPrezent_Click(sender, e);
            if (gwiazda) buttonGwiazda_Click(sender, e);
            if (bombki) buttonBombki_Click_1(sender, e);
            if (swiatelka) buttonSwiatelka_Click(sender, e);
        }

        private void buttonLancuchy_Click(object sender, EventArgs e)
        {
            lancuchy = true;
            Graphics g = panel.CreateGraphics();
            Point[] tablica = {
                new Point(220, 55),
                new Point(170, 100),
            };
            g.DrawCurve(new Pen(Brushes.White, 5f), tablica);
            Point[] tablica1 = {
                new Point(240, 110),
                new Point(150, 160),
            };
            g.DrawCurve(new Pen(Brushes.White, 5f), tablica1);
        }

        private void buttonSwiatelka_Click(object sender, EventArgs e)
        {
            swiatelka = true;
            Graphics g = panel.CreateGraphics();
            Point[] tablica =
            {
                new Point(170, 60),
                new Point(180, 70),
                new Point(190, 80),
                new Point(200, 90),
                new Point(210, 100),
                new Point(220, 110),
                new Point(230, 120),
                new Point(170, 130),
                new Point(180, 140),
                new Point(190, 150),
                new Point(200, 160),
                new Point(210, 170)
            };
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i % 3 == 0)
                {
                    g.FillEllipse(Brushes.Red, tablica[i].X, tablica[i].Y, 7, 7);
                }
                else if (i % 3 == 1)
                {
                    g.FillEllipse(Brushes.Yellow, tablica[i].X, tablica[i].Y, 7, 7);
                }
                else
                {
                    g.FillEllipse(Brushes.GreenYellow, tablica[i].X, tablica[i].Y, 7, 7);
                }
                
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            tablica_bombek = null;
            tablica_kolorow = null;
            drzewo = false;
            prezent = false;
            gwiazda = false;
            bombki = false;
            lancuchy = false;
            panel.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }
    }
}
