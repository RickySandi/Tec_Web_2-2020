using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Models
{
    public class BeerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal alcoholPorcentage { get; set; }
        public decimal? Price { get; set; }
        public int soldAmount { get; set; }
        public int breweryId { get; set; }
    }
}
