//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;

namespace FormsTask
{
    public class Figure
    {
        protected Point basePoint;
        public StrokeData Stroke;

        public Figure(Point point)
        {
            basePoint = point;
        }

        public Figure(string s)
        {
            basePoint = new Point(s);
        }

        public Figure(int x = 0, int y = 0)
        {
            basePoint = new Point(x, y);
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Figure");
        }

        public virtual string GetInfo()
        {
            string s = basePoint.ToString();
            return s;
        }
    }
}