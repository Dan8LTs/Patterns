namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class CarFactory : IAutoFactory
    {
        public IBody CreateBody()
        {
            return new CarBody();
        }
        public IEngine CreateEngine()
        {
            return new CarEngine();
        }
        public IBattery CreateBattery()
        {
            return new CarBattery();
        }
    }
}
