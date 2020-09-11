using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using Dependency_Injection_Mock_Final;








namespace CTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {    

            var mock = new Mock<ICalculator>();
            mock.Setup(i => i.Calculate(6)).Returns(11);
            Person p1 = new Person(mock.Object, 6);
            int result = p1.PersonCalculate();
            Assert.AreEqual(11, result);

        }
    }
}
