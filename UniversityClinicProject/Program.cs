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
            string menuChoice = "";//Variable that saves user's choice

            //menu to lead to employee list

            while (inHospital)
            {
                Console.WriteLine("\nUniversity Clinic Hospital:");
                Console.WriteLine("\n1. Employee List:  ");
                Console.WriteLine("2. Exit");
                menuChoice = Console.ReadLine();
                Console.Clear();

                switch (menuChoice)
                {
                    case "1":

                Console.WriteLine("\nClick on an employee to find out more..\n");

                        int counter = 1;
                       
                        foreach (Employee employee in employeeList)
                        { 
                            
                            // print employee info
                            Console.WriteLine($"{counter}.{employee.Name}");
                            counter++;

                        }
                        int userChoice = Convert.ToInt32(Console.ReadLine());
                        _ = employeeList[userChoice - 1];
                        break;

                    case "2":
                        inHospital = false;
                        break;
                }

            }
        }
    }
}
