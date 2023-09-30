using _4_SimpleManualStack;

namespace _4_SimpleManualStackTest
{
    public class SimpleManualStackTest
    {
        [Fact]
        public void PushTest()
        {
            // Arrange
            SimpleManualStack simpleManualStack = new();

            // Act
            simpleManualStack.Push(50.545);

            // Assert
            Assert.False(simpleManualStack.IsEmpty());
            Assert.Equal(50.545, simpleManualStack.Peek());
        }

        [Fact]
        public void PopTest() 
        {
            // Arrange
            SimpleManualStack simpleManualStack = new();
            simpleManualStack.Push(50.545);

            // Act
            simpleManualStack.Pop();

            // Assert
            Assert.True(simpleManualStack.IsEmpty());
            Assert.Null(simpleManualStack.Peek());
        }

        [Fact]
        public void PeekTest() 
        {
            // Arrange
            SimpleManualStack simpleManualStack = new();
            simpleManualStack.Push(50.545);

            // Act
            double? peek = simpleManualStack.Peek();

            // Assert
            Assert.Equal(50.545, peek);
        }

        [Fact]
        public void IsEmptyTest() 
        {
            // Arrange
            SimpleManualStack simpleManualStack = new();
            simpleManualStack.Push(50.545);

            // Act
            bool isEmpty = simpleManualStack.IsEmpty();

            // Assert
            Assert.False(isEmpty);
        }
    }
}