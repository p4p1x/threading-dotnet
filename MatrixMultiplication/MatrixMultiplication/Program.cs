using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MatrixMultiplication
{
    internal static class Program
    {
        public static List<List<long>> timeResults = new List<List<long>>();

        [STAThread]
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                timeResults.Add(new List<long>());
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
