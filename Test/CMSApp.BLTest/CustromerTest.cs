using CMSApp.BL;
namespace CMSApp.BLTest
{
    [TestClass]
    public class CustromerTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            //--> Arrange
            Customer c = new Customer { FirstName = "ammar", _LastName = "abdo"};


            string expected = "ammar, abdo";

            //--> Act
            string actual = c.Name;
            
            //--> Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //Arange
            var c1 = new Customer();
            c1.FirstName = "ammar";
            Customer.InstanceCount += 1;

            var c2 = new Customer() ;
            c2.FirstName = "Yousef";
            Customer.InstanceCount += 1;

            var c3 = new Customer() ;
            c3.FirstName = "Bl7op" ;
            Customer.InstanceCount += 1;

            //Act
            
            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var c = new Customer();
            c._LastName = "ammar ";
            c.FirstName = "abdo";
            c.EmailAddress = "Ammar@gmail.com";

            var expected = true;

            //Act
            var actule = c.Validate();

            //Assert
            Assert.AreEqual (expected, actule);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var c = new Customer();
            c.FirstName = "abdo";
            c.EmailAddress = "Ammar@gmail.com";
            c.Retrive(3);

            var expected = false;

            //Act
            var actule = c.Validate();

            //Assert
            Assert.AreEqual(expected, actule);
        }


    }

}