using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentEvil.Models.DAL.conexion;
using ResidentEvil.Models.Entities;
using System.Data.SqlClient;
using System.Data;


namespace ResidentEvil.Models.DAL.manejadora
{
    public class clsManejadoraAnciano
    {
        //atributos
        private clsMyConnection pedro;
        //constructor
        public clsManejadoraAnciano()
        {
            try
            {
                pedro = new clsMyConnection();
            }
            catch(Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// función que ofrece los detalles de un anciano
        /// </summary>
        /// <param name="id">es el número de id de anciano</param>
        /// <returns>devuelve un anciano</returns>
        public clsAnciano detallesAnciano(int id)
        {
            clsAnciano oAnciano = new clsAnciano();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader readerAncianos = null;
            SqlParameter parametro = new SqlParameter();
            try
            {
//En C#

//System.Data.SqlClient.SqlCommand cmd;
//cmd = new System.Data.SqlClient.SqlCommand();
//cmd.Connection = cnn;
//cmd.CommandText =
//    “Select * From Empleados Where Empleado = @Nombre”;
 
//System.Data.SqlClient.SqlParameter param;
//param = new System.Data.SqlClient.SqlParameter();
//param.ParameterName = “@Nombre”;
//param.SqlDbType = SqlDbType.VarChar;
//param.Size = 20;
//param.Value = txtNombre.Text;
 
//cmd.Parameters.Add(param);
//cmd.ExecuteNonQuery();
                //comando.Connection = pedro.getConnection();
                //comando.CommandText = "SELECT * FROM Ancianos WHERE idAnciano=@id";
                //parametro.ParameterName = "@id";
                //parametro.SqlDbType = SqlDbType.Int;
                //comando.Parameters.Add(parametro);

//System.Data.SqlClient.SqlCommand cmd;
//cmd = new System.Data.SqlClient.SqlCommand();
//cmd.Connection = cnn;
//cmd.CommandText =
//    “Select * From Empleados Where Empleado = @Nombre”;
 
//cmd.Parameters.Add(
//    “@Nombre”, SqlDbType.VarChar, 20).Value = txtNombre.Text;
//cmd.ExecuteNonQuery(); 
                conexion = pedro.getConnection();
                comando.CommandText = "SELECT * FROM Ancianos WHERE idAnciano=@id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comando.Connection = conexion;
                readerAncianos = comando.ExecuteReader();
                if (readerAncianos.HasRows)
                {
                    readerAncianos.Read();
                    
                        oAnciano = new clsAnciano();
                        oAnciano.idAnciano= (int)readerAncianos["idAnciano"];
                        oAnciano.nombreAnciano = readerAncianos["nombreAnciano"].ToString();
                    
                }
                return oAnciano;
            }
            finally
            {
                readerAncianos.Close();
                conexion.Close();
            }

            //return oAnciano;
        }
        /// <summary>
        /// procedimiento que elimina un anciano de la lista de ancianos
        /// </summary>
        /// <param name="id">id de anciano a eliminar de la lista</param>
        /// <returns>nada</returns>
        /// postcondiciones: elimina de la lista de ancianos al anciano seleccionado
        public void eliminaAnciano(int id)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion = pedro.getConnection();
                comando.CommandText = "DELETE FROM Ancianos WHERE idAnciano=@id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = id;
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }
        /// <summary>
        /// procedimiento que modifica un anciano
        /// </summary>
        /// <param name="viejete"></param>
        public void editaAnciano(clsAnciano viejete)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion = pedro.getConnection();
                comando.CommandText="UPDATE Ancianos SET nombreAnciano=@nombre WHERE idAnciano=@id";
                comando.Parameters.Add("@id", SqlDbType.Int).Value = viejete.idAnciano;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = viejete.nombreAnciano;
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }
        /// <summary>
        /// procedimiento que crea un objeto de tipo anciano
        /// </summary>
        /// <param name="inquilino"></param>
        public void creaAnciano(clsAnciano inquilino)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion = pedro.getConnection();
                comando.CommandText = "INSERT INTO Ancianos VALUES(@nombre)";
                comando.Parameters.Add("@nombre",SqlDbType.VarChar).Value=inquilino.nombreAnciano;
                comando.Connection=conexion;
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}