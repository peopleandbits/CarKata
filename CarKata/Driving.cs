namespace CarKata
{
    public class Driving
    {
        public Driving(Car car)
        {
            Car = car;
        }

        public Car Car { get; set; }

        public void Drive(int velocity)
        {
            Car.Engine.Start();

        }

        public void Break(int velocity)
        {
        }
    }
}