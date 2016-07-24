using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
   public class Proceso
    {
       public int CI_Proceso
       {
           get;
           set;
       }
       public int CI_Tipo_Proceso
       {
           get;
           set;
       }
       public string CI_Estudiante
       {
           get;
           set;
       }
       public string DestinoProceso
       {
           get;
           set;
       }
       public Boolean EstadoProceso
       {
           get;
           set;
       }
       public DateTime FechaSalida
       {
           get;
           set;
       }
       public DateTime FechaResolucion
       {
           get;
           set;
       }
       public byte[] Archivo
       {
           get;
           set;
       }
       public string Observacion
       {
           get;
           set;
       }
    }
}
