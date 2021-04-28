using System;
namespace Library
{
 public class IdConsulta
 {
    private int idconsulta = 0;
    public int Idconsulta
    {
        get
        {
            return this.idconsulta;
        }
    }
    public int GeneradorNumero()
    {
      int id = Idconsulta + 1;
      idconsulta = id;
      return id;  
    }
 } 
}