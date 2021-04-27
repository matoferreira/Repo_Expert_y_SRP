using System;

namespace Library
{
    public class Paciente
    {
        public string pacientname;
        public int edad;
        public int celular;
        public int id; //Para usar este tenemos que importar el IdUtils
        Boolean isValid = true;
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
        public int Id { get ; set; } //Falta usar el IDUtils acá, lo pongo así para poder hacer el commit

        public Paciente(String pacientname, int edad, int celular, int id)
        {
            if (isValid == true)
            {
                this.PacientName = pacientname;
                this.Edad = edad;
                this.Celular = celular;
                this.Id = id;
            }
        }
    }
}


// Falta chequear que funcione la clase y agregar la validación de la cédula de identidad