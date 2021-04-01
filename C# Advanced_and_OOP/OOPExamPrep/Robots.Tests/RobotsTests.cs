using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;

namespace Robots.Tests
{

    public class RobotsTests
    {
        private RobotManager manager;
        private Robot robot;

        [SetUp]
        public void Setup()
        {
            this.robot = new Robot("robby", 100);
            this.manager = new RobotManager(2);

        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            var anotherManager = new RobotManager(2);

            var expectedCapacity = 2;

            Assert.AreEqual(expectedCapacity, anotherManager.Capacity);
        }

        [Test]
        public void InvalidCapacityShouldThrowEx()
        {
            Assert.That(() =>
            { 
                var manager = new RobotManager(-1);
            }, Throws.Exception.InstanceOf<ArgumentException>().With.Message.EqualTo("Invalid capacity!"));

        }

        [Test]
        public void AddingRobotsWithExistingShouldThrowEx()
        {
            manager.Add(robot);
            var newRobot = new Robot("robby", 50);

            Assert.Throws<InvalidOperationException>(() => manager.Add(newRobot));
        }

        [Test]
        public void NotEnoughCalacityWhenAddShouldThrowEx()
        {
            var newRobot = new Robot("roby", 50);
            var yetAnoterRobot = new Robot("moby", 50);

            manager.Add(robot);
            manager.Add(newRobot);

            Assert.Throws<InvalidOperationException>(() => manager.Add(yetAnoterRobot));
        }

        [Test]
        public void AddingShouldWorkProperly()
        {
            var yetAnoterRobot = new Robot("moby", 50);

            manager.Add(robot);
            manager.Add(yetAnoterRobot);

            Assert.AreEqual(2, manager.Count);
        }

        [Test]
        public void Test()
        {

        }

        [Test]
        public void Test1()
        {

        }
    }
}
