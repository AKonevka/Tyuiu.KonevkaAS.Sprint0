using Tyuiu.KonevkaAS.Sprint0.Task4.V0.Lib;
using System.Security.Cryptography.X509Certificates;

namespace Tyuiu.KonevkaAS.Sprint0.Task4.V0.Test
{
    public class DataServiceTest
    {
        [Test]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [Test]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [Test]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [Test]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }

        [SetUp]
        public void Setup()
        {
           
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}