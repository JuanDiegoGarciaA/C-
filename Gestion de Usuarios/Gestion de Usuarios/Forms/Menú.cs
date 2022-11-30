namespace Gestion_de_Usuarios
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionUsuarios ventanaGestionUsuarios = new GestionUsuarios();
            ventanaGestionUsuarios.ShowDialog();
        }
    }
}