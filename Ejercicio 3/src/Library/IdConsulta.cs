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
      idconsulta = idconsulta + 1;
      return idconsulta;  
    }
 } 
}