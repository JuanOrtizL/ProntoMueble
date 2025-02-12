namespace Bases_de_datos
{
    partial class Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(407, 54);
            label1.Name = "label1";
            label1.Size = new Size(291, 65);
            label1.TabIndex = 0;
            label1.Text = "CONSULTAS";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cliente que gasto mas en un mes", "Clientes nuevos (cada mes)", "Cual vendedor realizo más ventas durante el ultimo mes", "Cual es el producto mas vendido durante el ultimo mes" });
            comboBox1.Location = new Point(255, 212);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(592, 23);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(488, 290);
            button1.Name = "button1";
            button1.Size = new Size(92, 48);
            button1.TabIndex = 2;
            button1.Text = "BUSCAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(255, 398);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(592, 181);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(1037, 547);
            button2.Name = "button2";
            button2.Size = new Size(90, 49);
            button2.TabIndex = 4;
            button2.Text = "ATRAS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Consultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1139, 608);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Consultas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}