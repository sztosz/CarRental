using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Models {
    public class Car {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LicencePlate { get; set; }
        public decimal DailyRate { get; set; }

    }
}
