namespace Q1
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
            lbCelsius = new Label();
            txtCelsius = new TextBox();
            btnConverter = new Button();
            lbResultado = new Label();
            SuspendLayout();
            // 
            // lbCelsius
            // 
            lbCelsius.AutoSize = true;
            lbCelsius.Location = new Point(231, 84);
            lbCelsius.Name = "lbCelsius";
            lbCelsius.Size = new Size(68, 15);
            lbCelsius.TabIndex = 0;
            lbCelsius.Text = "Celsius (C°)";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(217, 116);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 1;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(231, 173);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(351, 181);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(59, 15);
            lbResultado.TabIndex = 3;
            lbResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbResultado);
            Controls.Add(btnConverter);
            Controls.Add(txtCelsius);
            Controls.Add(lbCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCelsius;
        private TextBox txtCelsius;
        private Button btnConverter;
        private Label lbResultado;
    }
}
