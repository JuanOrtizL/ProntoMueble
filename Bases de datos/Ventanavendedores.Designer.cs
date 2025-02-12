namespace Bases_de_datos
{
    partial class Ventanavendedores
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
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 102);
            label2.Name = "label2";
            label2.Size = new Size(872, 350);
            label2.TabIndex = 20;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(491, 505);
            button1.Name = "button1";
            button1.Size = new Size(89, 43);
            button1.TabIndex = 21;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(396, 40);
            label1.Name = "label1";
            label1.Size = new Size(302, 45);
            label1.TabIndex = 22;
            label1.Text = "Vendedores activos";
            // 
            // Ventanavendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1139, 608);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Name = "Ventanavendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventanavendedores";
            Load += Ventanavendedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button3;
        private Button button1;
        private Label label1;
    }
}