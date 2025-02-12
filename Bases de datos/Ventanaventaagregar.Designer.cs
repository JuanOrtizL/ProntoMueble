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
            label2.Location = new Point(439, 37);
            label2.Name = "label2";
            label2.Size = new Size(221, 50);
            label2.TabIndex = 8;
            label2.Text = "Datos Venta";
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
            label3.Location = new Point(752, 363);
            label3.Name = "label3";
            label3.Size = new Size(301, 112);
            label3.TabIndex = 11;
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1035, 553);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
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
            dateTimePicker1.Size = new Size(200, 23);
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
            // Ventanaventaagregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1139, 608);
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
    }
}