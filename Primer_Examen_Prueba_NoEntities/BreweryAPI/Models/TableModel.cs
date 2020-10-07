using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Models
{
    public class TableModel
    {
        public int Id { get; set; }
        [Required]
        public char From { get; set; }
        //[StringLength(30, ErrorMessage = "Error {0} the max leng of the brewery name is{1} min lenght is {2}", MinimumLength = 2)]
        public char To { get; set; }
        public int Number { get; set; }
        public string President { get; set; }
        public bool IsValid { get; set; }

    }
}
