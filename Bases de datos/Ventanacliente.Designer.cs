namespace Bases_de_datos
{
    partial class Ventanacliente
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
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1009, 516);
            button3.Name = "button3";
            button3.Size = new Size(93, 43);
            button3.TabIndex = 5;
            button3.Text = "ATRAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 72);
            label1.Name = "label1";
            label1.Size = new Size(138, 90);
            label1.TabIndex = 7;
            label1.Text = "Nombre\r\n\r\n";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(464, 109);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 8;
            button1.Text = "Buscar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 119);
            label3.Name = "label3";
            label3.Size = new Size(51, 45);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 139);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Azure;
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(85, 213);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(890, 362);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(855, 92);
            button2.Name = "button2";
            button2.Size = new Size(172, 53);
            button2.TabIndex = 14;
            button2.Text = "AÑADIR CLIENTE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 9);
            label2.Name = "label2";
            label2.Size = new Size(223, 65);
            label2.TabIndex = 15;
            label2.Text = "AGENDA";
            // 
            // Ventanacliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1139, 608);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Name = "Ventanacliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventanacliente";
            Load += Ventanacliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Label label2;
    }
}