using System.Diagnostics;

namespace MatrixMultiplication
{
    public partial class Form1 : Form
    {
        private int size = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                int numThread = Environment.ProcessorCount; 

                Matrix a = Matrix.RandomMatrix(size, size);
                Matrix b = Matrix.RandomMatrix(size, size);

                txtMatrixA.Text = a.ToString();
                txtMatrixB.Text = b.ToString();

                var watch = Stopwatch.StartNew();
                Matrix result = Matrix.ThreadMultiply(a, b, numThread);
                watch.Stop();

                txtMatrixResult.Text = result.ToString();
                Program.timeResults[0].Add(watch.ElapsedMilliseconds);
                lblTime.Text = "Multiply Time: " + watch.ElapsedMilliseconds + "ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix a = Matrix.RandomMatrix(size, size);
                Matrix b = Matrix.RandomMatrix(size, size);

                txtMatrixA.Text = a.ToString();
                txtMatrixB.Text = b.ToString();

                var watch = Stopwatch.StartNew();
                Matrix result = Matrix.ThreadMultiply(a, b, 1); 
                watch.Stop();

                txtMatrixResult.Text = result.ToString();
                Program.timeResults[1].Add(watch.ElapsedMilliseconds);
                lblTime.Text = "Multiply Time: " + watch.ElapsedMilliseconds + "ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int numThread = Environment.ProcessorCount;

                Matrix a = Matrix.RandomMatrix(size, size);
                Matrix b = Matrix.RandomMatrix(size, size);

                txtMatrixA.Text = a.ToString();
                txtMatrixB.Text = b.ToString();

                var watch = Stopwatch.StartNew();
                Matrix result = Matrix.ParallelMultiply(a, b, numThread);
                watch.Stop();

                txtMatrixResult.Text = result.ToString();
                Program.timeResults[2].Add(watch.ElapsedMilliseconds);
                lblTime.Text = "Multiply Time: " + watch.ElapsedMilliseconds + "ms";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił error: " + ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<double> avg = new List<double>();
            foreach (List<long> timeResult in Program.timeResults)
            {
                avg.Add(timeResult.Average());
            }
            textBoxTimes.Text = $"Thread: {avg[0]:N2}\n\nSequence: {avg[1]:N2}\n\nParallel: {avg[2]:N2}\n";
        }

        private void txtMatrixB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
