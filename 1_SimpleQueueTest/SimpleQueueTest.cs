using _1_SimpleQueue;

namespace _1_SimpleQueueTest
{
    public class SimpleQueueTest
    {
        [Fact]
        public void InsertTest()
        {
            // Arrange
            SimpleQueue simpleQueue = new SimpleQueue();

            // Act
            simpleQueue.Insert("John");

            // Assert
            Assert.Equal(1, simpleQueue.ListCount());
        }
    }
}