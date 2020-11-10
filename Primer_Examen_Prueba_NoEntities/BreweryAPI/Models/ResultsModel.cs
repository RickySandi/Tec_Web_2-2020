using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Models
{

    public class ResultsModel
    {
        public int Id { get; set; }
        public int PartyA { get; set; }
        public int PartyB { get; set; }
        public int PartyC { get; set; }
        public int nulos { get; set; }
        public int blancos { get; set; }

    }
}
