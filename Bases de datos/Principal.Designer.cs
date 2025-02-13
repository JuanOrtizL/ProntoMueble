namespace Bases_de_datos
{
    partial class Principal
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
            Titulo = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Impact", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Titulo.Location = new Point(325, 37);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(429, 80);
            Titulo.TabIndex = 0;
            Titulo.Text = "PRONTOMUEBLE";
            Titulo.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Bisque;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(33, 366);
            button1.Name = "button1";
            button1.Size = new Size(356, 73);
            button1.TabIndex = 1;
            button1.Text = "VENTAS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Bisque;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(33, 203);
            button2.Name = "button2";
            button2.Size = new Size(356, 75);
            button2.TabIndex = 2;
            button2.Text = "INVENTARIO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Bisque;
            button3.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(33, 524);
            button3.Name = "button3";
            button3.Size = new Size(356, 73);
            button3.TabIndex = 3;
            button3.Text = "CLIENTES";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Bisque;
            button4.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(33, 445);
            button4.Name = "button4";
            button4.Size = new Size(356, 73);
            button4.TabIndex = 4;
            button4.Text = "VENDEDORES";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Bisque;
            button5.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(33, 284);
            button5.Name = "button5";
            button5.Size = new Size(356, 76);
            button5.TabIndex = 5;
            button5.Text = "CONSULTAS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Peru;
            ClientSize = new Size(1139, 608);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Titulo);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button button2;
        private Button button3;
        private Button button4;
        protected Button button1;
        private Button button5;
    }
}
