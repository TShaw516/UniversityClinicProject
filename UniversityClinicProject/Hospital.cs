using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Hospital
    {
        // Properties
        public List<Employee> employeeList = new List<Employee>();
        public List<Employee> medicalEmployeeList = new List<Employee>();
        public List<Employee> regularEmployeeList = new List<Employee>();
        public List<Patient> patientList = new List<Patient>();
      
        //Constructors
        public Hospital()
        {

        }

        //Methods
        public void AddDoctorToMedicalEmployee(Doctor myDoctor)
        {
            employeeList.Add(myDoctor);
            medicalEmployeeList.Add(myDoctor);
        }

        public void AddNurseToMedicalEmployee(Nurse myNurse)
        {
            employeeList.Add(myNurse);
            medicalEmployeeList.Add(myNurse);
        }

        public void AddPatientToPatientList(Patient newPatient)
        {
            patientList.Add(newPatient);
        }

        public void AddReceptionistToHospital(Receptionist myReceptionist)
        {
            employeeList.Add(myReceptionist);
            regularEmployeeList.Add(myReceptionist);
        }

        public void AddJanitorToHospital(Janitor myJanitor)
        {
            employeeList.Add(myJanitor);
            regularEmployeeList.Add(myJanitor);
        }

        public void ShowAllMedicalEmployeeInfo()
        {
            for (int i = 0; i < medicalEmployeeList.Count; i++)
            {
                medicalEmployeeList[i].DisplayInfo();
            }
        }

        public void ShowAllRegularEmployeeInfo()
        {
            for (int i = 0; i < regularEmployeeList.Count; i++)
            {
                regularEmployeeList[i].DisplayInfo();
            }
        }


        public void ListMedicalEmployeeSelection()
        {
            int medicalEmployeeChoice;
            medicalEmployeeChoice = 1;
            Console.WriteLine("Select the employee in order to perform a task: ");

            foreach (Employee newEmployee in medicalEmployeeList)
            {
                Console.WriteLine($"{medicalEmployeeChoice}. {newEmployee.Name} | {newEmployee.IDNumber}");
                medicalEmployeeChoice++;
            }
        }

        public void ListRegularEmployeeSelection()
        {
            int regularEmployeeChoice;
            regularEmployeeChoice = 1;
            Console.WriteLine("Select the employee in order to perform a task: ");

            foreach (Employee newEmployee in regularEmployeeList)
            {
                Console.WriteLine($"{regularEmployeeChoice}. {newEmployee.Name} | {newEmployee.IDNumber}");
                regularEmployeeChoice++;
            }
        }

        public Employee SelectMedicalEmployee()
        {
            int employeeChoice = Convert.ToInt32(Console.ReadLine());
            int chosenEmployee = (employeeChoice - 1);
            return medicalEmployeeList[chosenEmployee];
        }
        public Employee SelectRegularEmployee()
        {
            int employeeChoice = Convert.ToInt32(Console.ReadLine());
            int chosenEmployee = (employeeChoice - 1);
            return regularEmployeeList[chosenEmployee];
        }



    }
}
