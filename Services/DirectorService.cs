using System.Collections.Generic;
using MovieDb.MockRepository.Core;
using MovieDb.Models;
using MovieDb.Services.Core;

namespace MovieDb.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _repository;

        public DirectorService(IDirectorRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Director> GetDirectors()
        {
            var directors = _repository.GetDirectorList();

            return directors as IEnumerable<Director>;
        }
    }
}