using System;

namespace Library
{
    public class Consultorio
    {
        private string idconsultorio;
        private Boolean isValid = true;
        public bool IsValid 
        {
            get
            {
                return this.isValid;
            }
        }
        public string IdConsultorio
        { 
            get
            {
                return this.idconsultorio;
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