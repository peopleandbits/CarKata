namespace CarKata
{
    public class Door
    {
        public Door(DoorType dt)
        {
            ADoor = dt;
        }

        public DoorType ADoor { get; set; }
        public bool IsOpen { get; set; }

        public void Open() { IsOpen = true; }
        public void Close() { IsOpen = false; }
    }

    public enum DoorType { FrontLeft, FrontRight, BackLeft, BackRight, BackLuggage }
}