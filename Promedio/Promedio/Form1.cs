namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 =Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            double num3 = Convert.ToDouble(txt3.Text);

            double promedio = (num1 + num2 + num3) / 3;

            MessageBox.Show("El promedio de los numeros es: " + promedio);
        }
    }
}