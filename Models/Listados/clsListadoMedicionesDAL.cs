using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ResidentEvil.Models.Entities;
using System.Data.SqlClient;
using ResidentEvil.Models.DAL.conexion;
using ResidentEvil.Models.Modelo_para_las_vistas;

namespace ResidentEvil.Models.Listados
{
    public class clsListadoMedicionesDAL
    {
        public List<clsMedicionConNombreAnciano> getListadoMedicionesDAL()
        {
            List<clsMedicion> listaMediciones = new List<clsMedicion>();
            SqlConnection conexion = null;
            clsMyConnection miConexion = new clsMyConnection();
            SqlDataReader readerMediciones = null;
            SqlCommand oComando;
            clsMedicion medicion = null; ;
            //    clsAnciano anciano = new clsAnciano();
            try
            {
                conexion = miConexion.getConnection();
                //         oComando = new SqlCommand("SELECT * FROM Ancianos");
                oComando = new SqlCommand("SELECT * FROM Mediciones", conexion);
                readerMediciones = oComando.ExecuteReader();
                if (readerMediciones.HasRows)
                {
                    while (readerMediciones.Read())
                    {
                        medicion = new clsMedicion();
                        //    anciano = new clsAnciano((int)readerAncianos["idAnciano"], readerAncianos["nombreAnciano"].ToString());
          //              medicion.fecha = (DateTime)readerMediciones["fecha"];
                        medicion.idAnciano = (int)readerMediciones["idAnciano"];
                        medicion.temperatura = (float)readerMediciones["temperatura"];
              //          medicion.nombre = readerMediciones["nombre"];
                        medicion.tramo = (char)readerMediciones["tramo"];
                        listaMediciones.Add(medicion);
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                readerMediciones.Close();
                conexion.Close();
            }
            return listaMediciones;
        }
    }
}