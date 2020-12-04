namespace Robots.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RobotsTests
    {

        //Constructor
        [Test]
        public void ConstructorShouldWorkProperly()
        {
            RobotManager rm = new RobotManager(20);

            Assert.That(rm.Capacity, Is.EqualTo(20));
            Assert.That(rm.Count, Is.EqualTo(0));
        }

        [Test]
        public void ConstructorShouldReturnExcOnNegativeCapacity()
        {
            Assert.That(() => new RobotManager(-1), Throws.ArgumentException);
        }

        //Add
        [Test]
        public void DuplicatedRobotShouldReturnExc()
        {

            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);

            Assert.That(()=>rm.Add(robot), Throws.InvalidOperationException);
        }

        [Test]
        public void NotEnoughCapacityShouldReturnExc()
        {

            Robot robot = new Robot("Pesho", 10);
            Robot robot2 = new Robot("Pesho2", 10);
            RobotManager rm = new RobotManager(1);

            rm.Add(robot);

            Assert.That(()=> rm.Add(robot2), Throws.InvalidOperationException);
        }

        [Test]
        public void AddShouldWorkProperly()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);

            Assert.That(rm.Count, Is.EqualTo(1));
        }

        //Remove

        [Test]
        public void RemoveShouldWorkProperly()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);

            rm.Remove(robot.Name);

            Assert.That(rm.Count, Is.EqualTo(0));
        }

        public void RemoveShouldThrowAnExcWhenRobotIsNull()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            Assert.That(()=>rm.Remove(null), Throws.InvalidOperationException);
            Assert.That(rm.Count, Is.EqualTo(1));
        }

        //Work

        [Test]
        public void WorkShouldWorkProperly()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);
            rm.Work(robot.Name, "Clean", 8);


            Assert.That(() => robot.Battery, Is.EqualTo(2));
        }

        [Test]
        public void WorkShouldReturnExcOnRobotNull()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            Assert.That(() => rm.Work(robot.Name, "Clean", 8), Throws.InvalidOperationException);
        }

        [Test]
        public void WorkShouldReturnExcOnBatteryLessthanBatteryUsage()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);

            Assert.That(() => rm.Work(robot.Name, "Clean", 11),Throws.InvalidOperationException);
        }

        //Charge
        [Test]
        public void ChargeShouldWorkProperly()
        {

            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);
            rm.Charge(robot.Name);

            Assert.That(robot.Battery, Is.EqualTo(10));
        }

        [Test]
        public void ChargeShouldthrowAnExceptionIfRobotIsNull()
        {
            Robot robot = new Robot("Pesho", 10);
            RobotManager rm = new RobotManager(10);

            rm.Add(robot);

            Assert.That(() => rm.Charge("me"), Throws.InvalidOperationException);
        }

    }
}
