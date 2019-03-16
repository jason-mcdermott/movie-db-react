using System.Collections.Generic;
using MovieDb.Models;

namespace MovieDb.MockRepository.Core
{
    public interface IMovieRepository
    {
        IList<Movie> GetMovieList();
    }
}