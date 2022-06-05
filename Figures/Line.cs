//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.Drawing;

namespace FormsTask
{
    class Line : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;


        public Line(Point a, Point b, Color strokeColor, int widthStr) : base(a)
        {
            Stroke = new StrokeData(widthStr, strokeColor);
            B = b;
        }

        public Line(int x1, int y1, int x2, int y2, Color strokeColor, int widthStr) : base(x1, y1)
        {
            Stroke = new StrokeData(widthStr, strokeColor);
            B = new Point(x2, y2);
        }

        public override void Draw()
        {
            Graphics paper = mainForm.form.mainPanel.CreateGraphics();
            var thickPen = new Pen(Stroke.Color, Stroke.Width);

            paper.DrawLine(thickPen, basePoint.X, basePoint.Y, B.X, B.Y);
        }

        public override string GetInfo()
        {
            string s = A.ToString() + B.ToString() + Stroke.Color.A + " " + Stroke.Color.R + " " + 
                    Stroke.Color.G + " " + Stroke.Color.B + " " + Stroke.Width;
            return s;
        }
    }
}