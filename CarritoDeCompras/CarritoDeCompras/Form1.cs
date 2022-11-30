namespace CarritoDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProductos.Items.Add("Pantalón");
            cboProductos.Items.Add("Camisa");
            cboProductos.Items.Add("Zapatos");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string productos = cboProductos.SelectedItem.ToString(); 
            listCarrito.Items.Add(productos);

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Pantalon 20
            //Camisa 35
            //Zapatos 24

            double precioFinal = 0;
            int ProductosSeleccionados = listCarrito.Items.Count;

            for(int i = 0; i < ProductosSeleccionados; i++)
            {
                string productoElegido = listCarrito.Items[i].ToString();
                if(productoElegido == "Pantalón")
                {
                    precioFinal += 20;
                }
                else if (productoElegido == "Camisa")
                {
                    precioFinal += 35;
                }
                else if (productoElegido == "Zapatos")
                {
                    precioFinal += 24;
                }
            }
            string Codigo = txtDescuento.Text;
            if(Codigo == "NAVIDAD")
            {
                double descuento = precioFinal * 0.9;
                MessageBox.Show("El precio final es: $" + precioFinal + " y con descuento del 10% queda en: $" + descuento);
            }
            MessageBox.Show("El precio final es: $"+precioFinal);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}