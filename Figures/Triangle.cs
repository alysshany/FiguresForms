//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.Drawing;

namespace FormsTask
{
    class Triangle : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c, Color strokeColor, int widthStroke) : base(a)
        {
            Stroke = new StrokeData(widthStroke, strokeColor);
            B = b;
            C = c;
        }

        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, Color strokeColor, int widthStroke) : base(x1, y1)
        {
            Stroke = new StrokeData(widthStroke, strokeColor);
            B = new Point(x2, y2);
            C = new Point(x3, y3);
        }

        public override void Draw()
        {
            Graphics paper = mainForm.form.mainPanel.CreateGraphics();
            var thickPen = new Pen(Stroke.Color, Stroke.Width);
            System.Drawing.Point pA = new System.Drawing.Point(A.X, A.Y);
            System.Drawing.Point pB = new System.Drawing.Point(B.X, B.Y);
            System.Drawing.Point pC = new System.Drawing.Point(C.X, C.Y);
            System.Drawing.Point[] poin = new System.Drawing.Point[] { pA, pB, pC };

            paper.DrawPolygon(thickPen, poin);
        }

        public override string GetInfo()
        {
            string s = A.ToString() + B.ToString() + C.ToString() + Stroke.Color.A + " " + 
                    Stroke.Color.R + " " + Stroke.Color.G + " " + 
                    Stroke.Color.B + " " + Stroke.Width;
            return s;
        }
    }
}