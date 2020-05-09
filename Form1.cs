using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Створити  C# програму для малювання прямокутника. Колір пера - DeepPink,  ширина - 3 пікселі, стиль - Dot    . 
         * Всередині прямокутника повинен бути розміщений який-небудь текст. 
         * Шрифт – «Arial Black», розмір -  14. 
         * Також створити пензлик для штрихування. Стиль штрихування – DiagonalCross, колір – BlueViolet. 
         * Цей пензлик використати для  малювання еліпса. Розміри усіх графічних фігур – довільні. 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Pen pen1 = new Pen(Color.DeepPink);
            pen1.Width = 3;
            pen1.DashStyle = DashStyle.DashDotDot;
            HatchBrush brush1 = new HatchBrush(HatchStyle.DiagonalCross, Color.BlueViolet);

            Rectangle rect1 = new Rectangle(40, 40, 300, 200);
            Rectangle rect2 = new Rectangle(120, 150, 100, 50);
            Graphics g = Graphics.FromHwnd(this.Handle);
            g.DrawRectangle(pen1, rect1);
            g.FillEllipse(brush1, rect2);

            float a = 120, b = 60;
            Font myFont = new Font("Ariel Black", 14);
            g.DrawString("You are nice!", myFont, brush1, a, b);

        }
    }
}
