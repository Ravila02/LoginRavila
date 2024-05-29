using System;
using System.Data;
using System.Data.OleDb;

namespace loginFacu
{
    public partial class Form1 : Form
    {
        private clsUsuario usuario;
        public Form1()
        {
            InitializeComponent();
            usuario = new clsUsuario();
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtPass.Text;

            // Validar las credenciales del usuario
            usuario.ValidarUsuario(nombreUsuario, contraseña);

            // Verificar si el usuario es admin
            if (nombreUsuario == "admin" && contraseña == "admin")
            {
                // Abrir el formulario CrearUsuario
                CrearUsuario formCrearUsuario = new CrearUsuario();
                formCrearUsuario.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                // Verificar el estado de la conexión después de la validación
                if (usuario.estadoConexion == "Usuario EXISTE")
                {
                    // Si las credenciales son válidas, registrar el inicio de sesión
                    usuario.RegistroLogInicioSesion();

                    // Aquí puedes abrir el formulario principal de tu aplicación o realizar otras acciones
                    MessageBox.Show("Inicio de sesión exitoso");
                }
                else
                {
                    // Si las credenciales no son válidas, mostrar un mensaje de error
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de usuario y contraseña al hacer clic en Cancelar
            txtUsuario.Text = "";
            txtPass.Text = "";
        }
    }
}
