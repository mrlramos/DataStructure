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

        [Fact]
        public void RemoveTest() 
        {
            // Arrange
            SimpleQueue simpleQueue = new SimpleQueue();
            simpleQueue.Insert("John");

            // Act
            simpleQueue.Remove();

            // Assert
            Assert.Equal(0, simpleQueue.ListCount());
        }

        [Fact]
        public void ListAllTest()
        {
            // Arrange
            SimpleQueue simpleQueue = new SimpleQueue();
            simpleQueue.Insert("John");
            simpleQueue.Insert("Pedro");

            // Act
            List<string> allItems = simpleQueue.ListAll();

            // Assert
            Assert.Equal(new List<string> { "John", "Pedro" }, allItems);
        }

        [Fact]
        public void ListCountTest()
        {
            // Arrange
            SimpleQueue simpleQueue = new SimpleQueue();
            simpleQueue.Insert("Marlon");
            simpleQueue.Insert("Lygia");

            // Act
            short count = simpleQueue.ListCount();

            // Assert
            Assert.Equal(2, count); 
        }
    }
}