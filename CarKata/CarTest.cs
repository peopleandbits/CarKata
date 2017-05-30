using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarKata;

namespace CarKataUnitTestProject1
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Driving()
        {
            var car = new Car("Mersu", new Chassis(), new Engine(), new Electronics());
            var driving = new Driving(car);
            driving.Drive(100);
        }

        [TestMethod]
        public void OpenCloseDoor()
        {
            var car = new Car("Mersu", new Chassis(), new Engine(), new Electronics());

            car.Chassis.OpenDoor(DoorType.FrontLeft);
            Assert.IsTrue(car.Chassis.Doors[0].IsOpen);

            car.Chassis.CloseDoor(DoorType.FrontLeft);
            Assert.IsFalse(car.Chassis.Doors[0].IsOpen);
        }
    }
}