using DisneyCloneWebAPI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DisneyCloneWebAPI.Repository
{
   public interface IMovieRepository
    {
        Task<List<MovieModel>> GetAllMovieAsync();
    }
}
