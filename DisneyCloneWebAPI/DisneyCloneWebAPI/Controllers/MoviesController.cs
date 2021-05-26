using DisneyCloneWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DisneyCloneWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet ("")]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies =await  _movieRepository.GetAllMovieAsync();
            return Ok(movies);
        }
    }
}
