using System;
namespace Library
{
 public class IdConsulta
 {
    private string idconsulta;
    private int GeneradorNumero()
    {
        int min = 0000;
        int max = 9999;
        Random num = new Random();
        return num.Next(min,max);
    } //Falta sacar la variable para asignarla a idconsulta
 } 
}