using System;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using Emgu.CV;
using Emgu.CV.OCR;
using Emgu.CV.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ParallelImage
{
    public partial class Form1 : Form
    {
        private Bitmap? img;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                pictureBox1.Image = img;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var file_name = openFileDialog1.FileName;

            Parallel.Invoke(() => pictureBox2.Image = EdgeDetection(file_name),
                            () => pictureBox3.Image = Thresholding(file_name),
                            () => pictureBox4.Image = Negative(file_name),
                            () => pictureBox5.Image = Mirror(file_name));
        }

        public Bitmap EdgeDetection(string? file_name)
        {
            Bitmap? bmp = new Bitmap(file_name);
            Mat mat = new Mat();
            mat = bmp.ToMat();
            Mat mat_canny = new Mat();

            CvInvoke.Canny(mat, mat_canny, 100, 200);

            return mat_canny.ToBitmap();
        }

        
        public Bitmap Thresholding(string? file_name)
        {
            Bitmap? bmp = new Bitmap(file_name);
            Mat mat = new Mat();
            mat = bmp.ToMat();
            CvInvoke.CvtColor(mat, mat, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            Mat thresholding_mat = new Mat();

            CvInvoke.Threshold(mat, thresholding_mat, 127, 255, Emgu.CV.CvEnum.ThresholdType.Binary);

            return thresholding_mat.ToBitmap();
        }

        public Bitmap Negative(string? file_name)
        {
            Bitmap? bmp = new Bitmap(file_name);

            int w = bmp.Width;
            int h = bmp.Height;
            for (int x = 0; x < w; ++x)
            {
                for (int y = 0; y < h; ++y)
                {
                    Color pixelColor = bmp.GetPixel(x, y);
                    Color newColor = Color.FromArgb(0xff - pixelColor.R
                    , 0xff - pixelColor.G, 0xff - pixelColor.B);
                     bmp.SetPixel(x, y, newColor);
                }
            }
            return bmp;
             
        }
        public Bitmap Mirror(string? file_name)
        {
            Bitmap? bmp = new Bitmap(file_name);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX); 
            return bmp;
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        
    }
}
