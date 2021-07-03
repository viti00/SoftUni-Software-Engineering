
using NUnit.Framework;
using System.Linq;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private Person person;
        private ExtendedDatabase extended;
        [SetUp]
        public void Setup()
        {
            person = new Person(213, "Pesho");
            extended = new ExtendedDatabase();
        }

        [Test]
        public void When_InicialezedPerson_IdShoudBeCorreclySet()
        {
            long id = 213;
            Assert.AreEqual(person.Id, id);
        }
        [Test]
        public void When_InicialezedPeson_UsernameShoudBeCorrectlySet()
        {
            string username = "Pesho";

            Assert.AreEqual(person.UserName, username);
        }

        [Test]
        public void Add_ThrowExeption_WhenCapacityIsExceeded()
        {
            extended = new ExtendedDatabase();
            for (int i = 0; i < 16; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => extended.Add(new Person(17, "Gogi17")));
        }
        [Test]
        public void Add_ThrwoExeption_WhenNameIsInSequence()
        {
            extended = new ExtendedDatabase();
            for (int i = 0; i < 3; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => extended.Add(new Person(4, "Gogi1")));
        }
        [Test]
        public void Add_ThrowExeption_WhenIdIsInSequence()
        {
            extended = new ExtendedDatabase();
            for (int i = 0; i < 3; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => extended.Add(new Person(1, "Gogi4")));
        }
        [Test]
        public void Add_CountShoudBeIncrease()
        {
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Assert.AreEqual(extended.Count, n);
        }
        [Test]
        public void Add_AddedPerson_ShoudBeOnLastPosiont()
        {
            Person lastPerson = new Person(5, "Gogi5");
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }
            extended.Add(new Person(5, "Gogi5"));
            Person lastPersonAdded = extended.FindById(n);

            Assert.AreEqual(lastPerson.Id, lastPersonAdded.Id);
        }
        [Test]
        public void FindByUsername_ShoudThrowExeption_WhenGivenNameIsEmptyOrNull()
        {
            string name = string.Empty;
            Assert.Throws<ArgumentNullException>(() => extended.FindByUsername(name));
        }
        [Test]
        public void FindByUsername_ShoudThrowExeption_WhenGivenNameIsNotInSequence()
        {
            string name = "Pesho";
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => extended.FindByUsername(name));
        }
        [Test]
        public void FindByUsename_ShoudReturnPerson()
        {
            Person person = new Person(1, "Gogi1");
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Person findedPerson = extended.FindByUsername(person.UserName);

            Assert.AreEqual(person.UserName, findedPerson.UserName);
        }
        [Test]
        public void FindById_ShoudThrowExeption_WhenIdIsNegative()
        {
            long id = -123;

            Assert.Throws<ArgumentOutOfRangeException>(() => extended.FindById(id));
        }
        [Test]
        public void FindById_ShoudThrowExeption_WhenIdIsNotInSequence()
        {
            long id = 245;
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Assert.Throws<InvalidOperationException>(() => extended.FindById(id));
        }
        [Test]
        public void FindById_ShoudReturnPerson()
        {
            Person person = new Person(1, "Gogi1");
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }

            Person findedPerson = extended.FindById(person.Id);

            Assert.AreEqual(person.Id, findedPerson.Id);
        }
        [Test]
        public void Remove_ThrowExeption_WhenNotElementInSequence()
        {
            Assert.Throws<InvalidOperationException>(() => extended.Remove());
        }
        [Test]
        public void Remove_ShoudDecreaseCount()
        {
            int n = 5;
            extended = new ExtendedDatabase();
            for (int i = 0; i < n; i++)
            {
                extended.Add(new Person(i, $"Gogi{i}"));
            }
            extended.Remove();

            Assert.AreEqual(extended.Count, n - 1);
        }
        [Test]
        public void Ctor_ShoudThrowExeption_WhenCapacityIsExceeded()
        {
            Person[] persons = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                persons[i] = new Person(i, $"Gogi{i}");
            }

            for (int i = 0; i < persons.Length; i++)
            {
                extended.Add(persons[i]);
            }

            Assert.Throws<InvalidOperationException>(() => extended.Add(new Person(17, "Gogi17")));
        }
        [Test]
        public void Ctor_ShooudBeReturnZeroCount_WhenSequenceIsEmpty()
        {
            Assert.That(extended.Count, Is.EqualTo(0));
        }
    }
}