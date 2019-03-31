using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieDb.Models;
using MovieDb.Services.Core;

namespace MovieDb.Controllers
{
    [Route("api/[controller]")]
    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpGet]
        [Route("list")]
        public IEnumerable<Director> Get()
        {
            return _directorService.GetDirectors();
        }

        [HttpGet]
        [Route("{id}")]
        public Director Get(int id)
        {
            return _directorService.GetDirector(id);
        }
    }
}