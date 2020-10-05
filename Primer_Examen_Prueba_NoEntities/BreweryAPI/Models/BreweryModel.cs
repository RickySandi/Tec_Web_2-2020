using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Models
{
    public class BreweryModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [StringLength(30, ErrorMessage = "Error {0} the max leng of the brewery name is{1} min lenght is {2}", MinimumLength = 2)]
        public string Country { get; set; }
        public DateTime? FundationDate { get; set; }

    }
}
