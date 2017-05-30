namespace CarKata
{
    public class AutomaticFiveSpeedTransmission : FiveSpeedTransmission
    {
        public void Up()
        {
            SetGear(CurrentGear + 1);
        }

        public void Idle()
        {
            SetGear(IdleGear);
        }

        public void Down()
        {
            SetGear(CurrentGear - 1);
        }
    }

    public class FiveSpeedTransmission : Transmission
    {
        public FiveSpeedTransmission() : base(5, 0, -1) { }
    }
    
    public abstract class Transmission
    {
        public Transmission(int max, int idle, int min)
        {
            MaxGear = max;      // eg. 5 = max speed forwards
            IdleGear = idle;    // eg. 0 
            MinGear = min;      // eg. -1 = reverse
        }

        public int CurrentGear { get; private set; }
        public int MaxGear { get; private set; }
        public int IdleGear { get; private set; }
        public int MinGear { get; private set; }

        protected void SetGear(int gear)
        {
            if (gear >= MinGear && gear <= MaxGear)
                CurrentGear = gear;
        }
    }
}