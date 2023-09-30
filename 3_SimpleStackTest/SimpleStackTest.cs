using _3_SimpleStack;
using Xunit;

namespace _3_SimpleStackTest
{
    public class SimpleStackTest
    {
        [Fact]
        public void PushTest()
        {
            // Arrange
            SimpleStack simpleStack = new();

            // Act
            simpleStack.Push(14);

            // Assert
            Assert.False(simpleStack.IsEmpty());
            Assert.NotNull(simpleStack.Peek());
            Assert.True(simpleStack.Pop());
        }

        [Fact]
        public void PopTest()
        {
            // Arrange
            SimpleStack simpleStack = new();

            // Act
            simpleStack.Push(8.435);
            simpleStack.Pop();

            // Assert
            Assert.True(simpleStack.IsEmpty());
            Assert.Null(simpleStack.Peek());
            Assert.False(simpleStack.Pop());
        }

        [Fact]
        public void PeekTest()
        {
            // Arrange
            SimpleStack simpleStack = new();

            // Act
            simpleStack.Push(8.435);
            double? firstItemStack = simpleStack.Peek();

            // Assert
            Assert.Equal(8.435, firstItemStack);
            Assert.NotNull(simpleStack.Peek());
        }

        [Fact]
        public void IsEmptyTest()
        {
            // Arrange
            SimpleStack simpleStack = new();

            // Act
            simpleStack.Push(45.34);
            simpleStack.Pop();

            // Assert
            Assert.True(simpleStack.IsEmpty());
        }
    }
}