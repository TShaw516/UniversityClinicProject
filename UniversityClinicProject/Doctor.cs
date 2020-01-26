using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Doctor : Employee
    {
        Patient doctorsPatient = new Patient();

        //Properties
        public string Specialty { get; set; }
        public override int Salary { get; set; }

        
        //Constructor
        public Doctor (string specialty)
        { 
            {
                Specialty = specialty;
            }
        }

     

        //Methods

      
    }
}
