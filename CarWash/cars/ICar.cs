using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWash.cars
{
    /// <summary>
    /// Интерфейс для всех автомобилей.
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// Время мойки той или иной машины.
        /// </summary>
        public uint WashingTime { get; }
    }
}
