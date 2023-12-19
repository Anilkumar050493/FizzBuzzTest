using FirstMVCWebapp.Services;
using NUnit.Framework;
namespace FistMVCWebapp.nUnitTests
{
    public class FizzBuzzServiceTests
    {
        private FizzBuzzService _service { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _service = new FizzBuzzService();
        }
        [Test]
        public void GetResult_Returns_FizzBuzz_For_Multiple_Of_3_And_5()
        {
            // Arrange
            int number = 15;

            // Act
            string result = _service.GetResult(number.ToString());

            // Assert
            Assert.AreEqual(FizzBuzzmodel.Fizz_buzz, result);
        }

        [Test]

        public void GetResult_Returns_Fizz_For_Multiple_Of_3()
        {
            // Arrange
            int number = 9;

            // Act
            string result = _service.GetResult(number.ToString());

            // Assert
            Assert.AreEqual(FizzBuzzmodel.fizz_, result);
        }

        [Test]
        public void GetResult_Returns_Buzz_For_Multiple_Of_5()
        {
            // Arrange
            int number = 10;

            // Act
            string result = _service.GetResult(number.ToString());

            // Assert
            Assert.AreEqual(FizzBuzzmodel.buzz_, result);
        }
     


        [Test]
        public void GetResult_Returns_Divided_By_3_And_5_For_Non_Multiple_Of_3_And_5()
        {
            // Arrange
            int number = 7;

            // Act
            string result = _service.GetResult(number.ToString());

            // Assert
            Assert.AreEqual(string.Format(FizzBuzzmodel.Dividebynum,number), result);
        }
        [Test]
        public void GetResult_InputIsNonIntegerValue_ReturnsFormattedString()
        {
            // Arrange
            double input = 10.5;

            // Act
            string result = _service.GetResult(input.ToString());

            // Assert
            Assert.AreEqual(FizzBuzzmodel.InvalItem, result);
        }
        [Test]
        public void GetResult_InvalidInput_ReturnsInvalidItem()
        {
            // Arrange

            string valu = "abc";
            // Act
            var result = _service.GetResult(valu);

            // Assert
            Assert.AreEqual(FizzBuzzmodel.InvalItem, result);
        }


    }
}