using CMSApp.BL;
namespace CMSApp.BLTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void SaveTest()
        {
            //Arrange
            var o = new Order();
            var expected = false;

            //Act
            var actual = o.Save();

            //Assert
            Assert.AreNotEqual(expected, actual);

        }
    
        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var o = new Order();
            o.orderDate = DateTime.Now;
            var expected = true;

            //Act
            var actual = o.Validate();

            //Assert
            Assert.AreEqual(expected, actual);

        }    
    }



}