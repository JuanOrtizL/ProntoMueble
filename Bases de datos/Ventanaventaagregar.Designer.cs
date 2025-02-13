namespace Bases_de_datos
{
    partial class Ventanaventaagregar
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
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(828, 198);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "ID MUEBLE";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(828, 244);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "CANTIDAD";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 46);
            label2.Name = "label2";
            label2.Size = new Size(302, 50);
            label2.TabIndex = 8;
            label2.Text = "AGREGAR VENTA";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(177, 189);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "ID VENDEDOR";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 9;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(789, 285);
            button1.Name = "button1";
            button1.Size = new Size(175, 52);
            button1.TabIndex = 10;
            button1.Text = "Calcular subtotal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(725, 362);
            label3.Name = "label3";
            label3.Size = new Size(301, 112);
            label3.TabIndex = 11;
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1030, 537);
            button2.Name = "button2";
            button2.Size = new Size(78, 43);
            button2.TabIndex = 12;
            button2.Text = "atras";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(483, 477);
            button3.Name = "button3";
            button3.Size = new Size(137, 50);
            button3.TabIndex = 15;
            button3.Text = "AGREGAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 244);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ID CLIENTE";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(177, 301);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tarjeta de credito", "Efectivo", "Tarjeta de debito", "Transferencia" });
            comboBox1.Location = new Point(177, 341);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 188);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 19;
            label1.Text = "ID vendedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 247);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 20;
            label4.Text = "ID cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 303);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 21;
            label5.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(58, 344);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 22;
            label6.Text = "Medio de pago";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(688, 198);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 23;
            label7.Text = "ID mueble";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(688, 244);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 24;
            label8.Text = "Cantidad";
            // 
            // Ventanaventaagregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1139, 608);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label2);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Name = "Ventanaventaagregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventanaventaagregar";
            Load += Ventanaventaagregar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label2;
        private TextBox textBox8;
        private Button button1;
        private Label label3;
        private Button button2;
        
        private Label label4;
        private Button button3;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}