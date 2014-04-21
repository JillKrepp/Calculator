using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.UnitTest
{
    [TestFixture]
    public class SYParserTests
    {
        [TestCase("1 + 5", "1 5 +")]
        [TestCase("4 - 4 * 5", "4 4 5 * -")]
        [TestCase("5 * 5 + 4 * 4", "5 5 * 4 4 * +")]
        [TestCase("12 / 5", "12 5 /")]
        public void ReturnsRPN(string infix, string expectedpostfix)
        {
            string actualpostfix;
            SYParser syparser = new SYParser();
            syparser.setExpr(infix);
            actualpostfix = syparser.getRPN();
            Assert.AreEqual(expectedpostfix, actualpostfix);
        }
    }
}
