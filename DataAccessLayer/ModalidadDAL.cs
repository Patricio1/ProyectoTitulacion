using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
   public  class ModalidadDAL
    {
       Conexion conexion;
       public ModalidadDAL() {
           conexion = new Conexion();
       }
       public List<Modalidad> GetModalidad() {
           List<Modalidad> lista = new List<Modalidad>();
           Modalidad modalidad = null;

           string sql = "SELECT ID_MODALIDAD, NOMBRE, NUMERO_PROCESOS FROM MODALIDAD";

           using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
           {
               using (SqlCommand command = new SqlCommand(sql, connection))
               {
                   connection.Open();
                   SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                   while (reader.Read())
                   {
                       modalidad = new Modalidad();
                       modalidad.IDModalidad = reader["ID_MODALIDAD"].ToString();
                       modalidad.NombreModalidad = reader["NOMBRE"].ToString();
                       if (reader["NUMERO_PROCESOS"].ToString().Trim().Length > 0)
                       {
                           modalidad.CantidadProcesos = Convert.ToInt32(reader["NUMERO_PROCESOS"].ToString());
                       }
                       else {
                           modalidad.CantidadProcesos = 0;
                       }
                   
                       lista.Add(modalidad);
                   }
                   reader.Close();                
               }
               connection.Close();
           }
           return lista;
       }
    }
}
