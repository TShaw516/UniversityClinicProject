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
            Janitor JanitorOne = new Janitor("Janitor Neil Patricks", 333);
            Patient newPatient = new Patient();
            Doctor DoctorOne = new Doctor("Doctor Turk Monks", 111, "Neurosurgeon");
            Hospital theHospital = new Hospital();

            //adding employees to list
            theHospital.medicalEmployeeList.Add(DoctorOne);
            theHospital.medicalEmployeeList.Add(newNurse);
            theHospital.regularEmployeeList.Add(JanitorOne);
            theHospital.regularEmployeeList.Add(newReceptionist);
            theHospital.patientList.Add(newPatient);

            bool exitHospital = false;
            string employeeTypeSelection;

            //main menu

            do
            {
                newEmployee.MainMenu();
                employeeTypeSelection = Console.ReadLine();

                switch (employeeTypeSelection)
                {
                    case "1":
                        theHospital.ShowAllMedicalEmployeeInfo();
                        ScreenClear();
                        break;

                    case "2":
                        theHospital.ShowAllRegularEmployeeInfo();
                        ScreenClear();
                        break;

                    case "3":
                        exitHospital = true;
                        break;


                }
            } while (exitHospital == false);

           
        }
        static void ScreenClear()
        {
            Console.WriteLine("Press any key to return to the Main Menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}








