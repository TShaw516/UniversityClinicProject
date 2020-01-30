using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Doctor : Employee
    {
        

        //Properties
        public string Specialty { get; set; }

        //Constructors
        public Doctor() : base()
        {

        }

        public Doctor (string name, int iDNumber, string specialty) : base (name, iDNumber)

        { 
                Specialty = specialty;
                Salary = 90000;
            Name = "Turk";
            IDNumber = 111;
            bool paid = false;
        }

        //Methods
        public void DisplayDoctorsInfo()
        {
            Doctor newDoctor = new Doctor(Name, IDNumber, true, "Neurosurgeon");
            Console.WriteLine($"Doctor:{newDoctor.Name} ID Number:{newDoctor.IDNumber} Salary:${newDoctor.Salary}, " +
                $"{newDoctor.Paid}, Specialty:{newDoctor.Specialty}");
           
        }



      
    }
}
