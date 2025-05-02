namespace Abstract_Factory.BaseImplementation
{
    public class Engine
    {
        public string Name { get; }
        public double Power { get; }
        public double Weight { get; }

        public Engine(string name, double power, double weight)
        {
            Name = name;
            Power = power;
            Weight = weight;
        }
        public double GetConsumption(double speed)
        {
            return (Power / 450) * ((speed - 40) * (speed - 40) + 8000);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
