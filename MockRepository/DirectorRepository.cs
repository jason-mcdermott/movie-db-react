using System.Collections.Generic;
using System.IO;
using MovieDb.MockRepository.Core;
using MovieDb.Models;
using Newtonsoft.Json;

namespace ShoppingCart.MockRepository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly string _connection;

        public DirectorRepository(string connection)
        {
            _connection = connection;
        }
            
        public IList<Director> GetDirectorList()
        {
            List<Director> directors = new List<Director>();

            using (StreamReader reader = new StreamReader(_connection))
            {
                string json = reader.ReadToEnd();
                directors = JsonConvert.DeserializeObject<List<Director>>(json);
            }

            return directors;
        }
    }
}