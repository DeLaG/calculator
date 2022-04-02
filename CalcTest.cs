using NUnit.Framework;
using Calc;
using Moq;

namespace CalcTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalcTest()
        {

            // arrange
            Mock<ICalc> mock = new();

            mock.Setup(x => x.GetResult())
                .Returns(666);

            Calcc kalkulator = new();


            // act
            var result = kalkulator.Add(5, 5);


            // assert
            Assert.AreEqual(666,result);
        }
    }
}
