using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateProject;

namespace TestDate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testWrongDate1()
        {
            Date date = new Date(2000, 2, 31);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testWrongDate2()
        {
            Date date = new Date(-5, 2, 31);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testWrongDate3()
        {
            Date date = new Date(2000, 13, 31);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testValidate1()
        {
            Date._validate(2000, 2, 31);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testValidate2()
        {
            Date._validate(2001, 2, 29);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testValidate3()
        {
            Date._validate(2001, 1, 32); 
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidProgramException))]
        public void testValidate4()
        {
            Date._validate(2000, 4, 31);
        }

        [TestMethod]
        public void testIsLeapYear1()
        {
            Assert.AreEqual(true, Date.isLeapYear(2004));
        }

        [TestMethod]
        public void testIsLeapYear2()
        {
            Assert.AreEqual(true, Date.isLeapYear(400));
        }

        [TestMethod]
        public void testIsLeapYear3()
        {
            Assert.AreEqual(false, Date.isLeapYear(200));
        }

        [TestMethod]
        public void testGetMonthName()
        {
            Date date = new Date(2010, 5, 15);
            Assert.AreEqual("svibanj", date.getMonthName());
        }

        [TestMethod]
        public void testGetNumberOfRemaingDaysInMonth1()
        {
            Date date = new Date(2010, 4, 1);
            Assert.AreEqual(29, date.getNumberOfRemaingDaysInMonth());
        }
        [TestMethod]
        public void testGetNumberOfRemaingDaysInMonth2()
        {
            Date date = new Date(2010, 5, 1);
            Assert.AreEqual(30, date.getNumberOfRemaingDaysInMonth());
        }
        [TestMethod]
        public void testGetNumberOfRemaingDaysInMonth3()
        {
            Date date = new Date(2004, 2, 1);
            Assert.AreEqual(28, date.getNumberOfRemaingDaysInMonth());
        }
        [TestMethod]
        public void testGetNumberOfRemaingDaysInMonth4()
        {
            Date date = new Date(2005, 2, 1);
            Assert.AreEqual(27, date.getNumberOfRemaingDaysInMonth());
        }
    }
}
