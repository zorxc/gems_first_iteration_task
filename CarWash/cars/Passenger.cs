using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash.cars
{
    /// <summary>
    /// Класс легкового автомобиля.
    /// </summary>
    class Passenger : ICar
    {
        public uint WashingTime { get; } = 5;
    }
}
