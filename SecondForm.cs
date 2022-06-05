//Galieva Zilya 220, FormsFigureTask, 05/06/22
using System;
using System.Windows.Forms;

namespace FormsTask
{
    public partial class secondForm : Form
    {
        public bool okBtn = false;

        public secondForm(string str)
        {
            InitializeComponent();
            linePanel.Hide();
            rectanglePanel.Hide();
            trianglePanel.Hide();
            circlePanel.Hide();
            nameTextBox.Text = str;
            switch (str)
            {
                case "triangle":
                    trianglePanel.Show();
                    break;
                case "rectangle":
                    rectanglePanel.Show();
                    break;
                case "line":
                    linePanel.Show();
                    break;
                case "circle":
                    circlePanel.Show();
                    break;
            }
        }

        public secondForm(mainForm frm)
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            switch (nameTextBox.Text)
            {
                case "triangle":
                    Image.Add(new Triangle(Convert.ToInt32(Xnumeric.Text), Convert.ToInt32(Ynumeric.Text),
                                    Convert.ToInt32(xNumericTriangle.Text), Convert.ToInt32(yNumericTriangle.Text),
                                    Convert.ToInt32(x2NumericTriangle.Text), Convert.ToInt32(y2NumericTriangle.Text), 
                                    colorDialog.Color, Convert.ToInt32(widStrNumeric.Value)));
                    break;
                case "rectangle":
                    Image.Add(new Rectangle(Convert.ToInt32(Xnumeric.Text), Convert.ToInt32(Ynumeric.Text),
                                            Convert.ToInt32(heightNumeric.Text), Convert.ToInt32(widthNumeric.Text), 
                                            colorDialog.Color, Convert.ToInt32(widStrNumeric.Value)));
                    break;
                case "line":
                    Image.Add(new Line(int.Parse(Xnumeric.Text), int.Parse(Ynumeric.Text),
                                       int.Parse(xNumericLine.Text), int.Parse(yNumericLine.Text), colorDialog.Color, 
                                       Convert.ToInt32(widStrNumeric.Value)));
                    break;
                case "circle":
                    Image.Add(new Circle(Convert.ToInt32(Xnumeric.Text), Convert.ToInt32(Ynumeric.Text),
                                         Convert.ToInt32(radiusNumeric.Text), colorDialog.Color, 
                                         Convert.ToInt32(widStrNumeric.Value)));
                    break;
            }
            this.Close();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
        }
    }
}