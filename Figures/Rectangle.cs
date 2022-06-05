//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.Drawing;

namespace FormsTask
{
    class Rectangle : Figure
    {
        public int Height;
        public int Width;

        public Rectangle(Point point, int height, int width, Color strokeColor, int widthStroke) : base(point)
        {
            Stroke = new StrokeData(widthStroke, strokeColor);
            Height = height;
            Width = width;
        }

        public Rectangle(int x1, int y1, int height, int width, Color strokeColor, int widthStroke) : base(x1, y1)
        {
            Stroke = new StrokeData(widthStroke, strokeColor);
            Height = height;
            Width = width;
        }

        public override void Draw()
        {
            Graphics paper = mainForm.form.mainPanel.CreateGraphics();
            var thickPen = new Pen(Stroke.Color, Stroke.Width);

            paper.DrawRectangle(thickPen, basePoint.X, basePoint.Y, Width, Height);
        }

        public override string GetInfo()
        {
            string s = basePoint.ToString() + Height.ToString() + " " + Width.ToString() + " " + 
                    Stroke.Color.A + " " + Stroke.Color.R + " " + Stroke.Color.G + " " + 
                    Stroke.Color.B + " " + Stroke.Width;
            return s;
        }
    }
}