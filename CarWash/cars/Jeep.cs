using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash.cars
{
    /// <summary>
    /// Класс джипа.
    /// </summary>
    public class Jeep : ICar
    {
        public uint WashingTime { get; } = 8;
    }
}
