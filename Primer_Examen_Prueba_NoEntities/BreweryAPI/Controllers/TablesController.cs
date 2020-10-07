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
    public class TablesController : ControllerBase
    {

        private ITablesService _tableService;

        public TablesController(ITablesService tableService)
        {
            this._tableService = tableService;
        }

        //api/breweries
        [HttpGet]
        public ActionResult<IEnumerable<TableModel>> GetTables(string orderBy = "Id")
        {
            try
            {
                return Ok(_tableService.GetTables(orderBy));
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

        //api/tables/tableId
        [HttpGet("{tableId:int}", Name = "GetTable")]
        public ActionResult<TableModel> GetTable(int tableId)
        {
            try
            {
                return _tableService.GetTable(tableId);
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
        public ActionResult<TableModel> CreateTable([FromBody] TableModel TableModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var url = HttpContext.Request.Host;
                var newTable = _tableService.CreateTable(TableModel);
                return CreatedAtRoute("GetTable", new { tableId = newTable.Id }, newTable);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
            }
        }

        
        //
        ////[HttpGet("{beerCountry:string}", Name = "FilterBreweryByCountry")]
        //[HttpGet("FilterBreweryByCountry")]
        //public ActionResult<IEnumerable<TableModel>> FilterBreweryByCountry(string beerCountry="Country")
        //{
        //    try
        //    {
        //        return Ok(_tableService.FilterBreweryByCountry(beerCountry));
        //    }
        //    catch (BadRequestOperationException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
        //    }
        //}
        
        

    }
}
