using NUnit.Framework;

namespace DrawingBook.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DrawingBookTest()
        {
            Assert.AreEqual(Program.pageCount(3, 1), 0);
            Assert.AreEqual(Program.pageCount(3, 2), 0);
            Assert.AreEqual(Program.pageCount(3, 3), 0);

            Assert.AreEqual(Program.pageCount(20, 11), 5);
            Assert.AreEqual(Program.pageCount(20, 12), 4);
            Assert.AreEqual(Program.pageCount(20, 13), 4);
            Assert.AreEqual(Program.pageCount(20, 14), 3);
            Assert.AreEqual(Program.pageCount(20, 15), 3);
            Assert.AreEqual(Program.pageCount(20, 16), 2);
            Assert.AreEqual(Program.pageCount(20, 17), 2);
            Assert.AreEqual(Program.pageCount(20, 18), 1);
            Assert.AreEqual(Program.pageCount(20, 19), 1);
            Assert.AreEqual(Program.pageCount(20, 20), 0);


            // Assert
            Assert.AreEqual(Program.pageCount(19, 10), 4);
            Assert.AreEqual(Program.pageCount(19, 11), 4);
            Assert.AreEqual(Program.pageCount(19, 12), 3);
            Assert.AreEqual(Program.pageCount(19, 13), 3);
            Assert.AreEqual(Program.pageCount(19, 14), 2);
            Assert.AreEqual(Program.pageCount(19, 15), 2);
            Assert.AreEqual(Program.pageCount(19, 16), 1);
            Assert.AreEqual(Program.pageCount(19, 17), 1);
            Assert.AreEqual(Program.pageCount(19, 18), 0);
            Assert.AreEqual(Program.pageCount(19, 19), 0);
        }
    }
}