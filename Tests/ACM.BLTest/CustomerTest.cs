using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--arrage 
            BL.Customer customer = new BL.Customer { FirstName = "Bilbo", LastName = "Baggins" };
            string expected = "Baggins, Bilbo";
            //-- act
            string actual = customer.FullName;
            //--assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--arrage 
            BL.Customer customer = new BL.Customer
            {

                LastName = "Baggins"
            };
            string expected = "Baggins";
            //-- act
            string actual = customer.FullName;
            //--assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--arrage 
            BL.Customer customer = new BL.Customer
            {
                FirstName = "Bilbo"

            };
            string expected = "Bilbo";
            //-- act
            string actual = customer.FullName;
            //--assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //--arrage 
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;
            //-- act

            //--assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            var customer = new BL.Customer
            {
                LastName = "Baggins",
                EmailAddress = "ffff@mm.com"
            };
            bool expected = false;

            //Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateMissingLatName()
        {
            // Arrange
            var customer = new BL.Customer
            {

                EmailAddress = "fff@mm.com"
            };
            bool expected = false;

            //Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
    

