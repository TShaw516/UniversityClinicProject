using System;
using System.Collections.Generic;

namespace UniversityClinicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //new objects/classes
            Employee newEmployee = new Employee();
            Nurse newNurse = new Nurse("Nurse Carla Riley", 222, 1);
            Receptionist newReceptionist = new Receptionist("Receptionist Jane Reynolds", 444);
            Janitor newJanitor = new Janitor("Janitor Neil Patricks", 333);
            Patient newPatient = new Patient();
            Doctor newDoctor = new Doctor("Doctor Turk Monks", 111, "Neurosurgeon");
            Hospital theHospital = new Hospital();

            //adding employees to list
            theHospital.medicalEmployeeList.Add(newDoctor);
            theHospital.medicalEmployeeList.Add(newNurse);
            theHospital.regularEmployeeList.Add(newJanitor);
            theHospital.regularEmployeeList.Add(newReceptionist);

            bool inHospital = true; //stays in menu till exit 'bool is false'
            string mainMenuChoice = "";

           //main menu

            while (inHospital)
            {
                newEmployee.MainMenu();

                switch (mainMenuChoice)
                {
                    case "1":
                        newEmployee.DisplayEmployees();
                        newEmployee.SelectEmployee(newPatient);
                        break;


                    case "2":
                        inHospital = false;
                        break;

                    default:
                        break;
                }

            }
        }
    }
}
