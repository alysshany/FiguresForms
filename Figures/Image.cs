//Galieva Zilya 220, FormsFigureTask, 05/06/22

using System;
using System.Drawing;
namespace FormsTask
{
    class Image
    {
        public static Figures image = new Figures();

        public static void Save(string path)
        {
            image.Save(path);
        }

        public static void Add(Figure figure)
        {
            image.Add(figure);
        }

        public static void Load(string path)
        {
            image.Load(path);
        }

        public static void Clear()
        {
            image.Clear();
        }
    }
}