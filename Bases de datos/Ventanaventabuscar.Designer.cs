namespace Bases_de_datos
{
    partial class Ventanaventabuscar
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
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1020, 533);
            button1.Name = "button1";
            button1.Size = new Size(76, 35);
            button1.TabIndex = 0;
            button1.Text = "ATRAS";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(439, 115);
            button2.Name = "button2";
            button2.Size = new Size(123, 49);
            button2.TabIndex = 23;
            button2.Text = "Buscar ID";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 23);
            textBox2.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 108);
            label3.Name = "label3";
            label3.Size = new Size(51, 45);
            label3.TabIndex = 22;
            label3.Text = "ID";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(56, 194);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(924, 374);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 28);
            label1.Name = "label1";
            label1.Size = new Size(370, 65);
            label1.TabIndex = 25;
            label1.Text = "BUSCAR VENTA";
            // 
            // Ventanaventabuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1139, 608);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Name = "Ventanaventabuscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventanaventabuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}