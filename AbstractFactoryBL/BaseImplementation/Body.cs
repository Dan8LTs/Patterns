namespace Abstract_Factory.BaseImplementation
{
    public class Body
    {
        public string Name { get; }
        public double AeroСoefficient { get; }
        public decimal Price { get; }
        public double Durability { get; }
        public double Weight { get; }

        public Body(string name, double aerocoefficient, decimal price, double durability, double weight)
        {
            Name = name;
            AeroСoefficient = aerocoefficient;
            Price = price;  
            Durability = durability;
            Weight = weight;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
