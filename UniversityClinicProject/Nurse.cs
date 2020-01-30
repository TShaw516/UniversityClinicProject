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
            NumOfPatients = 1;
            Salary = 50000;
            Name = "Carla";
            IDNumber = 222;

        }

        //Methods
        public void DisplayNurseInfo()
        {
            Nurse newNurse = new Nurse(Name, IDNumber, true, NumOfPatients);
            Console.WriteLine($"Nurse:{newNurse.Name} ID Number:{newNurse.IDNumber} Salary:${newNurse.Salary} " +
                $"# of Patients:{newNurse.NumOfPatients},{newNurse.Paid}");
        }

    }
}
