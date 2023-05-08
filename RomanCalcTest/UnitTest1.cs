using RomanCalculator;

namespace RomanCalcTest
{
    public class RomanCalcTests
    {

        [TestCase("I", "I", "II")]
        [TestCase("I", "II", "III")]
        public void AddShouldReturnRomanSumWhenRomanSummandsGiven(string a, string b, string expected)
        {
            Assert.That(expected, Is.EqualTo(RomanCalculator.RomanCalculator.Add(a, b)));
        }
    }
}