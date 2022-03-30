using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTravelsCRUD.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TruckPlate { get; set; }
        public string Address { get; set; }
    }
}
