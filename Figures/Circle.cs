//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.Drawing;

namespace FormsTask
{
    class Circle : Figure
    {
        public int Radius;
        public Circle(Point point, int radius, Color strokeColor, int widthStr) : base(point)
        {
            Stroke = new StrokeData(widthStr, strokeColor);
            Radius = radius;
        }

        public Circle(int x1, int y1, int radius, Color strokeColor, int widthStr) : base(x1, y1)
        {
            Stroke = new StrokeData(widthStr, strokeColor);
            Radius = radius;
        }

        public override void Draw()
        {
            Graphics paper = mainForm.form.mainPanel.CreateGraphics();
            var thickRedPen = new Pen(Stroke.Color, Stroke.Width);

            paper.DrawEllipse(thickRedPen, basePoint.X - Radius, basePoint.Y - Radius, Radius + Radius, Radius + Radius);
        }

        public override string GetInfo()
        {
            string s = basePoint.ToString()  + Radius.ToString() + " " + Stroke.Color.A + " " + 
                    Stroke.Color.R + " " + Stroke.Color.G + " " + Stroke.Color.B + " " + Stroke.Width;
            return s;
        }
    }
}