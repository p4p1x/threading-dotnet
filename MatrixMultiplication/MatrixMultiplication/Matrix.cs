using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Matrix
    {
        private int rows;
        private int cols;
        private double[,] mat;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.mat = new double[rows, cols];
        }

        public void SetValue(int row, int col, double value)
        {
            mat[row, col] = value;
        }

        public double GetValue(int row, int col)
        {
            return mat[row, col];
        }

        public static Matrix RandomMatrix(int rows, int cols)
        {
            var matrix = new Matrix(rows, cols);
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix.SetValue(i, j, random.Next(1, 10));
                }
            }
            return matrix;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += mat[i, j].ToString().PadRight(6);
                }
                result += Environment.NewLine;
            }
            return result;
        }

        private static void Multiply(int start, int end, Matrix b, Matrix a, Matrix result)
        {
            for (int i = start; i < end; ++i)
            {
                int row = i / result.cols;
                int col = i % result.cols;
                double sum = 0;

                for (int j = 0; j < b.cols; ++j)
                {
                    sum += b.GetValue(row, j) * a.GetValue(j, col);
                }

                result.SetValue(row, col, sum);
            }
        }

        public static Matrix ThreadMultiply(Matrix b, Matrix a, int numThread)
        {
            if (b.cols != a.rows)
            {
                MessageBox.Show("Wymiary macierzy nie są odpowiednie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            if (a.rows < numThread)
            {
                numThread = a.rows;
            }
            var result = new Matrix(b.rows, a.cols);
            int totalCells = b.rows * a.cols;
            int cellsPerThread = totalCells / numThread;
            var threads = new Thread[numThread];

            for (int i = 0; i < numThread; ++i)
            {
                int start = i * cellsPerThread;
                int end = (i == numThread - 1) ? totalCells : (i + 1) * cellsPerThread;
                threads[i] = new Thread(() => Multiply(start, end, b, a, result));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            return result;
        }

        public static Matrix ParallelMultiply(Matrix b, Matrix a, int numThread)
        {
            if (b.cols != a.rows)
            {
                MessageBox.Show("Wymiary macierzy nie są odpowiednie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
            if (a.rows < numThread)
            {
                numThread = a.rows;
            }
            var result = new Matrix(b.rows, a.cols);
            var opt = new ParallelOptions { MaxDegreeOfParallelism = numThread };
            int totalCells = b.rows * a.cols;
            int cellsPerThread = totalCells / numThread;

            Parallel.For(0, numThread, opt, i =>
            {
                int start = i * cellsPerThread;
                int end = (i == numThread - 1) ? totalCells : (i + 1) * cellsPerThread;
                Multiply(start, end, b, a, result);
            });

            return result;
        }
    }
}
