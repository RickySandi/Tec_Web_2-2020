using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Data.Entities
{
    public class BreweryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public DateTime ? FundationDate { get; set; }

    }
}
