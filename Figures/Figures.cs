//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace FormsTask
{
    public class Figures
    {
        public List<Figure> List;

        public Figures()
        {
            List = new List<Figure>();
        }

        public List<Figure> Add(Figure figure)
        {
            List.Add(figure);
            figure.Draw();
            return List;
        }

        public void Save(string path)
        {
            try 
            {
                using (StreamWriter sr = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    foreach (var v in List)
                    {
                        sr.WriteLine(v + " " + v.GetInfo());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("problem");
            }
        }

        public void Load(string path)
        {
            string fig;
            try 
            { 
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    while ((fig = sr.ReadLine()) != null)
                    {
                        string[] s = fig.Split(' ');

                        switch (s[0])
                        {
                            case "FormsTask.Line":
                                Color resLine = Color.FromArgb(int.Parse(s[5]), int.Parse(s[6]), 
                                                            int.Parse(s[7]), int.Parse(s[8]));
                                List.Add(new Line(int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]), 
                                                int.Parse(s[4]), resLine, int.Parse(s[9])));
                                Draw();
                                break;
                            case "FormsTask.Triangle":
                                Color resTri = Color.FromArgb(int.Parse(s[7]), int.Parse(s[8]), 
                                                            int.Parse(s[9]), int.Parse(s[10]));
                                List.Add(new Triangle(int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]), 
                                                    int.Parse(s[4]), int.Parse(s[5]), int.Parse(s[6]), 
                                                    resTri, int.Parse(s[11])));
                                Draw();
                                break;
                            case "FormsTask.Rectangle":
                                Color resRec = Color.FromArgb(int.Parse(s[5]), int.Parse(s[6]), 
                                                            int.Parse(s[7]), int.Parse(s[8]));
                                int n = Convert.ToInt32(s[1]);
                                List.Add(new Rectangle(int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]), 
                                                    int.Parse(s[4]), resRec, int.Parse(s[9])));
                                Draw();
                                break;
                            case "FormsTask.Circle":
                                Color res = Color.FromArgb(int.Parse(s[4]), int.Parse(s[5]), 
                                                        int.Parse(s[6]), int.Parse(s[7]));
                                List.Add(new Circle(int.Parse(s[1]), int.Parse(s[2]), int.Parse(s[3]), 
                                                res, int.Parse(s[8])));
                                Draw();
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("problem");
            }
        }

        public void Clear()
        {
            List.Clear();
        }

        public void Draw()
        {
            foreach (var fig in List)
            {
                fig.Draw();
            }
        }
    }
}