﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Primer_Examen.Exceptions;
using Primer_Examen.Models;
using Primer_Examen.Services;

namespace Primer_Examen.Controllers
{
    [Route("api/test/{breweryId:int}/[controller]")]
    public class BeersController : ControllerBase
    {
        private IBeersService _beerService;
 
        public BeersController(IBeersService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<BeerModel>> GetBeers(int breweryId)
        {
            try
            {
                return Ok(_beerService.GetBeers(breweryId));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpGet("{beerId:int}", Name = "GetBeer")]
        public ActionResult<BeerModel> GetBeer(int breweryId, int beerId)
        {
            try
            {
                return Ok(_beerService.GetBeer(breweryId, beerId));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpPost]
        public ActionResult<BeerModel> CreateBeer(int breweryId, [FromBody] BeerModel beer)
        {
            try
            {
                var beerCreated = _beerService.CreateBeer(breweryId, beer);
                return CreatedAtRoute("GetBeer", new { breweryId = breweryId, videogameId = beerCreated.Id }, beerCreated);
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpPut("{beerId:int}")]
        public ActionResult<BeerModel> UpdateBeer(int breweryId, int beerId, [FromBody] BeerModel beer)
        {
            try
            {
                return Ok(_beerService.UpdateBeer(breweryId, beerId, beer));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        [HttpDelete("{beerId:int}")]
        public ActionResult<bool> DeleteBeer(int breweryId, int beerId)
        {
            try
            {
                return Ok(_beerService.DeleteBeer(breweryId, beerId));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        //Definir la ruta

        [HttpGet("NotSoldBeers")]
        public ActionResult<IEnumerable<BeerModel>> NotSoldBeers(int breweryId)
        {
            try
            {
                return Ok(_beerService.NotSoldBeers(breweryId));
            }
            catch (NotFoundOperationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

    }
}
