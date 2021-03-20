using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class FImage : Form
    {
        Point currentPoint;
        public FImage()
        {
            InitializeComponent();
        }

        public void savePbImage(string filePath)
        {
            try
            {
                pictureBox1.Image.Save(filePath, getFormat(filePath));
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить изображение", "Ошибка");
            }
        }

        public System.Drawing.Imaging.ImageFormat getFormat (string filePath)
        {
            string extension = Path.GetExtension(filePath);

            switch (extension)
            {
                case ("*.jpg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ("*.jpeg"):
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case ("*.png"):
                    return System.Drawing.Imaging.ImageFormat.Png;
                default:
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
        }
        private void FImage_Load(object sender, EventArgs e)
        {

        }

        private void F_Image_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void F_Image_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = Form1.imageEditor.Image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            currentPoint = Form1.imageEditor.ConvertCoordinates(pictureBox1, e.X, e.Y);
            X_textBox.Text = Convert.ToString(currentPoint.X);
            Y_textBox.Text = Convert.ToString(currentPoint.Y);
        }

        private void Mouse_Down_bt(object sender, MouseEventArgs e)
        {
            Timer_Paint.Start();
        }

        private void Mouse_Up_bt(object sender, MouseEventArgs e)
        {
            Timer_Paint.Stop();
        }

        private void Timer_Paint_Tick(object sender, EventArgs e)
        {
            int brushRadius = Form1.imageEditor.BrushRadius;
            for (int i = currentPoint.X - brushRadius;i <= currentPoint.X + brushRadius; i++)
            {
                for (int j = currentPoint.Y - brushRadius; j <= currentPoint.Y + brushRadius; j++)
                {
                    double dist = Math.Sqrt(Math.Pow(i - currentPoint.X, 2) + Math.Pow(j - currentPoint.Y, 2));
                    if (dist <= brushRadius && i >= 0 && j >= 0
                        && i < Form1.imageEditor.Image.Width
                        && j < Form1.imageEditor.Image.Height)
                    Form1.imageEditor.Image.SetPixel(i, j, Form1.imageEditor.BrushColor);
                }
            }
            Invalidate();
        }
    }
}
