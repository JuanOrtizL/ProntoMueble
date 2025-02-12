namespace Bases_de_datos
{
    partial class Ventanainvntarioproveedor
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
            label3 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(56, 108);
            label3.Name = "label3";
            label3.Size = new Size(51, 45);
            label3.TabIndex = 22;
            label3.Text = "ID";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 21;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(989, 505);
            button3.Name = "button3";
            button3.Size = new Size(93, 43);
            button3.TabIndex = 16;
            button3.Text = "ATRAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(56, 61);
            label1.Name = "label1";
            label1.Size = new Size(138, 90);
            label1.TabIndex = 18;
            label1.Text = "Nombre\r\n\r\n";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(440, 81);
            button1.Name = "button1";
            button1.Size = new Size(184, 72);
            button1.TabIndex = 19;
            button1.Text = "Buscar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(56, 209);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(875, 349);
            richTextBox1.TabIndex = 23;
            richTextBox1.Text = "";
            // 
            // Ventanainvntarioproveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1139, 608);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Ventanainvntarioproveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventanainvntarioproveedor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
    }
}