namespace Bases_de_datos
{
    partial class ventanaclientesagregar
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 28);
            label1.Name = "label1";
            label1.Size = new Size(319, 65);
            label1.TabIndex = 19;
            label1.Text = "Datos Cliente";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 325);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "EMAIL";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 274);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "TELEFONO";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 223);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "DIRECCIÓN";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 177);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "NOMBRE";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(501, 532);
            button1.Name = "button1";
            button1.Size = new Size(98, 42);
            button1.TabIndex = 21;
            button1.Text = "ATRAS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(214, 437);
            button2.Name = "button2";
            button2.Size = new Size(145, 41);
            button2.TabIndex = 22;
            button2.Text = "AGREGAR CLIENTE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(214, 383);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(234, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 177);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 24;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 226);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 25;
            label3.Text = "DIRECCIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(81, 277);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 26;
            label4.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(81, 328);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 27;
            label5.Text = "EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 385);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 28;
            label6.Text = "fecha de registro";
            // 
            // ventanaclientesagregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1139, 608);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "ventanaclientesagregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ventanaclientesagregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}