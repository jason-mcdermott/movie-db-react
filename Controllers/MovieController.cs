using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieDb.Models;

namespace MovieDb.Controllers
{
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        [HttpGet]
        [Route("list")]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }

        [HttpGet("[action]")]
        public Movie Get(int id)
        {
            return movies.FirstOrDefault(movie => movie.Id == id);
        }



        private static IEnumerable<Genre> genres = new List<Genre>
        {
            new Genre { Id = 1, Name = "Science Fiction" },
            new Genre { Id = 2, Name = "Sci-Fi" },
            new Genre { Id = 3, Name = "Action" },
            new Genre { Id = 4, Name = "Adventure" },
        };

        private static IList<Director> directors = new List<Director>
        {
            new Director { FirstName = "George", LastName = "Lucas"},
            new Director { FirstName = "Irvin", LastName = "Kershner"},
            new Director { FirstName = "Richard", LastName = "Marquand"},
        };

        private static IEnumerable<Movie> movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Star Wars", Director = directors[0], ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0) },
            new Movie { Id = 2, Title = "Empire Strikes Back", Director  = directors[1], ReleaseDate = new DateTime(1980, 5, 17, 0, 0, 0, 0) },
            new Movie { Id = 3, Title = "Return of the Jedi", Director  = directors[2], ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0) },
        };
    }
}