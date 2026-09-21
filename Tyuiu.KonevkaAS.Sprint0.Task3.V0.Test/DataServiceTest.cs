using Tyuiu.KonevkaAS.Sprint0.Task3.V0.Lib;
namespace Tyuiu.KonevkaAS.Sprint0.Task3.V0.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void CheckValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}