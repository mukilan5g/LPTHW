using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace StackTest
{
    [TestClass]
    public class StackTest1
    {
        StackExercise s = new StackExercise();

        [TestMethod]
        public void EmptyCheck()
        {
            s.push("mukilan");
            Assert.AreEqual("mukilan", s.pop());
            Assert.AreEqual("StackEmpty",s.pop());           
        }

        [TestMethod]
        public void topCheck()
        {
            s.push("dinesh");
            Assert.AreEqual("dinesh", s.top());

            s.push("mukilan");
            Assert.AreEqual("mukilan", s.top());
        }
        
        [TestMethod]
        public void emptyPop()
        {
            Assert.AreEqual("StackEmpty",s.pop());
        }

        [TestMethod]
        public void nullCheck()
        {
            s.push("mukilan");
            s.push(null);
            Assert.AreEqual("mukilan", s.pop());
        }

        [TestMethod]
        public void afterExceptionThrown()
        {
            Assert.AreEqual("StackEmpty", s.pop());
            s.push("new");
            Assert.IsNotNull(s.isEmpty());
        }
    }
}
