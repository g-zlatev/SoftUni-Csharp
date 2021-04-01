using ExtendedDatabase;
using NUnit.Framework;
using System;
namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase database;
        private readonly Person[] persons = new Person[] { new Person(1, "1") };

        [SetUp]
        public void Setup()
        {
            this.database = new ExtendedDatabase.ExtendedDatabase(persons);
        }

        [Test]
        public void EmptyConstructorShouldReturnCountZero()
        {
            var newDatabase = new ExtendedDatabase.ExtendedDatabase();

            Assert.AreEqual(0, newDatabase.Count);
        }

        [Test]
        public void DatabaseShouldReturnCorrectCount()
        {
            Assert.AreEqual(1, this.database.Count);
        }

        [Test]
        public void AddingToFullDatabaseShouldThrowException()
        {
            for (int i = 2; i <= 16; i++)
            {
                this.database.Add(new Person(i, $"{i}"));
            }

            Assert.That(
                () => this.database.Add(new Person(17, "17")),

                Throws.Exception.InstanceOf<InvalidOperationException>().With.Message
                    .EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void AddingPersonWithUsernameThatExistShouldThrowException()
        {
            Assert.That(() => this.database.Add(new Person(2, "1")),

                Throws.Exception.InstanceOf<InvalidOperationException>().With.Message
                    .EqualTo("There is already user with this username!"));
        }

        [Test]
        public void AddingPersonWithIdThatExistShouldThrowException()
        {
            Assert.That(() => this.database.Add(new Person(1, "2")),

                Throws.Exception.InstanceOf<InvalidOperationException>().With.Message
                    .EqualTo("There is already user with this Id!"));
        }

        [Test]
        public void RemovingFromEmptyDatabaseShouldThrowException()
        {
            this.database.Remove();

            Assert.That(() => this.database.Remove(), Throws.Exception.InstanceOf<InvalidOperationException>());
        }

        [Test]
        public void RemovingFromDatabaseShouldReturnCorrectCount()
        {
            this.database.Add(new Person(2, "2"));
            this.database.Add(new Person(3, "3"));

            this.database.Remove();

            Assert.AreEqual(2, this.database.Count);
        }

        [Test]
        public void AddingRangeBiggerThanDatabaseCapacityShouldThrowException()
        {
            var personArr = new Person[17];

            Assert.Throws<ArgumentException>(() =>
            {
                var newDatabase = new ExtendedDatabase.ExtendedDatabase(personArr);
            });
        }

        [Test]
        public void SearchingForUserWithEmptyUsernameShouldThrowException()
        {

            Assert.That(() => this.database.FindByUsername(""),
                Throws.Exception.InstanceOf<ArgumentNullException>());
        }

        [Test]
        public void SearchingForUserWithNotExistingUsernameShouldThrowException()
        {

            Assert.That(() => this.database.FindByUsername("Pesho"),
                Throws.Exception.InstanceOf<InvalidOperationException>().With.Message
                    .EqualTo("No user is present by this username!"));
        }

        [Test]
        public void SearchingForUserWithUsernameShouldWorkCorrectly()
        {
            var person = new Person(2, "ivan");
            var otherPerson = new Person(3, "gosho");

            this.database.Add(person);
            this.database.Add(otherPerson);

            var found = this.database.FindByUsername("gosho");

            Assert.AreEqual(otherPerson, found);
        }

        [Test]
        public void WhenSearchingIdShouldBePositiveNumber()
        {
            Assert.That(() => this.database.FindById(-1),
                Throws.Exception.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void SearchingForInvalidIdShouldThrowException()
        {
            Assert.That(() => this.database.FindById(14), Throws.InstanceOf<InvalidOperationException>().With.Message.EqualTo("No user is present by this ID!"));
        }

        [Test]
        public void SearchingByIdShouldReturnCorrectResult()
        {
            var person = new Person(2, "ivan");
            var otherPerson = new Person(3, "gosho");

            this.database.Add(person);
            this.database.Add(otherPerson);

            var found = this.database.FindById(3);

            Assert.AreEqual(otherPerson, found);
        }
    }
}