namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class TruckBattery : IBattery
    {
        public string Name => "SemiBattery";
        public double CurrentCharge { get; private set; }
        public double Weight => 1000;
        public double Capacity => 500000;

        public bool Discharged => CurrentCharge == 0;

        public TruckBattery()
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