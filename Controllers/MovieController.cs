using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MovieDb.Models;
using MovieDb.Services.Core;

namespace MovieDb.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        [Route("list")]
        public IEnumerable<Movie> Get()
        {
            return _movieService.GetAvailableMovies();
        }

        [HttpGet("[action]")]
        public Movie Get(int id)
        {
            return _movieService.GetMovie(id);
        }
    }
}