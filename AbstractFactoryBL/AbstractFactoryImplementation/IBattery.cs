namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public interface IBattery
    {
        public string Name { get; }
        public double CurrentCharge { get; }
        public double Weight { get; }
        public double Capacity { get; }
        public bool Discharged { get; }
        double Consume(double charge);
    }
}