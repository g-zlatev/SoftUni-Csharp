using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {

        private Database.Database database;
        private readonly int[] initialData = new int[] { 1, 2 };

        [SetUp]
        public void Setup()
        {
            this.database = new Database.Database(initialData);
        }

        [TestCase (new int[] {1,2,3})]
        [TestCase(new int[] {})]
        public void TestIfConstructorWorksCorrectly(int[] data)
        {
            //var data = new int[] { 1, 2, 3 };
            this.database = new Database.Database(data);

            var expectedCount = data.Length;
            var actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);

        }

        [Test]
        public void ConstructorShouldThrowExceptionWithBiggerCollection()
        {
            var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database = new Database.Database(data);
            });
        }

        [Test]
        public void AddingElementToFullDatabaseShouldThrowException()
        {
            //var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            //this.database = new Database(data);

            for (int i = 3; i <= 16; i++)
            {
                this.database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Add(17);
            });
        }

        [Test]
        public void AddShouldIncreaseCountWhenAddedSuccessfully()
        {
            this.database.Add(3);

            int expectedCount = 3;
            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void CannotRemoveElementsFromEmptyDatabase()
        {
            //this.database = new Database(new int[] { });
            this.database.Remove();
            this.database.Remove();

            Assert.Throws<InvalidOperationException>(() =>
            {
                this.database.Remove();
            });
        }

        [Test]
        public void RemovingFromDatabaseShouldDecreaseCount()
        {
            int expectedCount = 1;

            this.database.Remove();

            int actualCount = this.database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] {})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldReturnCopyOfData(int[] expectedData)
        {
            this.database = new Database.Database(expectedData);

            int[] actualDatabase = this.database.Fetch();

            CollectionAssert.AreEqual(expectedData, actualDatabase);

        }

        //[Test]
        //public void FetchShouldReturnArray()
        //{
        //    var returnedArray = this.database.Fetch();

        //    Assert.IsTrue(returnedArray.GetType().IsArray);
        //}

    }
}