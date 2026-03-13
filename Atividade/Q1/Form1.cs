namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        { 
            double Celsius  = Convert.ToDouble(txtCelsius.Text);
            lbResultado.Text = Convert.ToString(Celsius * 9 / 5) + 32;
        }
    }
}
