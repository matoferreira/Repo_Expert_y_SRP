using System;
namespace Library
{
 public class IdConsulta
 {
    static int idconsulta = 0;
    public int GeneradorNumero()
    {
      int id = idconsulta + 1;
      idconsulta = idconsulta + 1;
      return id;  
    }
 } 
}