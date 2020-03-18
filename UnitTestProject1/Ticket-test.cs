using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using exersice2_1;

namespace UnitTestProject1
{
    [TestClass]
    public class Ticket_test
    {
        [TestMethod]
        public void ComputeTicketsConst()
        {
            CinemaTicket CT = new CinemaTicket(5);
            CT.Ages.Add(4); CT.Ages.Add(19); CT.Ages.Add(50); CT.Ages.Add(69); CT.Ages.Add(101);
            Assert.AreEqual(290, CT.TotalPrice());

        }
        [TestMethod]
        public void TenTimesTextTest()
        {
            RepeatTen RT = new RepeatTen("ASD");
            Assert.AreEqual("1.ASD, 2.ASD, 3.ASD, 4.ASD, 5.ASD, 6.ASD, 7.ASD, 8.ASD, 9.ASD, 10.ASD", RT.TenTimesText);

        }
        [TestMethod]
        public void ThirdWordTest()
        {
            string text1 = "aa   bb   cc dd ee";
            string text2 = "aa  bb  ";
            ThirdWord TD1 = new ThirdWord(text1);
            ThirdWord TD2 = new ThirdWord(text2);
            Assert.AreEqual("cc", TD1.ThirdwordF(text1));
            Assert.AreEqual("Enter Three words to Run this program", TD2.ThirdwordF(text2));

        }
    }
}
