using CMSApp.BL;
namespace CMSApp.BLTest
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void SaveTest()
        {
            //Arrange
            var oI = new OrderItem(22071);
            var expected = true;

            //Act 
            var acual=oI.Save();

            //Assert
            Assert.AreEqual(expected, acual);
            
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var oI = new OrderItem(22071 ,22 ,3199.99m);
            var expected = true;

            //Act
            var acual = oI.Validate();

            //Assert
            Assert.AreEqual(expected , acual);
        }
    }
}
