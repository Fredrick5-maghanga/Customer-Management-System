using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Acme.CommonTest
{
    
        [TestClass]
        public class StringHandlerTest
        {
            [TestMethod]
            public void InsertSpacesTestValid()
            {
                // Arrange
                var source = "SoicScrewDriver";
                var expected = "Soic Screw Driver";
                //var handler = new StringHandler();

            //Act
            var actual = source.InsertSpaces();
            

                //Assert

                Assert.AreEqual(expected, actual);
            }
        [TestMethod]
        public void InsertSpacesTestWithExistingSpaceInvali() { }
    }
    }

