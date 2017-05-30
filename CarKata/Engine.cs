namespace CarKata
{
    public class Engine
    {
        public Engine(int? hp = null)
        {
            Transmission = new AutomaticFiveSpeedTransmission();

            if (hp.HasValue)
                HP = hp.Value;
            else
                HP = 100;

            Rev = 0;
        }

        public AutomaticFiveSpeedTransmission Transmission { get; private set; }
        public int Rev { get; private set; }
        public int HP { get; private set; }

        public void Start()
        {
            Transmission.Idle();
        }

        public void Stop()
        {
            Transmission.Idle();
        }

        public void Accelerate()
        {
            Transmission.Up();
        }

        public void Decelerate()
        {
            Transmission.Down();
        }
    }
}