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
        public override int Salary { get; set; }

        //Constructor
        public Nurse() : base()
        {
        
        }

        public Nurse(string name, int idNumber, bool paid, int numOfPatients) : base(name, idNumber, paid)
        {
            NumOfPatients = numOfPatients;
            Salary = 50000;

        }

        //Methods
        public void DisplayNurseInfo()
        {
            Nurse newNurse = new Nurse("Carla", 222, true, 1);
            Console.WriteLine($"Nurse:{newNurse.Name} ID Number:{newNurse.IDNumber} Salary:${newNurse.Salary} " +
                $"# of Patients:{newNurse.NumOfPatients},{newNurse.Paid}");
        }

    }
}
