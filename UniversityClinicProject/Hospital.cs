using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Hospital
    {
        public List<Employee> medicalEmployeeList = new List<Employee>();
        public List<Employee> regularEmployeeList = new List<Employee>();
        public List<Patient> patientList = new List<Patient>();

        public Hospital()
        {

        }

        public void AddDoctorToMedicalEmployee(Doctor myDoctor)
        {
            medicalEmployeeList.Add(myDoctor);
        }

        public void AddNurseToMedicalEmployee(Nurse myNurse)
        {
            medicalEmployeeList.Add(myNurse);
        }

        public void AddPatientToPatientList(Patient newPatient)
        {
            patientList.Add(newPatient);
        }

        public void AddReceptionistToHospital(Receptionist myReceptionist)
        {
            regularEmployeeList.Add(myReceptionist);
        }

        public void AddJanitorToHospital(Janitor myJanitor)
        {
            regularEmployeeList.Add(myJanitor);
        }

        public Employee SelectEmployee()
        {
            int employeeChoice = Convert.ToInt32(Console.ReadLine());
            Employee chosenEmployee = employeeList[employeeChoice - 1];
            Console.Clear();
        }


    }
}
