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
            theHospital.patientList.Add(newPatient);

            bool exitHospital = false;
            string chooseEmployeeType;
            string medEmployeeChoice;
            string regularEmployeeActionSelection;

            //main menu

            do
            {
                newEmployee.MainMenu();
                chooseEmployeeType = Console.ReadLine();
                
                switch(chooseEmployeeType)
                {   
                    case "1":
                        theHospital.ShowAllMedicalEmployeeInfo();
                        medEmployeeChoice = Console.ReadLine();
                        newEmployee.MedicalEmployeeMenu();
                        string medEmployeeAction = Console.ReadLine();
                        ScreenClear();

                    switch (medEmployeeAction)
                        {
                            case "1":
                            if (newEmployee == newNurse)
                                {
                                    newNurse.DrawBlood(newPatient);
                                }
                                else 
                                {
                                    newDoctor.DrawBlood(newPatient);
                                }
                                break;
                            
                            case "2":
                                if (newEmployee == newNurse)
                                {
                                    newNurse.CareForPatient(newPatient);
                                }
                                else
                                {
                                    newDoctor.CareForPatient(newPatient);
                                }
                                break;
                            
                            case "3":
                                newEmployee.PaySalary();
                                break;
                                
                                    
                        }
                        break;

                    case "2":
                        theHospital.ShowAllRegularEmployeeInfo();
                        regularEmployeeActionSelection = Console.ReadLine();
                        newEmployee.RegularEmployeeMenu();
                        ScreenClear();
                        

                        switch (regularEmployeeActionSelection)
                        {   
                            case "1":
                            break;
                            case "2":
                            break;
                            case "3":
                            break;
                        }
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












              