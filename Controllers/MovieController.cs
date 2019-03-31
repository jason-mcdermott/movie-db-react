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

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _movieService.GetMovie(id);
        }
        
        [HttpPut("edit")]
        public Movie EditMovie(int id)
        {
            return _movieService.GetMovie(id);
        }

        [HttpPut("add")]
        public Movie AddMovie(int id)
        {
            return _movieService.GetMovie(id);
        }


        [HttpGet("director/{directorId}")]
        public IEnumerable<Movie> GetByDirector(int directorId)
        {
            return _movieService.GetMoviesByDirector(directorId);
        }

        [HttpGet("genre/{genreId}")]
        public IEnumerable<Movie> GetByGenre(int genreId)
        {
            return _movieService.GetMoviesByGenre(genreId);
        }
    }
}