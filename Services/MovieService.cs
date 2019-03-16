using System.Collections.Generic;
using System.Linq;
using MovieDb.MockRepository.Core;
using MovieDb.Models;
using MovieDb.Services.Core;

namespace MovieDb.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Movie> GetAvailableMovies()
        {
            var movies = _repository.GetMovieList();

            return movies as IEnumerable<Movie>;
        }

        public Movie GetMovie(int id)
        {
            return _repository.GetMovieList().Where(m => m.Id == id).FirstOrDefault();
        }
    }
}
