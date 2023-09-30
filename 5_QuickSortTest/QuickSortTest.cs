using _5_QuickSort;

namespace _5_QuickSortTest
{
    public class QuickSortTest
    {
        [Fact]
        public void SortNegativeNumbersTest()
        {
            // Arrange
            QuickSort quickSort = new();
            int[] ints = { -1, -9, -6 };

            // Act
            quickSort.Sort(ref ints, 0, ints.Length - 1);

            // Assert
            Assert.Equal(new int[] { -9, -6, -1 }, ints);
        }

        [Fact]
        public void SortPositiveNumbersTest()
        {
            // Arrange
            QuickSort quickSort = new();
            int[] ints = { 0, 2, 5, 4, 1 };

            // Act
            quickSort.Sort(ref ints, 0, ints.Length - 1);

            // Assert
            Assert.Equal(new int[] { 0, 1, 2, 4, 5 }, ints);
        }
    }
}