namespace Abstract_Factory.BaseImplementation
{
    public class Engine
    {
        public string Name { get; }
        public double Power { get; }
        public decimal Price { get; }
        public double Weight { get; }

        public Engine(string name, double power, decimal price, double weight)
        {
            Name = name;
            Power = power;
            Price = price;
            Weight = weight;
        }
        public double GetConsumption(double speed)
        {
            var currentSpeed = speed > 0 ? speed : 1;
            var fuel = 0.0008 * currentSpeed * currentSpeed - 0.2 * currentSpeed + 17;
            return fuel;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
