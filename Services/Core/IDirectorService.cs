using System.Collections.Generic;
using MovieDb.Models;

namespace MovieDb.Services.Core
{
    public interface IDirectorService
    {
        IEnumerable<Director> GetDirectors();

        Director GetDirector(int id);
    }
}
