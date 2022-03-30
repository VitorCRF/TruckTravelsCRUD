using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruckTravelsCRUD.Models
{
    public class Travel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int DriverId { get; set; }
        public string Destination { get; set; }
        public string StartFrom { get; set; }
        public float TotalDistance { get; set; }

    }
}
