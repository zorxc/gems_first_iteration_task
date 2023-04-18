using CarWash.cars;

namespace CarWash
{
    internal class Program
    {
        /// <summary>
        /// Обработчик события OnCarWashingInfo.
        /// </summary>
        /// <param name="post">Текущий пост.</param>
        /// <param name="currentCar">Текущая машина.</param>
        private static void PrintInfo(Post post, ICar currentCar)
        {
            Console.WriteLine($"Post id: {post.Id}.\n" +
                              $"Post status: {post.Status}.\n" +
                              $"Car type: {currentCar.GetType().Name}.\n" +
                              $"Time: {currentCar.WashingTime}.\n");
        }
        /// <summary>
        /// Безопасное чтение количества моделируемых машин.
        /// </summary>
        /// <returns>Количество машин для моделирования.</returns>
        private static uint SafeReadNumberOfCars()
        {
            Console.Write("Enter the number of simulated machines: ");

            if (!uint.TryParse(Console.ReadLine(), out uint numOfCars) || numOfCars == 0)
            {
                Console.WriteLine("Incorrect number. Try again.");
                Console.ReadKey();
                Console.Clear();
                return SafeReadNumberOfCars();
            }

            return numOfCars;
        }

        static void Main(string[] args)
        {
            Wash wash = new Wash(PrintInfo);

            uint numberOfCars = SafeReadNumberOfCars();

            for (int i = 0; i < numberOfCars; i++)
            {
                Random rnd = new Random();
                
                switch (rnd.Next(0, 3))
                {
                    case 0: wash.AddCar(new Jeep()); break;
                    case 1: wash.AddCar(new Passenger()); break;
                    case 2: wash.AddCar(new Minibus()); break;
                }
            }

            wash.StartWorking();

            Console.WriteLine($"Total revenue: {wash.Revenue} rub.");

            Console.ReadKey();
        }
    }
}