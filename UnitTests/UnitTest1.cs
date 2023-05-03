using Xunit.Sdk;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Osama";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                MergeNames.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}