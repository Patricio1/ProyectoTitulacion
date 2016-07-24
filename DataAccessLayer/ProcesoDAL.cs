using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   public class ProcesoDAL
    {
       Conexion conexion;
       public ProcesoDAL() {
           conexion = new Conexion();
       }
       public List<string> GetProcesoById(int idProceso)
       {
           List<string> resultado = new List<string>();
           Proceso proceso = null;

           string sql = "SELECT E.NOMBRE, E.APELLIDO, P.DESTINO,P.FECHA_SALIDA, TP.NOMBRE AS NOMBRETP "+
                        "FROM ESTUDIANTE E, PROCESO P, TIPO_PROCESO TP "+
                        "WHERE P.CI_EST = E.CI_EST AND "+ 
                        "P.CI_TIPO_PROCESO = TP.CI_TIPO_PROCESO AND "+
                        "P.CI_PROCESO=@CI_PROCESO";

           using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
           {
               using (SqlCommand command = new SqlCommand(sql, connection))
               {
                   command.Parameters.AddWithValue("@CI_PROCESO", idProceso);
                   connection.Open();

                   SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                   if (reader.Read())
                   {
                       proceso = new Proceso();
                       resultado.Add(reader["NOMBRE"].ToString());
                       resultado.Add(reader["APELLIDO"].ToString());
                       resultado.Add(reader["DESTINO"].ToString());
                       resultado.Add(reader["FECHA_SALIDA"].ToString());
                       resultado.Add(reader["NOMBRETP"].ToString());
                   }
                   reader.Close();
               }
               connection.Close();
           }

           return resultado;
       }

       public int InsertProceso(Proceso proceso) {
           int afectadas;

           string sql = "INSERT INTO PROCESO (CI_TIPO_PROCESO,CI_EST,DESTINO,FECHA_SALIDA) VALUES(@CI_TIPO_PROCESO,@CI_EST,@DESTINO,@FECHA_SALIDA)";

           using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
           {
               using (SqlCommand command = new SqlCommand(sql, connection))
               {
                   command.Parameters.AddWithValue("@CI_TIPO_PROCESO", proceso.CI_Tipo_Proceso);
                   command.Parameters.AddWithValue("@CI_EST", proceso.CI_Estudiante);
                   command.Parameters.AddWithValue("@DESTINO", proceso.DestinoProceso);
                   command.Parameters.AddWithValue("@FECHA_SALIDA", proceso.FechaSalida);

                   connection.Open();
                   afectadas = command.ExecuteNonQuery();
                   connection.Close();
               }
           }
           return afectadas;
       }
       public int UpdateProceso(Proceso proceso)
       {
           int afectadas;

           string sql = "UPDATE PROCESO SET FECHA_RESOLUCION=@FECHA_RESOLUCION,"+
"ARCHIVO=@ARCHIVO,OBSERVACION=@OBSERVACION WHERE CI_PROCESO=@CI_PROCESO";

           using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
           {
               using (SqlCommand command = new SqlCommand(sql, connection))
               {                 
                   command.Parameters.AddWithValue("@FECHA_RESOLUCION", proceso.FechaResolucion);
                   command.Parameters.AddWithValue("@ARCHIVO", proceso.Archivo);
                   command.Parameters.AddWithValue("@OBSERVACION", proceso.Observacion);
                   command.Parameters.AddWithValue("@CI_PROCESO", proceso.CI_Proceso);

                   connection.Open();
                   afectadas = command.ExecuteNonQuery();
                   connection.Close();
               }
           }

           return afectadas;
       }
    }
}
