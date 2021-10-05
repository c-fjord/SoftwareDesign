
using RomanNuerals;
using NUnit.Framework;

namespace TestRomanNuerals
{
    public class TestRomanLiterals
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        [TestCase(27, "XXVII")]
        [TestCase(48, "XLVIII")]
        [TestCase(59, "LIX")]
        [TestCase(93, "XCIII")]
        [TestCase(141, "CXLI")]
        [TestCase(163, "CLXIII")]
        [TestCase(402, "CDII")]
        [TestCase(575, "DLXXV")]
        [TestCase(911, "CMXI")]
        [TestCase(1024, "MXXIV")]
        [TestCase(3000, "MMM")]

        public void TestRomenConversion(int number, string expected)
        {
            var arabic = new Arabic(number);
            Assert.AreEqual(expected, arabic.ToRoman());
        }
    }
}