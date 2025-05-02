namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class CarBody : IBody
    {
        public string Name => "Tesla Model Y";
        public double AeroСoefficient => 0.22;
        public double Durability => 2000;
        public double Weight => 500;
    }
}