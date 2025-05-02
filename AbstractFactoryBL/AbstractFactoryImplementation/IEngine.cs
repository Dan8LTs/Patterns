namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public interface IEngine
    {
        public string Name { get; }
        public double Power { get; }
        public double Weight { get; }
        double GetConsumption(double speed);
    }
}