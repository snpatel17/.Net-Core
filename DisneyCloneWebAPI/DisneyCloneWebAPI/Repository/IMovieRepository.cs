using DisneyCloneWebAPI.Data;
using DisneyCloneWebAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DisneyCloneWebAPI.Repository
{
   public interface IMovieRepository
    {
        Task<List<MovieModel>> GetAllMovieAsync();
        Task<MovieModel> GetMoviebyIdAsync(int movieId);
        Task<int> AddMovieAsync(MovieModel movieModel);
        Task UpdateMovieAsync(int MovieId, MovieModel movieModel);
    }
}
