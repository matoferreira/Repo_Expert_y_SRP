using System;

namespace Library
{
    public class Paciente
    {
        private string pacientname;
        private int edad = -1;
        private string celular;
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
                if ((edad >= 0) && (edad < 115))
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
        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                if (int.TryParse(value, out int digitos))
                {
                    digitos = (int)Math.Floor(Math.Log10(digitos) + 1);
                    if (digitos == 9)
                    {
                        this.celular = value; //Necesito chequear esto
                    }
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
    }
}


// Falta chequear que funcione la clase