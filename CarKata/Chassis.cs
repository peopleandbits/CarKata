using System.Linq;

namespace CarKata
{
    public class Chassis
    {
        public Chassis(Door[] doors = null)
        {
            if (doors == null)
                Doors = GetDefault();
            else
                Doors = doors;
        }

        public Door[] Doors { get; set; }
        public Wheel[] Wheels { get; set; }

        public void OpenDoor(DoorType door)
        {
            Doors.First(c => c.ADoor == door).Open();
        }

        public void CloseDoor(DoorType door)
        {
            Doors.First(c => c.ADoor == door).Close();
        }

        static Door[] GetDefault() => new[] {
            new Door(DoorType.FrontLeft), new Door(DoorType.FrontRight),
            new Door(DoorType.BackLeft),  new Door(DoorType.BackRight) };
    }
}