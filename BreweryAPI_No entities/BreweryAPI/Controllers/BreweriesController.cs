using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BreweryAPI.Models;
using BreweryAPI.Exceptions;
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

        //api/breweries
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

        //api/breweries/breweryId
        [HttpGet("{breweryId:int}", Name = "GetBrewery")]
        public ActionResult<BreweryModel> GetBrewery(int breweryId)
        {
            try
            {
                return _breweryService.GetBrewery(breweryId);
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
        public ActionResult<DeleteModel> DeleteBrewery(int breweryId)
        {
            try
            {
                return Ok(_breweryService.DeleteBrewery(breweryId));
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

        [HttpPut("{breweryId:int}")]
        public IActionResult UpdateBrewery(int breweryId, [FromBody] BreweryModel breweryModel)
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

                return Ok(_breweryService.UpdateBrewery(breweryId, breweryModel));
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
        //
        //[HttpGet("{beerCountry:string}", Name = "FilterBreweryByCountry")]
        [HttpGet("FilterBreweryByCountry")]
        public ActionResult<IEnumerable<BreweryModel>> FilterBreweryByCountry(string beerCountry="Country")
        {
            try
            {
                return Ok(_breweryService.FilterBreweryByCountry(beerCountry));
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
