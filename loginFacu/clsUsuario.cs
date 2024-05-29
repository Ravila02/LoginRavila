using System;
using System.Data;
using System.Data.OleDb;

namespace loginFacu
{
    public class clsUsuario
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        string rutaArchivo;
        public string estadoConexion;

        public clsUsuario()
        {
            try
            {
                rutaArchivo = @"C:\Users\Alumno\source\repos\loginFacu\loginFacu\BDusuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

                // Abre la conexión y verifica si está abierta
                conexionBD.Open();
                if (conexionBD.State == ConnectionState.Open)
                {
                    Console.WriteLine("Conexión establecida correctamente a la base de datos.");
                    estadoConexion = "Conectado";
                }
                else
                {
                    Console.WriteLine("Error al conectar con la base de datos.");
                    estadoConexion = "Desconectado";
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error al conectar con la base de datos: " + error.Message);
                estadoConexion = "Desconectado";
            }
            finally
            {
                // Cierra la conexión después de usarla
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }

        public void RegistroLogInicioSesion()
        {
            try
            {
                conexionBD.Open();

                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                adaptadorBD = new OleDbDataAdapter(comandoBD);

                adaptadorBD.Fill(objDS, "Logs");

                DataTable objTabla = objDS.Tables["Logs"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["Categoria"] = "Inicio Sesión";
                nuevoRegistro["FechaHora"] = DateTime.Now;
                nuevoRegistro["Descripcion"] = "Inicio exitoso";

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);
                adaptadorBD.Update(objDS, "Logs");

                estadoConexion = "Registro exitoso de log";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
            finally
            {
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }

        public void ValidarUsuario(string nombreUser, string passUser)
        {
            try
            {
                conexionBD.Open();

                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = CommandType.Text;
                comandoBD.CommandText = "SELECT * FROM Usuario WHERE Nombre = @nombre AND Contraseña = @contraseña";

                // Parámetros para evitar inyección SQL
                comandoBD.Parameters.AddWithValue("@nombre", nombreUser);
                comandoBD.Parameters.AddWithValue("@contraseña", passUser);

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    estadoConexion = "Usuario EXISTE";
                }
                else
                {
                    estadoConexion = "Usuario NO EXISTE";
                }
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
            finally
            {
                if (conexionBD.State == ConnectionState.Open)
                {
                    conexionBD.Close();
                }
            }
        }
    }
}