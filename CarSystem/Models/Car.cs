using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSystem.Models
{
    public class Car
    {
        public static int counter = 0;
        public int id { get; }

        public string LicensePlate { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Make { get; set; }
        public string Model { get; set; }
        public string AdditionalFeature { get; set; }
        public DateTime RegistrationDateAndTime { get; set; } = DateTime.Now;
        public Car()
        {
            id = counter++;
        }
    }
}
