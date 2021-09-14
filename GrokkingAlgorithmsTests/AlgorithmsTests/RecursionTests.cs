using FluentAssertions;
using GrokkingAlgorithms.Algorithms;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

namespace GrokkingAlgorithmsTests.AlgorithmsTests
{
    public class RecursionTests
    {
        [Test]
        public void RecursionSum_ShouldReturnCorrectSum() 
        {
            //Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Act
            int result = Recursion.RecursionSum(arr);

            //Assert
            result.Should().Be(45);
        }

        [Test]
        public void RecursionListCount_ShouldReturnCorrectListElementAmount() 
        {
            //Arrange
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Act
            int result = Recursion.RecursionListCount(list);

            //Assert
            result.Should().Be(list.Count);
        }

        [Test]
        public void RecursionListMaxElement_ShouldReturnCorrectMaxElement()
        {
            //Arrange
            List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };

            //Act
            int result = Recursion.RecursionListMaxElement(list);

            //Assert
            result.Should().Be(9);
        }

        [TestCase(0, 0)]
        [TestCase(4, 4)]
        [TestCase(9, 9)]
        [TestCase(-1, null)]
        [TestCase(10, null)]
        public void RecursionBinarySearch_ShouldReturnCorrectResult(int searchValue, int? expectedValue)
        {
            //Arrange
            int[] testData = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Act
            var result = Recursion.RecursionBinarySearch(testData, searchValue, 0, testData.Length-1);

            //Assert
            result.Should().Be(expectedValue);
        }
    }
}
