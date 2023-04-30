using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Clases
{
    public class Input1
    {
        public bool Pharmacy { get; set; }
        public bool? Restaurant { get; set; }

        [JsonProperty("Beauty Salon")]
        public bool? BeautySalon { get; set; }
        public bool? Mall { get; set; }
        public bool? Vet { get; set; }
        public bool? Hospital { get; set; }
        public bool? Academy { get; set; }
        public bool? Clinic { get; set; }
        public bool? Kindergarten { get; set; }

        [JsonProperty("Gas Station")]
        public bool? GasStation { get; set; }
        public bool? Park { get; set; }

        [JsonProperty("Cofee shop")]
        public bool? Cofeeshop { get; set; }
        public bool? Grocery { get; set; }

        [JsonProperty("Barber Shop")]
        public bool? BarberShop { get; set; }
        public bool? Gym { get; set; }
        public bool? Bakery { get; set; }
        public bool? Bar { get; set; }
    }
}
