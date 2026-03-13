namespace Q2
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
            lbCotação = new Label();
            txtCotação = new TextBox();
            lbQuantidade = new Label();
            txtDólares = new TextBox();
            btnConverter = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // lbCotação
            // 
            lbCotação.AutoSize = true;
            lbCotação.Location = new Point(70, 43);
            lbCotação.Name = "lbCotação";
            lbCotação.Size = new Size(99, 15);
            lbCotação.TabIndex = 0;
            lbCotação.Text = "Cotação do Dólar";
            // 
            // txtCotação
            // 
            txtCotação.Location = new Point(69, 61);
            txtCotação.Name = "txtCotação";
            txtCotação.Size = new Size(100, 23);
            txtCotação.TabIndex = 1;
            // 
            // lbQuantidade
            // 
            lbQuantidade.AutoSize = true;
            lbQuantidade.Location = new Point(57, 117);
            lbQuantidade.Name = "lbQuantidade";
            lbQuantidade.Size = new Size(130, 15);
            lbQuantidade.TabIndex = 2;
            lbQuantidade.Text = "Quantidade em dólares";
            // 
            // txtDólares
            // 
            txtDólares.Location = new Point(70, 135);
            txtDólares.Name = "txtDólares";
            txtDólares.Size = new Size(100, 23);
            txtDólares.TabIndex = 3;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(94, 214);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 4;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(110, 255);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 5;
            lbResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtDólares);
            Controls.Add(lbQuantidade);
            Controls.Add(txtCotação);
            Controls.Add(lbCotação);
            Name = "Form1";
            Text = "Resultado";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCotação;
        private TextBox txtCotação;
        private Label lbQuantidade;
        private TextBox txtDólares;
        private Button btnConverter;
        private Label lbResultado;
    }
}
