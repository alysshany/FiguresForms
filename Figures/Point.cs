//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;

namespace FormsTask
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(string s)
        {
            X = s[0];
            Y = s[1];
        }

        public override string ToString()
        {
            string s = X + " " + Y + " ";
            return s;
        }
    }
}