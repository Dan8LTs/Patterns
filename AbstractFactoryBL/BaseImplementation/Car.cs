namespace Abstract_Factory.BaseImplementation
{
    public class Car
    {
        public Body Body { get; }
        public Engine Engine { get; }
        public Tank Tank { get; }
        public string Vin { get; }
        public decimal Price { get; }
        public double Weight
        {
            get
            {
                return Body.Weight + Engine.Weight + Tank.Weight;
            }
        }
        public event EventHandler<double> Moved;

        public Car(Body body, Engine engine, Tank tank)
        {
            Body = body;
            Engine = engine;
            Tank = tank;
            Price = Body.Price + Engine.Price + Tank.Price;
            Vin = Guid.NewGuid().ToString();
        }

        private double Step(double speed)
        {
            var currentSpeed = speed < Engine.Power ? speed : Engine.Power;
            currentSpeed *= Body.AeroСoefficient;
            currentSpeed *= Tank.Acceleration;
            var needFuel = Engine.GetConsumption(currentSpeed);
            var pathRate = Tank.ConsumeFuel(needFuel);
            return currentSpeed * pathRate;
        }

        private double GetDistance(double speed)
        {
            if (Weight > Body.Durability)
            {
                throw new Exception("Вес автомобиля больше максимального. Движение не возможно.");
            }

            var path = 0.0;
            while (!Tank.Empty)
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
