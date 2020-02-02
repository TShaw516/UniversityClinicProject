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
            var newDoctor = new Doctor();
            var DocPatient = new Patient();

            //Act
            DocPatient.BloodLevel = 0;
            //DocPatient.DrawBlood();

            //Assert


        }
    }
}
