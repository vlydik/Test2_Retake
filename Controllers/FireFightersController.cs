using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test2_Retake.Exceptions;
using Test2_Retake.Models;
using Test2_Retake.Services;

namespace Test2_Retake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FireFightersController : ControllerBase
    {

        private readonly IListService _dbService;

        public FireFightersController(IListService dbService)
        {
            _dbService = dbService;

        }

        [HttpGet]
        [Route("{id:int}/actions")]

        public IActionResult GetFireFightersList(int id)
        {
            try
            {


                var res = _dbService.AssignFireTruckAction(id);
                return Created("Action assigned", res);


            }
            catch(FireFighterNotFoundException ex)
            {
                return NotFound(ex.Message);
            }

        }
    }
}