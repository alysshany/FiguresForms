
namespace FormsTask
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPan = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.CircleButton = new System.Windows.Forms.Button();
            this.TriangleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPan
            // 
            this.mainPan.BackColor = System.Drawing.Color.Gray;
            this.mainPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPan.Controls.Add(this.clearButton);
            this.mainPan.Controls.Add(this.loadButton);
            this.mainPan.Controls.Add(this.saveButton);
            this.mainPan.Controls.Add(this.LineButton);
            this.mainPan.Controls.Add(this.CircleButton);
            this.mainPan.Controls.Add(this.TriangleButton);
            this.mainPan.Controls.Add(this.rectangleButton);
            this.mainPan.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainPan.Location = new System.Drawing.Point(553, 0);
            this.mainPan.Name = "mainPan";
            this.mainPan.Size = new System.Drawing.Size(247, 451);
            this.mainPan.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(151, 11);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 31);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Gainsboro;
            this.loadButton.Location = new System.Drawing.Point(3, 391);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(107, 29);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.saveButton.Location = new System.Drawing.Point(130, 391);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(109, 29);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.BackColor = System.Drawing.Color.LightGray;
            this.LineButton.Location = new System.Drawing.Point(130, 221);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(109, 29);
            this.LineButton.TabIndex = 3;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = false;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // CircleButton
            // 
            this.CircleButton.BackColor = System.Drawing.Color.LightGray;
            this.CircleButton.Location = new System.Drawing.Point(3, 221);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(107, 29);
            this.CircleButton.TabIndex = 2;
            this.CircleButton.Text = "Circle";
            this.CircleButton.UseVisualStyleBackColor = false;
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // TriangleButton
            // 
            this.TriangleButton.BackColor = System.Drawing.Color.LightGray;
            this.TriangleButton.Location = new System.Drawing.Point(130, 176);
            this.TriangleButton.Name = "TriangleButton";
            this.TriangleButton.Size = new System.Drawing.Size(109, 29);
            this.TriangleButton.TabIndex = 1;
            this.TriangleButton.Text = "Triangle";
            this.TriangleButton.UseVisualStyleBackColor = false;
            this.TriangleButton.Click += new System.EventHandler(this.TriangleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.BackColor = System.Drawing.Color.LightGray;
            this.rectangleButton.Location = new System.Drawing.Point(3, 176);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(107, 29);
            this.rectangleButton.TabIndex = 0;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = false;
            this.rectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(553, 451);
            this.mainPanel.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.mainPan);
            this.Name = "mainForm";
            this.Text = "mainFrom";
            this.mainPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPan;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button CircleButton;
        private System.Windows.Forms.Button TriangleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button clearButton;
        public System.Windows.Forms.Panel mainPanel;
    }
}

