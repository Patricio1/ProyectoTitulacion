using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObject;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
  public  class DocenteDAL
    {
      Conexion conexion;
      public DocenteDAL() {
          conexion = new Conexion();
      }
      public Docente GetDocenteByCargo(string cargo) {
          Docente docente = null;
          string sql = "SELECT NOMBRE, APELLIDO, CARGO FROM DOCENTE WHERE CARGO LIKE '%"+cargo+"%'";
          //workstation id=titulacion.mssql.somee.com;packet size=4096;user id=ACER-PC;pwd=jSsA1991;data source=titulacion.mssql.somee.com;persist security info=False;initial catalog=titulacion
          using (SqlConnection connection = new SqlConnection(conexion.GetConnectionString()))
          {
              using (SqlCommand command = new SqlCommand(sql, connection))
              {
                  //command.Parameters.AddWithValue("@CARGO", cargo);
                  connection.Open();

                  SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                  if (reader.Read())
                  {
                      docente = new Docente();
                      docente.NombreDocente = reader["NOMBRE"].ToString();
                      docente.ApellidoDocente = reader["APELLIDO"].ToString();
                      docente.Cargo = reader["CARGO"].ToString();
                  }
                  reader.Close();
              }
              connection.Close();
          }
          return docente;
      }
    }
}
