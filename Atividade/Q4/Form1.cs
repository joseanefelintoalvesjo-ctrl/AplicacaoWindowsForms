namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
         int Numero =  Convert.ToInt32(txtNumero.Text);
            List<int> Tabuada = new List<int>();

            for(int i = 1; i<= 10; i++)
            {
                int Resultado = Numero * i;
                List.Items.Add(Numero + "X" + i + "=" + Resultado);
            }
        }
    }
}
