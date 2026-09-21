using Tyuiu.KonevkaAS.Sprint0.Task2.V0.lib;
namespace Tyuiu.KonevkaAS.Sprint0.Task2.V0.Test
{
    public class Tests
    {
        [SetUp]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Игорь", res);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}