using NUnit.Framework;
using System.Linq;

namespace Computers.Tests
{
    [TestFixture]
    public class ComputerManagerTests
    {
        private ComputerManager manager;
        private Computer computer;

        [SetUp]
        public void Setup()
        {
            computer = new Computer("dell", "model1", 100);
            manager = new ComputerManager();
        }

        [Test]
        public void AddShouldWorkCorrectly()
        {
            manager.AddComputer(computer);

            Assert.AreEqual(1, manager.Count);
        }

        [Test]
        public void AddExistingCompThrowExep()
        {
            manager.AddComputer(computer);
            Assert.Throws<ArgumentException>(() => manager.AddComputer(computer));
        }

        [Test]
        public void AddingValidationWorksCorrectly()
        {
            Assert.Throws<ArgumentNullException>(() => manager.AddComputer(null));
        }

        [Test]
        public void ValidateRemove()
        {
            this.manager.AddComputer(computer);
            this.manager.AddComputer(new Computer("hp", "model2", 50));

            this.manager.RemoveComputer("hp", "model2");

            Assert.AreEqual(1, manager.Count);
        }

        [Test]
        public void GetCoputerValidateManufacurerException()
        {
            this.manager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => this.manager.GetComputer("", ""));
        }

        [Test]
        public void ValidateGetComputer()
        {
            this.manager.AddComputer(computer);
            this.manager.AddComputer(new Computer("hp", "model2", 50));

            var computerGot = this.manager.GetComputer("dell", "model1");

            Assert.AreEqual(computer, computerGot);
        }

        [Test]
        public void ValidateGetCompByManufacturer()
        {
            this.manager.AddComputer(computer);

            var compList = this.manager.GetComputersByManufacturer("dell");

            Assert.AreEqual(1, compList.Count);
        }

        //[Test]
        //public void ValidateGetCompByManufacturerReturnsCorreclty()
        //{
        //    this.manager.AddComputer(computer);
        //    var compList = this.manager.GetComputersByManufacturer("dell");

        //    Assert.AreEqual(true, compList.Any(x => x.Manufacturer == "dell"));
        //}

    }
}