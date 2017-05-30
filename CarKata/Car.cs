namespace CarKata
{
    public class Car
    {
        public Car(string name, Chassis chassis, Engine engine, Electronics electronics)
        {
            Name = name;
            Chassis = chassis;
            Engine = engine;
            Electronics = electronics;
        }

        public string Name { get; set; }
        public Chassis Chassis { get; set; }
        public Engine Engine { get; set; }
        public Electronics Electronics { get; set; }
    }
}
