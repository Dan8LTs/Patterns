using Abstract_Factory.BaseImplementation;
using AbstractFactoryBL.AbstractFactoryImplementation;

namespace AbstractFactory
{
    public partial class Main : Form
    {
        private readonly int pause = 600;
        IAutoFactory factory;

        public Main()
        {
            InitializeComponent();
        }

        private Car CreateBaseImplementationCar()
        {
            var body = new Body("Tesla Model Y", 0.22, 2000, 500);
            var engine = new Engine("Standart", 450, 500);
            var battery = new Battery("LongRange", 500, 78100);

            var car = new Car(body, engine, battery);
            car.Moved += CarMoved;

            return car;
        }
        private void BasicButton_Click(object sender, EventArgs e)
        {
            var baseCar = CreateBaseImplementationCar();
            baseCar.GetDistance(trackBar.Value);
        }

        private void CarMoved(object sender, double e)
        {
            Refresh();
            label1.Text = $"Passed: {(int)e}";
            Thread.Sleep(pause);
        }

        private void FactoryTruckButton_Click(object sender, EventArgs e)
        {
            factory = new TruckFactory();
            var auto = new Auto(factory);
            auto.Moved += CarMoved;
            auto.GetDistance(trackBar.Value);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            label2.Text = $"Choose speed: {trackBar.Value}";
        }

        private void FactoryCarButton_Click(object sender, EventArgs e)
        {
            factory = new CarFactory();
            var auto = new Auto(factory);
            auto.Moved += CarMoved;
            auto.GetDistance(trackBar.Value);
        }
    }
}
