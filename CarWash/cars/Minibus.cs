using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash.cars
{
    /// <summary>
    /// Класс микроавтобуса.
    /// </summary>
    class Minibus : ICar
    {
        public uint WashingTime { get; } = 10;
    }
}
