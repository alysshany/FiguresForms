//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsTask
{
    public partial class mainForm : Form
    {
        public static Figures image = new Figures();
        public static mainForm form;
        public mainForm()
        {
            mainForm.form = this;
            InitializeComponent();
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            string str = "rectangle";
            secondForm frm = new secondForm(str);
            frm.Show();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            string str = "triangle";
            secondForm frm = new secondForm(str);
            frm.Show();
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            string str = "line";
            secondForm frm = new secondForm(str);
            frm.Show();
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            string str = "circle";
            secondForm frm = new secondForm(str);
            frm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = saveFileDialog.FileName;
            Image.Save(fileName);
        }

        
        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string fileName = openFileDialog.FileName;
            Image.Load(fileName);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics paper = mainForm.form.mainPanel.CreateGraphics();
            paper.Clear(Color.White);
            Image.Clear();
        }
    }
}