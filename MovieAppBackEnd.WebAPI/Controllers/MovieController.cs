using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAppBackEnd.Business.Abstract;
using Newtonsoft.Json;

namespace MovieAppBackEnd.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet("getlist")]
        public IActionResult GetList()
        {
            var result = _movieService.GetList();
            if (result.Success)
            {
                return Ok(JsonConvert.SerializeObject(result.Data));
            }
            return BadRequest(result.Message);
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(string id)
        {
            var result = _movieService.Get(id);
            if (result.Success)
            {
                return Ok(JsonConvert.SerializeObject(result.Data));
            }
            return BadRequest(result.Message);
        }
    }
}
