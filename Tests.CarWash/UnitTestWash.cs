using CarWash;
using CarWash.cars;

namespace Tests.CarWash
{
    public class UnitTestWash
    {
        private Wash wash;
        private PostStatus status;

        [SetUp]
        public void Setup()
        {
            wash = new Wash((Post post, ICar currentCar) =>
            {
                status = post.Status;
            });
        }



        [Test]
        public void TestWashOftenCarsRevenue()
        {
            wash.AddCar(new Minibus());
            wash.AddCar(new Jeep());
            wash.AddCar(new Minibus());
            wash.AddCar(new Jeep());
            wash.AddCar(new Minibus());
            wash.AddCar(new Passenger());
            wash.AddCar(new Passenger()); // 1200 + 720 + 300 = 2220
            wash.AddCar(new Jeep());
            wash.AddCar(new Minibus());

            wash.StartWorking();

            Assert.That(wash.Revenue, Is.EqualTo(2220));
        }
    }
}