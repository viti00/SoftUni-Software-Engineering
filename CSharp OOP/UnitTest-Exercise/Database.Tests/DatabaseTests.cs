using NUnit.Framework;
using System;

using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database();
        }
        [Test]
        public void When_AddAndCapacityIsFull_ShoudThrowExeption()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }
        [Test]
        public void When_AddElement_CapacityShoudBeIncrase()
        {
            int n = 13;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }
            Assert.AreEqual(database.Count, n);
        }
        [Test]
        public void When_AddElement_ShoudBeOnLastPosition()
        {
            int n = 3;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }
            database.Add(n);

            int[] elements = database.Fetch();

            Assert.AreEqual(elements[elements.Length - 1], n);
        }
        [Test]
        public void When_RemoveElementFromEmptyColection_ShoudThrowExeption()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void When_RemoveElement_ShoudDecreaseCount()
        {
            int n = 11;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }

            database.Remove();

            Assert.AreEqual(database.Count, n - 1);
        }
        [Test]
        public void When_RemoveElement_ShoudRemoveFromColection()
        {
            int n = 11;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }

            database.Remove();

            int[] elements = database.Fetch();

            Assert.IsFalse(elements.Contains(10));
        }

        [Test]
        public void Add_AddsElementToDataBase()
        {
            int element = 69;
            database.Add(element);

            int[] elements = database.Fetch();

            Assert.IsTrue(elements.Contains(element));
        }
        [Test]
        public void Fetch_ReturnDatabaseCopyInsteadOfReference()
        {
            int n = 6;
            for (int i = 0; i < n; i++)
            {
                database.Add(i);
            }
            int[] firstCopy = database.Fetch();

            database.Remove();

            int[] secondCopy = database.Fetch();

            Assert.IsFalse(firstCopy == secondCopy);
            
        }

        [Test]
        public void When_DatabaseIsEmpty_ShoudBeReturnZaroCount()
        {
            Assert.That(database.Count, Is.EqualTo(0));
        }
        [Test]
        public void Constructor_ThrowExeption_WhenCapacityIsExceeded()
        {
            Assert.Throws<InvalidOperationException>(() =>
           database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17));
        }

        [Test]
        public void Constructor_AddsElementToDatabase()
        {
            int[] arr = new[] { 1, 2, 3, 4 };

            database = new Database(arr);

            int[] elements = database.Fetch();

            Assert.That(elements, Is.EquivalentTo(arr));
        }
    }
}
