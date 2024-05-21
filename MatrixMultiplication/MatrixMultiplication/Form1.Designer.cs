namespace MatrixMultiplication
{
    partial class Form1
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
            txtMatrixB = new TextBox();
            txtMatrixA = new TextBox();
            button1 = new Button();
            lblTime = new Label();
            txtMatrixResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            button4 = new Button();
            textBoxTimes = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtMatrixB
            // 
            txtMatrixB.Location = new Point(450, 42);
            txtMatrixB.Multiline = true;
            txtMatrixB.Name = "txtMatrixB";
            txtMatrixB.Size = new Size(170, 168);
            txtMatrixB.TabIndex = 0;
            txtMatrixB.TextChanged += textBox1_TextChanged;
            // 
            // txtMatrixA
            // 
            txtMatrixA.Location = new Point(183, 42);
            txtMatrixA.Multiline = true;
            txtMatrixA.Name = "txtMatrixA";
            txtMatrixA.Size = new Size(170, 168);
            txtMatrixA.TabIndex = 1;
            txtMatrixA.TextChanged += txtMatrixB_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(359, 42);
            button1.Name = "button1";
            button1.Size = new Size(85, 42);
            button1.TabIndex = 2;
            button1.Text = "A×B";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(662, 75);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(86, 15);
            lblTime.TabIndex = 3;
            lblTime.Text = "Multiply Time: ";
            lblTime.Click += label1_Click;
            // 
            // txtMatrixResult
            // 
            txtMatrixResult.Location = new Point(317, 246);
            txtMatrixResult.Multiline = true;
            txtMatrixResult.Name = "txtMatrixResult";
            txtMatrixResult.Size = new Size(170, 168);
            txtMatrixResult.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 24);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Matrix A:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(450, 24);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Matrix B:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 24);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "  Thread  ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 87);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 8;
            label4.Text = "Sequence";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(359, 105);
            button2.Name = "button2";
            button2.Size = new Size(85, 42);
            button2.TabIndex = 9;
            button2.Text = "A×B";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(359, 168);
            button3.Name = "button3";
            button3.Size = new Size(85, 42);
            button3.TabIndex = 10;
            button3.Text = "A×B";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(373, 150);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 11;
            label5.Text = "  Parallel   ";
            label5.Click += label5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 246);
            button4.Name = "button4";
            button4.Size = new Size(85, 42);
            button4.TabIndex = 12;
            button4.Text = "AVG";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBoxTimes
            // 
            textBoxTimes.Location = new Point(103, 246);
            textBoxTimes.Multiline = true;
            textBoxTimes.Name = "textBoxTimes";
            textBoxTimes.Size = new Size(135, 104);
            textBoxTimes.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 228);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 14;
            label6.Text = "Time avg:";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBoxTimes);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatrixResult);
            Controls.Add(lblTime);
            Controls.Add(button1);
            Controls.Add(txtMatrixA);
            Controls.Add(txtMatrixB);
            Name = "Form1";
            Text = "Matrix Multiplication";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMatrixB;
        private TextBox txtMatrixA;
        private Button button1;
        private Label lblTime;
        private TextBox txtMatrixResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private Button button4;
        private TextBox textBoxTimes;
        private Label label6;
    }
}
