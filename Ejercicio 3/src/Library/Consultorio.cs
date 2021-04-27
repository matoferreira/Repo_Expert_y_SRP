using System;

namespace Library
{
    public class Consultorio
    {
        public string idconsultorio;
        Boolean isValid = true;
        public string IdConsultorio
        { 
            get
            {
                return this.IdConsultorio;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.idconsultorio = value;
                }
                else
                {
                    Console.WriteLine("El consultorio que ingresó no es válido, por favor intente de nuevo");
                    isValid = false;
                }
            }
        }
        public Consultorio(String idconsultorio)
        {
            if (isValid == true)
            {
                this.IdConsultorio = idconsultorio;
            }
            else
            {
                Console.WriteLine("No se pudo designar el consultorio, por favor verifique e intente nuevamente");
            }
        }
    }
}