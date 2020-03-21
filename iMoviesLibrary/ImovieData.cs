using iMoviesLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iMoviesLibrary
{
    public interface ImovieData
    {
        Task<List<movieModel>> GetMovie();
        Task InsertMovie(movieModel movie);
    }
}
