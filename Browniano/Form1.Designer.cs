namespace Browniano
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 80);
            label1.Name = "label1";
            label1.Size = new Size(252, 41);
            label1.TabIndex = 0;
            label1.Text = "Dimensión (1 o 2)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 146);
            label2.Name = "label2";
            label2.Size = new Size(163, 41);
            label2.TabIndex = 1;
            label2.Text = "# de pasos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 213);
            label3.Name = "label3";
            label3.Size = new Size(267, 41);
            label3.TabIndex = 2;
            label3.Text = "# de experimentos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(379, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(379, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 47);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(727, 140);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 6;
            button1.Text = "Ejecutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(75, 306);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.RowTemplate.Height = 49;
            dataGridView1.Size = new Size(1214, 506);
            dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 844);
            label4.Name = "label4";
            label4.Size = new Size(387, 41);
            label4.TabIndex = 8;
            label4.Text = "Promedio Distancia Máxima";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(727, 841);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 47);
            textBox4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 948);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox4;
    }
}