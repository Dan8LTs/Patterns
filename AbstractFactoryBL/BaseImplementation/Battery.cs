namespace Abstract_Factory.BaseImplementation
{
    public class Battery
    {
        public string Name { get; }
        public double CurrentCharge { get; private set; }
        public double Weight { get; private set; }
        public double Capacity { get; private set; }

        public bool Discharged => CurrentCharge == 0;

        public Battery(string name, double weight, int capacity)
        {
            Name = name;
            CurrentCharge = capacity;
            Weight = weight;
        }
        public double Consume(double charge)
        {
            if (charge <= CurrentCharge)
            {
                CurrentCharge -= charge;
                return 1;
            }
            else
            {
                double wayPercent = CurrentCharge / charge;
                CurrentCharge = 0;
                return wayPercent;
            }
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
