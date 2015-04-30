using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaxScheduler;
using System.IO;
namespace faxSheduleTest
{
    [TestClass]
    public class FaxTest1
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void InvalidAreaCode()
        {
            Fax c = new Fax();
           
            //X11-
           Assert.IsTrue( c.SendFax("211-190-2346",""));
           //X9X-
           Assert.IsTrue(c.SendFax("291-190-2346", ""));
           //37X-
           Assert.IsTrue(c.SendFax("371-190-2346", ""));
           //96X-
           Assert.IsTrue(c.SendFax("961-190-2346", ""));
            
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TooManyDigits()
        {
            Fax c = new Fax();

            //Xnn-nnn-nnnnn
            Assert.IsTrue(c.SendFax("211-190-23467", ""));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NotEnoughDigit()
        {
            Fax c = new Fax();

            //Xnn-nnn-nnn
            Assert.IsTrue(c.SendFax("211-190-234", ""));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void IllegalCharacters()
        {
            Fax c = new Fax();

            //Xn n-nnn-nnn
            Assert.IsTrue(c.SendFax("2 1-190-234", ""));
            //X(char)n-nnn-nnn
            Assert.IsTrue(c.SendFax("2X1-190-234", ""));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void MissingDashes()
        {
            Fax c = new Fax();

            //Xnn-nnnnnnn
            Assert.IsTrue(c.SendFax("211-1902345", ""));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void MultipleDashes()
        {
            Fax c = new Fax();

            //Xnn-nnn-nnn-n
            Assert.IsTrue(c.SendFax("211-190-234-5", ""));
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void NullValue()
        {
            Fax c = new Fax();

            //Null
            Assert.IsTrue(c.SendFax(" ", ""));
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFound()
        {
            Fax c = new Fax();
            Assert.IsTrue(c.SendFax("201-190-2346", @"C:\Users\mukilan\Desktop\new1.txt"));
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException),"Null")]
        public void NullFilename()
        {
            Fax c = new Fax();
            Assert.IsTrue(c.SendFax("201-190-2346", @"C:\Users\mukilan\Desktop\.txt"));
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void InvalidExtension()
        {
            Fax c = new Fax();
            Assert.IsTrue(c.SendFax("201-190-2346", @"C:\Users\mukilan\Desktop\new1.txt"));
        }
    }
}
