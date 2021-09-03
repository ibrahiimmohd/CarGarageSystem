using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSystem.Models
{
    public static class Repository
    {
        private static List<Car> cars = new List<Car>();

        public static IEnumerable<Car> Cars { get => cars; }

        public static void Add(Car car)
        {
            cars.Add(car);
        }

    }
}
