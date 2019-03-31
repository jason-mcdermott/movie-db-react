using System.Collections.Generic;
using MovieDb.Models;

namespace MovieDb.Services.Core
{
    public interface IMovieService
    {
        Movie GetMovie(int id);

        IEnumerable<Movie> GetAvailableMovies();
        

        IEnumerable<Movie> GetMoviesByDirector(int directorId);

        IEnumerable<Movie> GetMoviesByGenre(int genreId);
    }
}
