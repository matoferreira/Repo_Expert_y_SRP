﻿using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

/*
Lo que vemos que sucede en este programa es que se realizó toda la instrumentación del mismo
en una sola clase.
Para comenzar a solucionar esto, lo conveniente sería segmentar el procedimiento en las partes que
intervienen en la consulta.
Analizando, podemos observar que existen tres partes que interactuan en la consulta:
1- El paciente que va a consultar
2- El médico que lo atiende
3- El lugar donde se realiza la consulta
Por ende, para cumplir con el patrón SRP, debería existir una clase por cada una de estas partes.
Como dichas partes van a ser las expertas en la información, serán quienes tengan la responsabilidad de
ser los constructores de los objetos y validar los datos.
Existirá una cuarta parte, que será la clase que se encargue de consolidar esta información, consultando
a cada clase sobre la información para generar la Consulta resultante. De esta manera, podemos mantener
nuestras clases encapsuladas.
*/
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("\n");
            Console.WriteLine("Comenzando Coordinación...");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Error: Se requiere nombre de paciente\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Error: Se requiere un número de CI\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Error: Se requiere un celular\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Error: Se requiere un consultorio\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Error: Se requiere un Doctor\n");
                isValid = false;
            }

            if (isValid == true)
            {
                Paciente patient = new Paciente(name, id, phoneNumber);
                Consultorio consult = new Consultorio(appoinmentPlace);
                Doctor doctor = new Doctor(doctorName);
                if (patient.IsValid == true && consult.IsValid == true && doctor.IsValid == true)
                {
                    stringBuilder.Append("Consulta coordinada");
                }
                else
                {
                    stringBuilder.Append("Coordinación fallida");
                    //Console.WriteLine($"paciente = {patient.IsValid} consulta = {consult.IsValid} doctor = {doctor.IsValid}");
                }
            }

            return stringBuilder.ToString();
        }

    }
}
