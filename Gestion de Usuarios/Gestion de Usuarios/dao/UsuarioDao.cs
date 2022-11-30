using Gestion_de_Usuarios.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Usuarios.dao
{
    internal class UsuarioDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "instituto";
            string password = "instituto";
            string baseDeDatos = "usuarios";
            string Conexion = "Database=" + baseDeDatos + "; Data Source=" + servidor + "; user Id=" + usuario + "; Password=" + password + "";

            MySqlConnection conexionDb = new MySqlConnection(Conexion);
            conexionDb.Open();
            return conexionDb;
        }
        public List<Usuario> ObtenerlistadoDeUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            string consulta = "SELECT * FROM `usuario`";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();
            
            
            while (lectura.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = lectura.GetString("id");
                usuario.Nombre = lectura.GetString("nombre");
                usuario.Apellido = lectura.GetString("apellido");
                usuario.Telefono = lectura.GetString("telefono");
                usuario.TarjetaDeCredito = lectura.GetString("tarjeta");
                lista.Add(usuario);
            }
            comando.Connection.Close();
            return lista;
        }

        public void Guardar(Usuario usuario)
        {
            if (usuario.Id == null)
            {
                insert(usuario);
            }
            else
            {
                update(usuario);
            }

        }
        private void insert (Usuario usuario)
        {
            string consulta = "INSERT INTO `usuario` (`id`,`nombre`,`apellido`,`telefono`,`tarjeta`)VALUES(NULL,'" + usuario.Nombre + "','" + usuario.Apellido + "','" + usuario.Telefono + "','" + usuario.TarjetaDeCredito + "');";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        private void update(Usuario usuario)
        {
            string consulta = "UPDATE `usuario` SET `nombre`='"+usuario.Nombre+"', `apellido`='"+usuario.Apellido+"',`telefono`='"+usuario.Telefono+"', `tarjeta`='"+usuario.TarjetaDeCredito+"' WHERE `usuario`.`id`="+usuario.Id+";";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Eliminar(Usuario usuario)
        {
            string consulta = "DELETE FROM `usuario` WHERE `usuario`.`id` = "+usuario.Id+"";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}
