using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject
{
  public  class Formato_Archivo
    {
      public string ID_Formato
      {
          get;
          set;
      }
      public int CI_Tipo_Proceso
      {
          get;
          set;
      }
      public string NombreArchivo
      {
          get;
          set;
      }
      public Byte[] Archivo
      {
          get;
          set;
      }
    }
}
