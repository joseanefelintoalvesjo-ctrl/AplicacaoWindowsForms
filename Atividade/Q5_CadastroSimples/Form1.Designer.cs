namespace Q5_CadastroSimples
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
            lbnome = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtIdade = new TextBox();
            btnAdicionar = new Button();
            LstPessoas = new ListBox();
            SuspendLayout();
            // 
            // lbnome
            // 
            lbnome.AutoSize = true;
            lbnome.Location = new Point(211, 32);
            lbnome.Name = "lbnome";
            lbnome.Size = new Size(40, 15);
            lbnome.TabIndex = 0;
            lbnome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 93);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Idade";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(190, 130);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(211, 182);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // LstPessoas
            // 
            LstPessoas.FormattingEnabled = true;
            LstPessoas.ItemHeight = 15;
            LstPessoas.Location = new Point(146, 272);
            LstPessoas.Name = "LstPessoas";
            LstPessoas.Size = new Size(232, 154);
            LstPessoas.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LstPessoas);
            Controls.Add(btnAdicionar);
            Controls.Add(txtIdade);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(lbnome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbnome;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtIdade;
        private Button btnAdicionar;
        private ListBox LstPessoas;
    }
}
