using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            this.raceEntry = new RaceEntry();
        }

        [Test]
        public void CounterIsZeroByDefault()
        {
            Assert.That(this.raceEntry.Counter, Is.Zero);
        }

        [Test]
        public void CounterIncreasesWhenAddingDriver()
        {
            raceEntry.AddDriver(new UnitDriver("pesho", new UnitCar("model1", 200, 300)));
            raceEntry.AddDriver(new UnitDriver("pesho2", new UnitCar("model2", 300, 500)));
            Assert.AreEqual(2, this.raceEntry.Counter);
        }

        [Test]
        public void AddDriverThrowsExWhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => this.raceEntry.AddDriver(null));
        }

        [Test]
        public void AddDriverThrowsExWhenDriverExists()
        {
            var driverName = "Pesho";
            this.raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("model2", 300, 500)));

            Assert.Throws<InvalidOperationException>(() => this.raceEntry.AddDriver(new UnitDriver(driverName, new UnitCar("model4", 300, 500))));
        }

        [Test]
        public void AddDriverReturnsExpectedResMessage()
        {
            var actualRes = this.raceEntry.AddDriver(new UnitDriver("Pesho", new UnitCar("model2", 300, 500)));
            var expectedRes = "Driver Pesho added in race.";
            Assert.That(expectedRes, Is.EqualTo(actualRes));
        }

        [Test]
        public void CalcAverHorsePowerThrowsExcWhenParticipantsAreLessThanRequired()
        {
            Assert.Throws<InvalidOperationException>(() => this.raceEntry.CalculateAverageHorsePower());

            this.raceEntry.AddDriver(new UnitDriver("Pesho", new UnitCar("model2", 300, 500)));

            Assert.Throws<InvalidOperationException>(() => this.raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CalcAverHorsePowerReturnsExpectedRes()
        {
            double expected = 0;

            for (int i = 0; i < 10; i++)
            {
                var hp = 450 + i;
                expected += hp;
                this.raceEntry.AddDriver(new UnitDriver($"Name-{i}", new UnitCar($"model-{1}", hp, 550)));
            }

            expected /= 10;

            var actual = this.raceEntry.CalculateAverageHorsePower();

            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}