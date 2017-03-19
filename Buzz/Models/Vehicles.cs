using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Buzz.Models
{
    public class Vehicles
    {
        public class Truck
        {
            public string VIN { get; set; }
            public string Model { get; set; }
            public string Make { get; set; }
            public string ModelYear { get; set; }
            public string Color { get; set; }
            public bool AllWheelDrive { get; set; }
        }
    }
}