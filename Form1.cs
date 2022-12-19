using System.Windows.Forms.VisualStyles;

namespace _3sem_2lr_kg
{
    public partial class Form1 : Form
    {
        Point p1, p2;
        bool IsLine, IsArc, IsEllipse;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // нажатие на кнопку очистки
        {
            Graphics g = CreateGraphics();
            g.FillRectangle(new SolidBrush(SystemColors.Control), ClientRectangle);
            g.Dispose();
        }

        private void button_line_Click(object sender, EventArgs e) // нажатие на кнопку "ѕр¤ма¤"
        {
            IsLine = true;
            IsArc = false;
            IsEllipse = false;
        }
        private void button_arc_Click(object sender, EventArgs e) // нажатие на кнопку "ƒуга окружности"
        {
            IsLine = false;
            IsArc = true;
            IsEllipse = false;
        }
        private void button_ellipse_Click(object sender, EventArgs e) // нажатие на кнопку "Ёллипс"
        {
            IsLine = false;
            IsArc = false;
            IsEllipse = true;
        }

        private void Line(int I1, int J1, int I2, int J2)
        {
            Graphics g = CreateGraphics();
            if (I1 > I2)
            {
                int i = I1; I1 = I2; I2 = i;
                int j = J1; J1 = J2; J2 = j;
            }
            int dI = I2 - I1; int dJ = J2 - J1;
            int S = 0;
            if (dJ != 0)
                S = dJ / Math.Abs(dJ);
            int d = 2 * dJ - S * dI;
            if (S * dJ <= dI)
            {
                int j = J1;
                for (int i = I1; i <= I2; i++)
                {
                    g.FillRectangle(Brushes.Black, i, j, 2, 2);
                    d += 2 * dJ;
                    if (S * d >= 0)
                    {
                        j += S;
                        d -= 2 * S * dI;
                    }
                }
            }
            else
            {
                int i = I1;
                for (int j = J1; (J2 - j) * S >= 0; j += S)
                {
                    g.FillRectangle(Brushes.Black, i, j, 2, 2);
                    d += 2 * S * dI;
                    if (S * d >= 0)
                    {
                        d -= 2 * dJ;
                        i++;
                    }
                }
            }
            g.Dispose();
        }

        private void Circle(int X1, int Y1, int r)
        {
            Graphics g = CreateGraphics();
            int x = 0;
            int y = r;
            int delta = 2 - 2 * r;
            int error = 0;
            while (y >= 0)
            {
                // дуга 1-й четверти
                g.FillRectangle(Brushes.Black, X1 + x, Y1 - y, 2, 2);
                if (delta < 0)
                {
                    error = 2 * (delta + y) - 1;
                    if (error <= 0)
                        delta += 2 * ++x + 1;   // горизонтальный пиксель
                    else
                        delta += 2 * (++x - --y + 1);   // диагональный пиксель
                }
                else
                {
                    error = 2 * (delta - x) - 1;
                    if (error > 0)
                        delta -= 2 * --y + 1;   // вертикальный пиксель
                    else
                        delta += 2 * (++x - --y + 1);   // диагональный пиксель
                }
            }
            g.Dispose();
        }

        private void Ellipse(int X1, int Y1, int rx, int ry)
        {
            Graphics g = CreateGraphics();
            int x = 0;
            int y = ry;
            int rx2 = rx * rx;
            int ry2 = ry * ry;
            int delta = rx2 + ry2 - 2 * rx2 * ry;
            int error = 0;
            while (y >= 0)
            {
                // дуга 1-й четверти
                g.FillRectangle(Brushes.Black, X1 + x, Y1 - y, 2, 2);
                if (delta < 0)
                {
                    error = 2 * delta + rx2 * (2 * y - 1);
                    if (error <= 0)
                        delta += ry2 * (2 * ++x + 1);   // горизонтальный пиксель
                    else
                        delta += ry2 * (2 * ++x + 1) - rx2 * (2 * --y - 1);    // диагональный пиксель
                }
                else
                {
                    error = 2 * delta - ry2 * (2 * x + 1);
                    if (error > 0)
                        delta -= rx2 * (2 * --y + 1);   // вертикальный пиксель
                    else
                        delta += ry2 * (2 * ++x + 1) - rx2 * (2 * --y - 1);   // диагональный пиксель
                }
            }
            g.Dispose();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = e.Location; //начальное положение курсора
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsLine)
            {
                p2 = e.Location; //конечное положение курсора
                int r = (int)Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
                Line(p1.X, p1.Y, p2.X, p2.Y);
            }

            if (IsArc)
            {
                p2 = e.Location;
                int r = (int)Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
                Circle(p1.X, p1.Y, r);
            }

            if (IsEllipse)
            {
                p2 = e.Location;
                int r = (int)Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
                Ellipse(p1.X, p1.Y, r, 2 * r);
            }
        }
    }
}