using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x1, y1, x2, y2, r1, x3, y3, r2, x4, y4, r3;
        private double a, a1, a2;

        private Pen arrow = new Pen(Color.Gray, 2);
        private Pen frame = new Pen(Color.Black, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(arrow, x1, y1, x2, y2); // секундная стрелка
            g.DrawLine(arrow, x1, y1, x3, y3); // минутная стрелка
            g.DrawLine(arrow, x1, y1, x4, y4); // часовая стрелка
            g.DrawEllipse(frame, x1 - r1, y1 - r1, 2*r1, 2*r1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r1 = 150;
            r2 = 140;
            r3 = 90;
            a = 0;
            a1 = 0;
            a2 = 0;
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            // Конец стрелки
            x2 = x1 + (int)(r1 * Math.Cos(a));
            y2 = y1 - (int)(r1 * Math.Sin(a));
            x3 = x1 + (int)(r2 * Math.Cos(a));
            y3 = y1 - (int)(r2 * Math.Sin(a));
            x4 = x1 + (int)(r3 * Math.Cos(a));
            y4 = y1 - (int)(r3 * Math.Sin(a));
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            a -= 0.1;
            a1 -= 0.01;
            a2 -= 0.001;
            x2 = x1 + (int)(r1 * Math.Cos(a));
            y2 = y1 - (int)(r1 * Math.Sin(a));
            x3 = x1 + (int)(r2 * Math.Cos(a1));
            y3 = y1 - (int)(r2 * Math.Sin(a1));
            x4 = x1 + (int)(r3 * Math.Cos(a2));
            y4 = y1 - (int)(r3 * Math.Sin(a2));
            // Принудительный вызов события Paint
            Invalidate();
        }
    }
}
