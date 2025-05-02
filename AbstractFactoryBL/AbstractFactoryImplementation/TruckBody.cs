namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class TruckBody : IBody
    {
        public string Name => "Tesla Semi";
        public double AeroСoefficient => 0.35;
        public double Durability => 40000;
        public double Weight => 500;
    }
}