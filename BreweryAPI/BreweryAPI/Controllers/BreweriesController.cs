using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Models;
using BreweryAPI.Exceptions;
using BreweryAPI.Models;
using BreweryAPI.Services;

namespace BreweryAPI.Controllers
{
    [Route("api/[controller]")]
    public class BreweriesController : ControllerBase
    {

        private IBreweriesService _breweryService;

        public BreweriesController(IBreweriesService breweryService)
        {
            this._breweryService = breweryService;
        }

        //api/companies
        [HttpGet]
        public ActionResult<IEnumerable<BreweryModel>> GetBreweries(string orderBy = "Id")
        {
            try
            {
                return Ok(_breweryService.GetBreweries(orderBy));
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

        //api/companies/companiId
        [HttpGet("{breweryId:int}", Name = "GetBrewery")]
        public ActionResult<BreweryModel> GetCompany(int companyId)
        {
            try
            {
                return _breweryService.GetBrewery(companyId);
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message); ;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<BreweryModel> CreateBrewery([FromBody] BreweryModel breweryModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var url = HttpContext.Request.Host;
                var newBrewery = _breweryService.CreateBrewery(breweryModel);
                return CreatedAtRoute("GetBrewery", new { breweryId = newBrewery.Id }, newBrewery);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpDelete("{breweryId:int}")]
        public ActionResult<DeleteModel> Deletecompany(int companyId)
        {
            try
            {
                return Ok(_breweryService.DeleteBrewery(companyId));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message); ;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpPut("{companyId:int}")]
        public IActionResult UpdateBrewery(int companyId, [FromBody] BreweryModel breweryModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    foreach (var pair in ModelState)
                    {
                        if (pair.Key == nameof(breweryModel.Country) && pair.Value.Errors.Count > 0)
                        {
                            return BadRequest(pair.Value.Errors);
                        }
                    }
                }

                return Ok(_breweryService.UpdateBrewery(companyId, breweryModel));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message); ;
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }


    }
}
