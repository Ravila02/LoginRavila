using System;
using System.Data.OleDb;

namespace loginFacu
{
    public class ConexionBD
    {
        private OleDbConnection conexion;
        private string rutaArchivo;

        public ConexionBD()
        {
            try
            {
                // Ruta del archivo de la base de datos
               string rutaArchivo = @"C:\Users\Alumno\source\repos\loginFacu\loginFacu\BDusuarios.accdb";
                ;

                // Cadena de conexión
                string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={rutaArchivo};Persist Security Info=False;";

                // Inicializar la conexión
                conexion = new OleDbConnection(connectionString);

                // Abrir la conexión
                conexion.Open();
            }
            catch (Exception ex)
            {
                // Manejar excepciones si la conexión falla
                Console.WriteLine($"Error al conectar a la base de datos: {ex.Message}");
                throw;
            }
        }

        // Método para obtener la conexión
        public OleDbConnection ObtenerConexion()
        {
            return conexion;
            MessageBox.Show("Conexion exitosa");
        }
    }
}