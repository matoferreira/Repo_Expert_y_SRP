using System;
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
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid == true)
            {
                Paciente patient = new Paciente();
                patient.PacientName = name;
                patient.Id = id;
                patient.Celular = phoneNumber;
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
