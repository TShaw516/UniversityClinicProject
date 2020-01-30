using System;
using Xunit;

namespace ClinicProject.Test
{
    public class DoctorTests
    {

        [Fact]
        public void DoctorName()
        {
            // Arrange
           // var newDoctor = new Doctor();

            // Act
            string name = "John Smith";

            // Assert
            Assert.Equal("John Smith", name);
        }
    }
}
