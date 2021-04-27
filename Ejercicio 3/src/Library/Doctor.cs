using System;

namespace Library
{
    
    public class Doctor
    {
        private string doctorname;
        private string especialidad = "Desconocida";

        private Boolean isValid = true;
        public bool IsValid 
        {
            get
            {
                return this.isValid;
            }
        }
        public string DoctorName
        { 
            get
            {
                return this.doctorname;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.doctorname = value;
                }
                else
                {
                    Console.WriteLine("El nombre que ingresó no es válido, por favor intente de nuevo");
                    isValid = false;
                }
            }
        }
        public string Especialidad 
        { 
            get
            {
                return this.especialidad;
            } 
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.especialidad = value;
                }
                else
                {
                    Console.WriteLine("La especialidad que ingresó no es válida, por favor intente de nuevo");
                }
            }
        }

        public Doctor(String doctorname)
        {
            if (isValid == true)
            {
                this.DoctorName = doctorname;
            }
            else
            {
                Console.WriteLine("No se pudo agregar el médico, por favor verifique e intente nuevamente");
            }
        }
    }

}
