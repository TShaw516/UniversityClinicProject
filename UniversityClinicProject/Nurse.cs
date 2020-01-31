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
            Console.WriteLine($"Nurse:{Name} ID Number:{IDNumber} Salary:${Salary} # of Patients:{NumOfPatients},{Paid}");
        }
        
        public override void DrawBlood()
        {
            int bloodDrawn = nursePatient.BloodLevel;
            bloodDrawn -= 1;
            Console.WriteLine($"Nurse {Name} has successfully drawn blood");
        }

        public override void CareForPatient()
        {
            int healthStatus = nursePatient.HealthStatus;
            healthStatus += 1;
            Console.WriteLine($"Nurse {Name} has successfully cared for the patient");
        }

        public override void PaySalary()
        {
            if (Paid == false)
            { Console.WriteLine($"Nurse {Name} has been paid"); }
            else
            {Console.WriteLine($"Nurse {Name} has already been paid");}
        }

    }
}
