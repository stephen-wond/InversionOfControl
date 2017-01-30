using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IoC;
using Moq;

namespace IoCUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var mockRepo = new Mock<IPrintWords>();
            mockRepo.Setup(x => x.Alphabet()).Returns("TESTMETHOD TESTMETHOD TESTMETHOD");
            mockRepo.Setup(x => x.Repeater("test")).Returns("TESTMETHOD TESTMETHOD TESTMETHOD");

            //act
            var newPrintingService = new PrintingService(mockRepo.Object);
            var dataAlphabet = newPrintingService.Alphabet();
            var dataRepeater = newPrintingService.Repeater("test");

            //assert
            Assert.AreEqual(dataAlphabet, "TESTMETHOD TESTMETHOD TESTMETHOD");
            Assert.AreEqual(dataRepeater, "TESTMETHOD TESTMETHOD TESTMETHOD");
        }
    }
}
