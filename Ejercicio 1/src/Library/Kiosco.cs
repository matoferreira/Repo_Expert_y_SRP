using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa; /* Esto no cumple el patrón Expert porque:
            El cálculo lo debería realizar el Alfajor (al calculo final del precio) 
            porque es el experto en la información del valor de los ingredientes del mismo.*/
        }

/* Debería existir una clase de Conversión de moneda ya que:
No cumple con el principio de SRP debido a que Kiosco es responsable tanto de Comprobar si se puede
comprar el producto, como de hacer la conversión de la moneda. Por ende, se debe crear una clase que sea
responsable de hacer la conversión y que colabore con Kiosco. */
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}