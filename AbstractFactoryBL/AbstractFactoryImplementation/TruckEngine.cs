namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class TruckEngine : IEngine
    {
        public string Name => "Powerful";
        public double Power => 1032;
        public double Weight => 1000;

        public double GetConsumption(double speed)
        {
            return (Power / 450) * ((speed - 40) * (speed - 40) + 8000);
        }
    }
}