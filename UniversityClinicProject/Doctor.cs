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
        public void DisplayDoctorsInfo()
        {
            Doctor newDoctor = new Doctor(Name, IDNumber, "Neurosurgeon");
            Console.WriteLine($"Doctor:{newDoctor.Name} ID Number:{newDoctor.IDNumber} Salary:${newDoctor.Salary}, " +
                $"{newDoctor.Paid}, Specialty:{newDoctor.Specialty}");
           
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
            if (Paid)
            { Console.WriteLine($"Dr. {Name} has been paid"); }
            else
            { Console.WriteLine($"Dr. {Name} has already been paid"); }
        }




    }
}
