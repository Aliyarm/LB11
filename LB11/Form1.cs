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

        private int x1, y1, x2, y2, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 2);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Рисуем секундную стрелку
            g.DrawLine(pen, x1, y1, x2, y2);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            r = 150; // Радиус стрелки
            a = 0; // Угол поворота стрелки
                   // Определяем центр формы – начало стрелки
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            // Конец стрелки
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a -= 0.1; // Уменьшаем угол на 0,1 радиану
                      // Новые координаты конца стрелки
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            // Принудительный вызов события Paint
            Invalidate();
        }
    }
}
