using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreweryAPI.Models
{
    public class BreweryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FundationDate { get; set; }

    }
}
