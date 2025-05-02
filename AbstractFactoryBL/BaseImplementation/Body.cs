namespace Abstract_Factory.BaseImplementation
{
    public class Body
    {
        public string Name { get; }
        public double AeroСoefficient { get; }
        public double Durability { get; }
        public double Weight { get; }

        public Body(string name, double aerocoefficient, double durability, double weight)
        {
            Name = name;
            AeroСoefficient = aerocoefficient;
            Durability = durability;
            Weight = weight;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
