namespace AbstractFactoryBL.AbstractFactoryImplementation
{
    public class Auto
    {
        public IBody Body { get; }
        public IEngine Engine { get; }
        public IBattery Battery { get; }
        public string Vin { get; }
        public double Weight
        {
            get
            {
                if (Body != null && Engine != null && Battery != null)
                {
                    var weight = Body.Weight + Engine.Weight + Battery.Weight;
                    if (weight <= Body.Durability)
                    {
                        return weight;
                    }
                    else
                    {
                        throw new Exception("Вес автомобиля больше прочности кузова. Движение не возможно.");
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public event EventHandler<double> Moved;

        public Auto(IAutoFactory factory)
        {
            Body = factory.CreateBody();
            Engine = factory.CreateEngine();
            Battery = factory.CreateBattery();
            Vin = Guid.NewGuid().ToString();
        }

        private double Step(double speed)
        {
            return speed * Battery.Consume(Engine.GetConsumption(speed) * (Weight / 1500)) * (1 - Body.AeroСoefficient);
        }

        public double GetDistance(double speed)
        {
            if (Weight > Body.Durability)
            {
                throw new Exception("Вес автомобиля больше прочности кузова. Движение не возможно.");
            }

            double path = 0;
            while (!Battery.Discharged)
            {
                path += Step(speed);
                Moved?.Invoke(this, path);
            }

            return path;
        }
    }
}
