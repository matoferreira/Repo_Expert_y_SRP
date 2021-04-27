using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
       

        
        public Double PrecioAlfajor() {
            
            return PrecioDulce + PrecioMasa;
        }
    }
}