using DisneyCloneWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCloneWebAPI.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<MovieModel>> GetAllMovieAsync()
        {
            var records = await _context.Movies.Select(x=>new MovieModel() {
                MovieId = x.MovieId,
                BackgroundImg = x.BackgroundImg,
                CardImg=x.CardImg,
                Description=x.Description,
                SubTitle=x.SubTitle,
                Title=x.Title,
                TitleImg=x.TitleImg,
                Type=x.Type
            }).ToListAsync();

            return records;
        }
    }
}
