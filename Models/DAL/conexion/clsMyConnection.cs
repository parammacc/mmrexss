using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ResidentEvil.Models.DAL.conexion
{
    public class clsMyConnection
    {
        #region atributos
            public String database { get; set; }
            public String user { get; set; }
            public String pass { get; set; }
        #endregion

        #region constructores
            //constructor por defecto
            public clsMyConnection()
            {
                this.database = "Resident Evil Casa";
                this.user = "prueba";
            //    this.pass = "prueba";
                this.pass = "prueba123";
            }
            //constructor con parámetros
            public clsMyConnection(String database, String user, String pass)
            {
                this.database = database;
                this.user = user;
                this.pass = pass;
            }
        #endregion
            /**
             * ''' This method open a connection with the database.
//'    ''' </summary>
//'    ''' <pre>Nothing.</pre>
//'    ''' <post>The connection is opened.</post>
//'    ''' <returns>A connection with the database.</returns>
//'    ''' <remarks></remarks>
             */
            public SqlConnection getConnection()
            {
                SqlConnection connection = new SqlConnection();
                try
                {
                    
                    //connection.ConnectionString = "Data Source=" + System.Environment.MachineName + "Initial Catalog=" + database + ";uid=" + user + ";pwd=" + user + ";";
            //        connection.ConnectionString = "server=(local);database=" + database + ";uid=" + user + ";pwd=" + pass + ";";
            //        connection.ConnectionString = "server=PRIVADO-PC\\MIEQUIPO;database=" + database + ";uid=" + user + ";pwd=" + pass + ";";
                    connection.ConnectionString = "server=PRIVADO-PC\\SEKUL;database=" + database + ";uid=" + user + ";pwd=" + pass + ";";
                    connection.Open();
                }
                catch(SqlException){
                    throw;
                }
                return connection;
            }

            /*
             * ''' <summary>
    '    ''' This method close a connection with the database.
    '    ''' </summary>
    '    ''' <pre>Nothing.</pre>
    '    ''' <post>The connection is closed.</post>
    '    ''' <param name="connection">The input parameter is the connection to close.</param>
    '    ''' <remarks></remarks>
             */
            public void closeConnection(ref SqlConnection connection)
            {
                try
                {
                    connection.Close();
                }
                catch (SqlException)
                {
                    throw;
                }
                catch (Exception)
                {
                    throw;
                }
            }

        
    }
}