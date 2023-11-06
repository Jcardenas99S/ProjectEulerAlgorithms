using ProjectEulerAlgorithms.Algorithms;

namespace ProjectEuler.Tests
{
    [TestClass]
    public class AlgorithmsTest
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
            MultiplesOf3and5 sample = new MultiplesOf3and5();

            //Act
            int result = sample.multiplesOf3and5(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [TestMethod]
        public void ProjectEulerAlgorithms_EvenFibonacciNumbers_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {8, 10},
                {10, 10},
                {34, 44},
                {60, 44},
                {1000, 798},
                {100000, 60696},
                {4000000, 4613732},
            };
            EvenFibonacciNumbers sample = new EvenFibonacciNumbers();

            //Act
            long result = sample.FibonacciNumbers(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [DataRow(5)]
        [DataRow(6)]
        [TestMethod]
        public void ProjectEulerAlgorithms_LargestPrimeFactor_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {2, 2},
                {3, 3},
                {5, 5},
                {7, 7},
                {8, 2},
                {13195, 29},
                {600851475143, 6857}
            };
            LargestPrimeFactor sample = new LargestPrimeFactor();

            //Act
            long result = sample.largestPrimeFactor(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void ProjectEulerAlgorithms_LargestPalindromeProduct_ReturnInt(int test)
        {
            //Arrange
            IDictionary<int, int> Numbers = new Dictionary<int, int>()
            {
                {2, 9009},
                {3, 906609},
            };
            LargestPalindromeProduct sample = new LargestPalindromeProduct();

            //Act
            int result = sample.largestPalindromeProduct(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void ProjectEulerAlgorithms_SmallestMultiple_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {5,  60},
                {7,  420},
                {10, 2520},
                {13, 360360},
                {20, 232792560}
            };
            SmallestMultiple sample = new SmallestMultiple();

            //Act
            long result = sample.smallestMultiple(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void ProjectEulerAlgorithms_SumSquareDiference_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {10,  2640},
                {20,  41230},
                {100, 25164150}
            };
            SumSquareDifference sample = new SumSquareDifference();

            //Act
            long result = sample.sumSquareDifference(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [DataRow(4)]
        [TestMethod]
        public void ProjectEulerAlgorithms_10001stPrime_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {6,  13},
                {10,  29},
                {100, 541},
                {1000, 7919},
                {10001, 104743}
            };
            _10001stPrime sample = new _10001stPrime();

            //Act
            long result = sample.nthPrime(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [TestMethod]
        public void ProjectEulerAlgorithms_LargestProductSeries_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {4,  5832},
                {13,  23514624000}
            };
            LargestProductInSeries sample = new LargestProductInSeries();

            //Act
            long result = sample.largestProductInSeries(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [TestMethod]
        public void ProjectEulerAlgorithms_SpecialPythagoreanTriplet_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {24,   480},
                {120,  49920},
                {1000, 31875000}
            };
            SpecialPythagoreanTriplet sample = new SpecialPythagoreanTriplet();

            //Act
            long result = sample.specialPythagoreanTriplet(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result) || result.Equals(60000) || result.Equals(55080), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));
           
        }

        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(3)]
        [TestMethod]
        public void ProjectEulerAlgorithms_SummationOfPrimes_ReturnInt(int test)
        {
            //Arrange
            IDictionary<long, long> Numbers = new Dictionary<long, long>()
            {
                {17,   41},
                {2001,  277050},
                {140759, 873608362},
                {2000000, 142913828922}
            };
            SummationOfPrimes sample = new SummationOfPrimes();

            //Act
            long result = sample.primeSumation(Numbers.ElementAt(test).Key);
            //Assert
            Assert.IsTrue(Numbers.ElementAt(test).Value.Equals(result), string.Format($"Expected {Numbers.ElementAt(test).Value}, Actual: {result}"));

        }
    }
}