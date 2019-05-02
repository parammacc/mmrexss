using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentEvil.Models.Entities;
using System.Data.SqlClient;
using ResidentEvil.Models.DAL.conexion;

namespace ResidentEvil.Models.Listados
{
    public class clsListadoAncianosDAL
    {
        public List<clsAnciano> getListadoAncianosDAL()
        {
            /*
             * Dim listaArticulos As New List(Of clsArticulo)
        Dim conexion As New SqlConnection
        Dim miConexion As New clsMyConnection
        Dim readerArticulos As SqlDataReader = Nothing
        Dim oComando As New SqlCommand
        Dim articulo As clsArticulo
             */
            List<clsAnciano> listaAncianos=new List<clsAnciano>();
            SqlConnection conexion=null;
            clsMyConnection miConexion = new clsMyConnection();
            SqlDataReader readerAncianos = null;
            SqlCommand oComando;
            clsAnciano anciano = null; ;
        //    clsAnciano anciano = new clsAnciano();
            try
            {
                conexion = miConexion.getConnection();
       //         oComando = new SqlCommand("SELECT * FROM Ancianos");
                oComando = new SqlCommand("SELECT * FROM Ancianos", conexion);
                readerAncianos = oComando.ExecuteReader();
                if (readerAncianos.HasRows)
                {
                    while(readerAncianos.Read()){
                        anciano = new clsAnciano();
                    //    anciano = new clsAnciano((int)readerAncianos["idAnciano"], readerAncianos["nombreAnciano"].ToString());
                        anciano.idAnciano = (int)readerAncianos["idAnciano"];
                        anciano.nombreAnciano = readerAncianos["nombreAnciano"].ToString();
                        listaAncianos.Add(anciano);
                    }  
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                readerAncianos.Close();
                conexion.Close();
            }
            return listaAncianos;
        }
    }
}