namespace Meridian.MeaningfulToString.Tests
{
    using Meridian.MeaningfulToString.Tests.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MeaningfulBaseTests
    {
        [TestMethod]
        public void ToString_ProduceMeaningfulToString_EnsureOutputIsCorrect()
        {
            // Arrange
            Employee joe = new Employee()
            {
                Id = 13298278,
                Title = "Managing Director",
                FirstName = "Joe",
                LastName = "Bloggs",
                Emails = new string[]
                {
                    "joe.bloggs@somecorp.local",
                    "joeb1281@hotmail.co.uk"
                },
                Manager = null,
            };

            Employee fred = new Employee()
            {
                Id = 13298279,
                Title = "Head of Sales",
                FirstName = "Fred",
                LastName = "Smith",
                Emails = new string[] {
                    "fred.smith@somecorp.local"
                },
                Manager = joe,
            };

            string expectedToStringValue =
                "Employee (" +
                "Id = 13298279, " +
                "Title = Head of Sales, " +
                "FirstName = Fred, " +
                "LastName = Smith, " +
                "Emails = System.String[], " +
                "Manager = " +
                    "Employee (" +
                    "Id = 13298278, " +
                    "Title = Managing Director, " +
                    "FirstName = Joe, " +
                    "LastName = Bloggs, " +
                    "Emails = System.String[], " +
                    "Manager = null" +
                    ")" +
                ")";
            string actualToStringValue = null;

            // Act
            actualToStringValue = fred.ToString();

            // Assert
            Assert.AreEqual(expectedToStringValue, actualToStringValue);
        }

        [TestMethod]
        public void ToString_RunToStringOnInheritedType_InheritedTypeIncludesBaseProperties()
        {
            // Arrange
            Employee joe = new Employee()
            {
                Id = 13298278,
                Title = "Managing Director",
                FirstName = "Joe",
                LastName = "Bloggs",
                Emails = new string[]
                {
                    "joe.bloggs@somecorp.local",
                    "joeb1281@hotmail.co.uk"
                },
                Manager = null,
            };

            SoftwareDeveloper phillip = new SoftwareDeveloper()
            {
                Id = 13298329,
                Title = "Senior Software Developer",
                FirstName = "Phillip",
                LastName = "Jeffries",
                Emails = new string[] {
                    "phillip.jeffries@somecorp.local"
                },
                Manager = joe,
                Speciality = SoftwareDeveloper.SpecialityOption.Java,
            };
            string expectedToStringValue =
                "SoftwareDeveloper (" +
                "Speciality = Java, " +
                "Id = 13298329, " +
                "Title = Senior Software Developer, " +
                "FirstName = Phillip, " +
                "LastName = Jeffries, " +
                "Emails = System.String[], " +
                "Manager = " +
                    "Employee (" +
                    "Id = 13298278, " +
                    "Title = Managing Director, " +
                    "FirstName = Joe, " +
                    "LastName = Bloggs, " +
                    "Emails = System.String[], " +
                    "Manager = null" +
                    ")" +
                ")";
            string actualToStringValue = null;

            // Act
            actualToStringValue = phillip.ToString();

            // Assert
            Assert.AreEqual(expectedToStringValue, actualToStringValue);
        }
    }
}