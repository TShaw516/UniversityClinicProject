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
            theHospital.AddDoctorToMedicalEmployee(newDoctor);
            theHospital.AddNurseToMedicalEmployee(newNurse);
            theHospital.AddJanitorToHospital(newJanitor);
            theHospital.AddReceptionistToHospital(newReceptionist);
            theHospital.patientList.Add(newPatient);

            bool exitHospital = false;
            string chooseEmployeeType;
            

            //main menu

            do
            {
                newEmployee.MainMenu();
                chooseEmployeeType = Console.ReadLine();

                switch (chooseEmployeeType)
                {
                    case "1":
                        theHospital.ShowAllEmployees();
                        ScreenClear();
                        break;
                    
                    case "2":

                        theHospital.ListMedicalEmployeeSelection();
                        newEmployee = theHospital.SelectMedicalEmployee();
                        Console.WriteLine($"You are now interacting with {newEmployee.Name}");
                        newEmployee.MedicalEmployeeMenu();
                        string medEmployeeChoice = Console.ReadLine();

                        switch (medEmployeeChoice)
                        {
                            case "1":

                                newEmployee.DrawBlood(newPatient);
                                break;

                            case "2":
                    
                                newEmployee.CareForPatient(newPatient);
                                break;
                               

                            case "3":
                                newEmployee.PaySalary();
                                break;


                        }
                        break;

                    case "3":
                        theHospital.ListRegularEmployeeSelection();
                        newEmployee = theHospital.SelectRegularEmployee();
                        Console.WriteLine($"You are now interacting with {newEmployee.Name}");
                        newEmployee.RegularEmployeeMenu();
                        string regEmployeeChoice = Console.ReadLine();
                            
                        switch (regEmployeeChoice)
                        {
                            case "1":
                                
                            
                            case "2":
                                break;
                            
                            case "3":
                                newEmployee.PaySalary();
                                break;
                        }
                        break;

                    case "4":
                        exitHospital = true;
                        break;



                }
            } while (exitHospital == false); 


            static void ScreenClear()
            {
                Console.WriteLine("Press any key to return to the Main Menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}    
    
 












              