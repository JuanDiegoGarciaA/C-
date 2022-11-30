namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcular el IMC
            string alturatxt = txtAltura.Text;
            double altura = Double.Parse(alturatxt);

            string pesotxt = txtPeso.Text;
            double peso = Double.Parse(pesotxt);

            double imc = peso / (altura * altura);
            MessageBox.Show("El IMC es: " +imc);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}