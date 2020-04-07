using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 400;
            this.Height = 400;
            pictureBox1.Paint += this.Form1_Paint;
            this.Controls.Add(pictureBox1);
        }
        private PictureBox pictureBox1 = new PictureBox() { Size = new Size(400, 400), };

        public void Form1_Paint (object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            // "c" as coordinata
            Pen c = new Pen(Color.Black, 1);
            // "f" as figure
            Pen f = new Pen(Color.Red, 1);
           
            l.TranslateTransform(200, 200);
            l.RotateTransform(270.0F);
            //l.ScaleTransform(3.0F, 1.0F);

            l.DrawLine(c, -200, 0, 200, 0);
            l.DrawLine(c, 0, -200, 0, 200);

            
            //l.DrawRectangle(f, 1, 1, 60, 60);
            l.DrawEllipse(f, 65, -65, 50, 50);
            l.DrawEllipse(f, 5, 65, 20, 20);
            //l.Dispose();
        }

    }
}
