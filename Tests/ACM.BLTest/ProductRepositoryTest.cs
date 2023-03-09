using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()

        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            { 
                CurrentPrice= 15.98M,
                ProductDescription = "Assorted Size of 4 Bright yellow mini sunflowers",
                ProductName = "Sunflowers"
            };
               


            //--Act
            var actual = productRepository.Retrieve(2);

            //--Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
        [TestMethod]
        //--Arrange
        public void SaveTestValid() 
        { 
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice= 18m,
                ProductDescription= "Assorted size set of 4 bright yellow mini sunflowers",
                ProductName = "sunflowers",
                HasChanges = true
            };
            //--Act
            var actual = productRepository.Save(updatedProduct);

            //--Assert
            Assert.AreEqual(true, actual);

        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //--Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice= null,
                ProductDescription= "Assorted size set of 4 bright yellow mini sunflowers",
                ProductName="sunflowers",
                HasChanges = true
            };
            //--Act
            var actual = productRepository.Save(updatedProduct);

            //-Assert
            Assert.AreEqual(false, actual);

        }
       
    }

}
    
                    
   

