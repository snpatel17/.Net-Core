using DisneyCloneWebAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using DisneyCloneWebAPI.Data;

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

        //@desc get all movies from database to list

        [HttpGet ("")]
        public async Task<IActionResult> GetAllMovies()
        {
            var movies =await  _movieRepository.GetAllMovieAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMoviesById([FromRoute] int id)
        {
            var movie = await _movieRepository.GetAllMovieAsync();
            return Ok(movie);
        }

        [HttpGet("")]
        public async Task<IActionResult> AddNewMovie([FromBody] MovieModel moviemodel)
        {
            var id = await _movieRepository.AddMovieAsync(moviemodel);
            return CreatedAtAction(nameof(GetMoviesById),new { id = id, controller = "Movies" },id );
        }
    }
}
