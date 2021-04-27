using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public static Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            ConversorDeMoneda c = new ConversorDeMoneda();
            Double pesos = c.ConvertirAPesos(dinero, moneda);
            return pesos>=a.PrecioAlfajor();
        }
       
    }
}