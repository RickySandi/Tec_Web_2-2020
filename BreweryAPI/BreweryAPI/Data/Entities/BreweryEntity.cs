using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreweryAPI.Data.Entity
{
    public class BreweryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime FundationDate { get; set; }

    }
}
