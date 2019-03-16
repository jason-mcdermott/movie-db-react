using System.Collections.Generic;
using MovieDb.Models;

namespace MovieDb.MockRepository.Core
{
    public interface IDirectorRepository
    {
        IList<Director> GetDirectorList();
    }
}
