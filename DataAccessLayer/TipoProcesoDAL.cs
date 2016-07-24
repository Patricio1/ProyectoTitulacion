using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   public class TipoProcesoDAL
    {
       Conexion conexion;
       public TipoProcesoDAL() {
           conexion = new Conexion();
       }
       public List<TipoProceso> GetTipoProceso() {

           List<TipoProceso> lista = new List<TipoProceso>();
            TipoProceso tipoProceso = null;

            string sql = "SELECT CI_TIPO_PROCESO, NOMBRE FROM TIPO_PROCESO";

            using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        tipoProceso = new TipoProceso();
                        tipoProceso.CI_Tipo_Proceso = Convert.ToInt32(reader["CI_TIPO_PROCESO"].ToString());
                        tipoProceso.NombreProceso = reader["NOMBRE"].ToString();
                        lista.Add(tipoProceso);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return lista;
        

       }
    }
}
