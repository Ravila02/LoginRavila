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
            string contrase�a = txtPass.Text;

            // Validar las credenciales del usuario
            usuario.ValidarUsuario(nombreUsuario, contrase�a);

            // Verificar si el usuario es admin
            if (nombreUsuario == "admin" && contrase�a == "admin")
            {
                // Abrir el formulario CrearUsuario
                CrearUsuario formCrearUsuario = new CrearUsuario();
                formCrearUsuario.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesi�n
            }
            else
            {
                // Verificar el estado de la conexi�n despu�s de la validaci�n
                if (usuario.estadoConexion == "Usuario EXISTE")
                {
                    // Si las credenciales son v�lidas, registrar el inicio de sesi�n
                    usuario.RegistroLogInicioSesion();

                    // Aqu� puedes abrir el formulario principal de tu aplicaci�n o realizar otras acciones
                    MessageBox.Show("Inicio de sesi�n exitoso");
                }
                else
                {
                    // Si las credenciales no son v�lidas, mostrar un mensaje de error
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de usuario y contrase�a al hacer clic en Cancelar
            txtUsuario.Text = "";
            txtPass.Text = "";
        }
    }
}
