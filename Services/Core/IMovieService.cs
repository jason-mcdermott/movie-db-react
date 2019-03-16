using System.Collections.Generic;
using MovieDb.Models;

namespace MovieDb.Services.Core
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAvailableMovies();
        Movie GetMovie(int id);
    }
}
