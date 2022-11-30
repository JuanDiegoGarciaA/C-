namespace numeros_primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double numero = 1;
            string resultado = "";
            int aux = 0;
            int contador = Int32.Parse(cont.Text); 

            while (aux<contador)
            {
                if (esNumeroPrimo(numero))
                {
                    resultado = resultado + "," + numero;
                    aux++;
                }
                numero++;
            }
            MessageBox.Show(resultado); 
        }
        private bool esNumeroPrimo(double numero)
        {
            bool primo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    primo = false;
                }
            }
            return primo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}