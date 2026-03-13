using System.Diagnostics.Eventing.Reader;

namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Distancia = Convert.ToDouble(txtDistancia.Text);
            if(Distancia < 200)
            {
                lbResultado.Text = Convert.ToString(Distancia * 0.50);
            }
            else 
            {
                lbResultado.Text = Convert.ToString(Distancia * 0.45);
            }
           

        }
    }
}
