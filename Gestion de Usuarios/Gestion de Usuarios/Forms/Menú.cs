namespace Gestion_de_Usuarios
{
    public partial class Men� : Form
    {
        public Men�()
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