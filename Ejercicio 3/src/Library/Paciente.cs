using System;

namespace Library
{
    public class Paciente
    {
        private string pacientname;
        private int edad;
        private int celular;
        private string id; 
        private Boolean isValid = true;
        public string PacientName
        { 
            get
            {
                return this.pacientname;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    this.pacientname = value;
                }
                else
                {
                    Console.WriteLine("El nombre que ingresó no es válido, por favor intente de nuevo");
                    isValid = false;
                }
            }
        }
        public int Edad
        { 
            get
            {
                return this.edad;
            }
            set
            {
                if ((edad > 0) && (edad < 115))
                {
                    this.edad = value; //Necesito chequear esto
                }
                else
                {
                    Console.WriteLine("La edad que ingresó no es válida, por favor intente de nuevo");
                    isValid = false;
                }
            }
        }
        public int Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                int digitos = (int)Math.Floor(Math.Log10(celular) + 1);
                if (digitos == 9)
                {
                    this.celular = value; //Necesito chequear esto
                }
                else
                {
                    Console.WriteLine("El celular que ingresó no es válido, por favor intente de nuevo");
                    isValid = false;
                }
            }
        }
        public string Id 
        { 
            get
            {
                return this.id;
            } 
            set 
            {
                if (IdUtils.IdIsValid(value))
                {
                    this.id=value;
                }
                else 
                {
                    Console.WriteLine ("La C.I. que ingresó no es válida");
                    isValid = false;
                }
            }
        } 


/*       Creo que hay que eliminar esto
        public Paciente pacient = new Paciente(string pacientname, int edad, int celular, int id);
        {
            get
            {
                if (isValid == true)
                {
                return this.pacient;
                }
                else
                {
                    Console.WriteLine("Error al crear el Paciente");
                }
            }
            set
            {
                this.PacientName = pacientname;
                this.Edad = edad;
                this.Celular = celular;
                this.Id = id;
            }
        }
        */
    }
}


// Falta chequear que funcione la clase y agregar la validación de la cédula de identidad