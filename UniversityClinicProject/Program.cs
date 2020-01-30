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

            Nurse newNurse = new Nurse("Carla", 222, 1);
            Receptionist newReceptionist = new Receptionist("Jane", 444);
            Janitor newJanitor = new Janitor("Neil", 333);
            Patient newPatient = new Patient();
            Doctor newDoctor = new Doctor("Turk", 111, "Neurosurgeon");

            //adding employees to list
            employeeList.Add(newDoctor);
            employeeList.Add(newNurse);
            employeeList.Add(newJanitor);
            employeeList.Add(newReceptionist);


            bool inHospital = true; //stays in menu till exit 'bool is false'
            string menuChoice = "";//Variable that saves user's choice

            //loop for list of employees
            while (inHospital)
            {
                Console.WriteLine("\nUniversity Clinic Hospital:");
                Console.WriteLine("\n1. Employee List:  ");
                Console.WriteLine("\n1. Doctor Turk");
                Console.WriteLine("2. Nurse Carla");
                Console.WriteLine("3. Janitor Neil");
                Console.WriteLine("4. Receptionist Jane");
                Console.WriteLine("5. Exit");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        foreach (Employee empList in employeeList)
                        {
                            // print employee info
                            Console.WriteLine($"{newDoctor.Name} {newNurse.Name} " +
                                $"{newJanitor.Name} {newReceptionist.Name}");
                        }
                          //  newDoctor.DisplayDoctorsInfo();
                        break;

                    case "2":
                        newNurse.DisplayNurseInfo();
                        break;

                    case "3":
                        newJanitor.DisplayJanitorInfo();
                        break;

                    case "4":
                        newReceptionist.DisplayReceptionistInfo();
                        break;

                    case "5":
                        inHospital = false;
                        break;


                }

            }
        }
    }
}
