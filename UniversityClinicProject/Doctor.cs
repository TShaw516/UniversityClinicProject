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

        public Doctor (string name, int iDNumber, bool paid, string specialty) : base (name,iDNumber,paid)
        { 
                Specialty = specialty;
                Salary = 90000;
                
        }

        //Methods
        public void DisplayDoctorsInfo()
        {
            Doctor newDoctor = new Doctor("Turk", 111, true, "Neurosurgeon");
            Console.WriteLine($"Doctor:{newDoctor.Name}, ID Number:{newDoctor.IDNumber}, Salary:${newDoctor.Salary}, " +
                $"{newDoctor.Paid}, Specialty:{newDoctor.Specialty}");
           
            /*string doctor = "Turk";
            int idNumber = 111;

            Name = doctor;
            IDNumber = idNumber;
          Console.WriteLine($"Doctor: {doctor} ID Number:{idNumber} ");
            */
        }



      
    }
}
