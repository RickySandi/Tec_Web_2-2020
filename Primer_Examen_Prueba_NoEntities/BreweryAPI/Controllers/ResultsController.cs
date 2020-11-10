using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Primer_Examen.Models;
using Primer_Examen.Exceptions;
using Primer_Examen.Services;

namespace Primer_Examen.Controllers
{
    [Route("api/[controller]")]
    public class ResultsController : ControllerBase
    {
        private IResultsService _resultService;

        public ResultsController(IResultsService resultService)
        {
            this._resultService = resultService;
        }

        //api/breweries
        [HttpGet]
        public ActionResult<IEnumerable<TableModel>> GetResults(int resultId = 1)
        {
            try
            {
                return Ok(_resultService.GetResults(resultId));
            }
            catch (BadRequestOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }


    }
}

