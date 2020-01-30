using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Nurse : Employee

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
        public void DisplayNurseInfo()
        {
            Nurse newNurse = new Nurse(Name, IDNumber, NumOfPatients);
            Console.WriteLine($"Nurse:{newNurse.Name} ID Number:{newNurse.IDNumber} Salary:${newNurse.Salary} " +
                $"# of Patients:{newNurse.NumOfPatients},{newNurse.Paid}");
        }

    }
}
