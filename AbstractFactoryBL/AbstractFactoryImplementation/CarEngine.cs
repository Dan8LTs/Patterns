namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class CarEngine : IEngine
    {
        public string Name => "Standart";
        public double Power => 450;
        public double Weight => 500;

        public double GetConsumption(double speed)
        {
            return (Power / 450) * ((speed - 40) * (speed - 40) + 8000);
        }
    }
}