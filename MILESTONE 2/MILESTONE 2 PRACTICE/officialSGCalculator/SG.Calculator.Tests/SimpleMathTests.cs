using NUnit.Framework;
using SGCalculator.BLL;

namespace SG.Calculator.Tests
{
    [TestFixture]
    public class SimpleMathTests
    {
        [Test]
        [TestCase(4, 2, 2)]
        [TestCase(12, 3, 4)]
        public void IntegerDivision1(int a, int b, int expected)
        {
            SimpleMath math = new SimpleMath();
            int result = math.Divide(a, b);

            Assert.AreEqual(expected, result);
        }

        public void IntegerAddition()
        {
            SimpleMath math = new SimpleMath();
            int result = math.Add(4, 6);
        }
    }
}
