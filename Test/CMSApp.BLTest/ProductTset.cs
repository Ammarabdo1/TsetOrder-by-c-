using CMSApp.BL;
namespace CMSApp.BLTest
{
    [TestClass]
    public class ProductTset
    {
        [TestMethod]
        public void SaveTest()
        {
            //arrange
            var p = new Product(22071);
            var expected = true;

            //Act
            var acual = p.Save();

            //Assert
            Assert.AreEqual(expected, acual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var p = new Product { CurrentPrice = 29.99m, ProductName = "TV" };
            var expected = true;

            //Act
            var actual = p .Validate();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
