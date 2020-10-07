using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Models
{
    public class VoteModel
    {
        public int Id { get; set; }
        public bool PartyA { get; set; }
        public bool PartyB { get; set; }
        public bool PartyC { get; set; }
        public string Name { get; set; }
        public int tableId { get; set; }
    }
}
