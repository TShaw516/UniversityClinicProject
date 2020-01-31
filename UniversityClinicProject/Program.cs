using System;
using System.Collections.Generic;

namespace UniversityClinicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new list
            List<Employee> employeeList = new List<Employee>();

            //new objects/classes
            Employee newEmployee = new Employee();

            Nurse newNurse = new Nurse("Nurse: Carla Riley", 222, 1);
            Receptionist newReceptionist = new Receptionist("Receptionist: Jane Reynolds", 444);
            Janitor newJanitor = new Janitor("Janitor: Neil Patricks", 333);
            Patient newPatient = new Patient();
            Doctor newDoctor = new Doctor("Doctor: Turk Monks", 111, "Neurosurgeon");

            //adding employees to list
            employeeList.Add(newDoctor);
            employeeList.Add(newNurse);
            employeeList.Add(newJanitor);
            employeeList.Add(newReceptionist);


            bool inHospital = true; //stays in menu till exit 'bool is false'
            string mainMenuChoice = "";//Variable that saves user's choice

            //menu to lead to employee list

            while (inHospital)
            {
                Console.WriteLine("\nUniversity Clinic Hospital:");
                Console.WriteLine("\n1. Employee List:  ");
                Console.WriteLine("2. Exit");
                mainMenuChoice = Console.ReadLine();
                Console.Clear();

                switch (mainMenuChoice)
                {
                    case "1":



                    case "2":
                        inHospital = false;
                        break;
                }

            }
        }
    }
}
