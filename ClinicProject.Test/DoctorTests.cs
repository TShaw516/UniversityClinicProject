using System;
using UniversityClinicProject;
using Xunit;

namespace ClinicProject.Test
{
    public class DoctorTests
    {

        [Fact]
        public void DoctorName()
        {
            // Arrange
            var newDoctor = new Doctor();

            // Act
            string name = "John Smith";

            // Assert
            Assert.Equal("John Smith", name);
        }

        [Fact]
        public void Doctor_DrawBlood_Reduce_By_2()
        {
            //Arrange
            var myDoctor = new Doctor();
            var newPatient = new Patient();
            var currentBlood = newPatient.BloodLevel;

            //Act
            newPatient.BloodLevel = 20;
            myDoctor.DrawBlood(newPatient);

            //Assert
            Assert.Equal(currentBlood - 2, newPatient.BloodLevel);
        }

        [Fact]
        public void CareForPatient_Health_Goes_Up()
        {
            //Arrange
            var myDoctor = new Doctor();
            var newPatient = new Patient();
            var currentHealth = newPatient.HealthStatus;
            newPatient.HealthStatus = 10;

            // Act
            myDoctor.CareForPatient(newPatient);

            // Assert
            Assert.Equal(currentHealth + 2, newPatient.HealthStatus);
        }