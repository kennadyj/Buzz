using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static Buzz.Models.Vehicles;

namespace Buzz.Controllers
{
    public class VehiclesController : ApiController
    {
        Truck[] trucks = new Truck[]
       {

            new Truck { VIN="ABC12345ZZZ", Color="White", Make="Ford", Model="Explorer" , ModelYear="2017", AllWheelDrive=true},
            new Truck { VIN="AAAA456JJJJ", Color="Red", Make="Ferrari", Model="F12berlinetta" , ModelYear="2017", AllWheelDrive=false },
            new Truck { VIN="AXAXAXAX123", Color="Beige", Make="McLaren", Model="570GT" , ModelYear="2017", AllWheelDrive=false }
       };

        public IEnumerable<Truck> GetAllVehicles()
        {
            return trucks;
        }

        public IHttpActionResult GetVehicle(string id)
        {
            var product = trucks.FirstOrDefault((p) => p.VIN == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
