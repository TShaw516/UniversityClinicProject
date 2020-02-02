using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Doctor : Employee
    {
        //new object
        Patient newPatient = new Patient();

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
                Name = name;
                IDNumber = iDNumber;
                Paid = false;
        }

        //Methods
        public override void DisplayInfo(int counter)
        {
            Console.WriteLine($"\n1. {Name} ID Number:{IDNumber} Salary:${Salary}, Specialty:{Specialty}");
           
        }

        public override void DrawBlood(Patient newPatient)
        {
            newPatient.BloodLevel -= 2;
            Console.WriteLine($"Dr. {Name} has successfully reduced by {newPatient.BloodLevel}");
        }

        public override void CareForPatient(Patient newPatient)
        {
            newPatient.HealthStatus += 2;
            Console.WriteLine($"Dr. {Name} has successfully cared for the patient");
        }

        public override void PaySalary(Doctor myDoctor)
        {
            if (Paid == false)
            { Console.WriteLine($"Dr. {Name} has been paid");
                Paid = true;
            }
            else
            { Console.WriteLine($"Dr. {Name} has already been paid"); }
        }




    }
}
