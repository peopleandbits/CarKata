namespace CarKata
{
    public class Wheel
    {
        public Wheel(WheelPos pos)
        {
            Position = pos;
        }

        public WheelPos Position { get; set; }
    }

    public enum WheelPos { FrontLeft, FrontRight, BackLeft, BackRight }
}