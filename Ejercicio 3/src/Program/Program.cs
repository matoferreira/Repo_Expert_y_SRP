using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "", "5555-555-555", DateTime.Now, "Queen Street", "");
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = AppointmentService.CreateAppointment("Ralf Manson", "4.394.424-9", "097456123", DateTime.Now, "Queen Street", "Dr. Gonzalez");
            Console.WriteLine(appointmentResult3);
        }
    }
}
