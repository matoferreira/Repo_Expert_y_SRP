using System;

namespace Library
{
    public class Doctor
    {
        public string DoctorName { get ; set; }
        public string Especialidad { get ; set; }

        public Doctor(String doctorname, String especialidad)
        {
            this.DoctorName = doctorname;
            this.Especialidad = especialidad;

        }
    }

}
