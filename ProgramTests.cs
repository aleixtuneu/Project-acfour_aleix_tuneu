using Microsoft.VisualStudio.TestTools.UnitTesting;
using acfour_aleix_tuneu;

namespace acfour_aleix_tuneu.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void SortDescendent_ShouldSortCorrectly()
        {
            // Arrange
            int[] input = { 5, 2, 8, 3, 1 };
            int[] expected = { 8, 5, 3, 2, 1 };

            // Act
            int[] result = Program.SortDescendent(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortDescendent_ShouldHandleSingleElement()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            int[] result = Program.SortDescendent(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortDescendent_ShouldHandleEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            // Act
            int[] result = Program.SortDescendent(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SortDescendent_ShouldHandleAlreadySortedArray()
        {
            // Arrange
            int[] input = { 10, 8, 6, 4, 2 };
            int[] expected = { 10, 8, 6, 4, 2 };

            // Act
            int[] result = Program.SortDescendent(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}