using System.Collections.Generic;
using System.Linq;
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

        public Director GetDirector(int id)
        {
            return _repository.GetDirectorList().Where(m => m.Id == id).FirstOrDefault();
        }
    }
}