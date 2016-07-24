using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;//ConfigurationManager
using System.Web;

namespace DataAccessLayer
{
   public class EstudianteDAL
    {
       Conexion conexion;
        public EstudianteDAL() {
            conexion = new Conexion();
        
        }
        
        public Estudiante GetEstudianteById(string id)
        {
            Estudiante estudiante = null;
            string sql = "SELECT NOMBRE, APELLIDO, CARRERA, NUM_CREDITOS," +
             "CREDITOS_MALLA, IDIOMAS, CCFF, PRACTICAS, VINCULACION, VALORES_PAGO " +
             "FROM ESTUDIANTE WHERE CI_EST = @CI_EST";
            //workstation id=titulacion.mssql.somee.com;packet size=4096;user id=ACER-PC;pwd=jSsA1991;data source=titulacion.mssql.somee.com;persist security info=False;initial catalog=titulacion
            using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CI_EST", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.Read())
                    {
                        estudiante = new Estudiante();
                        estudiante.Nombre = reader["NOMBRE"].ToString();
                        estudiante.Apellido = reader["APELLIDO"].ToString();
                        estudiante.Carrera = reader["CARRERA"].ToString();
                        estudiante.NumeroCreditos = Convert.ToInt32(reader["NUM_CREDITOS"].ToString());
                        estudiante.CreditosMalla = Convert.ToBoolean(reader["CREDITOS_MALLA"].ToString());
                        estudiante.Idiomas = Convert.ToBoolean(reader["IDIOMAS"].ToString());
                        estudiante.CCFF = Convert.ToBoolean(reader["CCFF"].ToString());
                        estudiante.Practicas = Convert.ToBoolean(reader["PRACTICAS"].ToString());
                        estudiante.Vinculacion = Convert.ToBoolean(reader["VINCULACION"].ToString());
                        estudiante.ValoresPagados = Convert.ToBoolean(reader["VALORES_PAGO"].ToString());

                    }
                    reader.Close();
                }
                connection.Close();
            }
            return estudiante;
        }
       

        public List<Estudiante> GetEstudiantes()
        {
            List<Estudiante> lista = new List<Estudiante>();
            Estudiante estudiante = null;

            string sql = "SELECT CI_EST, NOMBRE, APELLIDO, CARRERA, NUM_CREDITOS FROM dbo.ESTUDIANTE";

            using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

                    while (reader.Read())
                    {
                        estudiante = new Estudiante();
                        estudiante.CI = reader["CI_EST"].ToString();
                        estudiante.Nombre = reader["NOMBRE"].ToString();
                        estudiante.Apellido = reader["APELLIDO"].ToString();
                        estudiante.Carrera = reader["CARRERA"].ToString();
                        estudiante.NumeroCreditos = Convert.ToInt32(reader["NUM_CREDITOS"].ToString());
                        lista.Add(estudiante);
                    }
                    reader.Close();
                }
                connection.Close();
            }
            return lista;
        }

    }
}
