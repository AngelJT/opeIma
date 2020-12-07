using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace EjercicioClase02._12._2020
{
    public partial class Form1 : Form
    {
        Image<Rgb, byte> img;
        Image<Rgb, byte> img2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                img = new Image <Rgb, byte>(abrir.FileName);
                pictureBox1.Image = img.ToBitmap();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                img2 = new Image<Rgb, byte>(abrir.FileName);
                pictureBox2.Image = img2.ToBitmap();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Image<Gray, Byte> imgOri1 = new Image<Gray, byte>(bmp);
            pictureBox1.Image = imgOri1.ToBitmap();
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Image<Gray, Byte> imgOri2 = new Image<Gray, byte>(bmp2);
            pictureBox2.Image = imgOri2.ToBitmap();
            

            //Image <Gray, Byte> imgRes = new Image<Gray, byte>()

            for (int i = 0; i < imgOri1.Height && i< imgOri2.Height; i++)
            {
                for (int j = 0; j < imgOri1.Width && i<imgOri2.Width; j++)
                {
                    int intensidad1 = imgOri1.Data[i, j, 0];
                    int intensidad2 = imgOri2.Data[i, j, 0];
                    if(intensidad1 == intensidad2)
                    {
                        intensidad1 = intensidad2;
                    }
                    else
                    {

                        intensidad1 = intensidad2;
                    }
                }
            }
            pictureBox3.Image = imgOri1.ToBitmap();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Image<Gray, Byte> imgOri1 = new Image<Gray, byte>(bmp);
            pictureBox1.Image = imgOri1.ToBitmap();
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Image<Gray, Byte> imgOri2 = new Image<Gray, byte>(bmp2);
            pictureBox2.Image = imgOri2.ToBitmap();
            for (int i = 0; i < imgOri1.Height && i < imgOri2.Height; i++)
            {
                for (int j = 0; j < imgOri1.Width && i < imgOri2.Width; j++)
                {
                    int intensidad1 = imgOri1.Data[i, j, 0];
                    int intensidad2 = imgOri2.Data[i, j, 0];
                    if (intensidad1 == intensidad2)
                    {
                        intensidad1 = intensidad2;
                    }
                    else
                    {

                        intensidad1 = intensidad2 - intensidad1;
                    }
                }
            }
            pictureBox3.Image = imgOri1.ToBitmap();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Image<Gray, Byte> imgOri1 = new Image<Gray, byte>(bmp);
            pictureBox1.Image = imgOri1.ToBitmap();
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Image<Gray, Byte> imgOri2 = new Image<Gray, byte>(bmp2);
            pictureBox2.Image = imgOri2.ToBitmap();
            for (int i = 0; i < imgOri1.Height && i < imgOri2.Height; i++)
            {
                for (int j = 0; j < imgOri1.Width && i < imgOri2.Width; j++)
                {
                    int intensidad1 = imgOri1.Data[i, j, 0];
                    int intensidad2 = imgOri2.Data[i, j, 0];
                    if (intensidad1 == intensidad2)
                    {
                        intensidad1 = intensidad2;
                    }
                    else
                    {

                        intensidad1 = intensidad2 * intensidad1;
                    }
                }
            }
            pictureBox3.Image = imgOri1.ToBitmap();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Image<Gray, Byte> imgOri1 = new Image<Gray, byte>(bmp);
            pictureBox1.Image = imgOri1.ToBitmap();
            Bitmap bmp2 = new Bitmap(pictureBox2.Image);
            Image<Gray, Byte> imgOri2 = new Image<Gray, byte>(bmp2);
            pictureBox2.Image = imgOri2.ToBitmap();
            for (int i = 0; i < imgOri1.Height && i < imgOri2.Height; i++)
            {
                for (int j = 0; j < imgOri1.Width && i < imgOri2.Width; j++)
                {
                    int intensidad1 = imgOri1.Data[i, j, 0];
                    int intensidad2 = imgOri2.Data[i, j, 0];
                    if (intensidad1 == intensidad2)
                    {
                        intensidad1 = intensidad2;
                    }
                    else
                    {

                        intensidad1 = intensidad2 / intensidad1;
                    }
                }
            }
            pictureBox3.Image = imgOri1.ToBitmap();
        }
    }
}
