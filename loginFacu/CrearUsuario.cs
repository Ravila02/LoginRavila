using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace loginFacu
{
    public partial class CrearUsuario : Form
    {
        private OleDbConnection conexionBD;
        public CrearUsuario()
        {
            InitializeComponent();
            // Inicializar la conexión a la base de datos
            string rutaArchivo = @"C:\Users\Alumno\source\repos\loginFacu\loginFacu\BDusuarios.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaArchivo};Persist Security Info=False;";
            conexionBD = new OleDbConnection(connectionString);
        }

        private void cmdCargarUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los datos ingresados por el usuario
                string usuario = txtUsuarioCargar.Text;
                string contraseña = txtPassCargar.Text;
                string perfil = txtPerfil.Text;

                // Verificar si el perfil es válido
                if (perfil == "Ventas" || perfil == "Compras" || perfil == "Secretaria")
                {
                    // Abrir la conexión a la base de datos
                    conexionBD.Open();

                    // Crear la consulta SQL para insertar un nuevo usuario
                    string consulta = "INSERT INTO Usuario (Nombre, Contraseña, Perfil) VALUES (@nombre, @contraseña, @perfil)";

                    // Crear y configurar el comando SQL
                    OleDbCommand comando = new OleDbCommand(consulta, conexionBD);
                    comando.Parameters.AddWithValue("@nombre", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    comando.Parameters.AddWithValue("@perfil", perfil);

                    // Ejecutar la consulta
                    comando.ExecuteNonQuery();

                    // Cerrar la conexión a la base de datos
                    conexionBD.Close();

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Usuario creado exitosamente");
                }
                else
                {
                    MessageBox.Show("Perfil inválido. Los perfiles válidos son: Ventas, Compras, Secretaria");
                }
            }
            catch (Exception ex)
            {
                // Manejar errores
                MessageBox.Show($"Error al crear usuario: {ex.Message}");
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario
            this.Close();
        }
    }
}