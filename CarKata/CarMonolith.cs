namespace CarKata
{
    public class CarMonolith
    {
        public string Name { get; set; }
        public int Doors { get; set; }

        public int CurrentVelocity { get; set; }
        public int CurrentGear { get; set; }
        public int MaxGear { get; set; }

        public int EngineRev { get; set; }
        public int EngineHP { get; set; }

        public CarMonolith(string name)
        {
        }

        public void StartEngine()
        {
        }

        public void StopEngine()
        {
        }

        public void Drive(int velocity)
        {
        }

        public void Break(int velocity)
        {
        }

        public void OpenDoor(int door)
        {
        }

        public void CloseDoor(int door)
        {
        }

        public void ChangeGear(int g)
        {
        }
    }
}