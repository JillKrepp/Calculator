using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Calculator.UnitTest
{
    [TestFixture]
    public class RPNParserTests
    {     
        [TestCase("1 5 +", 6)]
        [TestCase("4 4 5 * -", -16)]
        [TestCase("5 5 * 4 4 * +", 41)]
        [TestCase("12 5 /", 2.4)]
        public void CalculateRPN(string postfix, decimal expectedresult)
        {
            decimal actualresult;
            RPNParser rpnparser = new RPNParser();
            actualresult = rpnparser.CalculateRPN(postfix);
            Assert.AreEqual(expectedresult, actualresult);

        }      
    }
}
