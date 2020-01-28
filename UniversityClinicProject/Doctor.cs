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

        //Constructor
        public Doctor (string name, int iDNumber, bool paid, string specialty) : base (name,iDNumber,paid)
        { 
                Specialty = specialty;
                Salary = 90000;
        }

        public Doctor() : base()
        {
            
        }

     

        //Methods

      
    }
}
