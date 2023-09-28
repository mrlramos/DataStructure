using _2_SimpleManualQueue;

namespace _2_SimpleManualQueueTest
{
    public class SimpleManualQueueTest
    {
        [Fact]
        public void InsertTest()
        {
            // Arrange
            SimpleManualQueue simpleManualQueue = new();

            // Act
            simpleManualQueue.Insert("Marlon");
            simpleManualQueue.Insert("Dax");

            // Assert
            Assert.Equal("Marlon Dax ", simpleManualQueue.ListAll());
            Assert.Equal(2, simpleManualQueue.ListCount());
        }

        [Fact]
        public void RemoveTest()
        {
            // Arrange
            SimpleManualQueue simpleManualQueue = new();
            
            // Act
            simpleManualQueue.Insert("Marlon");
            simpleManualQueue.Remove();

            // Assert
            Assert.Empty(simpleManualQueue.ListAll());
            Assert.Equal(0, simpleManualQueue.ListCount());
        }

        [Fact]
        public void ListAllTest()
        {
            // Arrange
            SimpleManualQueue simpleManualQueue = new();
            simpleManualQueue.Insert("Marlon");

            // Act
            string list = simpleManualQueue.ListAll();

            // Assert
            Assert.Equal("Marlon ", list);
        }

        [Fact]
        public void ListCountTest() 
        {
            // Arrange
            SimpleManualQueue simpleManualQueue = new();
            simpleManualQueue.Insert("Marlon");
            simpleManualQueue.Insert("Diego");

            // Act
            short count = simpleManualQueue.ListCount();

            // Assert
            Assert.Equal(2, count);
        }
    }
}