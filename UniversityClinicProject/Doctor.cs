using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Doctor : Employee
    {
        //new object
        Patient drPatient = new Patient();

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
        public override void DisplayInfo()
        {
            Console.WriteLine($"Doctor:{Name} ID Number:{IDNumber} Salary:${Salary}, " +
                $"{Paid}, Specialty:{Specialty}");
           
        }

        public override void DrawBlood()
        {
            int bloodDrawn = drPatient.BloodLevel;
            bloodDrawn -= 2;
            Console.WriteLine($"Dr. {Name} has successfully drawn blood!");
        }

        public override void CareForPatient()
        {
            int healthStatus = drPatient.HealthStatus;
            healthStatus += 2;
            Console.WriteLine($"Dr. {Name} has successfully cared for the patient");
        }

        public override void PaySalary()
        {
            if (Paid == false)
            { Console.WriteLine($"Dr. {Name} has been paid"); }
            else
            { Console.WriteLine($"Dr. {Name} has already been paid"); }
        }




    }
}
