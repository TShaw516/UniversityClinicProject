using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Nurse : Employee

    {
        //new object
        Patient nursePatient = new Patient();

        //Properties
        int NumOfPatients { get; set; }
       
        //Constructor
        public Nurse() : base()
        {
        
        }

        public Nurse(string name, int iDNumber, int numOfPatients) : base(name, iDNumber)
        {
            NumOfPatients = numOfPatients;
            Salary = 50000;
            Name = name;
            IDNumber = iDNumber;
            Paid = false;
        }

        //Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"\n2. {Name} ID Number: {IDNumber} Salary: {Salary} # of Patients:{NumOfPatients}");
        }
        
        public override void DrawBlood(Patient newPatient)
        {
            nursePatient.BloodLevel -= 1;
            Console.WriteLine($"Nurse {Name} has successfully drawn blood");
        }


        public override void CareForPatient()
        {
            nursePatient.HealthStatus += 1;
            Console.WriteLine($"{Name} has successfully cared for the patient");
        }

        public override void PaySalary()
        {
            if (Paid == false)
            { Console.WriteLine($"Nurse {Name} has been paid");
                Paid = true;
            }
            else
            {Console.WriteLine($"Nurse {Name} has already been paid");}
        }

    }
}
