using ProjectEulerAlgorithms.Algorithms;
namespace TestEulerproject
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void ProjectEulerAlgorithms_TestMultiplesOf3and5_ReturnInt(int test)
        {
            //Arrange
            IDictionary<int, int> Numbers = new Dictionary<int, int>()
            {
                {49, 543},
                {1000, 233168},
                {8456, 16687353},
                {19564, 89301183}
            };
            MultiplesOf3and5 sampleOne = new MultiplesOf3and5();

            //Act
            int result = sampleOne.multiplesOf3and5(Numbers.ElementAt(test).Key);
            //Assert
            Assert.AreEqual(Numbers.ElementAt(test).Value, result, 0, string.Format($"Expected for {Numbers.ElementAt(test).Value}: true; Actual: {result}"));

        }
    }
}