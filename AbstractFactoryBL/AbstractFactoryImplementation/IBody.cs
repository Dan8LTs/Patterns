namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public interface IBody
    {
        public string Name { get; }
        public double AeroСoefficient { get; }
        public double Durability { get; }
        public double Weight { get; }
    }
}