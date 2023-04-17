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
        public void TestNoCarsException()
        {
            Assert.Throws<NoCarsException>(() =>
            {
                wash.StartWorking();
            });
        }

        [Test]
        public void TestWashJeepState()
        {
            wash.AddCar(new Jeep());

            wash.StartWorking();

            Assert.That(status, Is.EqualTo(PostStatus.Free));
        }
    }
}