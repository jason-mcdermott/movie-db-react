using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MovieDb.MockRepository.Core;
using MovieDb.Models;

namespace ShoppingCart.MockRepository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly string _connection;

        public MovieRepository(string connection)
        {
            _connection = connection;
        }
            
        public IList<Movie> GetMovieList()
        {
            List<Movie> movies = new List<Movie>();

            using (StreamReader reader = new StreamReader(_connection))
            {
                string json = reader.ReadToEnd();
                movies = JsonConvert.DeserializeObject<List<Movie>>(json);
            }

            return movies;
        }
    }
}