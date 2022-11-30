namespace Numero_mayor_y_menor
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        { 
            double num1 = Convert.ToDouble(txt1.Text);
            double num2 = Convert.ToDouble(txt2.Text);
            double num3 = Convert.ToDouble(txt3.Text);

            //mi solucion
            /*if(num1 > num2 && num1 > num3)
            {
                MessageBox.Show("El numero mayor es: " + num1);
                if (num2 < num3)
                {
                    MessageBox.Show("El numero menor es: " + num2);
                }
                else
                {
                    MessageBox.Show("El numero menor es: " + num3);
                }
            }
            else
            {
                if(num2> num3 && num2 > num1)
                {
                   c
                    if(num1< num3)
                    {
                        MessageBox.Show("El numero menor es: " + num1);
                    }
                    else
                    {
                        MessageBox.Show("El numero menor es: " + num3);
                    }
                }
                else
                {
                    MessageBox.Show("El numero mayor es: " + num3);
                    if(num1 < num2)
                    {
                        MessageBox.Show("El numero menor es: " + num1);
                    }
                    else
                    {
                        MessageBox.Show("El numero menor es: " + num2);
                    }
                }
            }*/
            //solucion del curso

            double mayor = num1;
            double menor = num1;

            if(mayor < num2)
            {
                mayor = num2;
            }
            if(mayor < num3)
            {
                mayor = num3;
            }
            if (menor > num2)
            {
                menor = num2;
            }
            if (menor > num3)
            {
                menor = num3;
            }
            MessageBox.Show("El numero mayor es: " + mayor);
            MessageBox.Show("El numero mayor es: " + menor);
        }
    }
}