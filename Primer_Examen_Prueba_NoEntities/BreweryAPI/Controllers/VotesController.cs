using System;
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
    [Route("api/test/{tableId:int}/[controller]")]
    public class VotesController : ControllerBase
    {
        private IVotesService _voteService;
 
        public VotesController(IVotesService voteService)
        {
            _voteService = voteService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VoteModel>> GetVotes(int tableId)
        {
            try
            {
                return Ok(_voteService.GetVotes(tableId));
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

        [HttpGet("{voteId:int}", Name = "GetVote")]
        public ActionResult<VoteModel> GetVote(int tableId, int voteId)
        {
            try
            {
                return Ok(_voteService.GetVote(tableId, voteId));
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
        public ActionResult<VoteModel> CreateVote(int tableId, [FromBody] VoteModel vote)
        {
            try
            {
                var voteCreated = _voteService.CreateVote(tableId, vote);
                return CreatedAtRoute("GetVote", new { tableId = tableId, videogameId = voteCreated.Id }, voteCreated);
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

        //[HttpGet("NotSoldvotes")]
        //public ActionResult<IEnumerable<VoteModel>> NotSoldBeers(int tableId)
        //{
        //    try
        //    {
        //        return Ok(_voteService.NotSoldvotes(tableId));
        //    }
        //    catch (NotFoundOperationException ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, $"Something happend: {ex.Message}");
        //    }
        //}

    }
}
