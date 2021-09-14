using FluentAssertions;
using GrokkingAlgorithms.Algorithms;
using NUnit.Framework;

namespace GrokkingAlgorithmsTests.AlgorithmsTests
{
    public class BinarySearchTests
    {
        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(9, 9)]
        [TestCase(-1, null)]
        [TestCase(10, null)]
        public void BinarySearch_ShouldReturnCorrectResult(int searchValue, int? expectedValue)
        {
            //Arrange
            int[] testData = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Act
            var result = BinarySearch.Run(testData, searchValue);

            //Assert
            result.Should().Be(expectedValue);
        }
    }
}
