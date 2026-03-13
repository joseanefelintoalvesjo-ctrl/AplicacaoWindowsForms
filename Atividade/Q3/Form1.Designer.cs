namespace Q3
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
            lbDistancia = new Label();
            lbResultado = new Label();
            txtDistancia = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lbDistancia
            // 
            lbDistancia.AutoSize = true;
            lbDistancia.Location = new Point(49, 36);
            lbDistancia.Name = "lbDistancia";
            lbDistancia.Size = new Size(55, 15);
            lbDistancia.TabIndex = 0;
            lbDistancia.Text = "Distancia";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(45, 184);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "Resultado";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(33, 69);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(42, 116);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtDistancia);
            Controls.Add(lbResultado);
            Controls.Add(lbDistancia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDistancia;
        private Label lbResultado;
        private TextBox txtDistancia;
        private Button btnCalcular;
    }
}
