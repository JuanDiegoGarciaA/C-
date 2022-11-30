using Gestion_de_Usuarios.dao;
using Gestion_de_Usuarios.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Usuarios
{
    public partial class GestionUsuarios : Form
    {
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            renderLista();
        }

        private void renderLista()
        {
            UsuarioDao baseDeDatos = new UsuarioDao();
            List<Usuario> listaDb = baseDeDatos.ObtenerlistadoDeUsuarios();
            listUsuarios.Items.Clear();
            for(int i = 0; i < listaDb.Count; i++)
            {
                Usuario usuario =listaDb[i];
                listUsuarios.Items.Add(usuario);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Telefono = txtTelefono.Text;
            usuario.TarjetaDeCredito = txtTarjeta.Text;

            if (lblId.Text != "")
            {
                usuario.Id = lblId.Text;
            }

            UsuarioDao baseDeDatos = new UsuarioDao();
            baseDeDatos.Guardar(usuario);
            renderLista();
            limpiarListado();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)listUsuarios.SelectedItem;

            UsuarioDao baseDeDatos = new UsuarioDao();
            baseDeDatos.Eliminar(usuario);
            renderLista();
            limpiarListado();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)listUsuarios.SelectedItem;
            lblId.Text = usuario.Id;
            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtTelefono.Text = usuario.Telefono;
            txtTarjeta.Text = usuario.TarjetaDeCredito;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarListado();
        }
        private void limpiarListado()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjeta.Text = "";
        }
    }
}
