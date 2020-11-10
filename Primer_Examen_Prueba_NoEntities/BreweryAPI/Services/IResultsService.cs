using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primer_Examen.Models;

namespace Primer_Examen.Services
{
    public interface IResultsService
    {
        IEnumerable<ResultsModel> GetResults(int resultId);
    }
}
