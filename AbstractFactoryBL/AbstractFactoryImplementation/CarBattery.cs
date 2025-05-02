namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class CarBattery : IBattery
    {
        public string Name => "LongRange";
        public double CurrentCharge { get; private set; }
        public double Weight => 500;
        public double Capacity => 78100;

        public bool Discharged => CurrentCharge == 0;

        public CarBattery()
        {
            CurrentCharge = Capacity;
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
    }
}