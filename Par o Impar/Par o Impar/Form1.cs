namespace Par_o_Impar
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
            int numero = Int32.Parse(txt1.Text);

            int operacion = numero % 2;

            if (operacion == 0)
            {
                MessageBox.Show("El numero es PAR");
            }
            else
            {
                MessageBox.Show("El numero es IMPAR");
            }

        }
    }
}