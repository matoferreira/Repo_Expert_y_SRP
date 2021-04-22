using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        ///Falta un método que calcule el precio final del alfajor sumando las variables del precio de sus ingredientes
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}
/* 
No cumple con el patrón de Expert porque la clase Alfajor no es la responsable de calcular el 
precio final del Alfajor. 
Una vez se agregue el método de calcular el precio final, cumplirá con el patrón de Expert y con el
principio de SRP porque su responsabilidad es calcular el precio final y su única razón de cambio es la
variación del precio de los ingredientes.
*/