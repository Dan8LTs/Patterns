namespace Abstract_Factory.BaseImplementation
{
    public class Car
    {
        public Body Body { get; }
        public Engine Engine { get; }
        public Battery Battery { get; }
        public string Vin { get; }
        public double Weight
        {
            get
            {
                return Body.Weight + Engine.Weight + Battery.Weight;
            }
        }
        public event EventHandler<double> Moved;

        public Car(Body body, Engine engine, Battery battery)
        {
            Body = body;
            Engine = engine;
            Battery = battery;
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

        public override string ToString()
        {
            return Vin;
        }
    }
}
