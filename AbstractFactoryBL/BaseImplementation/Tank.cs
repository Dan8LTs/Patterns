namespace Abstract_Factory.BaseImplementation
{
    public class Tank
    {
        public string Name { get; }
        public double MaxVolume { get; }
        public double CurrentVolume { get; private set; }
        public decimal Price { get; }
        public double Weight { get; private set; }
        public bool Empty => CurrentVolume == 0;

        public double Acceleration
        {
            get
            {
                return -0.4 * CurrentVolume / MaxVolume + 1.2;
            }
        }
        public Tank(string name, double maxvolume, decimal price, double weight)
        {
            Name = name;
            MaxVolume = maxvolume;
            CurrentVolume = maxvolume;
            Price = price;
            Weight = weight;
        }
        public double ConsumeFuel(double fuel)
        {
            if (fuel <= CurrentVolume)
            {
                CurrentVolume -= fuel;
                return 1;
            }
            else
            {
                var wayPercent = CurrentVolume / fuel;
                CurrentVolume = 0;
                return wayPercent;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
