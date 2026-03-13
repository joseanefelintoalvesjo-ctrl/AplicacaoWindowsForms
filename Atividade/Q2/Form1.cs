namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            
            double Cotacao = Convert.ToDouble(txtDólares.Text);
            double Resultado = Cotacao * Convert.ToDouble(txtCotação.Text);
            lbResultado.Text = Resultado.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
